namespace AppMecanica
{
    partial class FormAlerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlerta));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            btnCerrar = new Button();
            linkLabel3 = new LinkLabel();
            label1 = new Label();
            linkLabel4 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            lblAcercaDe = new Label();
            lblGitHub1 = new LinkLabel();
            panel2 = new Panel();
            button1 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel4);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblAcercaDe);
            panel1.Controls.Add(lblGitHub1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 386);
            panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(101, 227);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(155, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/MatuqE";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(210, 330);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(101, 259);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(229, 15);
            linkLabel3.TabIndex = 8;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "https://www.linkedin.com/in/joaquin-gil/";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 259);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 7;
            label1.Text = "Linkedin:";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(101, 285);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(315, 15);
            linkLabel4.TabIndex = 6;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "https://www.linkedin.com/in/matias-federico-bordenave/";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(101, 200);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(215, 15);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://github.com/FacundoJoaquinGil";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 200);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "GitHub:";
            // 
            // lblAcercaDe
            // 
            lblAcercaDe.AutoSize = true;
            lblAcercaDe.Location = new Point(50, 50);
            lblAcercaDe.Name = "lblAcercaDe";
            lblAcercaDe.Size = new Size(404, 150);
            lblAcercaDe.TabIndex = 2;
            lblAcercaDe.Text = resources.GetString("lblAcercaDe.Text");
            // 
            // lblGitHub1
            // 
            lblGitHub1.Location = new Point(0, 0);
            lblGitHub1.Name = "lblGitHub1";
            lblGitHub1.Size = new Size(100, 23);
            lblGitHub1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(503, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 431);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(213, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 7);
            label3.Name = "label3";
            label3.Size = new Size(289, 375);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            // 
            // FormAlerta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 443);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAlerta";
            Text = "FormAcercaDe";
            Load += FormAcercaDe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAcercaDe;
        private LinkLabel lblGitHub1;
        private LinkLabel linkLabel2;
        private Label label2;
        private LinkLabel linkLabel3;
        private Label label1;
        private LinkLabel linkLabel4;
        private Button btnCerrar;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Label label3;
        private Button button1;
    }
}