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
            this.KeyPreview = true; // Para que el formulario detecte las teclas
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Escape)
            {
                btnVolverDetalle_Click(sender, e); // Tu lógica de volver
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F2)
            {
                btnGenerarPDF_Click(sender, e); // Tu lógica de volver
                e.Handled = true;
            }
        }
        private void CargarTabsRegistros()
        {
            int yOffset = panelHeader.Height;

            foreach (var registro in detalle.Registros)
            {
                Panel tarjeta = new Panel();
                tarjeta.Size = new Size(panelRegistros.Width - 30, 200); 
                tarjeta.Location = new Point(10, yOffset);
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                int labelY = 10;

                Label lblFecha = new Label();
                lblFecha.Text = $"Fecha: {registro.Fecha.ToShortDateString()}";
                lblFecha.Location = new Point(10, labelY);
                lblFecha.AutoSize = true;
                tarjeta.Controls.Add(lblFecha);
                labelY += 20;

                Label lblDescripcionTrabajo = new Label();
                lblDescripcionTrabajo.Text = $"Trabajo: {registro.Descripcion}";
                lblDescripcionTrabajo.Location = new Point(10, labelY);
                lblDescripcionTrabajo.AutoSize = true;
                tarjeta.Controls.Add(lblDescripcionTrabajo);
                labelY += 20;

                if (!string.IsNullOrWhiteSpace(registro.DescripcionRepuestos))
                {
                    Label lblRepuestos = new Label();
                    lblRepuestos.Text = $"Repuestos: {registro.DescripcionRepuestos}";
                    lblRepuestos.Location = new Point(10, labelY);
                    lblRepuestos.Size = new Size(tarjeta.Width - 20, 40);
                    lblRepuestos.AutoEllipsis = true;
                    tarjeta.Controls.Add(lblRepuestos);
                    labelY += 45;

                    Label lblTotales = new Label();
                    lblTotales.Text = $"Total Repuestos: ${registro.TotalRepuestos}";
                    lblTotales.Location = new Point(10, labelY);
                    lblTotales.AutoSize = true;
                    tarjeta.Controls.Add(lblTotales);
                    labelY += 20;
                }

                Label lblHoras = new Label();
                lblHoras.Text = $"Horas: {registro.CantidadHoras} hs, ${registro.PrecioPorHora}/h";
                lblHoras.Location = new Point(10, labelY);
                lblHoras.AutoSize = true;
                tarjeta.Controls.Add(lblHoras);
                labelY += 20;

                Label lblKm = new Label();
                lblKm.Text = $"Kilometraje: {registro.KilometrajeRegistro} km";
                lblKm.Location = new Point(10, labelY);
                lblKm.AutoSize = true;
                tarjeta.Controls.Add(lblKm);

                panelRegistros.Controls.Add(tarjeta);
                yOffset += tarjeta.Height + 10;
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
