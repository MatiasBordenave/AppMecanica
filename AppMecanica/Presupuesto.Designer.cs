namespace AppMecanica
{
    partial class Presupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presupuesto));
            btnImprimir = new Button();
            btnLimpiar = new Button();
            btnVolverPresu = new Button();
            btnGuardar = new Button();
            txtTitular = new TextBox();
            lblPatente = new Label();
            lblVehiculo = new Label();
            lblTitular = new Label();
            lblMarca = new Label();
            txtVehiculo = new TextBox();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            lblModelo = new Label();
            lblAño = new Label();
            txtModelo = new TextBox();
            txtAño = new TextBox();
            label7 = new Label();
            lblCantidadHoras = new Label();
            lblPrecioHora = new Label();
            txtCantidadHoras = new TextBox();
            txtPrecioHora = new TextBox();
            dataGridView1 = new DataGridView();
            NombreRespuesto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Horas = new DataGridViewTextBoxColumn();
            PrecioxHora = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lblNombreRepo = new Label();
            txtNombreRepo = new TextBox();
            nupCantidad = new NumericUpDown();
            lblCantidad = new Label();
            txtPrecioUni = new TextBox();
            lblPrecioUni = new Label();
            btnAgregarPresu = new Button();
            btnEliminarPresu = new Button();
            groupBox1 = new GroupBox();
            txtDomicilio = new TextBox();
            txtTelefono = new TextBox();
            lblDomicilio = new Label();
            lblTelefono = new Label();
            btnNuevoPresupuesto = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.Location = new Point(930, 116);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(104, 38);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(930, 236);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(104, 38);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolverPresu
            // 
            btnVolverPresu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverPresu.Location = new Point(930, 507);
            btnVolverPresu.Margin = new Padding(3, 2, 3, 2);
            btnVolverPresu.Name = "btnVolverPresu";
            btnVolverPresu.Size = new Size(104, 38);
            btnVolverPresu.TabIndex = 2;
            btnVolverPresu.Text = "Volver";
            btnVolverPresu.UseVisualStyleBackColor = true;
            btnVolverPresu.Click += button3_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(930, 173);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 38);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(87, 32);
            txtTitular.Margin = new Padding(3, 2, 3, 2);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(153, 27);
            txtTitular.TabIndex = 4;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPatente.Location = new Point(8, 100);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(61, 20);
            lblPatente.TabIndex = 5;
            lblPatente.Text = "Patente";
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblVehiculo.Location = new Point(8, 65);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(68, 20);
            lblVehiculo.TabIndex = 6;
            lblVehiculo.Text = "Vehiculo";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTitular.Location = new Point(8, 32);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(53, 20);
            lblTitular.TabIndex = 7;
            lblTitular.Text = "Titular";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblMarca.Location = new Point(8, 135);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(52, 20);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca";
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(87, 65);
            txtVehiculo.Margin = new Padding(3, 2, 3, 2);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(153, 27);
            txtVehiculo.TabIndex = 9;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(87, 100);
            txtPatente.Margin = new Padding(3, 2, 3, 2);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(153, 27);
            txtPatente.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(87, 135);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(153, 27);
            txtMarca.TabIndex = 11;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblModelo.Location = new Point(299, 33);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(66, 20);
            lblModelo.TabIndex = 12;
            lblModelo.Text = "Modelo ";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblAño.Location = new Point(299, 71);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(37, 20);
            lblAño.TabIndex = 13;
            lblAño.Text = "Año";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(383, 33);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(153, 27);
            txtModelo.TabIndex = 14;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(383, 69);
            txtAño.Margin = new Padding(3, 2, 3, 2);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(153, 27);
            txtAño.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSkyBlue;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 373);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 17;
            label7.Text = "Detalles";
            // 
            // lblCantidadHoras
            // 
            lblCantidadHoras.AutoSize = true;
            lblCantidadHoras.BackColor = Color.LightSkyBlue;
            lblCantidadHoras.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblCantidadHoras.Location = new Point(8, 92);
            lblCantidadHoras.Name = "lblCantidadHoras";
            lblCantidadHoras.Size = new Size(114, 20);
            lblCantidadHoras.TabIndex = 18;
            lblCantidadHoras.Text = "Cantidad Horas";
            // 
            // lblPrecioHora
            // 
            lblPrecioHora.AutoSize = true;
            lblPrecioHora.BackColor = Color.LightSkyBlue;
            lblPrecioHora.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPrecioHora.Location = new Point(202, 92);
            lblPrecioHora.Name = "lblPrecioHora";
            lblPrecioHora.Size = new Size(90, 20);
            lblPrecioHora.TabIndex = 19;
            lblPrecioHora.Text = "Precio Hora";
            // 
            // txtCantidadHoras
            // 
            txtCantidadHoras.Location = new Point(8, 122);
            txtCantidadHoras.Margin = new Padding(3, 2, 3, 2);
            txtCantidadHoras.Name = "txtCantidadHoras";
            txtCantidadHoras.Size = new Size(69, 23);
            txtCantidadHoras.TabIndex = 20;
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.Location = new Point(202, 122);
            txtPrecioHora.Margin = new Padding(3, 2, 3, 2);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.Size = new Size(69, 23);
            txtPrecioHora.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreRespuesto, Cantidad, Precio, Horas, PrecioxHora, Total });
            dataGridView1.Location = new Point(28, 394);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(662, 158);
            dataGridView1.TabIndex = 26;
            // 
            // NombreRespuesto
            // 
            NombreRespuesto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NombreRespuesto.HeaderText = "Nombre";
            NombreRespuesto.MinimumWidth = 6;
            NombreRespuesto.Name = "NombreRespuesto";
            NombreRespuesto.Width = 93;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Horas
            // 
            Horas.HeaderText = "Horas";
            Horas.MinimumWidth = 6;
            Horas.Name = "Horas";
            Horas.Width = 125;
            // 
            // PrecioxHora
            // 
            PrecioxHora.HeaderText = "PrecioxHora";
            PrecioxHora.MinimumWidth = 6;
            PrecioxHora.Name = "PrecioxHora";
            PrecioxHora.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // lblNombreRepo
            // 
            lblNombreRepo.AutoSize = true;
            lblNombreRepo.BackColor = Color.LightSkyBlue;
            lblNombreRepo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblNombreRepo.Location = new Point(8, 24);
            lblNombreRepo.Name = "lblNombreRepo";
            lblNombreRepo.Size = new Size(158, 20);
            lblNombreRepo.TabIndex = 27;
            lblNombreRepo.Text = "Nombre del Repuesto";
            // 
            // txtNombreRepo
            // 
            txtNombreRepo.Location = new Point(8, 54);
            txtNombreRepo.Margin = new Padding(3, 2, 3, 2);
            txtNombreRepo.Name = "txtNombreRepo";
            txtNombreRepo.Size = new Size(153, 23);
            txtNombreRepo.TabIndex = 28;
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(202, 54);
            nupCantidad.Margin = new Padding(3, 2, 3, 2);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(75, 23);
            nupCantidad.TabIndex = 29;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.LightSkyBlue;
            lblCantidad.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblCantidad.Location = new Point(202, 24);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(70, 20);
            lblCantidad.TabIndex = 30;
            lblCantidad.Text = "Cantidad";
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.Location = new Point(334, 54);
            txtPrecioUni.Margin = new Padding(3, 2, 3, 2);
            txtPrecioUni.Multiline = true;
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.Size = new Size(67, 24);
            txtPrecioUni.TabIndex = 31;
            // 
            // lblPrecioUni
            // 
            lblPrecioUni.AutoSize = true;
            lblPrecioUni.BackColor = Color.LightSkyBlue;
            lblPrecioUni.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPrecioUni.Location = new Point(334, 24);
            lblPrecioUni.Name = "lblPrecioUni";
            lblPrecioUni.Size = new Size(112, 20);
            lblPrecioUni.TabIndex = 32;
            lblPrecioUni.Text = "Precio Unitario";
            // 
            // btnAgregarPresu
            // 
            btnAgregarPresu.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregarPresu.FlatStyle = FlatStyle.Popup;
            btnAgregarPresu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPresu.Location = new Point(402, 106);
            btnAgregarPresu.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPresu.Name = "btnAgregarPresu";
            btnAgregarPresu.Size = new Size(79, 31);
            btnAgregarPresu.TabIndex = 33;
            btnAgregarPresu.Text = "Agregar";
            btnAgregarPresu.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPresu
            // 
            btnEliminarPresu.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarPresu.FlatStyle = FlatStyle.Popup;
            btnEliminarPresu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPresu.Location = new Point(516, 106);
            btnEliminarPresu.Margin = new Padding(3, 2, 3, 2);
            btnEliminarPresu.Name = "btnEliminarPresu";
            btnEliminarPresu.Size = new Size(79, 31);
            btnEliminarPresu.TabIndex = 34;
            btnEliminarPresu.Text = "Eliminar";
            btnEliminarPresu.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(lblDomicilio);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(lblTitular);
            groupBox1.Controls.Add(txtTitular);
            groupBox1.Controls.Add(lblPatente);
            groupBox1.Controls.Add(lblVehiculo);
            groupBox1.Controls.Add(lblMarca);
            groupBox1.Controls.Add(txtVehiculo);
            groupBox1.Controls.Add(txtPatente);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(lblModelo);
            groupBox1.Controls.Add(lblAño);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtAño);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 25);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(662, 178);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Titular";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(383, 142);
            txtDomicilio.Margin = new Padding(3, 2, 3, 2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(153, 27);
            txtDomicilio.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(383, 107);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(153, 27);
            txtTelefono.TabIndex = 18;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblDomicilio.Location = new Point(299, 142);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(74, 20);
            lblDomicilio.TabIndex = 17;
            lblDomicilio.Text = "Domicilio";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTelefono.Location = new Point(299, 110);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 20);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono";
            // 
            // btnNuevoPresupuesto
            // 
            btnNuevoPresupuesto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoPresupuesto.Location = new Point(930, 25);
            btnNuevoPresupuesto.Margin = new Padding(3, 2, 3, 2);
            btnNuevoPresupuesto.Name = "btnNuevoPresupuesto";
            btnNuevoPresupuesto.Size = new Size(104, 66);
            btnNuevoPresupuesto.TabIndex = 36;
            btnNuevoPresupuesto.Text = "Nuevo Presupuesto";
            btnNuevoPresupuesto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(lblNombreRepo);
            groupBox2.Controls.Add(lblCantidadHoras);
            groupBox2.Controls.Add(btnEliminarPresu);
            groupBox2.Controls.Add(lblCantidad);
            groupBox2.Controls.Add(nupCantidad);
            groupBox2.Controls.Add(lblPrecioHora);
            groupBox2.Controls.Add(btnAgregarPresu);
            groupBox2.Controls.Add(txtPrecioUni);
            groupBox2.Controls.Add(txtNombreRepo);
            groupBox2.Controls.Add(lblPrecioUni);
            groupBox2.Controls.Add(txtPrecioHora);
            groupBox2.Controls.Add(txtCantidadHoras);
            groupBox2.Location = new Point(28, 214);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(662, 149);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Repuestos";
            // 
            // Presupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 560);
            Controls.Add(groupBox2);
            Controls.Add(btnNuevoPresupuesto);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolverPresu);
            Controls.Add(btnLimpiar);
            Controls.Add(btnImprimir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Presupuesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Presupuesto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private Button btnLimpiar;
        private Button btnVolverPresu;
        private Button btnGuardar;
        private TextBox txtTitular;
        private Label lblPatente;
        private Label lblVehiculo;
        private Label lblTitular;
        private Label lblMarca;
        private TextBox txtVehiculo;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private Label lblModelo;
        private Label lblAño;
        private TextBox txtModelo;
        private TextBox txtAño;
        private Label label7;
        private Label lblCantidadHoras;
        private Label lblPrecioHora;
        private TextBox txtCantidadHoras;
        private TextBox txtPrecioHora;
        private DataGridView dataGridView1;
        private Label lblNombreRepo;
        private TextBox txtNombreRepo;
        private NumericUpDown nupCantidad;
        private Label lblCantidad;
        private TextBox txtPrecioUni;
        private Label lblPrecioUni;
        private Button btnAgregarPresu;
        private Button btnEliminarPresu;
        private GroupBox groupBox1;
        private Button btnNuevoPresupuesto;
        private TextBox txtDomicilio;
        private TextBox txtTelefono;
        private Label lblDomicilio;
        private Label lblTelefono;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn NombreRespuesto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Horas;
        private DataGridViewTextBoxColumn PrecioxHora;
        private DataGridViewTextBoxColumn Total;
    }
}