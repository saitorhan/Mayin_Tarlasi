using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Mayin_Tarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 65);
            timer1.Start();
            timer2.Start();
            TarlayiHazirla();
        }
        void TarlayiHazirla()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button button_ = new Button();
                    button_.Name = "button" + i + "" + j;
                    button_.Tag = "+";
                    button_.Font = new Font(button_.Font.FontFamily, 25, FontStyle.Bold);
                    button_.ForeColor = Color.Blue;
                    button_.Size = new System.Drawing.Size(48, 48);
                    button_.Location = new Point(i * 48, j * 48);
                    button_.Image = dokumanlar.bakan_adam;
                    button_.Click += button__Click;
                    this.Controls.Add(button_);

                }

            }
            MayinYerlestir(); 
        }

        int puan = 0;

        void button__Click(object sender, EventArgs e)
        {
            
            Button tiklanan = sender as Button;
            if (tiklanan.Tag.ToString().CompareTo("+")==0)
            {
                int etraftakiMayinSayisi = EtraftakiMayinSayisi(tiklanan.Name);
                tiklanan.Text = etraftakiMayinSayisi.ToString();
                tiklanan.Image = dokumanlar.cam_icinde_gul;
                puan+=10;
                label1.Text = "Puan: " + puan;
                tiklanan.Tag = "0";
            }
            else if(tiklanan.Tag.ToString().CompareTo("-")==0)
            {
                tiklanan.Image = dokumanlar.cam_icinde_ates;
               DialogResult secim = MessageBox.Show("Oyun bittiiiiiii.....\nPuanınız: "+puan+"\nTekrar oynamak ister misan?", "Kötü haberrrr....", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               if (secim==DialogResult.No)
               {
                   Application.Exit();
               }
               else
               {
                   tiklanan.Image = dokumanlar.cam_icinde_ates;
                   Thread.Sleep(1000);
                   OyunuTekrarYukle();
               }
            }
        }

        private int EtraftakiMayinSayisi(string p)
        {
            int i = Convert.ToInt32(p.Substring(6, 1));
            int j = Convert.ToInt32(p.Substring(7, 1));
            int mayinsayisi = 0;
            if (i > 0 && j > 0 && i < 9 && j < 9)
            {
                Button tag = this.Controls["button" + (i - 1) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i + 1) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i + 1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i + 1) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i - 1) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i - 1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }
            }

            else if (i==0 && j==0)
            {
                Button tag = this.Controls["button" + (i+1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i+1) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }
            }

            else if (i == 9 && j == 0)
            {
                Button tag = this.Controls["button" + (i - 1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i - 1) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }
            }

            else if (i == 9 && j == 9)
            {
                Button tag = this.Controls["button" + (i) + "" + (j-1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i - 1) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i-1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }
            }

            else if (i == 0 && j == 9)
            {
                Button tag = this.Controls["button" + (i) + "" + (j-1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i + 1) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i+1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }
            }

            else if (i > 0 && i<9 && j == 0)
            {
                Button tag = this.Controls["button" + (i - 1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i - 1) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i+1) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i+1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }
            }

            else if (i > 0 && i < 9 && j == 9)
            {
                Button tag = this.Controls["button" + (i - 1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i - 1) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i + 1) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i + 1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }
            }

            else if (j > 0 && j<9 && i == 0)
            {
                Button tag = this.Controls["button" + (i) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i + 1) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i + 1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i+1) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }
            }

            else if (j > 0 && j < 9 && i == 9)
            {
                Button tag = this.Controls["button" + (i) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i - 1) + "" + (j - 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i - 1) + "" + (j)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i - 1) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }

                tag = this.Controls["button" + (i) + "" + (j + 1)] as Button;
                if (tag.Tag.ToString() == "-")
                {
                    mayinsayisi++;
                }
            }

            return mayinsayisi;
        }

        void OyunuTekrarYukle()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string isim = "button" + i + "" + j;
                    Button buton = this.Controls[isim] as Button;
                    this.Controls.Remove(buton);
                }
            }
            puan = 0;
            label1.Text = "Puan: 0";
            TarlayiHazirla();
        }

        static public int seviye;
        void MayinYerlestir()
        {
            Form_Zorluk form=new Form_Zorluk();

            form.ShowDialog();

            Random sayi = new Random();
            int yer;
            int i, j;
            for (int yeri = 0; yeri <= seviye; )
            {
                yer = sayi.Next(0, 99);
                i = yer / 10;
                j = yer % 10;
                string button = "button" + i + "" + j;
                if (this.Controls[button].Tag.ToString().CompareTo("-")!=0)
                {
                    yeri++;
                }
                this.Controls[button].Tag = "-";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Height<530)
            {
                this.Height += 1;
            }
            if (this.Width < 580)
            {
                this.Width += 2;
            }
            if(this.Height==530 && this.Width==580)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity<1)
            {
                this.Opacity = this.Opacity + 0.01;
            }
            else
            {
                timer2.Stop();
            }
        }

       
    }
}
