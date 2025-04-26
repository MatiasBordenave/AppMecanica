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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvRegistros = new DataGridView();
            txtBuscar = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistros
            // 
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("HomepageBaukasten Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("BreezeSans", 9.749999F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRegistros.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRegistros.Location = new Point(24, 90);
            dgvRegistros.Margin = new Padding(3, 2, 3, 2);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(858, 477);
            dgvRegistros.TabIndex = 0;
            dgvRegistros.CellContentClick += dgvRegistros_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(224, 224, 224);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(24, 46);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(197, 29);
            txtBuscar.TabIndex = 2;
            // 
            // btnVolverRegistro
            // 
            btnVolverRegistro.BackColor = Color.FromArgb(251, 176, 48);
            btnVolverRegistro.FlatStyle = FlatStyle.Flat;
            btnVolverRegistro.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnVolverRegistro.ForeColor = Color.FromArgb(51, 51, 51);
            btnVolverRegistro.Location = new Point(933, 590);
            btnVolverRegistro.Margin = new Padding(3, 2, 3, 2);
            btnVolverRegistro.Name = "btnVolverRegistro";
            btnVolverRegistro.Size = new Size(139, 60);
            btnVolverRegistro.TabIndex = 7;
            btnVolverRegistro.Text = "Volver";
            btnVolverRegistro.UseVisualStyleBackColor = false;
            btnVolverRegistro.Click += btnVolverRegistro_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.FromArgb(251, 176, 48);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnDetalles.ForeColor = Color.FromArgb(51, 51, 51);
            btnDetalles.Location = new Point(933, 507);
            btnDetalles.Margin = new Padding(3, 2, 3, 2);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(139, 60);
            btnDetalles.TabIndex = 8;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(251, 176, 48);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnBuscar.ForeColor = Color.FromArgb(51, 51, 51);
            btnBuscar.Location = new Point(238, 46);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(51, 51, 51);
            btnClientes.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(963, 287);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(109, 40);
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
            btnVehiculos.Location = new Point(963, 331);
            btnVehiculos.Margin = new Padding(3, 2, 3, 2);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(109, 40);
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
            btnRegistros.Location = new Point(963, 375);
            btnRegistros.Margin = new Padding(3, 2, 3, 2);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(109, 40);
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
            btnResetDgv.Location = new Point(963, 90);
            btnResetDgv.Margin = new Padding(3, 2, 3, 2);
            btnResetDgv.Name = "btnResetDgv";
            btnResetDgv.Size = new Size(109, 40);
            btnResetDgv.TabIndex = 14;
            btnResetDgv.Text = "Reset DGV";
            btnResetDgv.UseVisualStyleBackColor = false;
            btnResetDgv.Click += btnResetDgv_Click;
            // 
            // flpPaginas
            // 
            flpPaginas.BackColor = Color.Transparent;
            flpPaginas.Location = new Point(172, 602);
            flpPaginas.Name = "flpPaginas";
            flpPaginas.Size = new Size(573, 33);
            flpPaginas.TabIndex = 20;
            // 
            // btnAnteriorDGV
            // 
            btnAnteriorDGV.BackColor = Color.FromArgb(51, 51, 51);
            btnAnteriorDGV.FlatAppearance.BorderSize = 0;
            btnAnteriorDGV.FlatStyle = FlatStyle.Flat;
            btnAnteriorDGV.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnAnteriorDGV.ForeColor = Color.White;
            btnAnteriorDGV.Location = new Point(24, 606);
            btnAnteriorDGV.Margin = new Padding(3, 2, 3, 2);
            btnAnteriorDGV.Name = "btnAnteriorDGV";
            btnAnteriorDGV.Size = new Size(109, 29);
            btnAnteriorDGV.TabIndex = 19;
            btnAnteriorDGV.Text = "Anterior";
            btnAnteriorDGV.UseVisualStyleBackColor = false;
            btnAnteriorDGV.Click += btnAnteriorDGV_Click;
            // 
            // btnSiguienteDGV
            // 
            btnSiguienteDGV.BackColor = Color.FromArgb(51, 51, 51);
            btnSiguienteDGV.FlatAppearance.BorderSize = 0;
            btnSiguienteDGV.FlatStyle = FlatStyle.Flat;
            btnSiguienteDGV.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnSiguienteDGV.ForeColor = Color.White;
            btnSiguienteDGV.Location = new Point(773, 606);
            btnSiguienteDGV.Margin = new Padding(3, 2, 3, 2);
            btnSiguienteDGV.Name = "btnSiguienteDGV";
            btnSiguienteDGV.Size = new Size(109, 29);
            btnSiguienteDGV.TabIndex = 18;
            btnSiguienteDGV.Text = "Siguiente";
            btnSiguienteDGV.UseVisualStyleBackColor = false;
            btnSiguienteDGV.Click += btnSiguienteDGV_Click;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 661);
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
            Controls.Add(txtBuscar);
            Controls.Add(dgvRegistros);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(800, 598);
            Name = "Registros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ocaranza Mecanica Software";
            Load += Registros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegistros;
        private TextBox txtBuscar;
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
    }
}