namespace AppMecanica
{
    partial class DetalleRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleRegistro));
            btnVolverDetalle = new Button();
            btnGenerarPDF = new Button();
            lblVehiculoCliente = new Label();
            panelRegistros = new Panel();
            panelHeader = new Panel();
            lblLinea = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            datosMecanico2 = new Label();
            nombreMecanico = new Label();
            datosMecanico3 = new Label();
            datosMecanico = new Label();
            direccionMecanico = new Label();
            TelefonoMecanico = new Label();
            panelRegistros.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnVolverDetalle
            // 
            btnVolverDetalle.BackColor = Color.FromArgb(251, 176, 48);
            btnVolverDetalle.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnVolverDetalle.FlatStyle = FlatStyle.Flat;
            btnVolverDetalle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVolverDetalle.ForeColor = Color.FromArgb(51, 51, 51);
            btnVolverDetalle.Location = new Point(1181, 956);
            btnVolverDetalle.Name = "btnVolverDetalle";
            btnVolverDetalle.Size = new Size(159, 80);
            btnVolverDetalle.TabIndex = 3;
            btnVolverDetalle.Text = "Volver a Registros";
            btnVolverDetalle.UseVisualStyleBackColor = false;
            btnVolverDetalle.Click += btnVolverDetalle_Click;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.BackColor = Color.FromArgb(251, 176, 48);
            btnGenerarPDF.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnGenerarPDF.FlatStyle = FlatStyle.Flat;
            btnGenerarPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerarPDF.ForeColor = Color.FromArgb(51, 51, 51);
            btnGenerarPDF.Location = new Point(1002, 956);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(159, 80);
            btnGenerarPDF.TabIndex = 4;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // lblVehiculoCliente
            // 
            lblVehiculoCliente.AutoSize = true;
            lblVehiculoCliente.BackColor = Color.Transparent;
            lblVehiculoCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehiculoCliente.Location = new Point(55, 155);
            lblVehiculoCliente.Name = "lblVehiculoCliente";
            lblVehiculoCliente.Size = new Size(162, 32);
            lblVehiculoCliente.TabIndex = 61;
            lblVehiculoCliente.Text = "Ver Vehiculo:";
            // 
            // panelRegistros
            // 
            panelRegistros.AutoScroll = true;
            panelRegistros.BackColor = Color.WhiteSmoke;
            panelRegistros.Controls.Add(panelHeader);
            panelRegistros.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelRegistros.Location = new Point(14, 16);
            panelRegistros.Margin = new Padding(3, 4, 3, 4);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1314, 933);
            panelRegistros.TabIndex = 62;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(lblLinea);
            panelHeader.Controls.Add(lblVehiculoCliente);
            panelHeader.Controls.Add(pictureBox2);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(datosMecanico2);
            panelHeader.Controls.Add(nombreMecanico);
            panelHeader.Controls.Add(datosMecanico3);
            panelHeader.Controls.Add(datosMecanico);
            panelHeader.Controls.Add(direccionMecanico);
            panelHeader.Controls.Add(TelefonoMecanico);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1314, 211);
            panelHeader.TabIndex = 142;
            // 
            // lblLinea
            // 
            lblLinea.BackColor = Color.Silver;
            lblLinea.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinea.Location = new Point(38, 192);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(1257, 1);
            lblLinea.TabIndex = 141;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(826, 33);
            pictureBox2.Margin = new Padding(5, 5, 5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 135;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(974, 31);
            label1.Name = "label1";
            label1.Size = new Size(1, 133);
            label1.TabIndex = 140;
            // 
            // datosMecanico2
            // 
            datosMecanico2.AutoSize = true;
            datosMecanico2.BackColor = Color.Transparent;
            datosMecanico2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            datosMecanico2.ForeColor = Color.FromArgb(51, 51, 51);
            datosMecanico2.Location = new Point(982, 77);
            datosMecanico2.Name = "datosMecanico2";
            datosMecanico2.Size = new Size(107, 28);
            datosMecanico2.TabIndex = 136;
            datosMecanico2.Text = "Direccion:";
            // 
            // nombreMecanico
            // 
            nombreMecanico.AutoSize = true;
            nombreMecanico.BackColor = Color.Transparent;
            nombreMecanico.Font = new Font("Segoe UI", 11.25F);
            nombreMecanico.ForeColor = Color.FromArgb(51, 51, 51);
            nombreMecanico.Location = new Point(1085, 32);
            nombreMecanico.Name = "nombreMecanico";
            nombreMecanico.Size = new Size(162, 25);
            nombreMecanico.TabIndex = 134;
            nombreMecanico.Text = "Ocaranza Rodolfo";
            // 
            // datosMecanico3
            // 
            datosMecanico3.AutoSize = true;
            datosMecanico3.BackColor = Color.Transparent;
            datosMecanico3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            datosMecanico3.ForeColor = Color.FromArgb(51, 51, 51);
            datosMecanico3.Location = new Point(982, 125);
            datosMecanico3.Name = "datosMecanico3";
            datosMecanico3.Size = new Size(99, 28);
            datosMecanico3.TabIndex = 137;
            datosMecanico3.Text = "Telefono:";
            // 
            // datosMecanico
            // 
            datosMecanico.AutoSize = true;
            datosMecanico.BackColor = Color.Transparent;
            datosMecanico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            datosMecanico.ForeColor = Color.FromArgb(51, 51, 51);
            datosMecanico.Location = new Point(982, 32);
            datosMecanico.Name = "datosMecanico";
            datosMecanico.Size = new Size(108, 28);
            datosMecanico.TabIndex = 133;
            datosMecanico.Text = "Mecanico:";
            // 
            // direccionMecanico
            // 
            direccionMecanico.AutoSize = true;
            direccionMecanico.BackColor = Color.Transparent;
            direccionMecanico.Font = new Font("Segoe UI", 11.25F);
            direccionMecanico.ForeColor = Color.FromArgb(51, 51, 51);
            direccionMecanico.Location = new Point(1087, 77);
            direccionMecanico.Name = "direccionMecanico";
            direccionMecanico.Size = new Size(207, 25);
            direccionMecanico.TabIndex = 138;
            direccionMecanico.Text = "Av. Independencia 411 ";
            // 
            // TelefonoMecanico
            // 
            TelefonoMecanico.AutoSize = true;
            TelefonoMecanico.BackColor = Color.Transparent;
            TelefonoMecanico.Font = new Font("Segoe UI", 11.25F);
            TelefonoMecanico.ForeColor = Color.FromArgb(51, 51, 51);
            TelefonoMecanico.Location = new Point(1087, 125);
            TelefonoMecanico.Name = "TelefonoMecanico";
            TelefonoMecanico.Size = new Size(150, 25);
            TelefonoMecanico.TabIndex = 139;
            TelefonoMecanico.Text = "+54 3816405637";
            // 
            // DetalleRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1353, 971);
            Controls.Add(panelRegistros);
            Controls.Add(btnGenerarPDF);
            Controls.Add(btnVolverDetalle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(1369, 1018);
            Name = "DetalleRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ocaranza Mecanica Software";
            FormClosing += DetalleRegistro_FormClosing;
            Load += DetalleRegistro_Load;
            panelRegistros.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolverDetalle;
        private Button btnGenerarPDF;
        private Label lblVehiculoCliente;
        private Panel panelRegistros;
        private Label label1;
        private Label nombreMecanico;
        private Label datosMecanico;
        private Label TelefonoMecanico;
        private Label direccionMecanico;
        private Label datosMecanico3;
        private Label datosMecanico2;
        private PictureBox pictureBox2;
        private Label lblLinea;
        private Panel panelHeader;
    }
}