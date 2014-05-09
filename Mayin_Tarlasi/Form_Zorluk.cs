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
    public partial class Form_Zorluk : Form
    {
        public Form_Zorluk()
        {
            InitializeComponent();
        }

        private void Form_Zorluk_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (radioButton_kolay.Checked)
            {
                Form1.seviye = 10;
            }
            else if (radioButton_orta.Checked)
            {
                Form1.seviye = 15;
            }

            else if (radioButton_zor.Checked)
            {
                Form1.seviye = 20;
            }
        }
    }
}
