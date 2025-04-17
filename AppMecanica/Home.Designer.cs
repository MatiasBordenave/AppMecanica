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
            btnPresupuesto.Location = new Point(262, 697);
            btnPresupuesto.Margin = new Padding(5, 5, 5, 5);
            btnPresupuesto.Name = "btnPresupuesto";
            btnPresupuesto.Size = new Size(159, 80);
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
            btnRegistro.Location = new Point(809, 697);
            btnRegistro.Margin = new Padding(5, 5, 5, 5);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(153, 80);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "Regitro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(377, 85);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 527);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1239, 881);
            Controls.Add(btnPresupuesto);
            Controls.Add(btnRegistro);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(912, 784);
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
