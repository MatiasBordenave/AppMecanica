using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppMecanicaCAD;
using AppMecanicaCLN;
using AppMecanica.Models;
using AppMecanicaEntidades;
using AppMecanica.Services.Interfaces;

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

        private void OcultarAsteriscos()
        {
            lblAsTitu.Visible = false;
            lblAsTele.Visible = false;
            lblAsModelo.Visible = false;
            lblAsMarca.Visible = false;
            lblAsAño.Visible = false;

            // Agregá todos los label que uses como asteriscos obligatorios
        }


        private void MostrarAsteriscos()
        {
            lblAsTitu.Visible = true;
            lblAsTele.Visible = true;
            lblAsModelo.Visible = true;
            lblAsMarca.Visible = true;
            lblAsAño.Visible = true;

            // Agregá todos los label que uses como asteriscos obligatorios
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
            if (!_validator.TryParseDecimal(txtPrecioUni, out var precio))
            {
                _msg.ShowError("Ingrese un precio de repuesto válido.", "Error");
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
                dataGridView1.Rows.RemoveAt(
                    dataGridView1.SelectedRows[0].Index);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var obligatorios = new[] { txtTitular, txtTelefono, txtMarca, txtModelo, txtAño };
            if (!_validator.AreRequiredFieldsFilled(obligatorios))
            {
                MostrarAsteriscos();
                _msg.ShowWarning("Complete todos los campos obligatorios.", "Campos vacíos");
                return;
            }

            if (!_validator.TryParseDecimal(txtCantidadHoras, out var horas) ||
                !_validator.TryParseDecimal(txtPrecioHora, out var precioHora) ||
                !int.TryParse(txtKm.Text.Trim(), out var kilometraje))
            {
                _msg.ShowError("Datos numéricos inválidos.", "Error");
                return;
            }

            var listaRepuestos = _mapper.Map(dataGridView1);
            var totalRepuestos = (decimal)_calculator.CalculateTotalRepuestos(listaRepuestos);

            try
            {
                var registro = _registroFactory.CreateRegistro(
                    textBoxDesc.Text.Trim(),
                    totalRepuestos,
                    (int)horas,
                    precioHora,
                    kilometraje);

                _registroService.SaveRegistro(
                    txtTitular.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtDomicilio.Text.Trim(),
                    txtMarca.Text.Trim(),
                    txtModelo.Text.Trim(),
                    txtPatente.Text.Trim(),
                    int.Parse(txtAño.Text.Trim()),
                    kilometraje,
                    registro);

                _msg.ShowInfo("Registro guardado correctamente.", "Éxito");
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
                MostrarAsteriscos();
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
            this.Hide();
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
