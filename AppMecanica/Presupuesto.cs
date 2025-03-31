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
    public partial class Presupuesto : Form
    {
        public Presupuesto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
