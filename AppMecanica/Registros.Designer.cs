namespace AppMecanica
{
    partial class Registros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            dgvRegistros = new DataGridView();
            btnVolverRegistro = new Button();
            btnDetalles = new Button();
            btnBuscar = new Button();
            btnClientes = new Button();
            btnVehiculos = new Button();
            btnRegistros = new Button();
            btnResetDgv = new Button();
            flpPaginas = new FlowLayoutPanel();
            btnAnteriorDGV = new Button();
            btnSiguienteDGV = new Button();
            txtBuscar = new TextBox();
            btnRepuestos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistros
            // 
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistros.Location = new Point(27, 120);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(981, 636);
            dgvRegistros.TabIndex = 0;
            dgvRegistros.CellContentClick += dgvRegistros_CellContentClick;
            // 
            // btnVolverRegistro
            // 
            btnVolverRegistro.BackColor = Color.FromArgb(251, 176, 48);
            btnVolverRegistro.FlatStyle = FlatStyle.Flat;
            btnVolverRegistro.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnVolverRegistro.ForeColor = Color.FromArgb(51, 51, 51);
            btnVolverRegistro.Location = new Point(1066, 787);
            btnVolverRegistro.Name = "btnVolverRegistro";
            btnVolverRegistro.Size = new Size(159, 80);
            btnVolverRegistro.TabIndex = 7;
            btnVolverRegistro.Text = "Volver al menú principal";
            btnVolverRegistro.UseVisualStyleBackColor = false;
            btnVolverRegistro.Click += btnVolverRegistro_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.FromArgb(251, 176, 48);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnDetalles.ForeColor = Color.FromArgb(51, 51, 51);
            btnDetalles.Location = new Point(1066, 676);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(159, 80);
            btnDetalles.TabIndex = 8;
            btnDetalles.Text = "Ver Detalles del Cliente";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscar.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(51, 51, 51);
            btnBuscar.Location = new Point(262, 57);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(40, 47);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "🔎";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(51, 51, 51);
            btnClientes.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(1082, 192);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(125, 53);
            btnClientes.TabIndex = 10;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.BackColor = Color.FromArgb(51, 51, 51);
            btnVehiculos.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnVehiculos.ForeColor = Color.White;
            btnVehiculos.Location = new Point(1082, 251);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(125, 53);
            btnVehiculos.TabIndex = 11;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.UseVisualStyleBackColor = false;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.BackColor = Color.FromArgb(51, 51, 51);
            btnRegistros.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnRegistros.ForeColor = Color.White;
            btnRegistros.Location = new Point(1082, 309);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(125, 53);
            btnRegistros.TabIndex = 12;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = false;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // btnResetDgv
            // 
            btnResetDgv.BackColor = Color.FromArgb(51, 51, 51);
            btnResetDgv.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnResetDgv.ForeColor = Color.White;
            btnResetDgv.Location = new Point(1082, 133);
            btnResetDgv.Name = "btnResetDgv";
            btnResetDgv.Size = new Size(125, 53);
            btnResetDgv.TabIndex = 14;
            btnResetDgv.Text = "Reset DGV";
            btnResetDgv.UseVisualStyleBackColor = false;
            btnResetDgv.Click += btnResetDgv_Click;
            // 
            // flpPaginas
            // 
            flpPaginas.BackColor = Color.Transparent;
            flpPaginas.Location = new Point(147, 803);
            flpPaginas.Margin = new Padding(3, 4, 3, 4);
            flpPaginas.Name = "flpPaginas";
            flpPaginas.Size = new Size(741, 44);
            flpPaginas.TabIndex = 20;
            // 
            // btnAnteriorDGV
            // 
            btnAnteriorDGV.BackColor = Color.FromArgb(51, 51, 51);
            btnAnteriorDGV.FlatAppearance.BorderColor = Color.White;
            btnAnteriorDGV.FlatAppearance.BorderSize = 0;
            btnAnteriorDGV.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAnteriorDGV.FlatStyle = FlatStyle.Flat;
            btnAnteriorDGV.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnAnteriorDGV.ForeColor = Color.White;
            btnAnteriorDGV.Location = new Point(27, 808);
            btnAnteriorDGV.Name = "btnAnteriorDGV";
            btnAnteriorDGV.Size = new Size(113, 39);
            btnAnteriorDGV.TabIndex = 19;
            btnAnteriorDGV.Text = "Anterior";
            btnAnteriorDGV.UseVisualStyleBackColor = false;
            btnAnteriorDGV.Click += btnAnteriorDGV_Click;
            // 
            // btnSiguienteDGV
            // 
            btnSiguienteDGV.BackColor = Color.FromArgb(51, 51, 51);
            btnSiguienteDGV.FlatAppearance.BorderSize = 0;
            btnSiguienteDGV.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSiguienteDGV.FlatStyle = FlatStyle.Flat;
            btnSiguienteDGV.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnSiguienteDGV.ForeColor = Color.White;
            btnSiguienteDGV.Location = new Point(895, 808);
            btnSiguienteDGV.Name = "btnSiguienteDGV";
            btnSiguienteDGV.Size = new Size(113, 39);
            btnSiguienteDGV.TabIndex = 18;
            btnSiguienteDGV.Text = "Siguiente";
            btnSiguienteDGV.UseVisualStyleBackColor = false;
            btnSiguienteDGV.Click += btnSiguienteDGV_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(224, 224, 224);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtBuscar.Location = new Point(27, 65);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por cliente...";
            txtBuscar.Size = new Size(225, 26);
            txtBuscar.TabIndex = 21;
            // 
            // btnRepuestos
            // 
            btnRepuestos.BackColor = Color.FromArgb(51, 51, 51);
            btnRepuestos.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnRepuestos.ForeColor = Color.White;
            btnRepuestos.Location = new Point(1082, 368);
            btnRepuestos.Name = "btnRepuestos";
            btnRepuestos.Size = new Size(125, 53);
            btnRepuestos.TabIndex = 22;
            btnRepuestos.Text = "Repuestos";
            btnRepuestos.UseVisualStyleBackColor = false;
            btnRepuestos.Click += btnRepuestos_Click;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1239, 881);
            Controls.Add(btnRepuestos);
            Controls.Add(txtBuscar);
            Controls.Add(flpPaginas);
            Controls.Add(btnAnteriorDGV);
            Controls.Add(btnSiguienteDGV);
            Controls.Add(btnResetDgv);
            Controls.Add(btnRegistros);
            Controls.Add(btnVehiculos);
            Controls.Add(btnClientes);
            Controls.Add(btnBuscar);
            Controls.Add(btnDetalles);
            Controls.Add(btnVolverRegistro);
            Controls.Add(dgvRegistros);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(912, 779);
            Name = "Registros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ocaranza Mecanica Software";
            FormClosing += Registros_FormClosing;
            Load += Registros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegistros;
        private Button btnVolverRegistro;
        private Button btnDetalles;
        private Button btnBuscar;
        private Button btnClientes;
        private Button btnVehiculos;
        private Button btnRegistros;
        private Button btnResetDgv;
        private FlowLayoutPanel flpPaginas;
        private Button btnAnteriorDGV;
        private Button btnSiguienteDGV;
        private TextBox txtBuscar;
        private Button btnRepuestos;
    }
}