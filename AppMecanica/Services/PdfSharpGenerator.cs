using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace AppMecanica.Servicios
{
    public class PdfSharpGenerator : IPdfGenerator
    {
        public void GenerarDesdePanel(Panel panelContenido, string tituloArchivo, Panel? panelHeader = null)
        {
            var originalContenidoSize = panelContenido.Size;
            var originalHeaderSize = panelHeader?.Size;

            panelContenido.Size = new Size(panelContenido.Width, panelContenido.DisplayRectangle.Height);
            panelContenido.PerformLayout();
            panelContenido.Refresh();

            int totalWidth = panelContenido.Width;
            int totalHeight = (panelHeader?.Height ?? 0) + panelContenido.Height;

            using (var bmpFinal = new Bitmap(totalWidth, totalHeight))
            {
                using (Graphics g = Graphics.FromImage(bmpFinal))
                {
                    int currentY = 0;

                    if (panelHeader != null)
                    {
                        panelHeader.Size = new Size(totalWidth, panelHeader.Height);
                        panelHeader.PerformLayout();
                        panelHeader.Refresh();

                        using (var bmpHeader = new Bitmap(panelHeader.Width, panelHeader.Height))
                        {
                            panelHeader.DrawToBitmap(bmpHeader, new Rectangle(0, 0, bmpHeader.Width, bmpHeader.Height));
                            g.DrawImage(bmpHeader, 0, currentY);
                        }

                        currentY += panelHeader.Height;
                    }

                    using (var bmpContenido = new Bitmap(panelContenido.Width, panelContenido.Height))
                    {
                        panelContenido.DrawToBitmap(bmpContenido, new Rectangle(0, 0, bmpContenido.Width, bmpContenido.Height));
                        g.DrawImage(bmpContenido, 0, currentY);
                    }
                }

                using (var pdf = new PdfDocument())
                {
                    var page = pdf.AddPage();
                    page.Width = XUnit.FromPoint(bmpFinal.Width * 72.0 / bmpFinal.HorizontalResolution);
                    page.Height = XUnit.FromPoint(bmpFinal.Height * 72.0 / bmpFinal.VerticalResolution);

                    using (var gfx = XGraphics.FromPdfPage(page))
                    {
                        using (var ms = new MemoryStream())
                        {
                            bmpFinal.Save(ms, ImageFormat.Png);
                            ms.Position = 0;
                            XImage img = XImage.FromStream(ms);
                            gfx.DrawImage(img, 0, 0, page.Width, page.Height);
                        }
                    }

                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "PDF files (*.pdf)|*.pdf";
                        sfd.FileName = $"{SanitizeFileName(tituloArchivo)}";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            pdf.Save(sfd.FileName);
                            MessageBox.Show($"PDF generado Exitosamente",
                                            "Éxito",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }

            panelContenido.Size = originalContenidoSize;
            if (panelHeader != null && originalHeaderSize.HasValue)
                panelHeader.Size = originalHeaderSize.Value;
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
    }
}
