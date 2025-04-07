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
            btnVolverHome = new Button();
            btnDetalles = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(24, 123);
            dgvRegistros.Margin = new Padding(3, 2, 3, 2);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(916, 518);
            dgvRegistros.TabIndex = 0;
            dgvRegistros.CellContentClick += dgvRegistros_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(24, 70);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(197, 29);
            txtBuscar.TabIndex = 2;
            // 
            // btnVolverHome
            // 
            btnVolverHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverHome.Location = new Point(963, 601);
            btnVolverHome.Margin = new Padding(3, 2, 3, 2);
            btnVolverHome.Name = "btnVolverHome";
            btnVolverHome.Size = new Size(109, 40);
            btnVolverHome.TabIndex = 7;
            btnVolverHome.Text = "Volver";
            btnVolverHome.UseVisualStyleBackColor = true;
            btnVolverHome.Click += btnVolverReg_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.LightGreen;
            btnDetalles.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetalles.Location = new Point(963, 547);
            btnDetalles.Margin = new Padding(3, 2, 3, 2);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(109, 40);
            btnDetalles.TabIndex = 8;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(244, 59);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 40);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 661);
            Controls.Add(btnBuscar);
            Controls.Add(btnDetalles);
            Controls.Add(btnVolverHome);
            Controls.Add(txtBuscar);
            Controls.Add(dgvRegistros);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(800, 600);
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
        private Button btnVolverHome;
        private Button btnDetalles;
        private Button btnBuscar;
    }
}