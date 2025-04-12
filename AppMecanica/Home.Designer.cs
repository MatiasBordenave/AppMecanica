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
            btnPresupuesto = new Button();
            btnRegistro = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPresupuesto
            // 
            btnPresupuesto.BackColor = Color.FromArgb(255, 128, 0);
            btnPresupuesto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPresupuesto.ForeColor = SystemColors.ButtonHighlight;
            btnPresupuesto.Location = new Point(229, 523);
            btnPresupuesto.Margin = new Padding(4);
            btnPresupuesto.Name = "btnPresupuesto";
            btnPresupuesto.Size = new Size(139, 60);
            btnPresupuesto.TabIndex = 7;
            btnPresupuesto.Text = "Crear Un Presupuesto";
            btnPresupuesto.UseVisualStyleBackColor = false;
            btnPresupuesto.Click += btnPresupuesto_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(255, 128, 0);
            btnRegistro.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = SystemColors.ButtonHighlight;
            btnRegistro.Location = new Point(708, 523);
            btnRegistro.Margin = new Padding(4);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(134, 60);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "Regitro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(330, 64);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1084, 661);
            Controls.Add(btnPresupuesto);
            Controls.Add(btnRegistro);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ocaranza Mecanica";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPresupuesto;
        private Button btnRegistro;
        private PictureBox pictureBox1;
    }
}
