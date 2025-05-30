using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMecanica
{
    public partial class FormAlerta : Form
    {
        private string tipoContenido;
        public FormAlerta(string tipo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tipoContenido = tipo;
        }
        private void FormAcercaDe_Load(object sender, EventArgs e)
        {
            if (tipoContenido == "sobre")
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel1.Dock = DockStyle.Fill;
                this.Size = new Size(560, 630);
            }
            else if (tipoContenido == "comandos")
            {
                panel2.Visible = true;
                panel1.Visible = false;
                panel2.Dock = DockStyle.Fill;
                this.Size = new Size(650, 630);
            }
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCerrar_Click_1(sender, e); // Tu lógica de volver
                e.Handled = true;
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/matias-federico-bordenave-221986251/",
                UseShellExecute = true
            });
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/joaqu%C3%ADn-gil/",
                UseShellExecute = true
            });
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/FacundoJoaquinGil",
                UseShellExecute = true
            });
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/MatuqE",
                UseShellExecute = true
            });
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
