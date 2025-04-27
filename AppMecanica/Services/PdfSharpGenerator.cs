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
        public void GenerarDesdePanel(Panel panel, string tituloArchivo)
        {
            var originalSize = panel.Size;
            panel.Size = new Size(panel.Width, panel.DisplayRectangle.Height);

            // Forzamos que el panel se actualice
            panel.PerformLayout();
            panel.Refresh();

            using (var bmp = new Bitmap(panel.Width, panel.Height))
            {
                panel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
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
            panel.Size = originalSize;
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
