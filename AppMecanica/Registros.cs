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
        private bool mostrandoMensaje = false;

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
            else if (e.KeyCode == Keys.F2)
            {
                if (dgvRegistros.CurrentRow != null && dgvRegistros.CurrentRow.Index >= 0)
                {
                    btnDetalles_Click(sender, EventArgs.Empty);
                    e.Handled = true;
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnResetDgv_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                    btnVolverRegistro_Click(sender, e);
                    e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnBorrar_Click(sender, EventArgs.Empty);
                e.Handled = true;
            }
        }

        private void CargarDataGridView(int paginaActual)
        {
            try
            {
                int offset = (paginaActual - 1) * pageSize;
                totalPaginas = registroCLN.ObtenerTotalPaginas(pageSize);
                ObtenerCantidadPaginas();

                var lista = clienteVehiculoCLN.ObtenerClientesConVehiculos(offset, pageSize);

                Invoke(() =>
                {
                    dgvRegistros.DataSource = null;
                    dgvRegistros.Columns.Clear();

                    if (lista != null && lista.Count > 0)
                    {
                        mostrandoMensaje = false;

                        dgvRegistros.AutoGenerateColumns = true; 
                        dgvRegistros.DataSource = lista;

                        ConfigurarDataGridViewPostBinding();

                        if (dgvRegistros.Rows.Count > 0)
                        {
                            dgvRegistros.Rows[0].Selected = true;
                        }
                    }
                    else
                    {
                        mostrandoMensaje = true;
                        MostrarMensajeEnDataGrid("No hay datos para mostrar.");
                    }

                    GenerarBotonesPaginacion();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridViewPostBinding()
        {
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.MultiSelect = false;
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string[] columnasOcultar = { "IdCliente", "IdVehiculo", "activo" };
            foreach (string columna in columnasOcultar)
            {
                if (dgvRegistros.Columns.Contains(columna))
                {
                    dgvRegistros.Columns[columna].Visible = false;
                }
            }

            mostrandoMensaje = false;
            if (dgvRegistros.Columns.Contains("NombreYApellido"))
                dgvRegistros.Columns["NombreYApellido"].HeaderText = "Titular";
            if (dgvRegistros.Columns.Contains("Patente"))
                dgvRegistros.Columns["Patente"].HeaderText = "Patente";
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
            try
            {
                string nombreCliente = txtBuscar.Text.Trim();
                if (string.IsNullOrEmpty(nombreCliente))
                    nombreCliente = null;

                paginaActual = 1;
                var resultado = clienteVehiculoCLN.BuscarVehiculosPorCliente(nombreCliente, paginaActual, pageSize);

                dgvRegistros.Invoke(() =>
                {
                    limpiarDataGridView();

                    if (resultado == null || resultado.Count == 0)
                    {
                        MostrarMensajeEnDataGrid("No se encontraron vehículos con ese criterio de búsqueda");
                        btnDetalles.Enabled = false;
                    }
                    else
                    {
                        dgvRegistros.DataSource = resultado;
                        mostrandoMensaje = false;

                        if (dgvRegistros.Columns.Contains("IdCliente"))
                            dgvRegistros.Columns["IdCliente"].Visible = false;
                        if (dgvRegistros.Columns.Contains("IdVehiculo"))
                            dgvRegistros.Columns["IdVehiculo"].Visible = false;

                        btnDetalles.Enabled = true; 
                    }

                    txtBuscar.Focus();
                    txtBuscar.SelectionStart = txtBuscar.Text.Length;
                    totalPaginas = ObtenerCantidadPaginas(nombreCliente);
                    GenerarBotonesPaginacion();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
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
            try
            {
                if (dgvRegistros.SelectedRows.Count == 0 ||
                    dgvRegistros.CurrentRow == null ||
                    dgvRegistros.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Por favor, seleccioná un vehículo válido primero.",
                                  "Advertencia",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                if (dgvRegistros.CurrentRow.Cells["IdVehiculo"].Value == null)
                {
                    MessageBox.Show("No se puede obtener la información del vehículo seleccionado.",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                int idVehiculo = Convert.ToInt32(dgvRegistros.CurrentRow.Cells["IdVehiculo"].Value);

                VehiculoDetalleDTO detalle = vehiculoDetalleCLN.ObtenerDetalleVehiculo(idVehiculo);

                if (detalle == null)
                {
                    MessageBox.Show("No se encontraron detalles para el vehículo seleccionado.",
                                  "Información",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    return;
                }

                DetalleRegistro detalleRegistro = new DetalleRegistro(this, detalle);
                detalleRegistro.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar detalles: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (mostrandoMensaje)
            {
                MessageBox.Show("No hay registros válidos para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvRegistros.SelectedRows.Count == 0 || dgvRegistros.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Por favor, seleccioná un registro para borrar.",
                              "Advertencia",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvRegistros.SelectedRows[0];

            if (fila.IsNewRow || fila.Cells["IdVehiculo"].Value == null || fila.Cells["IdVehiculo"].Value == DBNull.Value)
            {
                MessageBox.Show("Por favor, seleccioná un registro válido para borrar.",
                              "Advertencia",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            int idVehiculo;
            if (!int.TryParse(fila.Cells["IdVehiculo"].Value.ToString(), out idVehiculo))
            {
                MessageBox.Show("El ID del vehículo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patente = fila.Cells["Patente"].Value?.ToString() ?? "sin patente";

            var confirm = MessageBox.Show(
                "¿Estás seguro de borrar este registro?",
                "Confirmar borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = RegistroCAD.MarcarRegistroComoEliminado(idVehiculo);

                    if (eliminado)
                    {
                        MessageBox.Show("Registros eliminados correctamente.",
                                      "Éxito",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                        CargarDataGridView(paginaActual);
                        dgvRegistros.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros para eliminar.",
                                      "Información",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar registros: {ex.Message}",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }
    }
}