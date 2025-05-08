using AppMecanica.Models;
using AppMecanicaCLN;

namespace AppMecanica
{
    public partial class PresupuestoGenerado : Form
    {
        PresupuestoCLN presupuestoCLN = new PresupuestoCLN();
        private Form formPresupuesto;
        private PresupuestoData data;
        private readonly IPrintService _printService;
        private readonly IExportService _exportService;
        private bool cierreDesdeBoton = false;

        public PresupuestoGenerado(Form presupuesto, PresupuestoData data,
            IPrintService printService, IExportService exportService)
        {
            InitializeComponent();
            formPresupuesto = presupuesto;
            this.data = data;
            _printService = printService;
            _exportService = exportService;
        }
        private void PresupuestoGenerado_Load(object sender, EventArgs e)
        {
            lblDatosCliente.Text = $"Cliente:  {data.Titular}";
            lblDatosTelefono.Text = $"Teléfono:  {data.Telefono}";
            lblDatosAuto.Text = $"Vehiculo:  {data.Marca},  {data.Modelo},  {data.Año}";
            if (!string.IsNullOrWhiteSpace(data.Desc))
            {
                lblDescPresupuesto.Visible = true;
                lblDescPresupuesto.Text = $"*{data.Desc}";
            }
            else
            {
                lblDescPresupuesto.Visible = false;
            }
            lblTituloRepuesto.Text = $"Repuesto: ${data.TotalRepuestos}";
            lblTituloMDO.Text = $"Mano de obra: ${data.TotalManoObra}";
            lblMDOyR.Text = $"Total: ${data.TotalGeneral}";
            lblFecha.Text = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}";
            int nuevoIdPresupuesto = presupuestoCLN.CrearNuevoPresupuesto();
            lblTitulo.Text = $"Presupuesto  - Nro 0{nuevoIdPresupuesto}";
            foreach (var rep in data.Repuestos)
            {
                var lbl = new Label();
                lbl.AutoSize = true;
                lbl.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lbl.Margin = new Padding(10);
                lbl.ForeColor = Color.FromArgb(51, 51, 51); // ← Establece el color de letra
                lbl.Text = $"{rep.Nombre}, Cantidad x{rep.Cantidad}, Precio: ${rep.Precio}";
                flowPanelRepuestos.Controls.Add(lbl);
            }

            this.KeyPreview = true;
            this.KeyDown += FormPresupuestoGenerado_KeyDown;
        }
        private void FormPresupuestoGenerado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnImprimir_Click(sender, e);
                e.Handled = true; 
            }     
            if (e.KeyCode == Keys.F2)
            {
                btnImg_Click(sender, e); 
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnVolverGenerado_Click(sender, e); 
                e.Handled = true;
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ToggleButtons(false);
            _printService.Print(panelContenido);
            ToggleButtons(true);
        }
        private void btnImg_Click(object sender, EventArgs e)
        {
            ToggleButtons(false);
            _exportService.SaveAsImage(this);
            ToggleButtons(true);
        }
        private void ToggleButtons(bool visible)
        {
            btnImg.Visible = visible;
            btnImprimir.Visible = visible;
            btnVolverGenerado.Visible = visible;
        }
        private void btnVolverGenerado_Click(object sender, EventArgs e)
        {
            cierreDesdeBoton = true;
            formPresupuesto.Show();
            this.Close();
        }
        private void PresupuestoGenerado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cierreDesdeBoton)
            {
                Application.Exit();
            }
        }
    }
}
