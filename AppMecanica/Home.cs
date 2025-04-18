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
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registros registroForm = new Registros(this);

            registroForm.Show();
            this.Hide();
            
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            Presupuesto presupuestoForm = new Presupuesto(this);

            presupuestoForm.Show();
            this.Hide();
            
        }

    }
}
