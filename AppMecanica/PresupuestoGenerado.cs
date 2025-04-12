using System.Drawing.Printing;


namespace AppMecanica
{
    public partial class PresupuestoGenerado : Form
    {
        public string Titular { get; set; }
        public string Telefono { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }


        private Form formPresupuesto;
        public PresupuestoGenerado(Form Presupuesto)

        {
            InitializeComponent();
            lblTitulo.Text = $"Presupuesto - Nro {"01"}";
            lblFecha.Text = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}";
            formPresupuesto = Presupuesto;
            this.Load += PresupuestoGenerado_Load;
        }
        private void PresupuestoGenerado_Load(object sender, EventArgs e)
        {
            lblDatosCliente.Text = $"Cliente: {Titular}";
            lblDatosTelefono.Text = $"Telefono: {Telefono}" ;
            lblDatosVehiculo.Text = $"Vehiculo: Marca: {Marca}, Modelo: {Modelo}, Año: {Año}";
        }

        //FALTA DEFINIR EL AREA DE IMPRESION
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImg.Visible = false;
            btnImprimir.Visible = false;
            btnVolverGenerado.Visible = false;

            this.Refresh();
            Application.DoEvents();

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintPreviewDialog printPreview = new PrintPreviewDialog
            {
                Document = pd
            };
            printPreview.ShowDialog();

            btnImg.Visible = true;
            btnImprimir.Visible = true;
            btnVolverGenerado.Visible = true;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //area sin bordes 
            Rectangle bounds = this.RectangleToScreen(this.ClientRectangle);
            Bitmap bmp = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }
            e.Graphics.DrawImage(bmp, 0, 0);
        }


        private void btnImg_Click(object sender, EventArgs e)
        {
            btnImg.Visible = false;
            btnImprimir.Visible = false;
            btnVolverGenerado.Visible = false;


            this.Refresh();
            Application.DoEvents();

            //area sin bordes 
            Rectangle bounds = this.RectangleToScreen(this.ClientRectangle);
            Bitmap bmp = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }

            //guardar 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
                MessageBox.Show("Imagen guardada exitosamente.");
            }


            btnImg.Visible = true;
            btnImprimir.Visible = true;
            btnVolverGenerado.Visible = true;
        }

        private void btnVolverGenerado_Click(object sender, EventArgs e)
        {
            formPresupuesto.Show();
            this.Close();
        }

        
    }
}
