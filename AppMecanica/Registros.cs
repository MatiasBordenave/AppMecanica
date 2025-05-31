using AppMecanicaCAD;
using AppMecanicaCLN;
using AppMecanicaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMecanica
{
    public partial class Registros : Form
    {
        private int paginaActual = 1;
        private int totalPaginas = 1;
        private int pageSize = 20;
        private ClienteCLN clienteCLN = new ClienteCLN();
        private RegistroCLN registroCLN = new RegistroCLN();
        private VehiculoCLN vehiculoCLN = new VehiculoCLN();
        private ClienteVehiculoCLN clienteVehiculoCLN = new ClienteVehiculoCLN();
        private VehiculoDetalleCLN vehiculoDetalleCLN = new VehiculoDetalleCLN();
        private bool cierreDesdeBoton = false;
        private Form formHome;
        public Registros(Form Home)
        {
            InitializeComponent();
            formHome = Home;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
        }
        private void btnVolverRegistro_Click(object sender, EventArgs e)
        {
            cierreDesdeBoton = true;
            formHome.Show();
            this.Close();
        }
        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRegistros.Columns[e.ColumnIndex].Name == "btnVerMas")
            {
                int idVehiculo = Convert.ToInt32(dgvRegistros.Rows[e.RowIndex].Cells["IdVehiculo"].Value);
                limpiarDataGridView();
                VehiculoDetalleDTO detalle = vehiculoDetalleCLN.ObtenerDetalleVehiculo(idVehiculo);
                dgvRegistros.DataSource = detalle.Registros;

                if (dgvRegistros.Columns.Contains("Id"))
                    dgvRegistros.Columns["Id"].Visible = false;
                if (dgvRegistros.Columns.Contains("IdVehiculo"))
                    dgvRegistros.Columns["IdVehiculo"].Visible = false;
            }
        }
        private async void Registros_Load(object sender, EventArgs e)
        {
            MostrarMensajeEnDataGrid("Cargando datos...");
            await Task.Run(() => CargarDataGridView(1));
            this.KeyPreview = true;
            this.KeyDown += FormRegistros_KeyDown;
        }


        private void MostrarMensajeEnDataGrid(string mensaje)
        {
            var tabla = new DataTable();
            tabla.Columns.Add("Mensaje");
            tabla.Rows.Add(mensaje);

            dgvRegistros.DataSource = tabla;
            dgvRegistros.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FormRegistros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtBuscar.Focus();
                e.Handled = true; 
            }
            if (e.KeyCode == Keys.F2)
            {
                if (dgvRegistros.CurrentRow != null && dgvRegistros.CurrentRow.Index >= 0)
                {
                    btnDetalles_Click(sender, EventArgs.Empty);
                    e.Handled = true;
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                btnResetDgv_Click(sender, e); 
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnVolverRegistro_Click(sender, e); 
                e.Handled = true;
            }
        }
        private void CargarDataGridView(int paginaActual)
        {
            int offset = (paginaActual - 1) * pageSize;
            totalPaginas = registroCLN.ObtenerTotalPaginas(pageSize);
            ObtenerCantidadPaginas();

            var lista = clienteVehiculoCLN.ObtenerClientesConVehiculos(offset, pageSize);

            Invoke(() =>
            {
                limpiarDataGridView();

                if (lista != null && lista.Count > 0)
                {
                    dgvRegistros.DataSource = lista;

                    if (dgvRegistros.Columns.Contains("IdCliente"))
                        dgvRegistros.Columns["IdCliente"].Visible = false;
                    if (dgvRegistros.Columns.Contains("IdVehiculo"))
                        dgvRegistros.Columns["IdVehiculo"].Visible = false;
                }
                else
                {
                    MostrarMensajeEnDataGrid("No hay datos para mostrar.");
                }

                GenerarBotonesPaginacion();
            });
        }

        private void limpiarDataGridView()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.Rows.Clear();
            dgvRegistros.Columns.Clear();
        }
        private void btnResetDgv_Click(object sender, EventArgs e)
        {
            CargarDataGridView(1);
            GenerarBotonesPaginacion();
            txtBuscar.Text = "";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(nombreCliente))
            nombreCliente = null;
            paginaActual = 1;
            var resultado = clienteVehiculoCLN.BuscarVehiculosPorCliente(nombreCliente, paginaActual, pageSize);
            dgvRegistros.Invoke(() =>
            {
                limpiarDataGridView();
                dgvRegistros.DataSource = resultado;
                if (dgvRegistros.Columns.Contains("IdCliente"))
                    dgvRegistros.Columns["IdCliente"].Visible = false;
                if (dgvRegistros.Columns.Contains("IdVehiculo"))
                    dgvRegistros.Columns["IdVehiculo"].Visible = false;
                txtBuscar.Focus();
                txtBuscar.SelectionStart = txtBuscar.Text.Length;
                totalPaginas = ObtenerCantidadPaginas(nombreCliente);
                GenerarBotonesPaginacion();
            });
        }
        private async void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnBuscar.PerformClick();
            }
        }


        private void btnDetalles_Click(object sender, EventArgs e)
        {

            if (dgvRegistros.CurrentRow != null)
            {
                int idVehiculo = Convert.ToInt32(dgvRegistros.CurrentRow.Cells["IdVehiculo"].Value);
                VehiculoDetalleDTO detalle = vehiculoDetalleCLN.ObtenerDetalleVehiculo(idVehiculo);
                DetalleRegistro detalleRegistro = new DetalleRegistro(this, detalle);
                detalleRegistro.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un vehículo primero.");
            }
        }
        private int ObtenerCantidadPaginas(string nombreCliente = null)
        {
            int totalRegistros;
            if (string.IsNullOrEmpty(nombreCliente))
                totalRegistros = clienteVehiculoCLN.ObtenerCantidadTotalRegistros();
            else
                totalRegistros = clienteVehiculoCLN.ObtenerCantidadRegistrosPorCliente(nombreCliente);
            return (int)Math.Ceiling((double)totalRegistros / pageSize);
        }
        private void GenerarBotonesPaginacion()
        {
            flpPaginas.Controls.Clear();
            int maxBotonesVisibles = 7;
            int inicio = Math.Max(1, paginaActual - 2);
            int fin = Math.Min(totalPaginas, paginaActual + 2);
            if (paginaActual <= 3)
            {
                inicio = 1;
                fin = Math.Min(totalPaginas, maxBotonesVisibles);
            }
            else if (paginaActual >= totalPaginas - 2)
            {
                inicio = Math.Max(1, totalPaginas - maxBotonesVisibles + 1);
                fin = totalPaginas;
            }
            void AgregarBoton(int numero)
            {
                Button btn = new Button();
                btn.Text = numero.ToString();
                btn.Width = 40;
                btn.Height = 30;
                btn.Tag = numero;
                if (numero == paginaActual)
                    btn.BackColor = Color.LightBlue;
                btn.Click += (s, e) =>
                {
                    paginaActual = (int)((Button)s).Tag;
                    CargarDataGridView(paginaActual);
                };
                flpPaginas.Controls.Add(btn);
            }
            if (inicio > 1)
            {
                AgregarBoton(1);

                if (inicio > 2)
                {
                    AgregarPuntosSuspensivos();
                }
            }
            for (int i = inicio; i <= fin; i++)
            {
                AgregarBoton(i);
            }
            if (fin < totalPaginas)
            {
                if (fin < totalPaginas - 1)
                {
                    AgregarPuntosSuspensivos();
                }

                AgregarBoton(totalPaginas);
            }
            btnAnteriorDGV.Enabled = paginaActual > 1;
            btnSiguienteDGV.Enabled = paginaActual < totalPaginas;
        }
        private void AgregarPuntosSuspensivos()
        {
            Button puntos = new Button();
            puntos.Text = "•••";
            puntos.Width = 40;
            puntos.Height = 30;
            puntos.Enabled = false;
            puntos.BackColor = Color.Gainsboro;
            puntos.ForeColor = Color.Black;
            puntos.FlatStyle = FlatStyle.Flat;
            puntos.Margin = new Padding(2);

            flpPaginas.Controls.Add(puntos);
        }
        private void btnSiguienteDGV_Click(object sender, EventArgs e)
        {
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                CargarDataGridView(paginaActual);
            }
        }
        private void btnAnteriorDGV_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarDataGridView(paginaActual);
            }
        }
        private void Registros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cierreDesdeBoton)
            {
                Application.Exit();
            }
        }
        private void btnSnRgstro_Click(object sender, EventArgs e)
        {
            FormAlerta alerta = new FormAlerta("sobre");
            alerta.ShowDialog();
        }
        private void btnManualRgstro_Click(object sender, EventArgs e)
        {
            FormAlerta alerta = new FormAlerta("comandos");
            alerta.ShowDialog();
        }
    }
}

