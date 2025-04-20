using AppMecanica;
using AppMecanicaCAD;
using AppMecanicaCLN;

namespace AppMecanica
{
    public partial class Presupuesto : Form
    {

        private Bitmap bitmap;
        private ClienteCLN clienteCLN = new ClienteCLN();
        private RegistroCLN registroCLN = new RegistroCLN();
        private VehiculoCLN vehiculoCLN = new VehiculoCLN();

        private Form homeForm;

        public Presupuesto(Form home)
        {
            InitializeComponent();
            homeForm = home;
        }

        private void btnVolverPresupuesto_Click(object sender, EventArgs e)
        {
            homeForm.Show(); // Mostrar el Home que estaba oculto
            this.Close();    // Cerrar el Presupuesto
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar TextBox individuales
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

            // Reiniciar NumericUpDown
            nupCantidad.Value = nupCantidad.Minimum;

            // Limpiar el DataGridView
            dataGridView1.Rows.Clear();

            //Limpiar el TextBox de descripción
            textBoxDesc.Clear();
        }




        private void btnAgregarPresu_Click(object sender, EventArgs e)
        {
            // Validación simple (opcional pero recomendado)
            if (string.IsNullOrWhiteSpace(txtNombreRepo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioUni.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos del repuesto.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir precio a decimal y cantidad a int
            if (!decimal.TryParse(txtPrecioUni.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidad = (int)nupCantidad.Value;

            // Agregar al DataGridView
            dataGridView1.Rows.Add(txtNombreRepo.Text, cantidad, precio);

            // Limpiar los campos del groupBox2 luego de agregar
            txtNombreRepo.Clear();
            txtPrecioUni.Clear();
            nupCantidad.Value = nupCantidad.Minimum;

            txtNombreRepo.Focus();
        }

        private void btnEliminarPresu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Confirmación opcional
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


            //Validacion global arriba de los campos

            //if (Validaciones.HayCamposVacios(this, out string campo))
            //{
            //    MessageBox.Show($"El campo '{campo}' está vacío. Por favor, completalo.",
            //                    "Validación de campos",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Warning);
            //    return;
            //}


        }



        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            List<Repuesto> listaRepuestos = new List<Repuesto>();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[1].Value != null && fila.Cells[2].Value != null)
                {
                    listaRepuestos.Add(new Repuesto
                    {
                        Nombre = fila.Cells[0].Value.ToString(),
                        Cantidad = Convert.ToInt32(fila.Cells[1].Value),
                        Precio = Convert.ToDecimal(fila.Cells[2].Value)
                    });
                }
            }

            PresupuestoGenerado generado = new PresupuestoGenerado(this, listaRepuestos)
            {
                Titular = txtTitular.Text,
                Telefono = txtTelefono.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Año = txtAño.Text
            };

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