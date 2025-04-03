using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace AppMecanica
{
    public partial class Presupuesto : Form
    {

        private Bitmap bitmap;
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CaptureForm();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (bitmap != null)
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
        }

        //private void btnGuardarImagen_Click(object sender, EventArgs e)
        //{
        //    CaptureForm();
        //    SaveFileDialog saveFileDialog = new SaveFileDialog
        //    {
        //        Filter = "PNG Image|*.png",
        //        Title = "Guardar imagen del presupuesto"
        //    };

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
        //        MessageBox.Show("Imagen guardada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void CaptureForm()
        {
            Graphics g = CreateGraphics();
            Size s = Size;
            bitmap = new Bitmap(s.Width, s.Height, g);
            DrawToBitmap(bitmap, new Rectangle(0, 0, s.Width, s.Height));
        }
    }
}
