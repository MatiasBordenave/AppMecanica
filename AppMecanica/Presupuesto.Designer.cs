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
            btnVolverPresupuesto.BackColor = Color.FromArgb(251, 176, 48);
            btnVolverPresupuesto.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnVolverPresupuesto.FlatStyle = FlatStyle.Flat;
            btnVolverPresupuesto.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnVolverPresupuesto.ForeColor = Color.FromArgb(51, 51, 51);
            btnVolverPresupuesto.Location = new Point(909, 595);
            btnVolverPresupuesto.Margin = new Padding(3, 2, 3, 2);
            btnVolverPresupuesto.Name = "btnVolverPresupuesto";
            btnVolverPresupuesto.Size = new Size(116, 38);
            btnVolverPresupuesto.TabIndex = 2;
            btnVolverPresupuesto.Text = "Volver";
            btnVolverPresupuesto.UseVisualStyleBackColor = false;
            btnVolverPresupuesto.Click += btnVolverPresupuesto_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(251, 176, 48);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("HomepageBaukasten Bold", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(51, 51, 51);
            btnGuardar.Location = new Point(909, 31);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 50);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar En Registros";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTitular
            // 
            txtTitular.BackColor = Color.FromArgb(224, 224, 224);
            txtTitular.BorderStyle = BorderStyle.FixedSingle;
            txtTitular.Location = new Point(217, 29);
            txtTitular.Margin = new Padding(3, 2, 3, 2);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(153, 24);
            txtTitular.TabIndex = 4;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblPatente.Location = new Point(411, 60);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(70, 17);
            lblPatente.TabIndex = 5;
            lblPatente.Text = "Patente:";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblTitular.Location = new Point(144, 30);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(62, 17);
            lblTitular.TabIndex = 7;
            lblTitular.Text = "Titular:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblMarca.Location = new Point(422, 27);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(58, 17);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca:";
            // 
            // txtPatente
            // 
            txtPatente.BackColor = Color.FromArgb(224, 224, 224);
            txtPatente.BorderStyle = BorderStyle.FixedSingle;
            txtPatente.Location = new Point(485, 60);
            txtPatente.Margin = new Padding(3, 2, 3, 2);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(153, 24);
            txtPatente.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(224, 224, 224);
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.Location = new Point(485, 29);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(153, 24);
            txtMarca.TabIndex = 11;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblModelo.Location = new Point(68, 132);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(138, 17);
            lblModelo.TabIndex = 12;
            lblModelo.Text = "Modelo del Auto:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblAño.Location = new Point(437, 132);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(43, 17);
            lblAño.TabIndex = 13;
            lblAño.Text = "Año:";
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(224, 224, 224);
            txtModelo.BorderStyle = BorderStyle.FixedSingle;
            txtModelo.Location = new Point(216, 134);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(153, 24);
            txtModelo.TabIndex = 14;
            txtModelo.KeyPress += txtModelo_KeyPress;
            // 
            // txtAño
            // 
            txtAño.BackColor = Color.FromArgb(224, 224, 224);
            txtAño.BorderStyle = BorderStyle.FixedSingle;
            txtAño.Location = new Point(485, 131);
            txtAño.Margin = new Padding(3, 2, 3, 2);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(153, 24);
            txtAño.TabIndex = 15;
            txtAño.KeyPress += txtAño_KeyPress;
            // 
            // lblCantidadHoras
            // 
            lblCantidadHoras.AutoSize = true;
            lblCantidadHoras.BackColor = Color.Transparent;
            lblCantidadHoras.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblCantidadHoras.ForeColor = Color.FromArgb(51, 51, 51);
            lblCantidadHoras.Location = new Point(104, 502);
            lblCantidadHoras.Name = "lblCantidadHoras";
            lblCantidadHoras.Size = new Size(235, 17);
            lblCantidadHoras.TabIndex = 18;
            lblCantidadHoras.Text = "Cantidad de Horas Estimadas:";
            // 
            // lblPrecioHora
            // 
            lblPrecioHora.AutoSize = true;
            lblPrecioHora.BackColor = Color.Transparent;
            lblPrecioHora.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblPrecioHora.ForeColor = Color.FromArgb(51, 51, 51);
            lblPrecioHora.Location = new Point(421, 502);
            lblPrecioHora.Name = "lblPrecioHora";
            lblPrecioHora.Size = new Size(131, 17);
            lblPrecioHora.TabIndex = 19;
            lblPrecioHora.Text = "Precio Por Hora:";
            // 
            // txtCantidadHoras
            // 
            txtCantidadHoras.BackColor = Color.FromArgb(224, 224, 224);
            txtCantidadHoras.BorderStyle = BorderStyle.FixedSingle;
            txtCantidadHoras.Location = new Point(345, 502);
            txtCantidadHoras.Margin = new Padding(3, 2, 3, 2);
            txtCantidadHoras.Name = "txtCantidadHoras";
            txtCantidadHoras.Size = new Size(64, 23);
            txtCantidadHoras.TabIndex = 20;
            txtCantidadHoras.KeyPress += txtCantidadHoras_KeyPress;
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.BackColor = Color.FromArgb(224, 224, 224);
            txtPrecioHora.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioHora.Location = new Point(558, 502);
            txtPrecioHora.Margin = new Padding(3, 2, 3, 2);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.Size = new Size(69, 23);
            txtPrecioHora.TabIndex = 21;
            txtPrecioHora.KeyPress += txtPrecioHora_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreRespuesto, CantidadRepuesto, PrecioRepuesto });
            dataGridView1.Location = new Point(104, 342);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(662, 139);
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
            lblNombreRepo.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblNombreRepo.Location = new Point(8, 35);
            lblNombreRepo.Name = "lblNombreRepo";
            lblNombreRepo.Size = new Size(177, 17);
            lblNombreRepo.TabIndex = 27;
            lblNombreRepo.Text = "Nombre del Repuesto:";
            // 
            // txtNombreRepo
            // 
            txtNombreRepo.BackColor = Color.FromArgb(224, 224, 224);
            txtNombreRepo.BorderStyle = BorderStyle.FixedSingle;
            txtNombreRepo.Location = new Point(8, 54);
            txtNombreRepo.Margin = new Padding(3, 2, 3, 2);
            txtNombreRepo.Name = "txtNombreRepo";
            txtNombreRepo.Size = new Size(153, 27);
            txtNombreRepo.TabIndex = 28;
            // 
            // nupCantidad
            // 
            nupCantidad.BackColor = Color.FromArgb(224, 224, 224);
            nupCantidad.Location = new Point(208, 54);
            nupCantidad.Margin = new Padding(3, 2, 3, 2);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(75, 27);
            nupCantidad.TabIndex = 29;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblCantidad.Location = new Point(206, 35);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(81, 17);
            lblCantidad.TabIndex = 30;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.BackColor = Color.FromArgb(224, 224, 224);
            txtPrecioUni.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioUni.Location = new Point(317, 57);
            txtPrecioUni.Margin = new Padding(3, 2, 3, 2);
            txtPrecioUni.Multiline = true;
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.Size = new Size(67, 24);
            txtPrecioUni.TabIndex = 31;
            txtPrecioUni.KeyPress += txtPrecioUni_KeyPress;
            // 
            // lblPrecioUni
            // 
            lblPrecioUni.AutoSize = true;
            lblPrecioUni.BackColor = Color.Transparent;
            lblPrecioUni.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblPrecioUni.Location = new Point(317, 35);
            lblPrecioUni.Name = "lblPrecioUni";
            lblPrecioUni.Size = new Size(61, 17);
            lblPrecioUni.TabIndex = 32;
            lblPrecioUni.Text = "Precio:";
            // 
            // btnAgregarPresu
            // 
            btnAgregarPresu.BackColor = Color.FromArgb(192, 255, 192);
            btnAgregarPresu.FlatStyle = FlatStyle.Popup;
            btnAgregarPresu.Font = new Font("HomepageBaukasten Bold", 9.75F);
            btnAgregarPresu.Location = new Point(465, 50);
            btnAgregarPresu.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPresu.Name = "btnAgregarPresu";
            btnAgregarPresu.Size = new Size(79, 31);
            btnAgregarPresu.TabIndex = 33;
            btnAgregarPresu.Text = "Agregar";
            btnAgregarPresu.UseVisualStyleBackColor = false;
            btnAgregarPresu.Click += btnAgregarPresu_Click;
            // 
            // btnEliminarPresu
            // 
            btnEliminarPresu.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarPresu.FlatStyle = FlatStyle.Popup;
            btnEliminarPresu.Font = new Font("HomepageBaukasten Bold", 9.75F);
            btnEliminarPresu.Location = new Point(559, 50);
            btnEliminarPresu.Margin = new Padding(3, 2, 3, 2);
            btnEliminarPresu.Name = "btnEliminarPresu";
            btnEliminarPresu.Size = new Size(79, 31);
            btnEliminarPresu.TabIndex = 34;
            btnEliminarPresu.Text = "Eliminar";
            btnEliminarPresu.UseVisualStyleBackColor = false;
            btnEliminarPresu.Click += btnEliminarPresu_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
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
            groupBox1.Font = new Font("HomepageBaukasten Bold", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(51, 51, 51);
            groupBox1.Location = new Point(104, 31);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(662, 178);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Registro";
            // 
            // txtKm
            // 
            txtKm.BackColor = Color.FromArgb(224, 224, 224);
            txtKm.BorderStyle = BorderStyle.FixedSingle;
            txtKm.Location = new Point(485, 92);
            txtKm.Margin = new Padding(3, 2, 3, 2);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(153, 24);
            txtKm.TabIndex = 21;
            // 
            // lblKm
            // 
            lblKm.AutoSize = true;
            lblKm.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblKm.Location = new Point(385, 95);
            lblKm.Name = "lblKm";
            lblKm.Size = new Size(96, 17);
            lblKm.TabIndex = 20;
            lblKm.Text = "Kilometros:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.BackColor = Color.FromArgb(224, 224, 224);
            txtDomicilio.BorderStyle = BorderStyle.FixedSingle;
            txtDomicilio.Location = new Point(216, 95);
            txtDomicilio.Margin = new Padding(3, 2, 3, 2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(153, 24);
            txtDomicilio.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(224, 224, 224);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(217, 62);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(153, 24);
            txtTelefono.TabIndex = 18;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblDomicilio.Location = new Point(119, 95);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(87, 17);
            lblDomicilio.TabIndex = 17;
            lblDomicilio.Text = "Domicilio:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            lblTelefono.Location = new Point(130, 63);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(80, 17);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(lblNombreRepo);
            groupBox2.Controls.Add(btnEliminarPresu);
            groupBox2.Controls.Add(lblCantidad);
            groupBox2.Controls.Add(nupCantidad);
            groupBox2.Controls.Add(btnAgregarPresu);
            groupBox2.Controls.Add(txtPrecioUni);
            groupBox2.Controls.Add(txtNombreRepo);
            groupBox2.Controls.Add(lblPrecioUni);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(51, 51, 51);
            groupBox2.Location = new Point(104, 230);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(662, 90);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Repuestos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(251, 176, 48);
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnLimpiar.ForeColor = Color.FromArgb(51, 51, 51);
            btnLimpiar.Location = new Point(909, 529);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 50);
            btnLimpiar.TabIndex = 38;
            btnLimpiar.Text = "Limpiar Presupuesto";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(251, 176, 48);
            btnGenerar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            btnGenerar.ForeColor = Color.FromArgb(51, 51, 51);
            btnGenerar.Location = new Point(909, 87);
            btnGenerar.Margin = new Padding(3, 2, 3, 2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(116, 50);
            btnGenerar.TabIndex = 39;
            btnGenerar.Text = "Generar Presupuesto";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.BackColor = Color.Transparent;
            labelDesc.Font = new Font("HomepageBaukasten Bold", 11.2499981F);
            labelDesc.ForeColor = Color.FromArgb(51, 51, 51);
            labelDesc.Location = new Point(104, 545);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(195, 17);
            labelDesc.TabIndex = 40;
            labelDesc.Text = "Descripcion del Trabajo:";
            // 
            // textBoxDesc
            // 
            textBoxDesc.BackColor = Color.FromArgb(224, 224, 224);
            textBoxDesc.BorderStyle = BorderStyle.FixedSingle;
            textBoxDesc.Location = new Point(310, 545);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(370, 89);
            textBoxDesc.TabIndex = 41;
            // 
            // Presupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = Properties.Resources.bg_forms;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 661);
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
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(800, 598);
            Name = "Presupuesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ocaranza Mecanica Software";
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