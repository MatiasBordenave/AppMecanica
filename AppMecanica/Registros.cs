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




        private Form formHome;

        public Registros(Form Home)
        {
            InitializeComponent();
            formHome = Home;
            txtBuscar.KeyDown += txtBuscar_KeyDown;

        }

        private void btnVolverRegistro_Click(object sender, EventArgs e)
        {
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

                // MOSTRAMOS SOLO LOS REGISTROS del vehículo
                dgvRegistros.DataSource = detalle.Registros;

                if (dgvRegistros.Columns.Contains("Id"))
                    dgvRegistros.Columns["Id"].Visible = false;
                if (dgvRegistros.Columns.Contains("IdVehiculo"))
                    dgvRegistros.Columns["IdVehiculo"].Visible = false;
            }

        }

        private async void Registros_Load(object sender, EventArgs e)
        {
            await Task.Run(() => CargarDataGridView(1));
        }

        private void CargarDataGridView(int paginaActual)
        {
            int offset = (paginaActual - 1) * pageSize;

            totalPaginas = registroCLN.ObtenerTotalPaginas(pageSize);
            ObtenerCantidadPaginas();


            Task.Run(() =>
            {
                var lista = clienteVehiculoCLN.ObtenerClientesConVehiculos(offset, pageSize);

                // Actualizá el DataGridView en el hilo de la UI
                dgvRegistros.Invoke(() =>
                {
                    limpiarDataGridView();
                    dgvRegistros.DataSource = lista;

                    if (dgvRegistros.Columns.Contains("IdCliente"))
                        dgvRegistros.Columns["IdCliente"].Visible = false;
                    if (dgvRegistros.Columns.Contains("IdVehiculo"))
                        dgvRegistros.Columns["IdVehiculo"].Visible = false;

                    if (dgvRegistros.Columns.Contains("btnVerMas"))
                        dgvRegistros.Columns.Remove("btnVerMas");

                    if (!dgvRegistros.Columns.Contains("btnVerMas"))
                    {
                        DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                        btnCol.HeaderText = "Acciones";
                        btnCol.Text = "Ver más";
                        btnCol.UseColumnTextForButtonValue = true;
                        btnCol.Name = "btnVerMas";
                        dgvRegistros.Columns.Add(btnCol);
                    }
                });
                Invoke(() => GenerarBotonesPaginacion());
            });
        }

        private void limpiarDataGridView()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.Rows.Clear();
            dgvRegistros.Columns.Clear();
        }






        private void btnClientes_Click(object sender, EventArgs e)
        {
            limpiarDataGridView();
            dgvRegistros.DataSource = clienteCLN.ObtenerClientes();
            dgvRegistros.Columns["nombreYApellido"].HeaderText = "Titular";
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            limpiarDataGridView();
            dgvRegistros.DataSource = vehiculoCLN.ObtenerVehiculos();



        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            limpiarDataGridView();
            dgvRegistros.DataSource = registroCLN.ObtenerRegistros();
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

                if (!dgvRegistros.Columns.Contains("btnVerMas"))
                {
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                    btnCol.HeaderText = "Acciones";
                    btnCol.Text = "Ver más";
                    btnCol.UseColumnTextForButtonValue = true;
                    btnCol.Name = "btnVerMas";
                    dgvRegistros.Columns.Add(btnCol);
                }

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
                e.SuppressKeyPress = true; // 👈 esto evita que el Enter "limpie" o haga algo raro
                btnBuscar.PerformClick();
            }
        }


        private void btnDetalles_Click(object sender, EventArgs e)
        {
            DetalleRegistro detalleRegistro = new DetalleRegistro(this);

            detalleRegistro.Show();
            this.Hide();

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

            for (int i = 1; i <= totalPaginas; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Width = 40;
                btn.Height = 30;
                btn.Tag = i;

                if (i == paginaActual)
                    btn.BackColor = Color.LightBlue;

                btn.Click += (s, e) =>
                {
                    paginaActual = (int)((Button)s).Tag;
                    CargarDataGridView(paginaActual);

                };

                flpPaginas.Controls.Add(btn);
            }

            btnAnteriorDGV.Enabled = paginaActual > 1;
            btnSiguienteDGV.Enabled = paginaActual < totalPaginas;
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
    }
}

