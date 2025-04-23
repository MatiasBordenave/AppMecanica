public class ExportService : IExportService
{
    public void SaveAsImage(Form form)
    {
        Rectangle bounds = form.RectangleToScreen(form.ClientRectangle);
        using Bitmap bmp = new Bitmap(bounds.Width, bounds.Height);
        using Graphics g = Graphics.FromImage(bmp);
        g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);

        using SaveFileDialog sfd = new SaveFileDialog
        {
            Filter = "PNG Image|*.png",
            FileName = $"Presupuesto_{DateTime.Now:dd-MM-yyyy}.png"
        };

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            bmp.Save(sfd.FileName);
            MessageBox.Show("Imagen guardada exitosamente.");
        }
    }
}
