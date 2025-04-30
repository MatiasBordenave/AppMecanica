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
        public DetalleRegistro(Form registro, VehiculoDetalleDTO detalle)
        {
            InitializeComponent();
            formRegistro = registro;
            this.detalle = detalle;

            lblVehiculoCliente.Text = $"Registros de {detalle.Titular} | {detalle.Marca} {detalle.Modelo} | {detalle.Patente}";
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
            panelRegistros.Controls.Clear();
            int yOffset = 10;

            foreach (var registro in detalle.Registros)
            {
                var tarjeta = new Panel
                {
                    Size = new Size(panelRegistros.Width - 30, 10),
                    Location = new Point(10, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    //BackColor = Color.White
                };

                int currentY = 10;

                var lblFecha = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(10, currentY),
                    Text = $"Fecha: {registro.Fecha.ToShortDateString()}"
                };
                tarjeta.Controls.Add(lblFecha);
                currentY = lblFecha.Bottom + 10;

                var lblDescripcion = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 11),
                    MaximumSize = new Size(tarjeta.Width - 20, 0),
                    Location = new Point(10, currentY),
                    Text = $"Descripción: {registro.Descripcion}"
                };
                tarjeta.Controls.Add(lblDescripcion);
                tarjeta.PerformLayout(); // para que mida bien
                currentY = lblDescripcion.Bottom + 10;

                var lblKilometro = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),
                    Location = new Point(10, currentY),
                    Text = $"Kilometraje: {registro.KilometrajeRegistro}"
                };
                tarjeta.Controls.Add(lblKilometro);
                currentY = lblKilometro.Bottom + 10;

                var lblCantidadHoras = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),
                    Location = new Point(10, currentY),
                    Text = $"Cantidad de Horas: {registro.CantidadHoras}"
                };
                tarjeta.Controls.Add(lblCantidadHoras);
                currentY = lblCantidadHoras.Bottom + 10;

                var lblPrecioPorHora = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),
                    Location = new Point(10, currentY),
                    Text = $"Precio por Hora: ${registro.PrecioPorHora}"
                };
                tarjeta.Controls.Add(lblPrecioPorHora);
                currentY = lblPrecioPorHora.Bottom + 10;

                var lblPrecioTotalHoras = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),
                    Location = new Point(10, currentY),
                    Text = $"Precio Total de Horas: ${registro.PrecioTotalHoras}"
                };
                tarjeta.Controls.Add(lblPrecioTotalHoras);
                currentY = lblPrecioTotalHoras.Bottom + 10;

                var lblTotalRepuestos = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),
                    Location = new Point(10, currentY),
                    Text = $"Total Repuestos: ${registro.TotalRepuestos}"
                };
                tarjeta.Controls.Add(lblTotalRepuestos);
                currentY = lblTotalRepuestos.Bottom + 10;

                var lblPrecioTotal = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(10, currentY),
                    Text = $"Precio Total: ${registro.PrecioTotal}"
                };
                tarjeta.Controls.Add(lblPrecioTotal);
                currentY = lblPrecioTotal.Bottom + 10;

                tarjeta.Height = currentY + 10;

                panelRegistros.Controls.Add(tarjeta);

                yOffset += tarjeta.Height;

                var linea = new Panel
                {
                    Size = new Size(panelRegistros.Width - 30, 1),
                    Location = new Point(10, yOffset),
                    //BackColor = Color.Gray
                };
                panelRegistros.Controls.Add(linea);

                yOffset += 10;
            }

            var espacioFinal = new Panel
            {
                Size = new Size(panelRegistros.Width - 30, 40),
                Location = new Point(10, yOffset)
            };
            panelRegistros.Controls.Add(espacioFinal);
        }




        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            pdfGenerator.GenerarDesdePanel(panelRegistros, $"Registros de {detalle.Titular}", panelHeader);
        }

    }
}
