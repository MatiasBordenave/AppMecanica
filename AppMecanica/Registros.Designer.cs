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
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            lblPaten = new Label();
            button1 = new Button();
            button3 = new Button();
            btnVolverReg = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(765, 461);
            dataGridView1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 128, 255);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(387, 112);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 35);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 112);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 33);
            textBox1.TabIndex = 2;
            // 
            // lblPaten
            // 
            lblPaten.AutoSize = true;
            lblPaten.BackColor = Color.FromArgb(128, 128, 255);
            lblPaten.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaten.Location = new Point(27, 112);
            lblPaten.Name = "lblPaten";
            lblPaten.Size = new Size(95, 31);
            lblPaten.TabIndex = 3;
            lblPaten.Text = "Patente";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(849, 193);
            button1.Name = "button1";
            button1.Size = new Size(125, 54);
            button1.TabIndex = 4;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(849, 296);
            button3.Name = "button3";
            button3.Size = new Size(125, 54);
            button3.TabIndex = 6;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnVolverReg
            // 
            btnVolverReg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverReg.Location = new Point(849, 571);
            btnVolverReg.Name = "btnVolverReg";
            btnVolverReg.Size = new Size(125, 54);
            btnVolverReg.TabIndex = 7;
            btnVolverReg.Text = "Volver";
            btnVolverReg.UseVisualStyleBackColor = true;
            btnVolverReg.Click += btnVolverReg_Click;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1034, 686);
            Controls.Add(btnVolverReg);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(lblPaten);
            Controls.Add(textBox1);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBuscar;
        private TextBox textBox1;
        private Label lblPaten;
        private Button button1;
        private Button button3;
        private Button btnVolverReg;
    }
}