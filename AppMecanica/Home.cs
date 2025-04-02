using AppMecanicaCLN;
using System.Windows.Forms;

namespace AppMecanica
{
    public partial class Home : Form
    {
        private ClienteCLN clienteCLN = new ClienteCLN();

        public Home()
        {
            InitializeComponent();
            hidePanel();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadData();
            panelPresupuesto.Dock = DockStyle.Fill;
            panelRegistro.Dock = DockStyle.Fill;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = clienteCLN.ObtenerClientes();
        }


        //desde aqui 

        private void hidePanel()
        {
            panelPresupuesto.Visible = false;
            panelRegistro.Visible = false;
            panelHome.Visible = !panelHome.Visible;
        }

        //metodo para los paneles

        private void showPaneles(Panel Paneles)
        {
            if (Paneles.Visible == false)
            {
                hidePanel();
                Paneles.Visible = true;
            }
            else
                Paneles.Visible = false;
        }


        private void GuardarCliente()
        {
            string nombreYApellido = txtTitular.Text;
            string telefono = "123456789"; /* falta el input */
            string domicilio = "Bella Vista"; /* falta el input */


        }

        private void GuardarVehiculo()
        {

        }

        private void GuardarPresupuesto()
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
            GuardarVehiculo();
            GuardarPresupuesto();
        }

        private void btnRegistro_Click_1(object sender, EventArgs e)
        {
            // Crear instancia del formulario Registro
            Registros registroForm = new Registros();

            // Ocultar el formulario actual (Home)
            this.Hide();

            // Mostrar el formulario Registro
            registroForm.ShowDialog();

            // Una vez que se cierre el formulario Registro, volver a mostrar el Home
            this.Show();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            // Crear instancia del formulario Registro
            Presupuesto presupuestoForm = new Presupuesto();

            // Ocultar el formulario actual (Home)
            this.Hide();

            // Mostrar el formulario Registro
            presupuestoForm.ShowDialog();

            // Una vez que se cierre el formulario Registro, volver a mostrar el Home
            this.Show();
        }

        private void btnVolverRegistro_Click_1(object sender, EventArgs e)
        {
            hidePanel();
        }

        private void btnVolverPresupuesto_Click(object sender, EventArgs e)
        {
            hidePanel();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
