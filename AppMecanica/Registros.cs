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

        public Registros()
        {
            InitializeComponent();
        }

        private void btnVolverReg_Click(object sender, EventArgs e)
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

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = clienteCLN.ObtenerClientes();
        }
    }
}
