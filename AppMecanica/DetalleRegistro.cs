using AppMecanicaEntidades;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace AppMecanica
{
    public partial class DetalleRegistro : Form
    {
        private Form formRegistro;
        private VehiculoDetalleDTO detalle;
        public DetalleRegistro(Form registro, VehiculoDetalleDTO detalle)
        {
            InitializeComponent();

            formRegistro = registro;
            this.detalle = detalle;

            lblVehiculoCliente.Text = $"Registros de {detalle.Titular} -- {detalle.Marca} {detalle.Modelo} -- {detalle.Patente}";


        }

        private void btnVolverDetalle_Click(object sender, EventArgs e)
        {
            formRegistro.Show();
            this.Close();
        }

        private void DetalleRegistro_Load(object sender, EventArgs e)
        {
            CargarTabsRegistros();
        }

        private void CargarTabsRegistros()
        {
            int yOffset = 10; // Espacio desde arriba

            foreach (var registro in detalle.Registros)
            {
                Panel tarjeta = new Panel();
                tarjeta.Size = new Size(panelRegistros.Width - 30, 150);
                tarjeta.Location = new Point(10, yOffset);
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                Label lblFecha = new Label();
                lblFecha.Text = $"Fecha: {registro.Fecha.ToShortDateString()}";
                lblFecha.Location = new Point(10, 10);
                lblFecha.AutoSize = true;

                Label lblDescripcion = new Label();
                lblDescripcion.Text = $"Descripción:\n{registro.Descripcion}";
                lblDescripcion.Location = new Point(10, 40);
                lblDescripcion.Size = new Size(tarjeta.Width - 20, 80);
                lblDescripcion.AutoEllipsis = true;

                tarjeta.Controls.Add(lblFecha);
                tarjeta.Controls.Add(lblDescripcion);

                panelRegistros.Controls.Add(tarjeta);

                yOffset += tarjeta.Height + 10;
            }
        }

        private string SanitizeFileName(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "ArchivoSinNombre";

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                input = input.Replace(c, '_');
            }
            return input;
        }


        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            var originalSize = panelRegistros.Size;
            panelRegistros.Size = new Size(panelRegistros.Width, panelRegistros.DisplayRectangle.Height);

            using (var bmp = new Bitmap(panelRegistros.Width, panelRegistros.Height))
            {
                panelRegistros.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                using (var pdf = new PdfDocument())
                {
                    var page = pdf.AddPage();
                    page.Width = XUnit.FromPoint(bmp.Width * 72.0 / bmp.HorizontalResolution);
                    page.Height = XUnit.FromPoint(bmp.Height * 72.0 / bmp.VerticalResolution);

                    using (var gfx = XGraphics.FromPdfPage(page))
                    {
                        using (var ms = new MemoryStream())
                        {
                            bmp.Save(ms, ImageFormat.Png);
                            ms.Position = 0;
                            XImage img = XImage.FromStream(ms);
                            gfx.DrawImage(img, 0, 0, page.Width, page.Height);
                        }
                    }
                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "PDF files (*.pdf)|*.pdf";
                        sfd.FileName = $"Registros de {SanitizeFileName(this.detalle.Titular)}";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            pdf.Save(sfd.FileName);
                            MessageBox.Show($"PDF generado en:\n{sfd.FileName}",
                                            "Éxito",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }
            panelRegistros.Size = originalSize;
        }

    }
}
