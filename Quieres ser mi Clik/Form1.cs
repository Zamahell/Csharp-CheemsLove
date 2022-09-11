using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quieres_ser_mi_Clik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            panel2.Hide();
            btnSi.TabStop = false;
            btnNo.TabStop = false;
        }
        public void MoverBoton() 
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btnNo.Width);
            int y = r.Next(0, this.Height - btnNo.Height);
            btnNo.Location = new Point(x, y);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if(btnNo.Location == btnSi.Location || btnNo.Location == label1.Location) 
            {
                MoverBoton();
            }
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string text = "PD: VAMOS A TOMAR <3";
            MessageBox.Show(text);
            Application.Exit();
        }
    }
}
