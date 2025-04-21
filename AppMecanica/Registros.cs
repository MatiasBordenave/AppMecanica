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
        private bool enDetalle = false;

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
            //    if (e.RowIndex >= 0 && dgvRegistros.Columns[e.ColumnIndex].Name == "btnVerMas")
            //    {
            //        int idVehiculo = Convert.ToInt32(dgvRegistros.Rows[e.RowIndex].Cells["IdVehiculo"].Value);

            //        limpiarDataGridView(); // Limpiar los datos anteriores

            //        VehiculoDetalleDTO detalle = vehiculoDetalleCLN.ObtenerDetalleVehiculo(idVehiculo);

            //        // Mostramos solo los registros del vehículo
            //        dgvRegistros.DataSource = detalle.Registros;

            //        // Escondemos columnas innecesarias
            //        if (dgvRegistros.Columns.Contains("Id"))
            //            dgvRegistros.Columns["Id"].Visible = false;
            //        if (dgvRegistros.Columns.Contains("IdVehiculo"))
            //            dgvRegistros.Columns["IdVehiculo"].Visible = false;

            //        // Limpiamos los botones de paginación para evitar confusión al ver detalles
            //        flpPaginas.Controls.Clear();

            //        // Desactivamos los botones de paginación en la vista detalle
            //        btnSiguienteDGV.Enabled = false;
            //        btnAnteriorDGV.Enabled = false;

            //        enDetalle = true; // Indicamos que estamos en el modo detalle
            //    }
        }



        private async void Registros_Load(object sender, EventArgs e)
        {
            await Task.Run(() => CargarDataGridView(1));
        }

        private void CargarDataGridView(int pagina)
        {
            int offset = (pagina - 1) * pageSize;

            Task.Run(() =>
            {
                // Obtener la lista de vehículos con clientes
                var lista = clienteVehiculoCLN.ObtenerClientesConVehiculos(offset, pageSize);

                // Contar el total de registros para calcular el número total de páginas
                int totalRegistros = clienteVehiculoCLN.ObtenerCantidadTotalRegistros();
                totalPaginas = (int)Math.Ceiling((double)totalRegistros / pageSize);

                // Actualizar la interfaz de usuario en el hilo principal
                dgvRegistros.Invoke(() =>
                {
                    limpiarDataGridView();
                    dgvRegistros.DataSource = lista;

                    // Escondemos las columnas innecesarias
                    if (dgvRegistros.Columns.Contains("IdCliente"))
                        dgvRegistros.Columns["IdCliente"].Visible = false;
                    if (dgvRegistros.Columns.Contains("IdVehiculo"))
                        dgvRegistros.Columns["IdVehiculo"].Visible = false;


                    // Actualizar los botones de paginación
                    GenerarPaginacion(pagina, null); // Carga sin filtro

                    // Habilitar o deshabilitar los botones de paginación
                    if (paginaActual >= totalPaginas)
                    {
                        btnSiguienteDGV.Enabled = false;  // Desactivar el botón "Siguiente"
                    }
                    else
                    {
                        btnSiguienteDGV.Enabled = true;   // Activar el botón "Siguiente"
                    }

                    if (paginaActual <= 1)
                    {
                        btnAnteriorDGV.Enabled = false;   // Desactivar el botón "Anterior"
                    }
                    else
                    {
                        btnAnteriorDGV.Enabled = true;    // Activar el botón "Anterior"
                    }
                });
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
            paginaActual = 1;
            txtBuscar.Text = "";

            limpiarDataGridView(); // Solo si notás comportamientos extraños

            CargarDataGridView(paginaActual);
            GenerarPaginacion(1);
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(nombreCliente))
                nombreCliente = null;

            paginaActual = 1;

            BuscarPorCliente(nombreCliente, paginaActual);
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

            if (dgvRegistros.CurrentRow != null)
            {
                // Obtener el ID del vehículo seleccionado
                int idVehiculo = Convert.ToInt32(dgvRegistros.CurrentRow.Cells["IdVehiculo"].Value);

                // Obtener los datos del vehículo y sus registros
                VehiculoDetalleDTO detalle = vehiculoDetalleCLN.ObtenerDetalleVehiculo(idVehiculo);

                // Abrir el nuevo formulario con los registros
                DetalleRegistro detalleRegistro = new DetalleRegistro(this, detalle);

                detalleRegistro.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un vehículo primero.");
            }

        }


        private void GenerarPaginacion(int paginaActual, string nombreCliente = null)
        {
            flpPaginas.Controls.Clear(); // Limpiar los botones previos

            // Obtener la cantidad de registros dependiendo si hay filtro o no
            int totalRegistros = string.IsNullOrEmpty(nombreCliente)
                ? clienteVehiculoCLN.ObtenerCantidadTotalRegistros()
                : clienteVehiculoCLN.ObtenerCantidadRegistrosPorCliente(nombreCliente);

            totalPaginas = (int)Math.Ceiling((double)totalRegistros / pageSize);

            // Si hay solo una página, no mostrar botones
            if (totalPaginas <= 1)
            {
                btnAnteriorDGV.Enabled = false;
                btnSiguienteDGV.Enabled = false;
                return;
            }

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
                    this.paginaActual = (int)((Button)s).Tag;

                    // Detectar si es búsqueda o carga completa
                    if (string.IsNullOrEmpty(nombreCliente))
                        CargarDataGridView(this.paginaActual);
                    else
                        BuscarPorCliente(nombreCliente, this.paginaActual);
                };

                flpPaginas.Controls.Add(btn);
            }

            btnAnteriorDGV.Enabled = paginaActual > 1;
            btnSiguienteDGV.Enabled = paginaActual < totalPaginas;
        }


        private void BuscarPorCliente(string nombreCliente, int pagina)
        {
            var resultado = clienteVehiculoCLN.BuscarVehiculosPorCliente(nombreCliente, pagina, pageSize);

            dgvRegistros.Invoke(() =>
            {
                limpiarDataGridView();
                dgvRegistros.DataSource = resultado;

                // Ocultar columnas innecesarias después de asignar DataSource
                if (dgvRegistros.Columns.Contains("IdVehiculo"))
                    dgvRegistros.Columns["IdVehiculo"].Visible = false;

                if (dgvRegistros.Columns.Contains("IdCliente"))
                    dgvRegistros.Columns["IdCliente"].Visible = false;

                GenerarPaginacion(pagina, nombreCliente);
            });
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

