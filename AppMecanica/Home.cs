using AppMecanicaCLN;
using System.Windows.Forms;
using AppMecanica.Services;

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
            IRepuestoMapper mapper = new RepuestoMapper();
            ITotalCalculator calculator = new TotalCalculator();

            Presupuesto presupuestoForm = new Presupuesto(this, mapper, calculator);
            presupuestoForm.Show();
            this.Hide();
        }
    }
}
