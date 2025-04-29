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
            OcultarAsteriscos();
            AttachDecimalOnly(
                txtTelefono, txtAño, txtPrecioUni,
                txtCantidadHoras, txtPrecioHora, txtKm);
            BloquearCopiarPegar(
                txtTitular, txtTelefono, txtDomicilio,
                txtModelo, txtMarca, txtPatente, txtAño, txtKm);
        }

        private void btnVolverPresupuesto_Click(object sender, EventArgs e)
        {
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
            // 1) Validación de campos obligatorios...
            var obligatorios = new[] { txtTitular, txtTelefono, txtMarca, txtModelo, txtAño, txtPatente };
            if (!_validator.AreRequiredFieldsFilled(obligatorios))
            {
                MostrarAsteriscos();
                _msg.ShowWarning("Complete todos los campos obligatorios.", "Campos vacíos");
                return;
            }

            // 2) Parse numérico...
            if (!_validator.TryParseDecimal(txtCantidadHoras, out var horas) ||
                !_validator.TryParseDecimal(txtPrecioHora, out var precioHora) ||
                !int.TryParse(txtKm.Text.Trim(), out var kilometraje) ||
                !int.TryParse(txtAño.Text.Trim(), out var año))
            {
                _msg.ShowError("Datos numéricos inválidos.", "Error");
                return;
            }

            // 3) Validar patente...
            var patente = txtPatente.Text.Trim().ToUpper();
            if (!Regex.IsMatch(patente, "^[A-Z]{3}\\d{3}$"))
            {
                _msg.ShowError("Formato de patente inválido. Debe ser ABC123.", "Error de patente");
                return;
            }

            // 4) Mapeo de repuestos y cálculos en front
            var repuestos = _mapper.Map(dataGridView1);
            var totalRepuestos = _calculator.CalculateTotalRepuestos(repuestos);
            var totalLaborHoras = _calculator.CalculateLaborCost(horas, precioHora);
            var totalGeneral = _calculator.CalculateTotalGeneral(repuestos, horas, precioHora);

            try
            {
                // 5) Crear el Registro con todos los datos
                var registro = _registroFactory.CreateRegistro(
                    textBoxDesc.Text.Trim(),
                    totalRepuestos,
                    horas,
                    precioHora,
                    totalLaborHoras,   // precioTotalHoras
                    totalGeneral,      // precioTotal
                    kilometraje,
                    repuestos          // <-- lista completa de repuestos
                );

                // 6) Mensaje si cliente existe...
                if (_registroService.ClienteExiste(patente))
                {
                    _msg.ShowInfo(
                        "Cliente existente: el nuevo registro se agregará a su historial.",
                        "Cliente existente"
                    );
                }

                // 7) Guardar en la capa de negocio / servicio
                _registroService.SaveRegistro(
                    txtTitular.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtDomicilio.Text.Trim(),
                    txtMarca.Text.Trim(),
                    txtModelo.Text.Trim(),
                    patente,
                    año,
                    kilometraje,
                    registro,
                    repuestos);

                // 8) Éxito y navegación
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
        private void AttachDecimalOnly(params TextBox[] textBoxes)
        {
            foreach (var txt in textBoxes)
            {
                txt.KeyPress += (s, e) =>
                {
                    if (!char.IsControl(e.KeyChar)
                        && !char.IsDigit(e.KeyChar)
                        && e.KeyChar != ','
                        && e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                    if ((e.KeyChar == ',' || e.KeyChar == '.')
                        && (txt.Text.Contains(",") || txt.Text.Contains(".")))
                    {
                        e.Handled = true;
                    }
                };
            }
        }
        private void BloquearCopiarPegar(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.ContextMenuStrip = new ContextMenuStrip();
                textBox.KeyDown += (s, e) =>
                {
                    if (e.Control && (e.KeyCode == Keys.C
                                      || e.KeyCode == Keys.V
                                      || e.KeyCode == Keys.X))
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                    }
                };
            }
        }
    }
}
