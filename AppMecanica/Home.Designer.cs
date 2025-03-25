namespace AppMecanica
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panelPresupuesto = new Panel();
            dataGridView1 = new DataGridView();
            btnHistorial = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnImprimir = new Button();
            txtTotal = new TextBox();
            txtSubtotal = new TextBox();
            txtMano = new TextBox();
            lblTotal = new Label();
            lblSubtotal = new Label();
            lblMano = new Label();
            lblCombustible = new Label();
            txtCombustible = new TextBox();
            rtDescripcion = new RichTextBox();
            lblDescripcion = new Label();
            txtPatente = new TextBox();
            txtAceite = new TextBox();
            lblPatente = new Label();
            lblAceite = new Label();
            txtKm = new TextBox();
            txtAño = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtVahiculo = new TextBox();
            txtTitular = new TextBox();
            lblAño = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            label5 = new Label();
            lblKm = new Label();
            lblVehiculo = new Label();
            lblTitular = new Label();
            lblDatos = new Label();
            btnVolverPresupuesto = new Button();
            label1 = new Label();
            panelRegistro = new Panel();
            btnVolverRegistro = new Button();
            label2 = new Label();
            btnRegistro = new Button();
            btnPresupuesto = new Button();
            pictureBox1 = new PictureBox();
            panelPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPresupuesto
            // 
            panelPresupuesto.Controls.Add(dataGridView1);
            panelPresupuesto.Controls.Add(btnHistorial);
            panelPresupuesto.Controls.Add(btnNuevo);
            panelPresupuesto.Controls.Add(btnGuardar);
            panelPresupuesto.Controls.Add(btnImprimir);
            panelPresupuesto.Controls.Add(txtTotal);
            panelPresupuesto.Controls.Add(txtSubtotal);
            panelPresupuesto.Controls.Add(txtMano);
            panelPresupuesto.Controls.Add(lblTotal);
            panelPresupuesto.Controls.Add(lblSubtotal);
            panelPresupuesto.Controls.Add(lblMano);
            panelPresupuesto.Controls.Add(lblCombustible);
            panelPresupuesto.Controls.Add(txtCombustible);
            panelPresupuesto.Controls.Add(rtDescripcion);
            panelPresupuesto.Controls.Add(lblDescripcion);
            panelPresupuesto.Controls.Add(txtPatente);
            panelPresupuesto.Controls.Add(txtAceite);
            panelPresupuesto.Controls.Add(lblPatente);
            panelPresupuesto.Controls.Add(lblAceite);
            panelPresupuesto.Controls.Add(txtKm);
            panelPresupuesto.Controls.Add(txtAño);
            panelPresupuesto.Controls.Add(txtModelo);
            panelPresupuesto.Controls.Add(txtMarca);
            panelPresupuesto.Controls.Add(txtVahiculo);
            panelPresupuesto.Controls.Add(txtTitular);
            panelPresupuesto.Controls.Add(lblAño);
            panelPresupuesto.Controls.Add(lblModelo);
            panelPresupuesto.Controls.Add(lblMarca);
            panelPresupuesto.Controls.Add(label5);
            panelPresupuesto.Controls.Add(lblKm);
            panelPresupuesto.Controls.Add(lblVehiculo);
            panelPresupuesto.Controls.Add(lblTitular);
            panelPresupuesto.Controls.Add(lblDatos);
            panelPresupuesto.Controls.Add(btnVolverPresupuesto);
            panelPresupuesto.Controls.Add(label1);
            panelPresupuesto.Location = new Point(1, 3);
            panelPresupuesto.Margin = new Padding(4);
            panelPresupuesto.Name = "panelPresupuesto";
            panelPresupuesto.Size = new Size(1089, 647);
            panelPresupuesto.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(840, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 240);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnHistorial
            // 
            btnHistorial.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorial.Location = new Point(920, 472);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(108, 43);
            btnHistorial.TabIndex = 34;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(920, 83);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 59);
            btnNuevo.TabIndex = 33;
            btnNuevo.Text = "Nuevo Presupuesto";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(658, 546);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 43);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImprimir.Location = new Point(523, 546);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(108, 43);
            btnImprimir.TabIndex = 31;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(658, 497);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(126, 23);
            txtTotal.TabIndex = 30;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubtotal.Location = new Point(658, 455);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(126, 23);
            txtSubtotal.TabIndex = 29;
            // 
            // txtMano
            // 
            txtMano.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMano.Location = new Point(658, 412);
            txtMano.Name = "txtMano";
            txtMano.Size = new Size(126, 23);
            txtMano.TabIndex = 28;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(519, 492);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 20);
            lblTotal.TabIndex = 27;
            lblTotal.Text = "Total";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(519, 454);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(69, 20);
            lblSubtotal.TabIndex = 26;
            lblSubtotal.Text = "Subtotal";
            // 
            // lblMano
            // 
            lblMano.AutoSize = true;
            lblMano.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMano.Location = new Point(519, 414);
            lblMano.Name = "lblMano";
            lblMano.Size = new Size(107, 20);
            lblMano.TabIndex = 25;
            lblMano.Text = "Mano de obra";
            // 
            // lblCombustible
            // 
            lblCombustible.AutoSize = true;
            lblCombustible.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCombustible.Location = new Point(29, 264);
            lblCombustible.Name = "lblCombustible";
            lblCombustible.Size = new Size(97, 20);
            lblCombustible.TabIndex = 24;
            lblCombustible.Text = "Combustible";
            // 
            // txtCombustible
            // 
            txtCombustible.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCombustible.Location = new Point(200, 265);
            txtCombustible.Name = "txtCombustible";
            txtCombustible.Size = new Size(126, 23);
            txtCombustible.TabIndex = 23;
            // 
            // rtDescripcion
            // 
            rtDescripcion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtDescripcion.Location = new Point(32, 415);
            rtDescripcion.Name = "rtDescripcion";
            rtDescripcion.Size = new Size(443, 163);
            rtDescripcion.TabIndex = 22;
            rtDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(29, 378);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(92, 20);
            lblDescripcion.TabIndex = 21;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtPatente
            // 
            txtPatente.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatente.Location = new Point(200, 220);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(126, 23);
            txtPatente.TabIndex = 20;
            // 
            // txtAceite
            // 
            txtAceite.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAceite.Location = new Point(200, 308);
            txtAceite.Name = "txtAceite";
            txtAceite.Size = new Size(126, 23);
            txtAceite.TabIndex = 19;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatente.Location = new Point(29, 222);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(65, 20);
            lblPatente.TabIndex = 18;
            lblPatente.Text = "Patente";
            // 
            // lblAceite
            // 
            lblAceite.AutoSize = true;
            lblAceite.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAceite.Location = new Point(29, 308);
            lblAceite.Name = "lblAceite";
            lblAceite.Size = new Size(54, 20);
            lblAceite.TabIndex = 17;
            lblAceite.Text = "Aceite";
            // 
            // txtKm
            // 
            txtKm.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKm.Location = new Point(496, 130);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(126, 23);
            txtKm.TabIndex = 16;
            // 
            // txtAño
            // 
            txtAño.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAño.Location = new Point(496, 175);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(126, 23);
            txtAño.TabIndex = 15;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModelo.Location = new Point(496, 258);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(126, 23);
            txtModelo.TabIndex = 14;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarca.Location = new Point(496, 215);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(126, 23);
            txtMarca.TabIndex = 13;
            // 
            // txtVahiculo
            // 
            txtVahiculo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVahiculo.Location = new Point(200, 175);
            txtVahiculo.Name = "txtVahiculo";
            txtVahiculo.Size = new Size(126, 23);
            txtVahiculo.TabIndex = 12;
            // 
            // txtTitular
            // 
            txtTitular.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitular.Location = new Point(200, 128);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(165, 23);
            txtTitular.TabIndex = 11;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(403, 174);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(38, 20);
            lblAño.TabIndex = 10;
            lblAño.Text = "Año";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(403, 257);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 20);
            lblModelo.TabIndex = 9;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(403, 215);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 20);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(569, 92);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 7;
            // 
            // lblKm
            // 
            lblKm.AutoSize = true;
            lblKm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKm.Location = new Point(400, 129);
            lblKm.Name = "lblKm";
            lblKm.Size = new Size(83, 20);
            lblKm.TabIndex = 6;
            lblKm.Text = "Kilometros";
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehiculo.Location = new Point(29, 174);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(100, 20);
            lblVehiculo.TabIndex = 5;
            lblVehiculo.Text = "Tipo vehiculo";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitular.Location = new Point(29, 128);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(138, 20);
            lblTitular.TabIndex = 4;
            lblTitular.Text = "Titular del vehiculo";
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatos.Location = new Point(29, 83);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(127, 20);
            lblDatos.TabIndex = 3;
            lblDatos.Text = "Datos del cliente";
            // 
            // btnVolverPresupuesto
            // 
            btnVolverPresupuesto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolverPresupuesto.Location = new Point(920, 546);
            btnVolverPresupuesto.Margin = new Padding(4);
            btnVolverPresupuesto.Name = "btnVolverPresupuesto";
            btnVolverPresupuesto.Size = new Size(108, 43);
            btnVolverPresupuesto.TabIndex = 2;
            btnVolverPresupuesto.Text = "Volver";
            btnVolverPresupuesto.UseVisualStyleBackColor = true;
            btnVolverPresupuesto.Click += btnVolverPresupuesto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(419, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 24);
            label1.TabIndex = 0;
            label1.Text = "PANEL PRESUPUESTO";
            // 
            // panelRegistro
            // 
            panelRegistro.BackColor = SystemColors.Control;
            panelRegistro.Controls.Add(btnVolverRegistro);
            panelRegistro.Controls.Add(label2);
            panelRegistro.Location = new Point(1, 3);
            panelRegistro.Margin = new Padding(4);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(1210, 666);
            panelRegistro.TabIndex = 5;
            // 
            // btnVolverRegistro
            // 
            btnVolverRegistro.Location = new Point(854, 545);
            btnVolverRegistro.Margin = new Padding(4);
            btnVolverRegistro.Name = "btnVolverRegistro";
            btnVolverRegistro.Size = new Size(88, 26);
            btnVolverRegistro.TabIndex = 1;
            btnVolverRegistro.Text = "Volver";
            btnVolverRegistro.UseVisualStyleBackColor = true;
            btnVolverRegistro.Click += btnVolverRegistro_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 546);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "Panel REGISTRO";
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(778, 497);
            btnRegistro.Margin = new Padding(4);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(130, 50);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "Regitro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click_1;
            // 
            // btnPresupuesto
            // 
            btnPresupuesto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPresupuesto.Location = new Point(339, 497);
            btnPresupuesto.Margin = new Padding(4);
            btnPresupuesto.Name = "btnPresupuesto";
            btnPresupuesto.Size = new Size(130, 50);
            btnPresupuesto.TabIndex = 7;
            btnPresupuesto.Text = "Crear Un Presupuesto";
            btnPresupuesto.UseVisualStyleBackColor = true;
            btnPresupuesto.Click += btnPresupuesto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(440, 52);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 666);
            Controls.Add(btnRegistro);
            Controls.Add(panelPresupuesto);
            Controls.Add(btnPresupuesto);
            Controls.Add(pictureBox1);
            Controls.Add(panelRegistro);
            Name = "Home";
            Text = "Ocaranza Mecanica";
            Load += Home_Load;
            panelPresupuesto.ResumeLayout(false);
            panelPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPresupuesto;
        private Button btnHistorial;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnImprimir;
        private TextBox txtTotal;
        private TextBox txtSubtotal;
        private TextBox txtMano;
        private Label lblTotal;
        private Label lblSubtotal;
        private Label lblMano;
        private Label lblCombustible;
        private TextBox txtCombustible;
        private RichTextBox rtDescripcion;
        private Label lblDescripcion;
        private TextBox txtPatente;
        private TextBox txtAceite;
        private Label lblPatente;
        private Label lblAceite;
        private TextBox txtKm;
        private TextBox txtAño;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtVahiculo;
        private TextBox txtTitular;
        private Label lblAño;
        private Label lblModelo;
        private Label lblMarca;
        private Label label5;
        private Label lblKm;
        private Label lblVehiculo;
        private Label lblTitular;
        private Label lblDatos;
        private Button btnVolverPresupuesto;
        private Label label1;
        private Panel panelRegistro;
        private Button btnVolverRegistro;
        private Label label2;
        private Button btnRegistro;
        private Button btnPresupuesto;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
    }
}
