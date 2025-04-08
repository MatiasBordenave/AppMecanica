namespace AppMecanica
{
    partial class PresupuestoGenerado
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
            btnImprimir = new Button();
            btnImg = new Button();
            btnVolverGenerado = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.MediumTurquoise;
            btnImprimir.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(660, 586);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(116, 50);
            btnImprimir.TabIndex = 39;
            btnImprimir.Text = "Imprimir Presupuesto";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnImg
            // 
            btnImg.BackColor = Color.LimeGreen;
            btnImg.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImg.ForeColor = Color.White;
            btnImg.Location = new Point(801, 586);
            btnImg.Margin = new Padding(3, 2, 3, 2);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(116, 50);
            btnImg.TabIndex = 40;
            btnImg.Text = "Guardar Imagen";
            btnImg.UseVisualStyleBackColor = false;
            btnImg.Click += btnImg_Click;
            // 
            // btnVolverGenerado
            // 
            btnVolverGenerado.BackColor = Color.Ivory;
            btnVolverGenerado.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverGenerado.ForeColor = Color.Black;
            btnVolverGenerado.Location = new Point(939, 586);
            btnVolverGenerado.Margin = new Padding(3, 2, 3, 2);
            btnVolverGenerado.Name = "btnVolverGenerado";
            btnVolverGenerado.Size = new Size(116, 50);
            btnVolverGenerado.TabIndex = 41;
            btnVolverGenerado.Text = "Volver";
            btnVolverGenerado.UseVisualStyleBackColor = false;
            btnVolverGenerado.Click += btnVolverGenerado_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(398, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(140, 30);
            lblTitulo.TabIndex = 42;
            lblTitulo.Text = "Presupuesto ";
            // 
            // PresupuestoGenerado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1084, 661);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolverGenerado);
            Controls.Add(btnImg);
            Controls.Add(btnImprimir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PresupuestoGenerado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PresupuestoGenerado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private Button btnImg;
        private Button btnVolverGenerado;
        private Label lblTitulo;
    }
}