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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            NombreRepuesto = new DataGridViewTextBoxColumn();
            CantidadRepuesto = new DataGridViewTextBoxColumn();
            PrecioRepuesto = new DataGridViewTextBoxColumn();
            lblNombreRepo = new Label();
            txtNombreRepo = new TextBox();
            nupCantidad = new NumericUpDown();
            lblCantidad = new Label();
            lblPrecioUni = new Label();
            btnAgregarPresu = new Button();
            btnEliminarPresu = new Button();
            groupBox1 = new GroupBox();
            lblAsKm = new Label();
            lblAsPatente = new Label();
            lblAsDomicilio = new Label();
            txtKm = new TextBox();
            lblKm = new Label();
            txtDomicilio = new TextBox();
            txtTelefono = new TextBox();
            lblDomicilio = new Label();
            lblTelefono = new Label();
            lblAsAño = new Label();
            lblAsMarca = new Label();
            lblAsModelo = new Label();
            lblAsTele = new Label();
            lblAsTitu = new Label();
            groupBox2 = new GroupBox();
            txtPrecioUni = new TextBox();
            btnLimpiar = new Button();
            btnGenerar = new Button();
            labelDesc = new Label();
            textBoxDesc = new TextBox();
            lblLinea = new Label();
            label1 = new Label();
            lblAsHoras = new Label();
            lblAsPxH = new Label();
            lblAsDesc = new Label();
            btnSnPrspto = new Button();
            btnManualPrspto = new Button();
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
            btnVolverPresupuesto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVolverPresupuesto.ForeColor = Color.FromArgb(51, 51, 51);
            btnVolverPresupuesto.Location = new Point(1155, 865);
            btnVolverPresupuesto.Name = "btnVolverPresupuesto";
            btnVolverPresupuesto.Size = new Size(159, 80);
            btnVolverPresupuesto.TabIndex = 17;
            btnVolverPresupuesto.Text = "Volver al menú principal";
            btnVolverPresupuesto.UseVisualStyleBackColor = false;
            btnVolverPresupuesto.Click += btnVolverPresupuesto_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(251, 176, 48);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(51, 51, 51);
            btnGuardar.Location = new Point(1155, 47);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(159, 80);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar datos del cliente";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTitular
            // 
            txtTitular.BackColor = Color.FromArgb(224, 224, 224);
            txtTitular.BorderStyle = BorderStyle.FixedSingle;
            txtTitular.Font = new Font("Segoe UI", 9.75F);
            txtTitular.Location = new Point(263, 40);
            txtTitular.Name = "txtTitular";
            txtTitular.ShortcutsEnabled = false;
            txtTitular.Size = new Size(175, 29);
            txtTitular.TabIndex = 0;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblPatente.ForeColor = Color.FromArgb(51, 51, 51);
            lblPatente.Location = new Point(503, 105);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(85, 25);
            lblPatente.TabIndex = 5;
            lblPatente.Text = "Patente:";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTitular.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitular.Location = new Point(177, 43);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(76, 25);
            lblTitular.TabIndex = 7;
            lblTitular.Text = "Titular:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblMarca.ForeColor = Color.FromArgb(51, 51, 51);
            lblMarca.Location = new Point(517, 44);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(72, 25);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca:";
            // 
            // txtPatente
            // 
            txtPatente.BackColor = Color.FromArgb(224, 224, 224);
            txtPatente.BorderStyle = BorderStyle.FixedSingle;
            txtPatente.Font = new Font("Segoe UI", 9.75F);
            txtPatente.Location = new Point(599, 101);
            txtPatente.Name = "txtPatente";
            txtPatente.PlaceholderText = "Ejemplo: ABC 123";
            txtPatente.ShortcutsEnabled = false;
            txtPatente.Size = new Size(175, 29);
            txtPatente.TabIndex = 3;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(224, 224, 224);
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.Font = new Font("Segoe UI", 9.75F);
            txtMarca.Location = new Point(599, 40);
            txtMarca.Name = "txtMarca";
            txtMarca.ShortcutsEnabled = false;
            txtMarca.Size = new Size(175, 29);
            txtMarca.TabIndex = 1;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblModelo.ForeColor = Color.FromArgb(51, 51, 51);
            lblModelo.Location = new Point(86, 211);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(167, 25);
            lblModelo.TabIndex = 12;
            lblModelo.Text = "Modelo del Auto:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblAño.ForeColor = Color.FromArgb(51, 51, 51);
            lblAño.Location = new Point(534, 211);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(54, 25);
            lblAño.TabIndex = 13;
            lblAño.Text = "Año:";
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(224, 224, 224);
            txtModelo.BorderStyle = BorderStyle.FixedSingle;
            txtModelo.Font = new Font("Segoe UI", 9.75F);
            txtModelo.Location = new Point(263, 207);
            txtModelo.Name = "txtModelo";
            txtModelo.ShortcutsEnabled = false;
            txtModelo.Size = new Size(175, 29);
            txtModelo.TabIndex = 6;
            // 
            // txtAño
            // 
            txtAño.BackColor = Color.FromArgb(224, 224, 224);
            txtAño.BorderStyle = BorderStyle.FixedSingle;
            txtAño.Font = new Font("Segoe UI", 9.75F);
            txtAño.Location = new Point(599, 207);
            txtAño.Name = "txtAño";
            txtAño.ShortcutsEnabled = false;
            txtAño.Size = new Size(175, 29);
            txtAño.TabIndex = 7;
            // 
            // lblCantidadHoras
            // 
            lblCantidadHoras.AutoSize = true;
            lblCantidadHoras.BackColor = Color.WhiteSmoke;
            lblCantidadHoras.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCantidadHoras.ForeColor = Color.FromArgb(51, 51, 51);
            lblCantidadHoras.Location = new Point(177, 769);
            lblCantidadHoras.Name = "lblCantidadHoras";
            lblCantidadHoras.Size = new Size(162, 25);
            lblCantidadHoras.TabIndex = 18;
            lblCantidadHoras.Text = "Horas Estimadas:";
            // 
            // lblPrecioHora
            // 
            lblPrecioHora.AutoSize = true;
            lblPrecioHora.BackColor = Color.WhiteSmoke;
            lblPrecioHora.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblPrecioHora.ForeColor = Color.FromArgb(51, 51, 51);
            lblPrecioHora.Location = new Point(542, 769);
            lblPrecioHora.Name = "lblPrecioHora";
            lblPrecioHora.Size = new Size(159, 25);
            lblPrecioHora.TabIndex = 19;
            lblPrecioHora.Text = "Precio Por Hora:";
            // 
            // txtCantidadHoras
            // 
            txtCantidadHoras.BackColor = Color.FromArgb(224, 224, 224);
            txtCantidadHoras.BorderStyle = BorderStyle.FixedSingle;
            txtCantidadHoras.Font = new Font("Segoe UI", 9.75F);
            txtCantidadHoras.Location = new Point(350, 763);
            txtCantidadHoras.Name = "txtCantidadHoras";
            txtCantidadHoras.ShortcutsEnabled = false;
            txtCantidadHoras.Size = new Size(99, 29);
            txtCantidadHoras.TabIndex = 11;
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.BackColor = Color.FromArgb(224, 224, 224);
            txtPrecioHora.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioHora.Font = new Font("Segoe UI", 9.75F);
            txtPrecioHora.Location = new Point(708, 763);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.PlaceholderText = "$";
            txtPrecioHora.ShortcutsEnabled = false;
            txtPrecioHora.Size = new Size(99, 29);
            txtPrecioHora.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreRepuesto, CantidadRepuesto, PrecioRepuesto });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.FromArgb(51, 51, 51);
            dataGridView1.Location = new Point(177, 536);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(838, 193);
            dataGridView1.TabIndex = 26;
            // 
            // NombreRepuesto
            // 
            NombreRepuesto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NombreRepuesto.HeaderText = "Nombre Repuesto";
            NombreRepuesto.MinimumWidth = 6;
            NombreRepuesto.Name = "NombreRepuesto";
            NombreRepuesto.ReadOnly = true;
            NombreRepuesto.Width = 350;
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
            lblNombreRepo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNombreRepo.ForeColor = Color.FromArgb(51, 51, 51);
            lblNombreRepo.Location = new Point(64, 55);
            lblNombreRepo.Name = "lblNombreRepo";
            lblNombreRepo.Size = new Size(91, 25);
            lblNombreRepo.TabIndex = 27;
            lblNombreRepo.Text = "Nombre:";
            // 
            // txtNombreRepo
            // 
            txtNombreRepo.BackColor = Color.FromArgb(224, 224, 224);
            txtNombreRepo.BorderStyle = BorderStyle.FixedSingle;
            txtNombreRepo.Font = new Font("Segoe UI", 9.75F);
            txtNombreRepo.Location = new Point(64, 84);
            txtNombreRepo.Name = "txtNombreRepo";
            txtNombreRepo.ShortcutsEnabled = false;
            txtNombreRepo.Size = new Size(175, 29);
            txtNombreRepo.TabIndex = 8;
            // 
            // nupCantidad
            // 
            nupCantidad.BackColor = Color.FromArgb(224, 224, 224);
            nupCantidad.BorderStyle = BorderStyle.FixedSingle;
            nupCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nupCantidad.ForeColor = Color.FromArgb(51, 51, 51);
            nupCantidad.Location = new Point(271, 84);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(99, 29);
            nupCantidad.TabIndex = 9;
            nupCantidad.TextAlign = HorizontalAlignment.Center;
            nupCantidad.Click += nupCantidad_Click;
            nupCantidad.Enter += nupCantidad_Enter;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCantidad.ForeColor = Color.FromArgb(51, 51, 51);
            lblCantidad.Location = new Point(271, 55);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(97, 25);
            lblCantidad.TabIndex = 30;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecioUni
            // 
            lblPrecioUni.AutoSize = true;
            lblPrecioUni.BackColor = Color.Transparent;
            lblPrecioUni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblPrecioUni.ForeColor = Color.FromArgb(51, 51, 51);
            lblPrecioUni.Location = new Point(383, 55);
            lblPrecioUni.Name = "lblPrecioUni";
            lblPrecioUni.Size = new Size(73, 25);
            lblPrecioUni.TabIndex = 32;
            lblPrecioUni.Text = "Precio:";
            // 
            // btnAgregarPresu
            // 
            btnAgregarPresu.BackColor = Color.FromArgb(51, 51, 51);
            btnAgregarPresu.FlatAppearance.BorderColor = Color.White;
            btnAgregarPresu.FlatAppearance.BorderSize = 2;
            btnAgregarPresu.FlatStyle = FlatStyle.Popup;
            btnAgregarPresu.Font = new Font("Segoe UI", 11.25F);
            btnAgregarPresu.ForeColor = Color.White;
            btnAgregarPresu.Location = new Point(563, 95);
            btnAgregarPresu.Name = "btnAgregarPresu";
            btnAgregarPresu.Size = new Size(120, 52);
            btnAgregarPresu.TabIndex = 10;
            btnAgregarPresu.Text = " Agregar ✔️";
            btnAgregarPresu.UseVisualStyleBackColor = false;
            btnAgregarPresu.Click += btnAgregarPresu_Click;
            // 
            // btnEliminarPresu
            // 
            btnEliminarPresu.BackColor = Color.FromArgb(51, 51, 51);
            btnEliminarPresu.FlatAppearance.BorderColor = Color.White;
            btnEliminarPresu.FlatAppearance.BorderSize = 2;
            btnEliminarPresu.FlatStyle = FlatStyle.Popup;
            btnEliminarPresu.Font = new Font("Segoe UI", 11.25F);
            btnEliminarPresu.ForeColor = Color.White;
            btnEliminarPresu.Location = new Point(699, 95);
            btnEliminarPresu.Name = "btnEliminarPresu";
            btnEliminarPresu.Size = new Size(120, 52);
            btnEliminarPresu.TabIndex = 34;
            btnEliminarPresu.Text = "Eliminar ❌";
            btnEliminarPresu.UseVisualStyleBackColor = false;
            btnEliminarPresu.Click += btnEliminarPresu_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(lblAsKm);
            groupBox1.Controls.Add(lblAsPatente);
            groupBox1.Controls.Add(lblAsDomicilio);
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
            groupBox1.Controls.Add(lblAsAño);
            groupBox1.Controls.Add(lblAsMarca);
            groupBox1.Controls.Add(lblAsModelo);
            groupBox1.Controls.Add(lblAsTele);
            groupBox1.Controls.Add(lblAsTitu);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(51, 51, 51);
            groupBox1.Location = new Point(174, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(838, 284);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DE REGISTRO";
            // 
            // lblAsKm
            // 
            lblAsKm.AutoSize = true;
            lblAsKm.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsKm.ForeColor = Color.Red;
            lblAsKm.Location = new Point(781, 155);
            lblAsKm.Name = "lblAsKm";
            lblAsKm.Size = new Size(24, 29);
            lblAsKm.TabIndex = 48;
            lblAsKm.Text = "*";
            // 
            // lblAsPatente
            // 
            lblAsPatente.AutoSize = true;
            lblAsPatente.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsPatente.ForeColor = Color.Red;
            lblAsPatente.Location = new Point(781, 101);
            lblAsPatente.Name = "lblAsPatente";
            lblAsPatente.Size = new Size(24, 29);
            lblAsPatente.TabIndex = 47;
            lblAsPatente.Text = "*";
            // 
            // lblAsDomicilio
            // 
            lblAsDomicilio.AutoSize = true;
            lblAsDomicilio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsDomicilio.ForeColor = Color.Red;
            lblAsDomicilio.Location = new Point(445, 151);
            lblAsDomicilio.Name = "lblAsDomicilio";
            lblAsDomicilio.Size = new Size(24, 29);
            lblAsDomicilio.TabIndex = 46;
            lblAsDomicilio.Text = "*";
            // 
            // txtKm
            // 
            txtKm.BackColor = Color.FromArgb(224, 224, 224);
            txtKm.BorderStyle = BorderStyle.FixedSingle;
            txtKm.Font = new Font("Segoe UI", 9.75F);
            txtKm.Location = new Point(599, 155);
            txtKm.Name = "txtKm";
            txtKm.ShortcutsEnabled = false;
            txtKm.Size = new Size(175, 29);
            txtKm.TabIndex = 5;
            // 
            // lblKm
            // 
            lblKm.AutoSize = true;
            lblKm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblKm.ForeColor = Color.FromArgb(51, 51, 51);
            lblKm.Location = new Point(475, 159);
            lblKm.Name = "lblKm";
            lblKm.Size = new Size(113, 25);
            lblKm.TabIndex = 20;
            lblKm.Text = "Kilometros:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.BackColor = Color.FromArgb(224, 224, 224);
            txtDomicilio.BorderStyle = BorderStyle.FixedSingle;
            txtDomicilio.Font = new Font("Segoe UI", 9.75F);
            txtDomicilio.Location = new Point(263, 153);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.ShortcutsEnabled = false;
            txtDomicilio.Size = new Size(175, 29);
            txtDomicilio.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(224, 224, 224);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Segoe UI", 9.75F);
            txtTelefono.Location = new Point(263, 97);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ejemplo: 3816566750";
            txtTelefono.ShortcutsEnabled = false;
            txtTelefono.Size = new Size(175, 29);
            txtTelefono.TabIndex = 2;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDomicilio.ForeColor = Color.FromArgb(51, 51, 51);
            lblDomicilio.Location = new Point(155, 163);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(101, 25);
            lblDomicilio.TabIndex = 17;
            lblDomicilio.Text = "Domicilio:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(51, 51, 51);
            lblTelefono.Location = new Point(161, 109);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(94, 25);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono:";
            // 
            // lblAsAño
            // 
            lblAsAño.AutoSize = true;
            lblAsAño.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsAño.ForeColor = Color.Red;
            lblAsAño.Location = new Point(781, 207);
            lblAsAño.Name = "lblAsAño";
            lblAsAño.Size = new Size(24, 29);
            lblAsAño.TabIndex = 45;
            lblAsAño.Text = "*";
            // 
            // lblAsMarca
            // 
            lblAsMarca.AutoSize = true;
            lblAsMarca.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsMarca.ForeColor = Color.Red;
            lblAsMarca.Location = new Point(781, 40);
            lblAsMarca.Name = "lblAsMarca";
            lblAsMarca.Size = new Size(24, 29);
            lblAsMarca.TabIndex = 44;
            lblAsMarca.Text = "*";
            // 
            // lblAsModelo
            // 
            lblAsModelo.AutoSize = true;
            lblAsModelo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsModelo.ForeColor = Color.Red;
            lblAsModelo.Location = new Point(445, 204);
            lblAsModelo.Name = "lblAsModelo";
            lblAsModelo.Size = new Size(24, 29);
            lblAsModelo.TabIndex = 43;
            lblAsModelo.Text = "*";
            // 
            // lblAsTele
            // 
            lblAsTele.AutoSize = true;
            lblAsTele.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsTele.ForeColor = Color.Red;
            lblAsTele.Location = new Point(445, 104);
            lblAsTele.Name = "lblAsTele";
            lblAsTele.Size = new Size(24, 29);
            lblAsTele.TabIndex = 42;
            lblAsTele.Text = "*";
            // 
            // lblAsTitu
            // 
            lblAsTitu.AutoSize = true;
            lblAsTitu.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsTitu.ForeColor = Color.Red;
            lblAsTitu.Location = new Point(445, 47);
            lblAsTitu.Name = "lblAsTitu";
            lblAsTitu.Size = new Size(24, 29);
            lblAsTitu.TabIndex = 42;
            lblAsTitu.Text = "*";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(txtPrecioUni);
            groupBox2.Controls.Add(lblNombreRepo);
            groupBox2.Controls.Add(btnEliminarPresu);
            groupBox2.Controls.Add(lblCantidad);
            groupBox2.Controls.Add(nupCantidad);
            groupBox2.Controls.Add(btnAgregarPresu);
            groupBox2.Controls.Add(txtNombreRepo);
            groupBox2.Controls.Add(lblPrecioUni);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(51, 51, 51);
            groupBox2.Location = new Point(174, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(838, 167);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "AGREGAR REPUESTOS";
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.BackColor = Color.FromArgb(224, 224, 224);
            txtPrecioUni.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioUni.Font = new Font("Segoe UI", 9.75F);
            txtPrecioUni.Location = new Point(383, 84);
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.PlaceholderText = "$";
            txtPrecioUni.ShortcutsEnabled = false;
            txtPrecioUni.Size = new Size(99, 29);
            txtPrecioUni.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(251, 176, 48);
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(51, 51, 51);
            btnLimpiar.Location = new Point(1155, 763);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(159, 80);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar Presupuesto";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(251, 176, 48);
            btnGenerar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.FromArgb(51, 51, 51);
            btnGenerar.Location = new Point(1155, 148);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(159, 80);
            btnGenerar.TabIndex = 15;
            btnGenerar.Text = "Crear presupuesto";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.BackColor = Color.WhiteSmoke;
            labelDesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelDesc.ForeColor = Color.FromArgb(51, 51, 51);
            labelDesc.Location = new Point(177, 841);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(121, 25);
            labelDesc.TabIndex = 40;
            labelDesc.Text = "Descripcion:";
            // 
            // textBoxDesc
            // 
            textBoxDesc.BackColor = Color.FromArgb(224, 224, 224);
            textBoxDesc.BorderStyle = BorderStyle.FixedSingle;
            textBoxDesc.Font = new Font("Segoe UI", 9.75F);
            textBoxDesc.Location = new Point(304, 841);
            textBoxDesc.Margin = new Padding(3, 4, 3, 4);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(423, 110);
            textBoxDesc.TabIndex = 13;
            // 
            // lblLinea
            // 
            lblLinea.BackColor = Color.FromArgb(224, 224, 224);
            lblLinea.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinea.ForeColor = Color.Silver;
            lblLinea.Location = new Point(138, 349);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(914, 1);
            lblLinea.TabIndex = 122;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(134, 748);
            label1.Name = "label1";
            label1.Size = new Size(914, 1);
            label1.TabIndex = 123;
            // 
            // lblAsHoras
            // 
            lblAsHoras.AutoSize = true;
            lblAsHoras.BackColor = Color.Transparent;
            lblAsHoras.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsHoras.ForeColor = Color.Red;
            lblAsHoras.Location = new Point(456, 760);
            lblAsHoras.Name = "lblAsHoras";
            lblAsHoras.Size = new Size(24, 29);
            lblAsHoras.TabIndex = 124;
            lblAsHoras.Text = "*";
            // 
            // lblAsPxH
            // 
            lblAsPxH.AutoSize = true;
            lblAsPxH.BackColor = Color.Transparent;
            lblAsPxH.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsPxH.ForeColor = Color.Red;
            lblAsPxH.Location = new Point(813, 763);
            lblAsPxH.Name = "lblAsPxH";
            lblAsPxH.Size = new Size(24, 29);
            lblAsPxH.TabIndex = 125;
            lblAsPxH.Text = "*";
            // 
            // lblAsDesc
            // 
            lblAsDesc.AutoSize = true;
            lblAsDesc.BackColor = Color.Transparent;
            lblAsDesc.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsDesc.ForeColor = Color.Red;
            lblAsDesc.Location = new Point(738, 841);
            lblAsDesc.Name = "lblAsDesc";
            lblAsDesc.Size = new Size(24, 29);
            lblAsDesc.TabIndex = 126;
            lblAsDesc.Text = "*";
            // 
            // btnSnPrspto
            // 
            btnSnPrspto.BackColor = Color.FromArgb(51, 51, 51);
            btnSnPrspto.FlatAppearance.BorderColor = Color.Gray;
            btnSnPrspto.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnSnPrspto.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSnPrspto.FlatStyle = FlatStyle.Flat;
            btnSnPrspto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSnPrspto.ForeColor = Color.White;
            btnSnPrspto.Location = new Point(-1, -1);
            btnSnPrspto.Margin = new Padding(1, 3, 1, 3);
            btnSnPrspto.Name = "btnSnPrspto";
            btnSnPrspto.Size = new Size(119, 33);
            btnSnPrspto.TabIndex = 127;
            btnSnPrspto.Text = "Sobre Nostros";
            btnSnPrspto.UseVisualStyleBackColor = false;
            btnSnPrspto.Click += btnSnPrspto_Click;
            // 
            // btnManualPrspto
            // 
            btnManualPrspto.BackColor = Color.FromArgb(51, 51, 51);
            btnManualPrspto.FlatAppearance.BorderColor = Color.Gray;
            btnManualPrspto.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnManualPrspto.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnManualPrspto.FlatStyle = FlatStyle.Flat;
            btnManualPrspto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManualPrspto.ForeColor = Color.White;
            btnManualPrspto.Location = new Point(115, -1);
            btnManualPrspto.Margin = new Padding(1, 3, 1, 3);
            btnManualPrspto.Name = "btnManualPrspto";
            btnManualPrspto.Size = new Size(109, 33);
            btnManualPrspto.TabIndex = 128;
            btnManualPrspto.Text = "Ayuda";
            btnManualPrspto.UseVisualStyleBackColor = false;
            btnManualPrspto.Click += btnManualPrspto_Click;
            // 
            // Presupuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1353, 963);
            Controls.Add(btnManualPrspto);
            Controls.Add(btnSnPrspto);
            Controls.Add(lblAsDesc);
            Controls.Add(lblAsPxH);
            Controls.Add(lblAsHoras);
            Controls.Add(label1);
            Controls.Add(lblLinea);
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
            DoubleBuffered = true;
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1369, 999);
            Name = "Presupuesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ocaranza Mecanica Software";
            FormClosing += Presupuesto_FormClosing;
            Load += Presupuesto_Load;
            KeyDown += Presupuesto_KeyDown;
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
        private Label labelDesc;
        private TextBox textBoxDesc;
        private TextBox txtKm;
        private Label lblKm;
        private TextBox txtPrecioUni;
        private Label lblLinea;
        private Label label1;
        private Label lblAsAño;
        private Label lblAsMarca;
        private Label lblAsModelo;
        private Label lblAsTele;
        private Label lblAsTitu;
        private Label lblAsKm;
        private Label lblAsPatente;
        private Label lblAsDomicilio;
        private Label lblAsHoras;
        private Label lblAsPxH;
        private Label lblAsDesc;
        private DataGridViewTextBoxColumn NombreRepuesto;
        private DataGridViewTextBoxColumn CantidadRepuesto;
        private DataGridViewTextBoxColumn PrecioRepuesto;
        private Button btnSnPrspto;
        private Button btnManualPrspto;
    }
}