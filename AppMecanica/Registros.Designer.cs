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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            dgvRegistros = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblPatenteRegis = new Label();
            btnAbrir = new Button();
            btnEliminarReg = new Button();
            btnVolverReg = new Button();
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
            dgvRegistros.Size = new Size(881, 376);
            dgvRegistros.TabIndex = 0;
            dgvRegistros.CellContentClick += dgvRegistros_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 128, 255);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(339, 84);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 26);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(122, 84);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(197, 26);
            txtBuscar.TabIndex = 2;
            // 
            // lblPatenteRegis
            // 
            lblPatenteRegis.AutoSize = true;
            lblPatenteRegis.BackColor = Color.FromArgb(128, 128, 255);
            lblPatenteRegis.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatenteRegis.Location = new Point(24, 84);
            lblPatenteRegis.Name = "lblPatenteRegis";
            lblPatenteRegis.Size = new Size(80, 25);
            lblPatenteRegis.TabIndex = 3;
            lblPatenteRegis.Text = "Patente";
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.FromArgb(128, 255, 128);
            btnAbrir.FlatStyle = FlatStyle.Popup;
            btnAbrir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrir.Location = new Point(928, 123);
            btnAbrir.Margin = new Padding(3, 2, 3, 2);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(109, 40);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = false;
            // 
            // btnEliminarReg
            // 
            btnEliminarReg.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarReg.FlatStyle = FlatStyle.Popup;
            btnEliminarReg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarReg.Location = new Point(928, 200);
            btnEliminarReg.Margin = new Padding(3, 2, 3, 2);
            btnEliminarReg.Name = "btnEliminarReg";
            btnEliminarReg.Size = new Size(109, 40);
            btnEliminarReg.TabIndex = 6;
            btnEliminarReg.Text = "Eliminar";
            btnEliminarReg.UseVisualStyleBackColor = false;
            // 
            // btnVolverReg
            // 
            btnVolverReg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverReg.Location = new Point(928, 459);
            btnVolverReg.Margin = new Padding(3, 2, 3, 2);
            btnVolverReg.Name = "btnVolverReg";
            btnVolverReg.Size = new Size(109, 40);
            btnVolverReg.TabIndex = 7;
            btnVolverReg.Text = "Volver";
            btnVolverReg.UseVisualStyleBackColor = true;
            btnVolverReg.Click += btnVolverReg_Click;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 560);
            Controls.Add(btnVolverReg);
            Controls.Add(btnEliminarReg);
            Controls.Add(btnAbrir);
            Controls.Add(lblPatenteRegis);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvRegistros);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblPatenteRegis;
        private Button btnAbrir;
        private Button btnEliminarReg;
        private Button btnVolverReg;
    }
}