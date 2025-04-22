using AppMecanica;
using AppMecanica.Services;
using AppMecanicaCAD;
using AppMecanicaCLN;
using AppMecanica.Models;


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

            string nombreYApellido = txtTitular.Text;
            string telefono = txtTelefono.Text;
            string domicilio = txtDomicilio.Text;
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string patente = txtPatente.Text;
            string año = txtAño.Text;
            string kilometraje = txtKm.Text;

            txtNombreRepo.Clear();
            txtPrecioUni.Clear();
            txtCantidadHoras.Clear();
            txtPrecioHora.Clear();
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

    }
}