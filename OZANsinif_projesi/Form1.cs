using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OZANsinif_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int sinav1, sinav2, sinav3, ort;
        int sayac = 0;
        

       
        private void btnCizgi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("---------------------------");

        }
          
        private void button4_Click(object sender, EventArgs e)
        {
            
          
            sayac++;
            lblsayac.Text=sayac.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtDurum.Clear();
            txtOrt.Clear();
            txtSinav1.Clear();
            txtSinav2.Clear();
            txtSinav3.Clear();
            maskedTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
            txtAdSoyad.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMesajKutusu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ss :","Mesaj Kutusu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void btnForDongusu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                listBox2.Items.Add(i +  " sa");
            }
        }

        private void btnForDongusu2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    listBox2.Items.Add(i);
                }
                
            }
        }

        private void btnListBoxTemizle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int x = 0;
                while (x <10)
                {
                listBox2.Items.Add(x +" -While Döngüsü");
                x++;
                }
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "adana", "ankara", "antalya", "ardahan", "afyon" };
            txtAdSoyad.Text = sehirler[0];
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 34, 66, 87, 32, 98, 104, 327, 78 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    listBox2.Items.Add  ((int)sayilar[i]);
            //}
            foreach (var k in sayilar)
            {
                if (k %4==0)
                {
                    listBox2.Items.Add(k);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDurum.Text !="" && txtOrt.Text != "" )
            {
                string adsoyad, ders, numara;
            adsoyad=txtAdSoyad.Text;
            ders = comboBox1.Text;
            numara = maskedTextBox1.Text;
            listBox1.Items.Add(adsoyad+ " " + ders+ " Numara      ;" 
                + numara +"Ortalama       ; " + txtOrt.Text+ "Durum      ; " + txtDurum.Text);
                sayac++;
                lblsayac.Text = "kaydedilen öğrenci sayısı :"+sayac;
            }
            
            else
            {
                 MessageBox.Show("Lütfen ORtalama ve Durum değerlerini hesaplatınız",
                    "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string durum;

        private void button2_Click(object sender, EventArgs e)
        {
            sinav1 = Convert.ToInt32(txtSinav1.Text);
            sinav2 = Convert.ToInt32(txtSinav2.Text);
            sinav3 = Convert.ToInt32(txtSinav3.Text);
            ort = (sinav1 + sinav2 + sinav3) / 3;
            txtOrt.Text = ort.ToString();
            if (ort>=50)
            {
                durum = "Geçti";

            }
            else
            {
                durum = "Kaldı";
            }
            txtDurum.Text= durum;
        }
    }
}
