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
            btnVolverPresupuesto = new Button();
            btnGuardar = new Button();
            txtTitular = new TextBox();
            lblPatente = new Label();
            lblTitular = new Label();
            lblMarca = new Label();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            lblModelo = new Label();
            lblAño = new Label();
            txtModelo = new TextBox();
            txtAño = new TextBox();
            lblCantidadHoras = new Label();
            lblPrecioHora = new Label();
            txtCantidadHoras = new TextBox();
            txtPrecioHora = new TextBox();
            dataGridView1 = new DataGridView();
            NombreRespuesto = new DataGridViewTextBoxColumn();
            CantidadRepuesto = new DataGridViewTextBoxColumn();
            PrecioRepuesto = new DataGridViewTextBoxColumn();
            lblNombreRepo = new Label();
            txtNombreRepo = new TextBox();
            nupCantidad = new NumericUpDown();
            lblCantidad = new Label();
            txtPrecioUni = new TextBox();
            lblPrecioUni = new Label();
            btnAgregarPresu = new Button();
            btnEliminarPresu = new Button();
            groupBox1 = new GroupBox();
            txtKm = new TextBox();
            lblKm = new Label();
            txtDomicilio = new TextBox();
            txtTelefono = new TextBox();
            lblDomicilio = new Label();
            lblTelefono = new Label();
            groupBox2 = new GroupBox();
            btnLimpiar = new Button();
            btnGenerar = new Button();
            labelDesc = new Label();
            textBoxDesc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolverPresupuesto
            // 
            btnVolverPresupuesto.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverPresupuesto.Location = new Point(1039, 793);
            btnVolverPresupuesto.Name = "btnVolverPresupuesto";
            btnVolverPresupuesto.Size = new Size(133, 51);
            btnVolverPresupuesto.TabIndex = 2;
            btnVolverPresupuesto.Text = "Volver";
            btnVolverPresupuesto.UseVisualStyleBackColor = true;
            btnVolverPresupuesto.Click += btnVolverPresupuesto_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1039, 41);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(133, 67);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar En Registros";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(177, 39);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(174, 29);
            txtTitular.TabIndex = 4;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPatente.Location = new Point(399, 80);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(80, 25);
            lblPatente.TabIndex = 5;
            lblPatente.Text = "Patente:";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTitular.Location = new Point(94, 40);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(71, 25);
            lblTitular.TabIndex = 7;
            lblTitular.Text = "Titular:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblMarca.Location = new Point(411, 36);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(66, 25);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca:";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(483, 79);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(174, 29);
            txtPatente.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(483, 35);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(174, 29);
            txtMarca.TabIndex = 11;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblModelo.Location = new Point(18, 179);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(158, 25);
            lblModelo.TabIndex = 12;
            lblModelo.Text = "Modelo del Auto:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblAño.Location = new Point(429, 176);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(50, 25);
            lblAño.TabIndex = 13;
            lblAño.Text = "Año:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(176, 178);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(174, 29);
            txtModelo.TabIndex = 14;
            txtModelo.KeyPress += txtModelo_KeyPress;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(483, 175);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(174, 29);
            txtAño.TabIndex = 15;
            txtAño.KeyPress += txtAño_KeyPress;
            // 
            // lblCantidadHoras
            // 
            lblCantidadHoras.AutoSize = true;
            lblCantidadHoras.BackColor = Color.Transparent;
            lblCantidadHoras.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblCantidadHoras.ForeColor = SystemColors.ButtonHighlight;
            lblCantidadHoras.Location = new Point(119, 667);
            lblCantidadHoras.Name = "lblCantidadHoras";
            lblCantidadHoras.Size = new Size(256, 25);
            lblCantidadHoras.TabIndex = 18;
            lblCantidadHoras.Text = "Cantidad de Horas Estimadas:";
            // 
            // lblPrecioHora
            // 
            lblPrecioHora.AutoSize = true;
            lblPrecioHora.BackColor = Color.Transparent;
            lblPrecioHora.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPrecioHora.ForeColor = SystemColors.ButtonHighlight;
            lblPrecioHora.Location = new Point(501, 667);
            lblPrecioHora.Name = "lblPrecioHora";
            lblPrecioHora.Size = new Size(146, 25);
            lblPrecioHora.TabIndex = 19;
            lblPrecioHora.Text = "Precio Por Hora:";
            // 
            // txtCantidadHoras
            // 
            txtCantidadHoras.Location = new Point(381, 668);
            txtCantidadHoras.Name = "txtCantidadHoras";
            txtCantidadHoras.Size = new Size(73, 27);
            txtCantidadHoras.TabIndex = 20;
            txtCantidadHoras.KeyPress += txtCantidadHoras_KeyPress;
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.Location = new Point(653, 667);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.Size = new Size(78, 27);
            txtPrecioHora.TabIndex = 21;
            txtPrecioHora.KeyPress += txtPrecioHora_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreRespuesto, CantidadRepuesto, PrecioRepuesto });
            dataGridView1.Location = new Point(119, 456);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(757, 185);
            dataGridView1.TabIndex = 26;
            // 
            // NombreRespuesto
            // 
            NombreRespuesto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NombreRespuesto.HeaderText = "Nombre Repuesto";
            NombreRespuesto.MinimumWidth = 6;
            NombreRespuesto.Name = "NombreRespuesto";
            NombreRespuesto.ReadOnly = true;
            NombreRespuesto.Width = 350;
            // 
            // CantidadRepuesto
            // 
            CantidadRepuesto.HeaderText = "Cantidad";
            CantidadRepuesto.MinimumWidth = 6;
            CantidadRepuesto.Name = "CantidadRepuesto";
            CantidadRepuesto.ReadOnly = true;
            // 
            // PrecioRepuesto
            // 
            PrecioRepuesto.HeaderText = "Precio";
            PrecioRepuesto.MinimumWidth = 6;
            PrecioRepuesto.Name = "PrecioRepuesto";
            PrecioRepuesto.ReadOnly = true;
            // 
            // lblNombreRepo
            // 
            lblNombreRepo.AutoSize = true;
            lblNombreRepo.BackColor = Color.Transparent;
            lblNombreRepo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblNombreRepo.Location = new Point(9, 32);
            lblNombreRepo.Name = "lblNombreRepo";
            lblNombreRepo.Size = new Size(196, 25);
            lblNombreRepo.TabIndex = 27;
            lblNombreRepo.Text = "Nombre del Repuesto";
            // 
            // txtNombreRepo
            // 
            txtNombreRepo.Location = new Point(9, 72);
            txtNombreRepo.Name = "txtNombreRepo";
            txtNombreRepo.Size = new Size(174, 32);
            txtNombreRepo.TabIndex = 28;
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(231, 72);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(86, 32);
            nupCantidad.TabIndex = 29;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblCantidad.Location = new Point(231, 32);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(86, 25);
            lblCantidad.TabIndex = 30;
            lblCantidad.Text = "Cantidad";
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.Location = new Point(362, 76);
            txtPrecioUni.Multiline = true;
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.Size = new Size(76, 31);
            txtPrecioUni.TabIndex = 31;
            txtPrecioUni.KeyPress += txtPrecioUni_KeyPress;
            // 
            // lblPrecioUni
            // 
            lblPrecioUni.AutoSize = true;
            lblPrecioUni.BackColor = Color.Transparent;
            lblPrecioUni.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPrecioUni.Location = new Point(362, 32);
            lblPrecioUni.Name = "lblPrecioUni";
            lblPrecioUni.Size = new Size(64, 25);
            lblPrecioUni.TabIndex = 32;
            lblPrecioUni.Text = "Precio";
            // 
            // btnAgregarPresu
            // 
            btnAgregarPresu.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregarPresu.FlatStyle = FlatStyle.Popup;
            btnAgregarPresu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPresu.Location = new Point(472, 67);
            btnAgregarPresu.Name = "btnAgregarPresu";
            btnAgregarPresu.Size = new Size(90, 41);
            btnAgregarPresu.TabIndex = 33;
            btnAgregarPresu.Text = "Agregar";
            btnAgregarPresu.UseVisualStyleBackColor = false;
            btnAgregarPresu.Click += btnAgregarPresu_Click;
            // 
            // btnEliminarPresu
            // 
            btnEliminarPresu.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarPresu.FlatStyle = FlatStyle.Popup;
            btnEliminarPresu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPresu.Location = new Point(599, 67);
            btnEliminarPresu.Name = "btnEliminarPresu";
            btnEliminarPresu.Size = new Size(90, 41);
            btnEliminarPresu.TabIndex = 34;
            btnEliminarPresu.Text = "Eliminar";
            btnEliminarPresu.UseVisualStyleBackColor = false;
            btnEliminarPresu.Click += btnEliminarPresu_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 192, 192);
            groupBox1.Controls.Add(txtKm);
            groupBox1.Controls.Add(lblKm);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(lblDomicilio);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(lblTitular);
            groupBox1.Controls.Add(txtTitular);
            groupBox1.Controls.Add(lblPatente);
            groupBox1.Controls.Add(lblMarca);
            groupBox1.Controls.Add(txtPatente);
            groupBox1.Controls.Add(txtAño);
            groupBox1.Controls.Add(lblAño);
            groupBox1.Controls.Add(lblModelo);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(119, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 237);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Registro";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(483, 130);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(174, 29);
            txtKm.TabIndex = 21;
            // 
            // lblKm
            // 
            lblKm.AutoSize = true;
            lblKm.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblKm.Location = new Point(372, 127);
            lblKm.Name = "lblKm";
            lblKm.Size = new Size(107, 25);
            lblKm.TabIndex = 20;
            lblKm.Text = "Kilometros:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(176, 127);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(174, 29);
            txtDomicilio.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(177, 83);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(174, 29);
            txtTelefono.TabIndex = 18;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblDomicilio.Location = new Point(75, 128);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(95, 25);
            lblDomicilio.TabIndex = 17;
            lblDomicilio.Text = "Domicilio:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTelefono.Location = new Point(78, 84);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(88, 25);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(lblNombreRepo);
            groupBox2.Controls.Add(btnEliminarPresu);
            groupBox2.Controls.Add(lblCantidad);
            groupBox2.Controls.Add(nupCantidad);
            groupBox2.Controls.Add(btnAgregarPresu);
            groupBox2.Controls.Add(txtPrecioUni);
            groupBox2.Controls.Add(txtNombreRepo);
            groupBox2.Controls.Add(lblPrecioUni);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(119, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(757, 120);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Repuestos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(1039, 705);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(133, 67);
            btnLimpiar.TabIndex = 38;
            btnLimpiar.Text = "Limpiar Presupuesto";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = SystemColors.MenuHighlight;
            btnGenerar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(1039, 116);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(133, 67);
            btnGenerar.TabIndex = 39;
            btnGenerar.Text = "Generar Presupuesto";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.BackColor = Color.Transparent;
            labelDesc.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelDesc.ForeColor = SystemColors.ButtonHighlight;
            labelDesc.Location = new Point(119, 725);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(210, 25);
            labelDesc.TabIndex = 40;
            labelDesc.Text = "Descripcion del Trabajo:";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(347, 727);
            textBoxDesc.Margin = new Padding(3, 4, 3, 4);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(422, 117);
            textBoxDesc.TabIndex = 41;
            // 
            // Presupuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1239, 881);
            Controls.Add(textBoxDesc);
            Controls.Add(labelDesc);
            Controls.Add(btnGenerar);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox2);
            Controls.Add(lblCantidadHoras);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lblPrecioHora);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolverPresupuesto);
            Controls.Add(txtPrecioHora);
            Controls.Add(txtCantidadHoras);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(912, 784);
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
        private Button btnVolverPresupuesto;
        private Button btnGuardar;
        private TextBox txtTitular;
        private Label lblPatente;
        private Label lblTitular;
        private Label lblMarca;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private Label lblModelo;
        private Label lblAño;
        private TextBox txtModelo;
        private TextBox txtAño;
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
        private TextBox txtDomicilio;
        private TextBox txtTelefono;
        private Label lblDomicilio;
        private Label lblTelefono;
        private GroupBox groupBox2;
        private Button btnLimpiar;
        private Button btnGenerar;
        private DataGridViewTextBoxColumn NombreRespuesto;
        private DataGridViewTextBoxColumn CantidadRepuesto;
        private DataGridViewTextBoxColumn PrecioRepuesto;
        private Label labelDesc;
        private TextBox textBoxDesc;
        private TextBox txtKm;
        private Label lblKm;
    }
}