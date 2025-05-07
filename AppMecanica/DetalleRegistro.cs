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
            foreach (var registro in detalle.Registros)
            {
                Panel tarjeta = new Panel();
                tarjeta.Size = new Size(panelRegistros.Width - 40, 10);
                tarjeta.Location = new Point(10, yOffset);
                int labelY = 10;

                Label lblFecha = new Label();
                lblFecha.Text = $"Fecha: {registro.Fecha.ToShortDateString()}";
                lblFecha.Location = new Point(10, labelY);
                lblFecha.AutoSize = true;
                tarjeta.Controls.Add(lblFecha);
                labelY += lblFecha.Height + 10;

                Label lblDescripcionTrabajo = new Label();
                lblDescripcionTrabajo.Text = $"Trabajo: {registro.Descripcion}";
                lblDescripcionTrabajo.Location = new Point(10, labelY);
                lblDescripcionTrabajo.MaximumSize = new Size(tarjeta.Width - 20, 0);
                lblDescripcionTrabajo.AutoSize = true;
                lblDescripcionTrabajo.TextAlign = ContentAlignment.TopLeft;
                tarjeta.Controls.Add(lblDescripcionTrabajo);
                labelY += lblDescripcionTrabajo.Height + 10;

                if (!string.IsNullOrWhiteSpace(registro.DescripcionRepuestos))
                {
                    Label lblRepuestos = new Label();
                    lblRepuestos.Text = $"Repuestos: {registro.DescripcionRepuestos}";
                    lblRepuestos.Location = new Point(10, labelY);
                    lblRepuestos.MaximumSize = new Size(tarjeta.Width - 10, 0);
                    lblRepuestos.AutoSize = true;
                    lblRepuestos.TextAlign = ContentAlignment.TopLeft;
                    tarjeta.Controls.Add(lblRepuestos);
                    labelY += lblRepuestos.Height + 10;

                    Label lblTotales = new Label();
                    lblTotales.Text = $"Total Repuestos: ${registro.TotalRepuestos}";
                    lblTotales.Location = new Point(10, labelY);
                    lblTotales.AutoSize = true;
                    tarjeta.Controls.Add(lblTotales);
                    labelY += lblTotales.Height + 10;
                }

                Label lblHoras = new Label();
                lblHoras.Text = $"Cantidad de Horas: {registro.CantidadHoras}, Precio por hora: ${registro.PrecioPorHora}";
                lblHoras.Location = new Point(10, labelY);
                lblHoras.AutoSize = true;
                tarjeta.Controls.Add(lblHoras);
                labelY += lblHoras.Height + 10;

                Label lblTotalHoras = new Label();
                lblTotalHoras.Text = $"Mano de obra total: ${registro.PrecioTotalHoras}";
                lblTotalHoras.Location = new Point(10, labelY);
                lblTotalHoras.AutoSize = true;
                tarjeta.Controls.Add(lblTotalHoras);
                labelY += lblTotalHoras.Height + 10;

                Label lblKm = new Label();
                lblKm.Text = $"Kilometraje: {registro.KilometrajeRegistro} km";
                lblKm.Location = new Point(10, labelY);
                lblKm.AutoSize = true;
                tarjeta.Controls.Add(lblKm);
                labelY += lblKm.Height + 12;
                tarjeta.Height = labelY;
                panelRegistros.Controls.Add(tarjeta);
                yOffset += tarjeta.Height + 20;

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
