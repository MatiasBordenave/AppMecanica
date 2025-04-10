using System.Drawing.Printing;


namespace AppMecanica
{
    public partial class PresupuestoGenerado : Form
    {
        public string Titular { get; set; }
        //public string DNI { get; set; }
        //public string Telefono { get; set; }
        //public string Email { get; set; }
        //public string Patente { get; set; }
        //public string Marca { get; set; }
        //public string Modelo { get; set; }
        //public string Año { get; set; }
        //public string Problema { get; set; }
        //public string Servicios { get; set; }
        //public string Precio { get; set; }
        //public string FechaIngreso { get; set; }
        //public string FechaEntrega { get; set; }
        //public string Observaciones { get; set; }

        private Form formPresupuesto;
        public PresupuestoGenerado(Form Presupuesto)
        {
            InitializeComponent();
            lblTitulo.Text = $"Presupuesto - {DateTime.Now.ToString("dd/MM/yyyy")}";
            formPresupuesto = Presupuesto;
            this.Load += PresupuestoGenerado_Load;

        }
        private void PresupuestoGenerado_Load(object sender, EventArgs e)
        {
            lblTitular.Text = Titular;
            //lblDNI.Text = DNI;
            //lblTelefono.Text = Telefono;
            //lblEmail.Text = Email;
            //lblPatente.Text = Patente;
            //lblMarca.Text = Marca;
            //lblModelo.Text = Modelo;
            //lblAño.Text = Año;
            //lblProblema.Text = Problema;
            //lblServicios.Text = Servicios;
            //lblPrecio.Text = Precio;
            //lblFechaIngreso.Text = FechaIngreso;
            //lblFechaEntrega.Text = FechaEntrega;
            //lblObservaciones.Text = Observaciones;
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
            formPresupuesto.Show();
            this.Close();
        }

        
    }
}
