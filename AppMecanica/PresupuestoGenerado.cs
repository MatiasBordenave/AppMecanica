using AppMecanica.Models;
using System.Drawing.Printing;
using AppMecanica.Models;

namespace AppMecanica
{
    public partial class PresupuestoGenerado : Form
    {
        private Form formPresupuesto;
        private PresupuestoData data;

        public PresupuestoGenerado(Form presupuesto, PresupuestoData data)
        {
            InitializeComponent();
            lblTitulo.Text = $"Presupuesto - Nro {"01"}";
            lblFecha.Text = $"Fecha: {DateTime.Now:dd/MM/yyyy}";
            formPresupuesto = presupuesto;
            this.data = data;

            this.Load += PresupuestoGenerado_Load;
        }

        private void PresupuestoGenerado_Load(object sender, EventArgs e)
        {
            lblDatosCliente.Text = $"Cliente: {data.Titular}";
            lblDatosTelefono.Text = $"Teléfono: {data.Telefono}";
            lblMarcaPresu.Text = $"Marca: {data.Marca}";
            lblModeloPresu.Text = $"Modelo: {data.Modelo}";
            lblAnoPresu.Text = $"Año: {data.Año}";

            lblDescPresupuesto.Text = $"\"{data.Desc}\"";
            lblTituloRepuesto.Text = $"Repuesto: ${data.TotalRepuestos}";
            lblTituloMDO.Text = $"Mano de obra: ${data.TotalManoObra}";
            lblMDOyR.Text = $"Total: ${data.TotalGeneral}";

            foreach (var rep in data.Repuestos)
            {
                var lbl = new Label();
                lbl.AutoSize = true;
                lbl.Font = new Font("HomepageBaukasten 249998pt", 11, FontStyle.Bold);
                lbl.Margin = new Padding(10);
                lbl.Text = $"{rep.Nombre.ToUpper()} | Cantidad x{rep.Cantidad} | Precio: ${rep.Precio}";
                flowPanelRepuestos.Controls.Add(lbl);
            }
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
            Bitmap bmp = new Bitmap(panelContenido.Width, panelContenido.Height);
            panelContenido.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            // Usamos toda la hoja (sin márgenes)
            Rectangle printArea = e.PageBounds;

            // Calcular escalado para llenar toda la hoja
            float ratioX = (float)printArea.Width / bmp.Width;
            float ratioY = (float)printArea.Height / bmp.Height;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(bmp.Width * ratio);
            int newHeight = (int)(bmp.Height * ratio);

            int posX = printArea.X + (printArea.Width - newWidth) / 2;
            int posY = printArea.Y + (printArea.Height - newHeight) / 2;

            e.Graphics.DrawImage(bmp, posX, posY, newWidth, newHeight);
        }



        private void btnImg_Click(object sender, EventArgs e)
        {
            btnImg.Visible = false;
            btnImprimir.Visible = false;
            btnVolverGenerado.Visible = false;

            this.Refresh();
            Application.DoEvents();

            // Capturar sin bordes
            Rectangle bounds = this.RectangleToScreen(this.ClientRectangle);
            Bitmap bmp = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }
            // nombre
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            sfd.FileName = $"Presupuesto_{DateTime.Now:dd-MM-yyyy}.png";

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
