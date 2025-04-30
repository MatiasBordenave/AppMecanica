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
            NombreRespuesto = new DataGridViewTextBoxColumn();
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
            btnVolverPresupuesto.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnVolverPresupuesto.ForeColor = Color.FromArgb(51, 51, 51);
            btnVolverPresupuesto.Location = new Point(924, 583);
            btnVolverPresupuesto.Margin = new Padding(3, 2, 3, 2);
            btnVolverPresupuesto.Name = "btnVolverPresupuesto";
            btnVolverPresupuesto.Size = new Size(139, 60);
            btnVolverPresupuesto.TabIndex = 2;
            btnVolverPresupuesto.Text = "Volver al menú principal";
            btnVolverPresupuesto.UseVisualStyleBackColor = false;
            btnVolverPresupuesto.Click += btnVolverPresupuesto_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(251, 176, 48);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnGuardar.ForeColor = Color.FromArgb(51, 51, 51);
            btnGuardar.Location = new Point(924, 17);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 60);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar datos del cliente";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTitular
            // 
            txtTitular.BackColor = Color.FromArgb(224, 224, 224);
            txtTitular.BorderStyle = BorderStyle.FixedSingle;
            txtTitular.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtTitular.Location = new Point(213, 43);
            txtTitular.Margin = new Padding(3, 2, 3, 2);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(153, 22);
            txtTitular.TabIndex = 4;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblPatente.Location = new Point(417, 79);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(69, 20);
            lblPatente.TabIndex = 5;
            lblPatente.Text = "Patente:";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblTitular.Location = new Point(149, 43);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(56, 20);
            lblTitular.TabIndex = 7;
            lblTitular.Text = "Titular:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblMarca.Location = new Point(433, 42);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(57, 20);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca:";
            // 
            // txtPatente
            // 
            txtPatente.BackColor = Color.FromArgb(224, 224, 224);
            txtPatente.BorderStyle = BorderStyle.FixedSingle;
            txtPatente.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtPatente.Location = new Point(505, 76);
            txtPatente.Margin = new Padding(3, 2, 3, 2);
            txtPatente.Name = "txtPatente";
            txtPatente.PlaceholderText = "Ejemplo: ABC 123";
            txtPatente.Size = new Size(153, 22);
            txtPatente.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(224, 224, 224);
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtMarca.Location = new Point(505, 45);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(153, 22);
            txtMarca.TabIndex = 11;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblModelo.Location = new Point(77, 148);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(128, 20);
            lblModelo.TabIndex = 12;
            lblModelo.Text = "Modelo del Auto:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblAño.Location = new Point(446, 148);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(42, 20);
            lblAño.TabIndex = 13;
            lblAño.Text = "Año:";
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(224, 224, 224);
            txtModelo.BorderStyle = BorderStyle.FixedSingle;
            txtModelo.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtModelo.Location = new Point(212, 148);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(153, 22);
            txtModelo.TabIndex = 14;
            // 
            // txtAño
            // 
            txtAño.BackColor = Color.FromArgb(224, 224, 224);
            txtAño.BorderStyle = BorderStyle.FixedSingle;
            txtAño.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtAño.Location = new Point(505, 147);
            txtAño.Margin = new Padding(3, 2, 3, 2);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(153, 22);
            txtAño.TabIndex = 15;
            // 
            // lblCantidadHoras
            // 
            lblCantidadHoras.AutoSize = true;
            lblCantidadHoras.BackColor = Color.Transparent;
            lblCantidadHoras.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblCantidadHoras.ForeColor = Color.FromArgb(51, 51, 51);
            lblCantidadHoras.Location = new Point(76, 524);
            lblCantidadHoras.Name = "lblCantidadHoras";
            lblCantidadHoras.Size = new Size(135, 20);
            lblCantidadHoras.TabIndex = 18;
            lblCantidadHoras.Text = "Horas Estimadas:";
            // 
            // lblPrecioHora
            // 
            lblPrecioHora.AutoSize = true;
            lblPrecioHora.BackColor = Color.Transparent;
            lblPrecioHora.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblPrecioHora.ForeColor = Color.FromArgb(51, 51, 51);
            lblPrecioHora.Location = new Point(351, 524);
            lblPrecioHora.Name = "lblPrecioHora";
            lblPrecioHora.Size = new Size(124, 20);
            lblPrecioHora.TabIndex = 19;
            lblPrecioHora.Text = "Precio Por Hora:";
            // 
            // txtCantidadHoras
            // 
            txtCantidadHoras.BackColor = Color.FromArgb(224, 224, 224);
            txtCantidadHoras.BorderStyle = BorderStyle.FixedSingle;
            txtCantidadHoras.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtCantidadHoras.Location = new Point(225, 524);
            txtCantidadHoras.Margin = new Padding(3, 2, 3, 2);
            txtCantidadHoras.Name = "txtCantidadHoras";
            txtCantidadHoras.Size = new Size(87, 22);
            txtCantidadHoras.TabIndex = 20;
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.BackColor = Color.FromArgb(224, 224, 224);
            txtPrecioHora.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioHora.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtPrecioHora.Location = new Point(485, 524);
            txtPrecioHora.Margin = new Padding(3, 2, 3, 2);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.PlaceholderText = "$";
            txtPrecioHora.Size = new Size(87, 22);
            txtPrecioHora.TabIndex = 21;
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
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreRespuesto, CantidadRepuesto, PrecioRepuesto });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.FromArgb(51, 51, 51);
            dataGridView1.Location = new Point(76, 342);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
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
            dataGridView1.Size = new Size(690, 145);
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
            lblNombreRepo.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblNombreRepo.Location = new Point(21, 31);
            lblNombreRepo.Name = "lblNombreRepo";
            lblNombreRepo.Size = new Size(69, 20);
            lblNombreRepo.TabIndex = 27;
            lblNombreRepo.Text = "Nombre:";
            // 
            // txtNombreRepo
            // 
            txtNombreRepo.BackColor = Color.FromArgb(224, 224, 224);
            txtNombreRepo.BorderStyle = BorderStyle.FixedSingle;
            txtNombreRepo.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtNombreRepo.Location = new Point(21, 53);
            txtNombreRepo.Margin = new Padding(3, 2, 3, 2);
            txtNombreRepo.Name = "txtNombreRepo";
            txtNombreRepo.Size = new Size(153, 22);
            txtNombreRepo.TabIndex = 28;
            // 
            // nupCantidad
            // 
            nupCantidad.BackColor = Color.FromArgb(224, 224, 224);
            nupCantidad.BorderStyle = BorderStyle.FixedSingle;
            nupCantidad.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            nupCantidad.Location = new Point(202, 53);
            nupCantidad.Margin = new Padding(3, 2, 3, 2);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(87, 22);
            nupCantidad.TabIndex = 29;
            nupCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblCantidad.Location = new Point(202, 31);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(77, 20);
            lblCantidad.TabIndex = 30;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecioUni
            // 
            lblPrecioUni.AutoSize = true;
            lblPrecioUni.BackColor = Color.Transparent;
            lblPrecioUni.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblPrecioUni.Location = new Point(300, 31);
            lblPrecioUni.Name = "lblPrecioUni";
            lblPrecioUni.Size = new Size(57, 20);
            lblPrecioUni.TabIndex = 32;
            lblPrecioUni.Text = "Precio:";
            // 
            // btnAgregarPresu
            // 
            btnAgregarPresu.BackColor = Color.FromArgb(51, 51, 51);
            btnAgregarPresu.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAgregarPresu.FlatStyle = FlatStyle.Popup;
            btnAgregarPresu.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnAgregarPresu.ForeColor = Color.White;
            btnAgregarPresu.Location = new Point(459, 52);
            btnAgregarPresu.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPresu.Name = "btnAgregarPresu";
            btnAgregarPresu.Size = new Size(105, 39);
            btnAgregarPresu.TabIndex = 33;
            btnAgregarPresu.Text = " Agregar ✔️";
            btnAgregarPresu.UseVisualStyleBackColor = false;
            btnAgregarPresu.Click += btnAgregarPresu_Click;
            // 
            // btnEliminarPresu
            // 
            btnEliminarPresu.BackColor = Color.FromArgb(51, 51, 51);
            btnEliminarPresu.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnEliminarPresu.FlatStyle = FlatStyle.Popup;
            btnEliminarPresu.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnEliminarPresu.ForeColor = Color.White;
            btnEliminarPresu.Location = new Point(578, 52);
            btnEliminarPresu.Margin = new Padding(3, 2, 3, 2);
            btnEliminarPresu.Name = "btnEliminarPresu";
            btnEliminarPresu.Size = new Size(99, 39);
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
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(51, 51, 51);
            groupBox1.Location = new Point(76, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(690, 198);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DE REGISTRO";
            // 
            // lblAsKm
            // 
            lblAsKm.AutoSize = true;
            lblAsKm.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsKm.ForeColor = Color.Red;
            lblAsKm.Location = new Point(664, 106);
            lblAsKm.Name = "lblAsKm";
            lblAsKm.Size = new Size(18, 24);
            lblAsKm.TabIndex = 48;
            lblAsKm.Text = "*";
            // 
            // lblAsPatente
            // 
            lblAsPatente.AutoSize = true;
            lblAsPatente.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsPatente.ForeColor = Color.Red;
            lblAsPatente.Location = new Point(664, 74);
            lblAsPatente.Name = "lblAsPatente";
            lblAsPatente.Size = new Size(18, 24);
            lblAsPatente.TabIndex = 47;
            lblAsPatente.Text = "*";
            // 
            // lblAsDomicilio
            // 
            lblAsDomicilio.AutoSize = true;
            lblAsDomicilio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsDomicilio.ForeColor = Color.Red;
            lblAsDomicilio.Location = new Point(371, 108);
            lblAsDomicilio.Name = "lblAsDomicilio";
            lblAsDomicilio.Size = new Size(18, 24);
            lblAsDomicilio.TabIndex = 46;
            lblAsDomicilio.Text = "*";
            // 
            // txtKm
            // 
            txtKm.BackColor = Color.FromArgb(224, 224, 224);
            txtKm.BorderStyle = BorderStyle.FixedSingle;
            txtKm.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtKm.Location = new Point(505, 108);
            txtKm.Margin = new Padding(3, 2, 3, 2);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(153, 22);
            txtKm.TabIndex = 21;
            // 
            // lblKm
            // 
            lblKm.AutoSize = true;
            lblKm.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblKm.Location = new Point(400, 109);
            lblKm.Name = "lblKm";
            lblKm.Size = new Size(87, 20);
            lblKm.TabIndex = 20;
            lblKm.Text = "Kilometros:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.BackColor = Color.FromArgb(224, 224, 224);
            txtDomicilio.BorderStyle = BorderStyle.FixedSingle;
            txtDomicilio.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtDomicilio.Location = new Point(212, 109);
            txtDomicilio.Margin = new Padding(3, 2, 3, 2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(153, 22);
            txtDomicilio.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(224, 224, 224);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtTelefono.Location = new Point(213, 76);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ejemplo: 3816566750";
            txtTelefono.Size = new Size(153, 22);
            txtTelefono.TabIndex = 18;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblDomicilio.Location = new Point(129, 109);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(76, 20);
            lblDomicilio.TabIndex = 17;
            lblDomicilio.Text = "Domicilio:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            lblTelefono.Location = new Point(129, 78);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(75, 20);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono:";
            // 
            // lblAsAño
            // 
            lblAsAño.AutoSize = true;
            lblAsAño.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsAño.ForeColor = Color.Red;
            lblAsAño.Location = new Point(664, 148);
            lblAsAño.Name = "lblAsAño";
            lblAsAño.Size = new Size(18, 24);
            lblAsAño.TabIndex = 45;
            lblAsAño.Text = "*";
            // 
            // lblAsMarca
            // 
            lblAsMarca.AutoSize = true;
            lblAsMarca.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsMarca.ForeColor = Color.Red;
            lblAsMarca.Location = new Point(664, 45);
            lblAsMarca.Name = "lblAsMarca";
            lblAsMarca.Size = new Size(18, 24);
            lblAsMarca.TabIndex = 44;
            lblAsMarca.Text = "*";
            // 
            // lblAsModelo
            // 
            lblAsModelo.AutoSize = true;
            lblAsModelo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsModelo.ForeColor = Color.Red;
            lblAsModelo.Location = new Point(371, 147);
            lblAsModelo.Name = "lblAsModelo";
            lblAsModelo.Size = new Size(18, 24);
            lblAsModelo.TabIndex = 43;
            lblAsModelo.Text = "*";
            // 
            // lblAsTele
            // 
            lblAsTele.AutoSize = true;
            lblAsTele.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsTele.ForeColor = Color.Red;
            lblAsTele.Location = new Point(372, 77);
            lblAsTele.Name = "lblAsTele";
            lblAsTele.Size = new Size(18, 24);
            lblAsTele.TabIndex = 42;
            lblAsTele.Text = "*";
            // 
            // lblAsTitu
            // 
            lblAsTitu.AutoSize = true;
            lblAsTitu.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsTitu.ForeColor = Color.Red;
            lblAsTitu.Location = new Point(372, 46);
            lblAsTitu.Name = "lblAsTitu";
            lblAsTitu.Size = new Size(18, 24);
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
            groupBox2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(51, 51, 51);
            groupBox2.Location = new Point(76, 236);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(690, 105);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "AGREGAR REPUESTOS";
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.BackColor = Color.FromArgb(224, 224, 224);
            txtPrecioUni.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioUni.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            txtPrecioUni.Location = new Point(300, 53);
            txtPrecioUni.Margin = new Padding(3, 2, 3, 2);
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.PlaceholderText = "$";
            txtPrecioUni.Size = new Size(87, 22);
            txtPrecioUni.TabIndex = 42;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(251, 176, 48);
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(51, 51, 51);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnLimpiar.ForeColor = Color.FromArgb(51, 51, 51);
            btnLimpiar.Location = new Point(924, 506);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(139, 60);
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
            btnGenerar.Font = new Font("Microsoft Sans Serif", 11.2499981F);
            btnGenerar.ForeColor = Color.FromArgb(51, 51, 51);
            btnGenerar.Location = new Point(924, 101);
            btnGenerar.Margin = new Padding(3, 2, 3, 2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(139, 60);
            btnGenerar.TabIndex = 39;
            btnGenerar.Text = "Crear presupuesto";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.BackColor = Color.Transparent;
            labelDesc.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            labelDesc.ForeColor = Color.FromArgb(51, 51, 51);
            labelDesc.Location = new Point(76, 566);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(96, 20);
            labelDesc.TabIndex = 40;
            labelDesc.Text = "Descripcion:";
            // 
            // textBoxDesc
            // 
            textBoxDesc.BackColor = Color.FromArgb(224, 224, 224);
            textBoxDesc.BorderStyle = BorderStyle.FixedSingle;
            textBoxDesc.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold);
            textBoxDesc.Location = new Point(178, 567);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(370, 83);
            textBoxDesc.TabIndex = 41;
            // 
            // lblLinea
            // 
            lblLinea.BackColor = Color.FromArgb(224, 224, 224);
            lblLinea.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinea.ForeColor = Color.Silver;
            lblLinea.Location = new Point(33, 221);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(800, 1);
            lblLinea.TabIndex = 122;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(33, 502);
            label1.Name = "label1";
            label1.Size = new Size(800, 1);
            label1.TabIndex = 123;
            // 
            // lblAsHoras
            // 
            lblAsHoras.AutoSize = true;
            lblAsHoras.BackColor = Color.Transparent;
            lblAsHoras.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsHoras.ForeColor = Color.Red;
            lblAsHoras.Location = new Point(318, 523);
            lblAsHoras.Name = "lblAsHoras";
            lblAsHoras.Size = new Size(18, 24);
            lblAsHoras.TabIndex = 124;
            lblAsHoras.Text = "*";
            // 
            // lblAsPxH
            // 
            lblAsPxH.AutoSize = true;
            lblAsPxH.BackColor = Color.Transparent;
            lblAsPxH.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsPxH.ForeColor = Color.Red;
            lblAsPxH.Location = new Point(581, 524);
            lblAsPxH.Name = "lblAsPxH";
            lblAsPxH.Size = new Size(18, 24);
            lblAsPxH.TabIndex = 125;
            lblAsPxH.Text = "*";
            // 
            // lblAsDesc
            // 
            lblAsDesc.AutoSize = true;
            lblAsDesc.BackColor = Color.Transparent;
            lblAsDesc.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsDesc.ForeColor = Color.Red;
            lblAsDesc.Location = new Point(554, 564);
            lblAsDesc.Name = "lblAsDesc";
            lblAsDesc.Size = new Size(18, 24);
            lblAsDesc.TabIndex = 126;
            lblAsDesc.Text = "*";
            // 
            // Presupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 661);
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
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(800, 596);
            Name = "Presupuesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ocaranza Mecanica Software";
            FormClosing += Presupuesto_FormClosing;
            Load += Presupuesto_Load;
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
        private DataGridViewTextBoxColumn NombreRespuesto;
        private DataGridViewTextBoxColumn CantidadRepuesto;
        private DataGridViewTextBoxColumn PrecioRepuesto;
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
    }
}