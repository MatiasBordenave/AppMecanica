using AppMecanicaCAD;
using AppMecanicaCLN;
using AppMecanicaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMecanica
{
    public partial class Registros : Form
    {
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

        private void Registros_Load(object sender, EventArgs e)
        {
            lblFormRegistros.Text = "";
            CargarDataGridView();
        }

        private void CargarDataGridView()
        {
            limpiarDataGridView();
            var lista = clienteVehiculoCLN.ObtenerClientesConVehiculos();
            dgvRegistros.DataSource = lista;

            if (dgvRegistros.Columns.Contains("IdCliente"))
                dgvRegistros.Columns["IdCliente"].Visible = false;
            if (dgvRegistros.Columns.Contains("IdVehiculo"))
                dgvRegistros.Columns["IdVehiculo"].Visible = false;

            if (dgvRegistros.Columns.Contains("btnVerMas"))
            {
                dgvRegistros.Columns.Remove("btnVerMas");
            }

            // Podés agregar una columna de botón aquí
            if (!dgvRegistros.Columns.Contains("btnVerMas"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.HeaderText = "Acciones";
                btnCol.Text = "Ver más";
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.Name = "btnVerMas";
                dgvRegistros.Columns.Add(btnCol);
            }
        }

        private void limpiarDataGridView()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.Rows.Clear();
            dgvRegistros.Columns.Clear();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            lblFormRegistros.Text = "Clientes";
            limpiarDataGridView();
            dgvRegistros.DataSource = clienteCLN.ObtenerClientes();
            dgvRegistros.Columns["nombreYApellido"].HeaderText = "Titular";
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            lblFormRegistros.Text = "Vehiculos";
            limpiarDataGridView();
            dgvRegistros.DataSource = vehiculoCLN.ObtenerVehiculos();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            lblFormRegistros.Text = "Registros";
            limpiarDataGridView();
            dgvRegistros.DataSource = registroCLN.ObtenerRegistros();
        }

        private void btnResetDgv_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string nombreCliente = txtBuscar.Text.Trim();


            if (!string.IsNullOrEmpty(nombreCliente))
            {
                var resultado = clienteVehiculoCLN.BuscarVehiculosPorCliente(nombreCliente);
                dgvRegistros.DataSource = resultado;

                // (Opcional) volvés a agregar el botón Ver Más
                if (!dgvRegistros.Columns.Contains("btnVerMas"))
                {
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                    btnCol.HeaderText = "Acciones";
                    btnCol.Text = "Ver más";
                    btnCol.UseColumnTextForButtonValue = true;
                    btnCol.Name = "btnVerMas";
                    dgvRegistros.Columns.Add(btnCol);
                }
            }

        }
    }
}

