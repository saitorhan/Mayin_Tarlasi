using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mayin_Tarlasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string isim = "Sait ORHAN";

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prg.Value<300)
            {
                prg.Value++;
                label1.Visible = !label1.Visible;
                if (prg.Value%30==0)
                {
                    Form1.ActiveForm.Text += isim[prg.Value / 30 - 1];
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.ActiveForm.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100,0);
            timer1.Start();
        }
    }
}
