using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMecanica
{
    public partial class PresupuestoGenerado : Form
    {
        private Form formPresupuesto;
        public PresupuestoGenerado(Form Presupuesto)
        {
            InitializeComponent();
            lblTitulo.Text = $"Presupuesto - {DateTime.Now.ToString("dd/MM/yyyy")}";
            formPresupuesto = Presupuesto;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //// Obtener la instancia del formulario Home que estaba oculto
            //Form homeForm = Application.OpenForms["HomeForm"];

            //if (homeForm != null)
            //{
            //    homeForm.Show(); // Mostrar HomeForm si está oculto
            //}

            //// Cerrar el formulario actual (Registro)
            //this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintPreviewDialog printPreview = new PrintPreviewDialog
            {
                Document = pd
            };
            printPreview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void btnImg_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PNG Image|*.png"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
                MessageBox.Show("Imagen guardada exitosamente.");
            }
        }

        private void btnVolverGenerado_Click(object sender, EventArgs e)
        {
            formPresupuesto.Show(); // Muestra el formulario anterior
            this.Close();
        }

        
    }
}
