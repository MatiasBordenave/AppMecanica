using AppMecanicaCAD;
using AppMecanicaCLN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMecanica
{
    public partial class Registros : Form
    {

        private ClienteCLN clienteCLN = new ClienteCLN();
        private RegistroCLN registroCLN = new RegistroCLN();
        private VehiculoCLN vehiculoCLN = new VehiculoCLN();

        private Form formHome;

        public Registros(Form Home)
        {
            InitializeComponent();
            formHome = Home;
        }

        private void btnVolverRegistro_Click(object sender, EventArgs e)
        {
            formHome.Show();
            this.Close();        
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registros_Load(object sender, EventArgs e)
        {
            lblFormRegistros.Text = "";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            lblFormRegistros.Text = "Clientes";
            dgvRegistros.DataSource = clienteCLN.ObtenerClientes();
            dgvRegistros.Columns["nombreYApellido"].HeaderText = "Titular";
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            lblFormRegistros.Text = "Vehiculos"; 
            dgvRegistros.DataSource = vehiculoCLN.ObtenerVehiculos();

        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            lblFormRegistros.Text = "Registros";
            dgvRegistros.DataSource = registroCLN.ObtenerRegistros();
        }
    }
}
