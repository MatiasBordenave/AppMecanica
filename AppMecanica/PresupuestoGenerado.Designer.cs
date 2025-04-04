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
            btnVolver = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.MediumTurquoise;
            btnImprimir.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(660, 499);
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
            btnImg.Location = new Point(801, 499);
            btnImg.Margin = new Padding(3, 2, 3, 2);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(116, 50);
            btnImg.TabIndex = 40;
            btnImg.Text = "Guardar Imagen";
            btnImg.UseVisualStyleBackColor = false;
            btnImg.Click += btnImg_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Ivory;
            btnVolver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Black;
            btnVolver.Location = new Point(939, 499);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 50);
            btnVolver.TabIndex = 41;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 19);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 42;
            label1.Text = "Presupuesto (Fecha)";
            // 
            // PresupuestoGenerado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 560);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnImg);
            Controls.Add(btnImprimir);
            Name = "PresupuestoGenerado";
            Text = "PresupuestoGenerado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private Button btnImg;
        private Button btnVolver;
        private Label label1;
    }
}