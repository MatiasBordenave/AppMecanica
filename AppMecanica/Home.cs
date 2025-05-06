using AppMecanica;
using AppMecanica.Services;
using AppMecanicaCAD;
using AppMecanicaCLN;
using AppMecanica.Models;
using AppMecanicaEntidades;
using AppMecanica.Services.Interfaces;

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
            IFormCleaner cleaner = new FormCleaner();
            IInputValidator validator = new InputValidator();
            IRegistroFactory regFactory = new RegistroFactory();
            IRegistroService regService = new RegistroService();
            IMessageService msgService = new MessageService();

            var presupuestoForm = new Presupuesto(
                this,
                mapper,
                calculator,
                cleaner,
                validator,
                regFactory,
                regService,
                msgService
            );

            presupuestoForm.Show();
            this.Hide();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FormHome_KeyDown;
        }
        private void FormHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnPresupuesto_Click(sender, e);
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F2)
            {
                btnRegistro_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
