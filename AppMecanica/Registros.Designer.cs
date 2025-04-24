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
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(27, 120);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(1047, 691);
            dgvRegistros.TabIndex = 0;
            dgvRegistros.CellContentClick += dgvRegistros_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(224, 224, 224);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(27, 61);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(225, 38);
            txtBuscar.TabIndex = 2;
            // 
            // btnVolverRegistro
            // 
            btnVolverRegistro.BackColor = Color.FromArgb(251, 176, 48);
            btnVolverRegistro.FlatStyle = FlatStyle.Flat;
            btnVolverRegistro.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnVolverRegistro.Location = new Point(1101, 800);
            btnVolverRegistro.Name = "btnVolverRegistro";
            btnVolverRegistro.Size = new Size(125, 67);
            btnVolverRegistro.TabIndex = 7;
            btnVolverRegistro.Text = "Volver";
            btnVolverRegistro.UseVisualStyleBackColor = false;
            btnVolverRegistro.Click += btnVolverRegistro_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.FromArgb(251, 176, 48);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnDetalles.Location = new Point(1101, 705);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(125, 71);
            btnDetalles.TabIndex = 8;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(251, 176, 48);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnBuscar.Location = new Point(271, 61);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 39);
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
            btnClientes.Location = new Point(1101, 383);
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
            btnVehiculos.Location = new Point(1101, 441);
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
            btnRegistros.Location = new Point(1101, 500);
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
            btnResetDgv.Location = new Point(1101, 120);
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
            flpPaginas.Location = new Point(238, 821);
            flpPaginas.Margin = new Padding(3, 4, 3, 4);
            flpPaginas.Name = "flpPaginas";
            flpPaginas.Size = new Size(655, 44);
            flpPaginas.TabIndex = 20;
            // 
            // btnAnteriorDGV
            // 
            btnAnteriorDGV.BackColor = Color.FromArgb(51, 51, 51);
            btnAnteriorDGV.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnAnteriorDGV.ForeColor = Color.Coral;
            btnAnteriorDGV.Location = new Point(27, 827);
            btnAnteriorDGV.Name = "btnAnteriorDGV";
            btnAnteriorDGV.Size = new Size(125, 39);
            btnAnteriorDGV.TabIndex = 19;
            btnAnteriorDGV.Text = "Anterior";
            btnAnteriorDGV.UseVisualStyleBackColor = false;
            btnAnteriorDGV.Click += btnAnteriorDGV_Click;
            // 
            // btnSiguienteDGV
            // 
            btnSiguienteDGV.BackColor = Color.FromArgb(51, 51, 51);
            btnSiguienteDGV.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnSiguienteDGV.ForeColor = Color.Coral;
            btnSiguienteDGV.Location = new Point(950, 827);
            btnSiguienteDGV.Name = "btnSiguienteDGV";
            btnSiguienteDGV.Size = new Size(125, 39);
            btnSiguienteDGV.TabIndex = 18;
            btnSiguienteDGV.Text = "Siguiente";
            btnSiguienteDGV.UseVisualStyleBackColor = false;
            btnSiguienteDGV.Click += btnSiguienteDGV_Click;
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
            MaximizeBox = false;
            MinimumSize = new Size(912, 784);
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