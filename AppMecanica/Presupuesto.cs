using AppMecanicaCLN;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace AppMecanica
{
    public partial class Presupuesto : Form
    {

        private Bitmap bitmap;
        private ClienteCLN clienteCLN = new ClienteCLN();

        public Presupuesto()
        {
            InitializeComponent();

        }

        private void btnVolverHome_Click(object sender, EventArgs e)
        {
            // Obtener la instancia del formulario Home que estaba oculto
            Form homeForm = Application.OpenForms["HomeForm"];

            if (homeForm != null)
            {
                homeForm.Show(); // Mostrar HomeForm si está oculto
            }

            // Cerrar el formulario actual (Registro)
            this.Close();
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
            txtVehiculo.Clear();
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {

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
    }
}
