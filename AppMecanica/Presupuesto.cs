using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppMecanicaCAD;
using AppMecanicaCLN;
using AppMecanica.Models;
using AppMecanicaEntidades;
using AppMecanica.Services.Interfaces;
using System.Text.RegularExpressions;

namespace AppMecanica
{
    public partial class Presupuesto : Form
    {
        private readonly IFormCleaner _cleaner;
        private readonly IInputValidator _validator;
        private readonly IRegistroFactory _registroFactory;
        private readonly IRegistroService _registroService;
        private readonly IMessageService _msg;
        private readonly IRepuestoMapper _mapper;
        private readonly ITotalCalculator _calculator;
        private readonly Form _homeForm;
        private readonly Label[] _asteriscoLblRegistro;
        private readonly Label[] _asteriscosLblPresupuesto;

        private bool cierreDesdeBoton = false;
        public Presupuesto(
            Form homeForm,
            IRepuestoMapper mapper,
            ITotalCalculator calculator,
            IFormCleaner cleaner,
            IInputValidator validator,
            IRegistroFactory registroFactory,
            IRegistroService registroService,
            IMessageService messageService)
        {
            InitializeComponent();
            _homeForm = homeForm;
            _mapper = mapper;
            _calculator = calculator;
            _cleaner = cleaner;
            _validator = validator;
            _registroFactory = registroFactory;
            _registroService = registroService;
            _msg = messageService;

            _asteriscoLblRegistro = new[]
            {
                lblAsTitu, lblAsTele, lblAsModelo, lblAsMarca,
                lblAsAño, lblAsDomicilio, lblAsKm, lblAsPatente,
                lblAsHoras, lblAsPxH, lblAsDesc
            };
            _asteriscosLblPresupuesto = new[]
            {
                lblAsTitu, lblAsTele, lblAsModelo, lblAsMarca, lblAsAño
            };
        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                txtTitular.Focus();
            }));

            OcultarAsteriscos();

            AttachOnlyDigits(
                txtTelefono, txtAño, txtPrecioUni,
                txtCantidadHoras, txtPrecioHora, txtKm);
            MaximoRango();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtTitular.Focus();
                e.Handled = true; 
            }
            if (e.KeyCode == Keys.F2)
            {
                txtCantidadHoras.Focus();
                e.Handled = true; 
            }
            if (e.KeyCode == Keys.F5)
            {
                btnLimpiar_Click(sender, e); 
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                btnGenerar_Click(sender, e); 
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F4)
            {
                btnGuardar_Click(sender, e); 
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnVolverPresupuesto_Click(sender, e);
                e.Handled = true;
            }
        }
        private void MaximoRango()
        {
            var configuraciones = new (TextBox textBox, int maxLength)[]
            {
        (textBoxDesc, 200),
        (txtTitular, 35),
        (txtTelefono, 10),
        (txtDomicilio, 30),
        (txtMarca, 20),
        (txtModelo, 20),
        (txtPatente, 9),
        (txtAño, 4),
        (txtKm, 7),
        (txtNombreRepo, 30),
        (txtPrecioUni, 7),
        (txtCantidadHoras, 3),
        (txtPrecioHora, 6)
            };

            foreach (var (textBox, maxLength) in configuraciones)
            {
                textBox.MaxLength = maxLength;
            }
        }
        private void btnVolverPresupuesto_Click(object sender, EventArgs e)
        {
            cierreDesdeBoton = true;
            _homeForm.Show();
            this.Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var controles = new Control[]
            {
                txtCantidadHoras, txtPrecioHora, txtNombreRepo, txtPrecioUni,
                txtTitular, txtTelefono, txtDomicilio, txtModelo,
                txtMarca, txtPatente, txtAño, txtKm, textBoxDesc,
                dataGridView1, nupCantidad
            };
            _cleaner.ClearControls(controles);
        }
        private void btnAgregarPresu_Click(object sender, EventArgs e)
        {
            var camposRequeridos = new List<TextBox> { txtNombreRepo };

            if (!_validator.AreRequiredFieldsFilled(camposRequeridos))
            {
                _msg.ShowError("Complete todos los campos", "Error");
                return;
            }
            if (nupCantidad.Value <= 0)
            {
                _msg.ShowError("La cantidad debe ser mayor a 0", "Error");
                return;
            }
            if (!_validator.TryParseDecimal(txtPrecioUni, out var precio))
            {
                _msg.ShowError("Ingrese un precio de repuesto válido", "Error");
                return;
            }
            var cantidad = (int)nupCantidad.Value;
            dataGridView1.Rows.Add(txtNombreRepo.Text.Trim(), cantidad, precio);
            txtNombreRepo.Clear();
            txtPrecioUni.Clear();
            nupCantidad.Value = nupCantidad.Minimum;
            txtNombreRepo.Focus();
        }
        private void btnEliminarPresu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                _msg.ShowWarning("Seleccioná una fila para eliminar.", "Atención");
                return;
            }
            if (_msg.ShowConfirmation(
                "¿Seguro que querés eliminar el repuesto seleccionado?", "Eliminar"))
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var obligatorios = new[] { txtTitular, txtTelefono, txtMarca, txtModelo, txtAño, txtPatente };
            if (!_validator.AreRequiredFieldsFilled(obligatorios))
            {
                MostrarAsteriscos();
                _msg.ShowWarning("Complete todos los campos obligatorios.", "Campos vacíos");
                return;
            }
            if (!_validator.TryParseDecimal(txtCantidadHoras, out var horas) ||
                !_validator.TryParseDecimal(txtPrecioHora, out var precioHora) ||
                !int.TryParse(txtKm.Text.Trim(), out var kilometraje) ||
                !int.TryParse(txtAño.Text.Trim(), out var año))
            {
                _msg.ShowError("Datos numéricos inválidos.", "Error");
                return;
            }
            var patente = txtPatente.Text.Trim().ToUpper();
            if (!Regex.IsMatch(patente, "^[A-Z]{3}\\d{3}$"))
            {
                _msg.ShowError("Formato de patente inválido. Debe ser ABC123.", "Error de patente");
                return;
            }
            var repuestos = _mapper.Map(dataGridView1);
            var totalRepuestos = _calculator.CalculateTotalRepuestos(repuestos);
            var totalLaborHoras = _calculator.CalculateLaborCost(horas, precioHora);
            var totalGeneral = _calculator.CalculateTotalGeneral(repuestos, horas, precioHora);  
            string descripcionRepuestos = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                var nombre = row.Cells["NombreRepuesto"].Value?.ToString();
                var cantidad = row.Cells["CantidadRepuesto"].Value?.ToString();
                var precio = row.Cells["PrecioRepuesto"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(nombre) &&
                    !string.IsNullOrWhiteSpace(cantidad) &&
                    !string.IsNullOrWhiteSpace(precio))
                {
                    descripcionRepuestos += $"{nombre} x{cantidad} - ${precio}, ";
                }
            }
            if (descripcionRepuestos.EndsWith(", "))
            {
                descripcionRepuestos = descripcionRepuestos.Substring(0, descripcionRepuestos.Length - 2);
            }
            try
            {
                var registro = _registroFactory.CreateRegistro(
                    textBoxDesc.Text.Trim(),
                    totalRepuestos,
                    horas,
                    precioHora,
                    totalLaborHoras,
                    totalGeneral,
                    kilometraje,
                    descripcionRepuestos
                );
                if (_registroService.ClienteExiste(patente))
                {
                    _msg.ShowInfo(
                        "Cliente existente: el nuevo registro se agregará a su historial.",
                        "Cliente existente"
                    );
                }
                _registroService.SaveRegistro(
                    txtTitular.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtDomicilio.Text.Trim(),
                    txtMarca.Text.Trim(),
                    txtModelo.Text.Trim(),
                    patente,
                    año,
                    kilometraje,
                    registro);
                _msg.ShowInfo("Registro procesado correctamente.", "Éxito");
                new Registros(_homeForm).Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                _msg.ShowError("Error al guardar: " + ex.Message, "Error");
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!_validator.AreRequiredFieldsFilled(
                new[] { txtTitular, txtTelefono, txtMarca, txtModelo, txtAño }))
            {
                MostrarAsteriscos(_asteriscosLblPresupuesto);
                _msg.ShowWarning("Complete todos los campos obligatorios.", "Campos vacíos");
                return;
            }
            var listaRepuestos = _mapper.Map(dataGridView1);
            var totalRepuestos = _calculator.CalculateTotalRepuestos(listaRepuestos);
            decimal.TryParse(txtCantidadHoras.Text.Trim(), out var horas);
            decimal.TryParse(txtPrecioHora.Text.Trim(), out var precioHora);
            var totalManoObra = _calculator.CalculateLaborCost(horas, precioHora);
            var totalGeneral = _calculator.CalculateTotalGeneral(listaRepuestos, horas, precioHora);
            var data = new PresupuestoData
            {
                Repuestos = listaRepuestos,
                TotalRepuestos = totalRepuestos,
                CantidadHoras = horas,
                PrecioHora = precioHora,
                TotalManoObra = totalManoObra,
                TotalGeneral = totalGeneral,
                Titular = txtTitular.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Año = txtAño.Text.Trim(),
                Desc = textBoxDesc.Text.Trim()
            };
            IPrintService printService = new PrintService();
            IExportService exportService = new ExportService();
            var generado = new PresupuestoGenerado(this, data, printService, exportService);
            generado.Show();
            OcultarAsteriscos();
            _cleaner.ClearControls(new Control[]
            {
                txtCantidadHoras, txtPrecioHora, txtNombreRepo, txtPrecioUni,
                txtTitular, txtTelefono, txtDomicilio, txtModelo,
                txtMarca, txtPatente, txtAño, txtKm, textBoxDesc,
                dataGridView1, nupCantidad
            });
            this.Hide();
        }
        private void OcultarAsteriscos()
        {
            foreach (var label in _asteriscoLblRegistro)
            {
                label.Visible = false;
            }
        }
        private void MostrarAsteriscos(IEnumerable<Label> labelsToShow = null)
        {
            foreach (var label in _asteriscoLblRegistro)
            {
                label.Visible = false;
            }
            if (labelsToShow != null)
            {
                foreach (var label in labelsToShow)
                {
                    label.Visible = true;
                }
            }
            else
            {
                foreach (var label in _asteriscoLblRegistro)
                {
                    label.Visible = true;
                }
            }
        }
        private void AttachOnlyDigits(params TextBox[] textBoxes)
        {
            foreach (var txt in textBoxes)
            {
                txt.KeyPress += (s, e) =>
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true; // Bloquea cualquier cosa que no sea dígito o control
                    }
                };
            }
        }
       
        private void Presupuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cierreDesdeBoton)
            {
                Application.Exit();
            }
        }
        private void nupCantidad_Enter(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            if (nud.Controls.Count > 0 && nud.Controls[1] is TextBox)
            {
                TextBox tb = (TextBox)nud.Controls[1];
                tb.SelectAll();
            }
        }
        private void nupCantidad_Click(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            if (nud.Controls.Count > 0 && nud.Controls[1] is TextBox)
            {
                TextBox tb = (TextBox)nud.Controls[1];
                tb.SelectAll();
            }
        }
        private void btnSnPrspto_Click(object sender, EventArgs e)
        {
            FormAlerta alerta = new FormAlerta("sobre");
            alerta.ShowDialog();
        }
        private void btnManualPrspto_Click(object sender, EventArgs e)
        {
            FormAlerta alerta = new FormAlerta("comandos");
            alerta.ShowDialog();
        }
    }
}
