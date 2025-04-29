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
            label1 = new Label();
            nombreMecanico = new Label();
            datosMecanico = new Label();
            TelefonoMecanico = new Label();
            direccionMecanico = new Label();
            datosMecanico3 = new Label();
            datosMecanico2 = new Label();
            pictureBox2 = new PictureBox();
            lblLinea = new Label();
            panelContenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolverDetalle
            // 
            btnVolverDetalle.BackColor = Color.FromArgb(251, 176, 48);
            btnVolverDetalle.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnVolverDetalle.FlatStyle = FlatStyle.Flat;
            btnVolverDetalle.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnVolverDetalle.ForeColor = Color.FromArgb(51, 51, 51);
            btnVolverDetalle.Location = new Point(933, 590);
            btnVolverDetalle.Margin = new Padding(3, 2, 3, 2);
            btnVolverDetalle.Name = "btnVolverDetalle";
            btnVolverDetalle.Size = new Size(139, 60);
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
            btnGenerarPDF.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnGenerarPDF.ForeColor = Color.FromArgb(51, 51, 51);
            btnGenerarPDF.Location = new Point(777, 590);
            btnGenerarPDF.Margin = new Padding(3, 2, 3, 2);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(139, 60);
            btnGenerarPDF.TabIndex = 4;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // lblVehiculoCliente
            // 
            lblVehiculoCliente.AutoSize = true;
            lblVehiculoCliente.BackColor = Color.Transparent;
            lblVehiculoCliente.Font = new Font("HomepageBaukasten Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehiculoCliente.Location = new Point(31, 102);
            lblVehiculoCliente.Name = "lblVehiculoCliente";
            lblVehiculoCliente.Size = new Size(119, 18);
            lblVehiculoCliente.TabIndex = 61;
            lblVehiculoCliente.Text = "Ver Vehiculo:";
            // 
            // panelRegistros
            // 
            panelRegistros.AutoScroll = true;
            panelRegistros.BackColor = SystemColors.ButtonHighlight;
            panelRegistros.Location = new Point(12, 147);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1060, 421);
            panelRegistros.TabIndex = 62;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(802, 20);
            label1.Name = "label1";
            label1.Size = new Size(1, 100);
            label1.TabIndex = 140;
            // 
            // nombreMecanico
            // 
            nombreMecanico.AutoSize = true;
            nombreMecanico.BackColor = Color.Transparent;
            nombreMecanico.Font = new Font("BreezeSans", 11.25F, FontStyle.Bold);
            nombreMecanico.ForeColor = Color.FromArgb(51, 51, 51);
            nombreMecanico.Location = new Point(899, 21);
            nombreMecanico.Name = "nombreMecanico";
            nombreMecanico.Size = new Size(132, 18);
            nombreMecanico.TabIndex = 134;
            nombreMecanico.Text = "Ocaranza Rodolfo";
            // 
            // datosMecanico
            // 
            datosMecanico.AutoSize = true;
            datosMecanico.BackColor = Color.Transparent;
            datosMecanico.Font = new Font("HomepageBaukasten Bold", 11.9999981F);
            datosMecanico.ForeColor = Color.FromArgb(51, 51, 51);
            datosMecanico.Location = new Point(809, 21);
            datosMecanico.Name = "datosMecanico";
            datosMecanico.Size = new Size(90, 18);
            datosMecanico.TabIndex = 133;
            datosMecanico.Text = "Mecanico:";
            // 
            // TelefonoMecanico
            // 
            TelefonoMecanico.AutoSize = true;
            TelefonoMecanico.BackColor = Color.Transparent;
            TelefonoMecanico.Font = new Font("BreezeSans", 11.25F, FontStyle.Bold);
            TelefonoMecanico.ForeColor = Color.FromArgb(51, 51, 51);
            TelefonoMecanico.Location = new Point(901, 91);
            TelefonoMecanico.Name = "TelefonoMecanico";
            TelefonoMecanico.Size = new Size(128, 18);
            TelefonoMecanico.TabIndex = 139;
            TelefonoMecanico.Text = "+54 3816405637";
            // 
            // direccionMecanico
            // 
            direccionMecanico.AutoSize = true;
            direccionMecanico.BackColor = Color.Transparent;
            direccionMecanico.Font = new Font("BreezeSans", 11.25F, FontStyle.Bold);
            direccionMecanico.ForeColor = Color.FromArgb(51, 51, 51);
            direccionMecanico.Location = new Point(901, 55);
            direccionMecanico.Name = "direccionMecanico";
            direccionMecanico.Size = new Size(166, 18);
            direccionMecanico.TabIndex = 138;
            direccionMecanico.Text = "Av. Independencia 411 ";
            // 
            // datosMecanico3
            // 
            datosMecanico3.AutoSize = true;
            datosMecanico3.BackColor = Color.Transparent;
            datosMecanico3.Font = new Font("HomepageBaukasten Bold", 11.9999981F);
            datosMecanico3.ForeColor = Color.FromArgb(51, 51, 51);
            datosMecanico3.Location = new Point(809, 91);
            datosMecanico3.Name = "datosMecanico3";
            datosMecanico3.Size = new Size(86, 18);
            datosMecanico3.TabIndex = 137;
            datosMecanico3.Text = "Telefono:";
            // 
            // datosMecanico2
            // 
            datosMecanico2.AutoSize = true;
            datosMecanico2.BackColor = Color.Transparent;
            datosMecanico2.Font = new Font("HomepageBaukasten Bold", 11.9999981F);
            datosMecanico2.ForeColor = Color.FromArgb(51, 51, 51);
            datosMecanico2.Location = new Point(809, 55);
            datosMecanico2.Name = "datosMecanico2";
            datosMecanico2.Size = new Size(92, 18);
            datosMecanico2.TabIndex = 136;
            datosMecanico2.Text = "Direccion:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(673, 22);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 135;
            pictureBox2.TabStop = false;
            // 
            // lblLinea
            // 
            lblLinea.BackColor = Color.Silver;
            lblLinea.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinea.Location = new Point(17, 132);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(1050, 1);
            lblLinea.TabIndex = 141;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Transparent;
            panelContenedor.Controls.Add(panelRegistros);
            panelContenedor.Controls.Add(lblLinea);
            panelContenedor.Controls.Add(lblVehiculoCliente);
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Controls.Add(datosMecanico2);
            panelContenedor.Controls.Add(nombreMecanico);
            panelContenedor.Controls.Add(datosMecanico3);
            panelContenedor.Controls.Add(datosMecanico);
            panelContenedor.Controls.Add(direccionMecanico);
            panelContenedor.Controls.Add(TelefonoMecanico);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1084, 661);
            panelContenedor.TabIndex = 142;
            // 
            // DetalleRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.bg1;
            ClientSize = new Size(1084, 661);
            Controls.Add(btnGenerarPDF);
            Controls.Add(btnVolverDetalle);
            Controls.Add(panelContenedor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "DetalleRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ocaranza Mecanica Software";
            Load += DetalleRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
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
        private Panel panelContenedor;
    }
}