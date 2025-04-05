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
            btnRegistro = new Button();
            btnPresupuesto = new Button();
            pictureBox1 = new PictureBox();
            panelHome = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHome.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(472, 461);
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
            btnPresupuesto.Location = new Point(28, 461);
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
            pictureBox1.Location = new Point(170, 25);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panelHome
            // 
            panelHome.Controls.Add(pictureBox1);
            panelHome.Controls.Add(btnRegistro);
            panelHome.Controls.Add(btnPresupuesto);
            panelHome.Location = new Point(193, 10);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(644, 530);
            panelHome.TabIndex = 9;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 560);
            Controls.Add(panelHome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ocaranza Mecanica";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistro;
        private Button btnPresupuesto;
        private PictureBox pictureBox1;
        private Panel panelHome;
    }
}
