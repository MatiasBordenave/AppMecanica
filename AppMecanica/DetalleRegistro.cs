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
            int yOffset = 10;

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



        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            pdfGenerator.GenerarDesdePanel(panelRegistros, $"Registros de {detalle.Titular}");
        }

    }
}
