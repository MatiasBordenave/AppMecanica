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
    public partial class DetalleRegistro : Form
    {
        private Form formRegistro;

        public DetalleRegistro(Form registro)
        {
            InitializeComponent();
            formRegistro = registro;
        }

        private void btnVolverDetalle_Click(object sender, EventArgs e)
        {
            formRegistro.Show();
            this.Close();
        }
    }
}
