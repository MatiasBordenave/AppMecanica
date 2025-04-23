using System.Drawing.Printing;

public class PrintService : IPrintService
{
    public void Print(Control control)
    {
        PrintDocument pd = new PrintDocument();
        pd.PrintPage += (sender, e) =>
        {
            Bitmap bmp = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            Rectangle printArea = e.PageBounds;
            float ratioX = (float)printArea.Width / bmp.Width;
            float ratioY = (float)printArea.Height / bmp.Height;
            float ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(bmp.Width * ratio);
            int newHeight = (int)(bmp.Height * ratio);
            int posX = printArea.X + (printArea.Width - newWidth) / 2;
            int posY = printArea.Y + (printArea.Height - newHeight) / 2;

            e.Graphics.DrawImage(bmp, posX, posY, newWidth, newHeight);
        };

        PrintPreviewDialog preview = new PrintPreviewDialog
        {
            Document = pd
        };
        preview.ShowDialog();
    }
}
