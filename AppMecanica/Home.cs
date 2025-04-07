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
           
        }

       

        

        //desde aqui 

      
        //metodo para los paneles

        private void showPaneles(Panel Paneles)
        {
            if (Paneles.Visible == false)
            {
                
                Paneles.Visible = true;
            }
            else
                Paneles.Visible = false;
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

        

        

        
    }
}
