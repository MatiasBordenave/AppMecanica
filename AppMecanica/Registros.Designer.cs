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
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(27, 164);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(1047, 618);
            dgvRegistros.TabIndex = 0;
            dgvRegistros.CellContentClick += dgvRegistros_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(27, 79);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(225, 51);
            txtBuscar.TabIndex = 2;
            // 
            // btnVolverRegistro
            // 
            btnVolverRegistro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverRegistro.Location = new Point(1101, 801);
            btnVolverRegistro.Name = "btnVolverRegistro";
            btnVolverRegistro.Size = new Size(125, 53);
            btnVolverRegistro.TabIndex = 7;
            btnVolverRegistro.Text = "Volver";
            btnVolverRegistro.UseVisualStyleBackColor = true;
            btnVolverRegistro.Click += btnVolverRegistro_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.LightGreen;
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetalles.Location = new Point(1101, 729);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(125, 53);
            btnDetalles.TabIndex = 8;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSeaGreen;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(259, 79);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 53);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Chartreuse;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(27, 801);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(125, 53);
            btnClientes.TabIndex = 10;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVehiculos
            // 
            btnVehiculos.BackColor = Color.Chartreuse;
            btnVehiculos.FlatStyle = FlatStyle.Flat;
            btnVehiculos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehiculos.Location = new Point(158, 801);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(125, 53);
            btnVehiculos.TabIndex = 11;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.UseVisualStyleBackColor = false;
            btnVehiculos.Click += btnVehiculos_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.BackColor = Color.Chartreuse;
            btnRegistros.FlatStyle = FlatStyle.Flat;
            btnRegistros.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistros.Location = new Point(289, 801);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(125, 53);
            btnRegistros.TabIndex = 12;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = false;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // btnResetDgv
            // 
            btnResetDgv.BackColor = Color.Silver;
            btnResetDgv.FlatStyle = FlatStyle.Flat;
            btnResetDgv.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetDgv.Location = new Point(1101, 164);
            btnResetDgv.Name = "btnResetDgv";
            btnResetDgv.Size = new Size(125, 53);
            btnResetDgv.TabIndex = 14;
            btnResetDgv.Text = "Reset DGV";
            btnResetDgv.UseVisualStyleBackColor = false;
            btnResetDgv.Click += btnResetDgv_Click;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.MidnightBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1239, 881);
            Controls.Add(btnResetDgv);
            Controls.Add(btnRegistros);
            Controls.Add(btnVehiculos);
            Controls.Add(btnClientes);
            Controls.Add(btnBuscar);
            Controls.Add(btnDetalles);
            Controls.Add(btnVolverRegistro);
            Controls.Add(txtBuscar);
            Controls.Add(dgvRegistros);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(912, 784);
            Name = "Registros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
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
    }
}