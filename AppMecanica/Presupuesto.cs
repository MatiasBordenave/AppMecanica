using AppMecanica;
using AppMecanica.Services;
using AppMecanicaCAD;
using AppMecanicaCLN;
using AppMecanica.Models;
using AppMecanicaEntidades;


namespace AppMecanica
{
    public partial class Presupuesto : Form
    {
        private readonly IRepuestoMapper _mapper;
        private readonly ITotalCalculator _calculator;
        private readonly Form _homeForm;

        public Presupuesto(Form homeForm,
                           IRepuestoMapper mapper,
                           ITotalCalculator calculator)
        {
            InitializeComponent();
            _homeForm = homeForm;
            _mapper = mapper;
            _calculator = calculator;
        }



        private void btnVolverPresupuesto_Click(object sender, EventArgs e)
        {
            _homeForm.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidadHoras.Clear();
            txtPrecioHora.Clear();
            txtNombreRepo.Clear();
            txtPrecioUni.Clear();
            txtTitular.Clear();
            txtTelefono.Clear();
            txtDomicilio.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtPatente.Clear();
            txtAño.Clear();
            txtKm.Clear();
            nupCantidad.Value = nupCantidad.Minimum;
            dataGridView1.Rows.Clear();
            textBoxDesc.Clear();
        }


        private void btnAgregarPresu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreRepo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioUni.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos del repuesto.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrecioUni.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidad = (int)nupCantidad.Value;
            dataGridView1.Rows.Add(txtNombreRepo.Text, cantidad, precio);

            txtNombreRepo.Clear();
            txtPrecioUni.Clear();
            nupCantidad.Value = nupCantidad.Minimum;
            txtNombreRepo.Focus();
        }

        private void btnEliminarPresu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var confirmar = MessageBox.Show("¿Seguro que querés eliminar el repuesto seleccionado?",
                                                "Eliminar",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Seleccioná una fila para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            // Datos Titular
            string nombreYApellido = txtTitular.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string domicilio = txtDomicilio.Text.Trim();

            // Datos Vehículo
            string modelo = txtModelo.Text.Trim();
            string marca = txtMarca.Text.Trim();
            string patente = txtPatente.Text.Trim();
            int año = Convert.ToInt32(txtAño.Text);
            int kilometraje = Convert.ToInt32(txtKm.Text);

            // Datos del registro de mantenimiento
            string descripcion = textBoxDesc.Text.Trim();
            double totalRepuestos = Convert.ToDouble(txtPrecioUni.Text);
            int cantidadHoras = Convert.ToInt32(txtCantidadHoras.Text);
            double precioPorHora = Convert.ToDouble(txtPrecioHora.Text);
            double precioTotalHoras = cantidadHoras * precioPorHora;
            double totalFinal = totalRepuestos + precioTotalHoras;
            int kilometrajeRegistro = kilometraje;
            DateTime fecha = DateTime.Now; // O podés usar un DateTimePicker si tenés uno

            // Construir el objeto Registro
            Registro registro = new Registro
            {
                Fecha = fecha,
                Descripcion = descripcion,
                TotalRepuestos = totalRepuestos,
                CantidadHoras = cantidadHoras,
                PrecioPorHora = precioPorHora,
                PrecioTotalHoras = precioTotalHoras,
                PrecioTotal = totalFinal,
                KilometrajeRegistro = kilometrajeRegistro
            };

            try
            {
                // Llamada a la lógica de negocio (Capa Lógica de Negocio)
                RegistroCLN.AgregarRegistro(
                    nombreYApellido,
                    telefono,
                    domicilio,
                    marca,
                    modelo,
                    patente,
                    año,
                    kilometraje,
                    registro
                );

                MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var listaRepuestos = _mapper.Map(dataGridView1);
            var totalRepuestos = _calculator.CalculateTotalRepuestos(listaRepuestos);

            decimal horas = 0, precioHora = 0;
            decimal.TryParse(txtCantidadHoras.Text, out horas);
            decimal.TryParse(txtPrecioHora.Text, out precioHora);

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
                Titular = txtTitular.Text,
                Telefono = txtTelefono.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Año = txtAño.Text,
                Desc = textBoxDesc.Text
            };

            var generado = new PresupuestoGenerado(this, data);
            generado.Show();
            this.Hide();
        }


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permite dígitos, punto o coma (solo uno) y teclas de control
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permite dígitos, punto o coma (solo uno) y teclas de control
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permite letras, números y teclas de control
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar)) // Opcional: permite espacios
            {
                e.Handled = true;
            }
        }


        private void txtPrecioUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permite dígitos, punto o coma (solo uno) y teclas de control
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtCantidadHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permite dígitos, punto o coma (solo uno) y teclas de control
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtPrecioHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permite dígitos, punto o coma (solo uno) y teclas de control
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private bool ValidarCampos()
        {
            // Lista de todos los TextBox a validar
            TextBox[] campos = {
        txtTitular,
        txtTelefono,
        txtDomicilio,
        txtModelo,
        txtMarca,
        txtPatente,
        txtAño,
        txtKm
    };

            foreach (TextBox txt in campos)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Focus();
                    return false;
                }
            }

            return true;
        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {

        }
    }
}