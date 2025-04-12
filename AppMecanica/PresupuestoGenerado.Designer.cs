namespace AppMecanica
{
    partial class PresupuestoGenerado
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresupuestoGenerado));
            btnImprimir = new Button();
            btnImg = new Button();
            btnVolverGenerado = new Button();
            lblTitulo = new Label();
            lblDatosCliente = new Label();
            pictureBox2 = new PictureBox();
            imageList1 = new ImageList(components);
            datosMecanico = new Label();
            datosMecanico2 = new Label();
            datosMecanico3 = new Label();
            nombreMecanico = new Label();
            direccionMecanico = new Label();
            TelefonoMecanico = new Label();
            lblFecha = new Label();
            lblLinea = new Label();
            lblLinea2 = new Label();
            lblDatosVehiculo = new Label();
            lblDatosTelefono = new Label();
            lblTituloDatos = new Label();
            lblDatosTrabajo = new Label();
            lblDatosRepuesto = new Label();
            lblTituloValor = new Label();
            lblLinea3 = new Label();
            lblTituloRepuesto = new Label();
            lblTituloMDO = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.MediumTurquoise;
            btnImprimir.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(677, 600);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(116, 50);
            btnImprimir.TabIndex = 39;
            btnImprimir.Text = "Imprimir Presupuesto";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnImg
            // 
            btnImg.BackColor = Color.LimeGreen;
            btnImg.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImg.ForeColor = Color.White;
            btnImg.Location = new Point(818, 600);
            btnImg.Margin = new Padding(3, 2, 3, 2);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(116, 50);
            btnImg.TabIndex = 40;
            btnImg.Text = "Guardar Imagen";
            btnImg.UseVisualStyleBackColor = false;
            btnImg.Click += btnImg_Click;
            // 
            // btnVolverGenerado
            // 
            btnVolverGenerado.BackColor = Color.Ivory;
            btnVolverGenerado.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverGenerado.ForeColor = Color.Black;
            btnVolverGenerado.Location = new Point(956, 600);
            btnVolverGenerado.Margin = new Padding(3, 2, 3, 2);
            btnVolverGenerado.Name = "btnVolverGenerado";
            btnVolverGenerado.Size = new Size(116, 50);
            btnVolverGenerado.TabIndex = 41;
            btnVolverGenerado.Text = "Volver";
            btnVolverGenerado.UseVisualStyleBackColor = false;
            btnVolverGenerado.Click += btnVolverGenerado_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(348, 45);
            lblTitulo.TabIndex = 42;
            lblTitulo.Text = "Presupuesto  - Nro 01";
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatosCliente.Location = new Point(17, 165);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(101, 17);
            lblDatosCliente.TabIndex = 43;
            lblDatosCliente.Text = "Datos Titular";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(705, 9);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // datosMecanico
            // 
            datosMecanico.AutoSize = true;
            datosMecanico.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datosMecanico.Location = new Point(846, 23);
            datosMecanico.Name = "datosMecanico";
            datosMecanico.Size = new Size(79, 20);
            datosMecanico.TabIndex = 45;
            datosMecanico.Text = "Mecanico:";
            // 
            // datosMecanico2
            // 
            datosMecanico2.AutoSize = true;
            datosMecanico2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datosMecanico2.Location = new Point(847, 58);
            datosMecanico2.Name = "datosMecanico2";
            datosMecanico2.Size = new Size(78, 20);
            datosMecanico2.TabIndex = 46;
            datosMecanico2.Text = "Direccion:";
            // 
            // datosMecanico3
            // 
            datosMecanico3.AutoSize = true;
            datosMecanico3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datosMecanico3.Location = new Point(851, 93);
            datosMecanico3.Name = "datosMecanico3";
            datosMecanico3.Size = new Size(74, 20);
            datosMecanico3.TabIndex = 47;
            datosMecanico3.Text = "Telefono:";
            // 
            // nombreMecanico
            // 
            nombreMecanico.AutoSize = true;
            nombreMecanico.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreMecanico.Location = new Point(931, 26);
            nombreMecanico.Name = "nombreMecanico";
            nombreMecanico.Size = new Size(140, 17);
            nombreMecanico.TabIndex = 48;
            nombreMecanico.Text = "Ocaranza Rodolfo";
            // 
            // direccionMecanico
            // 
            direccionMecanico.AutoSize = true;
            direccionMecanico.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionMecanico.Location = new Point(931, 61);
            direccionMecanico.Name = "direccionMecanico";
            direccionMecanico.Size = new Size(120, 17);
            direccionMecanico.TabIndex = 49;
            direccionMecanico.Text = "Avellaneda 118";
            // 
            // TelefonoMecanico
            // 
            TelefonoMecanico.AutoSize = true;
            TelefonoMecanico.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TelefonoMecanico.Location = new Point(931, 96);
            TelefonoMecanico.Name = "TelefonoMecanico";
            TelefonoMecanico.Size = new Size(129, 17);
            TelefonoMecanico.TabIndex = 50;
            TelefonoMecanico.Text = "+54 3816566750";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial Unicode MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(12, 61);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(125, 33);
            lblFecha.TabIndex = 51;
            lblFecha.Text = "Ver Fecha";
            // 
            // lblLinea
            // 
            lblLinea.BackColor = SystemColors.ControlDarkDark;
            lblLinea.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinea.Location = new Point(17, 148);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(1050, 1);
            lblLinea.TabIndex = 52;
            // 
            // lblLinea2
            // 
            lblLinea2.BackColor = SystemColors.ControlDarkDark;
            lblLinea2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinea2.Location = new Point(17, 311);
            lblLinea2.Name = "lblLinea2";
            lblLinea2.Size = new Size(1050, 1);
            lblLinea2.TabIndex = 53;
            // 
            // lblDatosVehiculo
            // 
            lblDatosVehiculo.AutoSize = true;
            lblDatosVehiculo.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatosVehiculo.Location = new Point(17, 237);
            lblDatosVehiculo.Name = "lblDatosVehiculo";
            lblDatosVehiculo.Size = new Size(117, 17);
            lblDatosVehiculo.TabIndex = 54;
            lblDatosVehiculo.Text = "Datos Vehiculo";
            // 
            // lblDatosTelefono
            // 
            lblDatosTelefono.AutoSize = true;
            lblDatosTelefono.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatosTelefono.Location = new Point(17, 199);
            lblDatosTelefono.Name = "lblDatosTelefono";
            lblDatosTelefono.Size = new Size(120, 17);
            lblDatosTelefono.TabIndex = 55;
            lblDatosTelefono.Text = "Datos Contacto";
            // 
            // lblTituloDatos
            // 
            lblTituloDatos.AutoSize = true;
            lblTituloDatos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloDatos.Location = new Point(17, 123);
            lblTituloDatos.Name = "lblTituloDatos";
            lblTituloDatos.Size = new Size(262, 25);
            lblTituloDatos.TabIndex = 56;
            lblTituloDatos.Text = "Datos del Cliente y Vehiculo:";
            // 
            // lblDatosTrabajo
            // 
            lblDatosTrabajo.AutoSize = true;
            lblDatosTrabajo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosTrabajo.Location = new Point(17, 286);
            lblDatosTrabajo.Name = "lblDatosTrabajo";
            lblDatosTrabajo.Size = new Size(185, 25);
            lblDatosTrabajo.TabIndex = 57;
            lblDatosTrabajo.Text = "Trabajos A Realizar:";
            // 
            // lblDatosRepuesto
            // 
            lblDatosRepuesto.AutoSize = true;
            lblDatosRepuesto.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatosRepuesto.Location = new Point(17, 340);
            lblDatosRepuesto.Name = "lblDatosRepuesto";
            lblDatosRepuesto.Size = new Size(115, 17);
            lblDatosRepuesto.TabIndex = 58;
            lblDatosRepuesto.Text = "Ver Repuestos";
            // 
            // lblTituloValor
            // 
            lblTituloValor.AutoSize = true;
            lblTituloValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloValor.Location = new Point(17, 534);
            lblTituloValor.Name = "lblTituloValor";
            lblTituloValor.Size = new Size(185, 25);
            lblTituloValor.TabIndex = 60;
            lblTituloValor.Text = "Trabajos A Realizar:";
            // 
            // lblLinea3
            // 
            lblLinea3.BackColor = SystemColors.ControlDarkDark;
            lblLinea3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinea3.Location = new Point(17, 559);
            lblLinea3.Name = "lblLinea3";
            lblLinea3.Size = new Size(1050, 1);
            lblLinea3.TabIndex = 59;
            // 
            // lblTituloRepuesto
            // 
            lblTituloRepuesto.AutoSize = true;
            lblTituloRepuesto.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRepuesto.Location = new Point(17, 573);
            lblTituloRepuesto.Name = "lblTituloRepuesto";
            lblTituloRepuesto.Size = new Size(118, 20);
            lblTituloRepuesto.TabIndex = 61;
            lblTituloRepuesto.Text = "Total Repuesto:";
            // 
            // lblTituloMDO
            // 
            lblTituloMDO.AutoSize = true;
            lblTituloMDO.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloMDO.Location = new Point(17, 603);
            lblTituloMDO.Name = "lblTituloMDO";
            lblTituloMDO.Size = new Size(112, 20);
            lblTituloMDO.TabIndex = 62;
            lblTituloMDO.Text = "Mano de Obra:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 632);
            label1.Name = "label1";
            label1.Size = new Size(243, 20);
            label1.TabIndex = 63;
            label1.Text = "Total Mano de Obra + Repuestos:";
            // 
            // PresupuestoGenerado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1084, 661);
            Controls.Add(label1);
            Controls.Add(lblTituloMDO);
            Controls.Add(lblTituloRepuesto);
            Controls.Add(lblTituloValor);
            Controls.Add(lblLinea3);
            Controls.Add(lblDatosRepuesto);
            Controls.Add(lblDatosTrabajo);
            Controls.Add(lblTituloDatos);
            Controls.Add(lblDatosTelefono);
            Controls.Add(lblDatosVehiculo);
            Controls.Add(lblLinea2);
            Controls.Add(lblLinea);
            Controls.Add(lblFecha);
            Controls.Add(TelefonoMecanico);
            Controls.Add(direccionMecanico);
            Controls.Add(nombreMecanico);
            Controls.Add(datosMecanico3);
            Controls.Add(datosMecanico2);
            Controls.Add(datosMecanico);
            Controls.Add(pictureBox2);
            Controls.Add(lblDatosCliente);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolverGenerado);
            Controls.Add(btnImg);
            Controls.Add(btnImprimir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PresupuestoGenerado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PresupuestoGenerado";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private Button btnImg;
        private Button btnVolverGenerado;
        private Label lblTitulo;
        private Label lblDatosCliente;
        private PictureBox pictureBox2;
        private ImageList imageList1;
        private Label datosMecanico;
        private Label datosMecanico2;
        private Label datosMecanico3;
        private Label nombreMecanico;
        private Label direccionMecanico;
        private Label TelefonoMecanico;
        private Label lblFecha;
        private Label lblLinea;
        private Label lblLinea2;
        private Label lblDatosVehiculo;
        private Label lblDatosTelefono;
        private Label lblTituloDatos;
        private Label lblDatosTrabajo;
        private Label lblDatosRepuesto;
        private Label lblTituloValor;
        private Label lblLinea3;
        private Label lblTituloRepuesto;
        private Label lblTituloMDO;
        private Label label1;
    }
}