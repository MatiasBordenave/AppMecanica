using AppMecanicaEntidades;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AppMecanica.Servicios;


namespace AppMecanica
{
    public partial class DetalleRegistro : Form
    {
        private Form formRegistro;
        private VehiculoDetalleDTO detalle;
        private IPdfGenerator pdfGenerator = new PdfSharpGenerator();
        private bool cierreDesdeBoton = false;
        public DetalleRegistro(Form registro, VehiculoDetalleDTO detalle)
        {
            InitializeComponent();
            formRegistro = registro;
            this.detalle = detalle;
            lblVehiculoCliente.Text = $"Registros de {detalle.Titular} -- {detalle.Marca} {detalle.Modelo} -- {detalle.Patente}";
        }
        private void btnVolverDetalle_Click(object sender, EventArgs e)
        {
            cierreDesdeBoton = true;
            formRegistro.Show();
            this.Close();
        }
        private void DetalleRegistro_Load(object sender, EventArgs e)
        {
            CargarTabsRegistros();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Escape)
            {
                btnVolverDetalle_Click(sender, e);
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F2)
            {
                btnGenerarPDF_Click(sender, e);
                e.Handled = true;
            }
        }
        private void CargarTabsRegistros()
        {
            int yOffset = panelHeader.Height;
            int spacing = 10;
            Font labelFont = new Font("Segoe UI", 15); // Usar la misma fuente que tus labels

            foreach (var registro in detalle.Registros)
            {
                Panel tarjeta = new Panel();
                tarjeta.Width = panelRegistros.Width - 120;
                tarjeta.Location = new Point(10, yOffset);
                tarjeta.AutoSize = false;

                int labelY = 10;
                int availableWidth = tarjeta.Width - 20; // Ancho disponible para los labels

                // Función auxiliar para crear labels con texto multilínea
                Label CreateMultilineLabel(string text, ref int currentY)
                {
                    var label = new Label();
                    label.Text = text;
                    label.Location = new Point(10, currentY);
                    label.MaximumSize = new Size(availableWidth, 0);
                    label.AutoSize = true;
                    label.Font = labelFont;

                    // Calcular altura necesaria
                    using (Graphics g = CreateGraphics())
                    {
                        SizeF size = g.MeasureString(text, labelFont, availableWidth);
                        label.Height = (int)Math.Ceiling(size.Height);
                    }

                    tarjeta.Controls.Add(label);
                    currentY += label.Height + spacing;
                    return label;
                }

                // Agregar todos los elementos
                CreateMultilineLabel($"Fecha: {registro.Fecha.ToShortDateString()}", ref labelY);
                CreateMultilineLabel($"Trabajo: {registro.Descripcion}", ref labelY);

                if (!string.IsNullOrWhiteSpace(registro.DescripcionRepuestos))
                {
                    CreateMultilineLabel($"Repuestos: {registro.DescripcionRepuestos}", ref labelY);
                    CreateMultilineLabel($"Total Repuestos: ${registro.TotalRepuestos}", ref labelY);
                }

                CreateMultilineLabel($"Horas: {registro.CantidadHoras} hs, ${registro.PrecioPorHora}/h", ref labelY);
                CreateMultilineLabel($"Kilometraje: {registro.KilometrajeRegistro} km", ref labelY);
                CreateMultilineLabel($"Total: {registro.PrecioTotal}.", ref labelY);

                // Ajustar altura del panel
                tarjeta.Height = labelY;
                panelRegistros.Controls.Add(tarjeta);

                // Línea separadora
                yOffset += tarjeta.Height + 10;
                Panel linea = new Panel();
                linea.BackColor = Color.DarkGray;
                linea.Size = new Size(panelRegistros.Width - 40, 1);
                linea.Location = new Point(10, yOffset);
                panelRegistros.Controls.Add(linea);
                yOffset += 20;
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            panelRegistros.BackColor = Color.Transparent;
            pdfGenerator.GenerarDesdePanel(panelRegistros, $"Registros de {detalle.Titular}");
        }
        private void DetalleRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cierreDesdeBoton)
            {
                Application.Exit();
            }
        }
    }
}
