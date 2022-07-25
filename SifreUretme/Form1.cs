using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        bool kucukHarfVarMi;
        bool buyukHarfVarMi;
        bool rakamVarMi;
        bool ozelKarakterVarMi;
        int sifreUzunlugu, sifreSayisi;


        private void btnUret_Click(object sender, EventArgs e)
        {
            kucukHarfVarMi = cbxKucukHarf.Checked;
            buyukHarfVarMi = cbxBuyukHarf.Checked;
            rakamVarMi = cbxRakam.Checked;
            ozelKarakterVarMi = cbxSembol.Checked;

            sifreUzunlugu = (int)nudSifreUzunlugu.Value;
            sifreSayisi = (int)nudSifreAdedi.Value;
            textBox1.Text = "";

            if(!kucukHarfVarMi || !buyukHarfVarMi || !rakamVarMi || !ozelKarakterVarMi)
            {
                MessageBox.Show("Lutfen bir parametre seçiniz.");
            }
            string secilenKarakterler = "";
            if (ozelKarakterVarMi)
            {
                for(int i = 33; i < 48; i++)
                {
                    secilenKarakterler+=Convert.ToChar(i);
                }
                for (int i = 58; i < 65; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 91; i < 97; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
                for (int i = 123; i < 127; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }

            }
            if (rakamVarMi)
            {
                for (int i = 48; i < 58; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (buyukHarfVarMi)
            {
                for (int i = 65; i < 91; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
            if (kucukHarfVarMi)
            {
                for (int i = 97; i < 123; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);

                }
            }
            for (int i = 0; i < sifreSayisi; i++)
            {
                string sifre = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sifre += secilenKarakterler[rnd.Next(secilenKarakterler.Length)];
                }
                textBox1.Text += sifre;
                textBox1.Text += "\r\n\r\n";
            }

            //if (cbxBuyukHarf.Checked && !cbxKucukHarf.Checked && !cbxRakam.Checked && !cbxSembol.Checked)
            //{
            //    do
            //    {
            //        for (int i = 0; i < nudSifreUzunlugu.Value; i++)
            //        {
            //            sifre += Convert.ToChar(rnd.Next(65, 91));
            //        }
            //        sayac++;
            //        MessageBox.Show(sifre);
            //    } while (nudSifreAdedi.Value >= sayac);
            //    
            //}
        }
    }
}
