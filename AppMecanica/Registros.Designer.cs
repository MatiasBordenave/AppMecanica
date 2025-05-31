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
            btnResetDgv = new Button();
            flpPaginas = new FlowLayoutPanel();
            btnAnteriorDGV = new Button();
            btnSiguienteDGV = new Button();
            txtBuscar = new TextBox();
            btnManualRgstro = new Button();
            btnSnRgstro = new Button();
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
            dgvRegistros.Location = new Point(24, 90);
            dgvRegistros.Margin = new Padding(3, 2, 3, 2);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(974, 586);
            dgvRegistros.TabIndex = 0;
            dgvRegistros.CellContentClick += dgvRegistros_CellContentClick;
            // 
            // btnVolverRegistro
            // 
            btnVolverRegistro.BackColor = Color.FromArgb(251, 176, 48);
            btnVolverRegistro.FlatStyle = FlatStyle.Flat;
            btnVolverRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVolverRegistro.ForeColor = Color.FromArgb(51, 51, 51);
            btnVolverRegistro.Location = new Point(1023, 616);
            btnVolverRegistro.Margin = new Padding(3, 2, 3, 2);
            btnVolverRegistro.Name = "btnVolverRegistro";
            btnVolverRegistro.Size = new Size(139, 60);
            btnVolverRegistro.TabIndex = 7;
            btnVolverRegistro.Text = "Volver al menú principal";
            btnVolverRegistro.UseVisualStyleBackColor = false;
            btnVolverRegistro.Click += btnVolverRegistro_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.FromArgb(251, 176, 48);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDetalles.ForeColor = Color.FromArgb(51, 51, 51);
            btnDetalles.Location = new Point(1023, 534);
            btnDetalles.Margin = new Padding(3, 2, 3, 2);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(139, 60);
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
            btnBuscar.Location = new Point(225, 47);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(35, 35);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "🔎";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnResetDgv
            // 
            btnResetDgv.BackColor = Color.FromArgb(251, 176, 48);
            btnResetDgv.FlatStyle = FlatStyle.Flat;
            btnResetDgv.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResetDgv.ForeColor = Color.FromArgb(51, 51, 51);
            btnResetDgv.Location = new Point(1023, 90);
            btnResetDgv.Margin = new Padding(3, 2, 3, 2);
            btnResetDgv.Name = "btnResetDgv";
            btnResetDgv.Size = new Size(139, 60);
            btnResetDgv.TabIndex = 14;
            btnResetDgv.Text = "Reiniciar Busqueda";
            btnResetDgv.UseVisualStyleBackColor = false;
            btnResetDgv.Click += btnResetDgv_Click;
            // 
            // flpPaginas
            // 
            flpPaginas.BackColor = Color.Transparent;
            flpPaginas.Location = new Point(192, 681);
            flpPaginas.Name = "flpPaginas";
            flpPaginas.Size = new Size(648, 33);
            flpPaginas.TabIndex = 20;
            // 
            // btnAnteriorDGV
            // 
            btnAnteriorDGV.BackColor = Color.FromArgb(251, 176, 48);
            btnAnteriorDGV.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnAnteriorDGV.FlatAppearance.CheckedBackColor = Color.Silver;
            btnAnteriorDGV.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAnteriorDGV.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAnteriorDGV.FlatStyle = FlatStyle.Flat;
            btnAnteriorDGV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAnteriorDGV.ForeColor = Color.White;
            btnAnteriorDGV.Location = new Point(87, 685);
            btnAnteriorDGV.Margin = new Padding(3, 2, 3, 2);
            btnAnteriorDGV.Name = "btnAnteriorDGV";
            btnAnteriorDGV.Size = new Size(99, 29);
            btnAnteriorDGV.TabIndex = 19;
            btnAnteriorDGV.Text = "Anterior";
            btnAnteriorDGV.UseVisualStyleBackColor = false;
            btnAnteriorDGV.Click += btnAnteriorDGV_Click;
            // 
            // btnSiguienteDGV
            // 
            btnSiguienteDGV.BackColor = Color.FromArgb(251, 176, 48);
            btnSiguienteDGV.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnSiguienteDGV.FlatAppearance.CheckedBackColor = Color.Silver;
            btnSiguienteDGV.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnSiguienteDGV.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSiguienteDGV.FlatStyle = FlatStyle.Flat;
            btnSiguienteDGV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSiguienteDGV.ForeColor = Color.White;
            btnSiguienteDGV.Location = new Point(846, 685);
            btnSiguienteDGV.Margin = new Padding(3, 2, 3, 2);
            btnSiguienteDGV.Name = "btnSiguienteDGV";
            btnSiguienteDGV.Size = new Size(99, 29);
            btnSiguienteDGV.TabIndex = 18;
            btnSiguienteDGV.Text = "Siguiente";
            btnSiguienteDGV.UseVisualStyleBackColor = false;
            btnSiguienteDGV.Click += btnSiguienteDGV_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(224, 224, 224);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(24, 51);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por cliente...";
            txtBuscar.ShortcutsEnabled = false;
            txtBuscar.Size = new Size(197, 27);
            txtBuscar.TabIndex = 21;
            // 
            // btnManualRgstro
            // 
            btnManualRgstro.BackColor = Color.FromArgb(51, 51, 51);
            btnManualRgstro.FlatAppearance.BorderColor = Color.Gray;
            btnManualRgstro.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnManualRgstro.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnManualRgstro.FlatStyle = FlatStyle.Flat;
            btnManualRgstro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManualRgstro.ForeColor = Color.White;
            btnManualRgstro.Location = new Point(103, 0);
            btnManualRgstro.Margin = new Padding(1, 2, 1, 2);
            btnManualRgstro.Name = "btnManualRgstro";
            btnManualRgstro.Size = new Size(95, 25);
            btnManualRgstro.TabIndex = 130;
            btnManualRgstro.Text = "Ayuda";
            btnManualRgstro.UseVisualStyleBackColor = false;
            btnManualRgstro.Click += btnManualRgstro_Click;
            // 
            // btnSnRgstro
            // 
            btnSnRgstro.BackColor = Color.FromArgb(51, 51, 51);
            btnSnRgstro.FlatAppearance.BorderColor = Color.Gray;
            btnSnRgstro.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnSnRgstro.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSnRgstro.FlatStyle = FlatStyle.Flat;
            btnSnRgstro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSnRgstro.ForeColor = Color.White;
            btnSnRgstro.Location = new Point(0, 0);
            btnSnRgstro.Margin = new Padding(1, 2, 1, 2);
            btnSnRgstro.Name = "btnSnRgstro";
            btnSnRgstro.Size = new Size(104, 25);
            btnSnRgstro.TabIndex = 129;
            btnSnRgstro.Text = "Sobre Nostros";
            btnSnRgstro.UseVisualStyleBackColor = false;
            btnSnRgstro.Click += btnSnRgstro_Click;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 722);
            Controls.Add(btnManualRgstro);
            Controls.Add(btnSnRgstro);
            Controls.Add(txtBuscar);
            Controls.Add(flpPaginas);
            Controls.Add(btnAnteriorDGV);
            Controls.Add(btnSiguienteDGV);
            Controls.Add(btnResetDgv);
            Controls.Add(btnBuscar);
            Controls.Add(btnDetalles);
            Controls.Add(btnVolverRegistro);
            Controls.Add(dgvRegistros);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(1100, 698);
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
        private Button btnResetDgv;
        private FlowLayoutPanel flpPaginas;
        private Button btnAnteriorDGV;
        private Button btnSiguienteDGV;
        private TextBox txtBuscar;
        private Button btnManualRgstro;
        private Button btnSnRgstro;
    }
}