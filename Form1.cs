using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Hadet, Hfiyat, Radet, Rfiyat, Oadet, Ofiyat, Gadet, Gfiyat, ToplamKitapAdedi;
            double NormalFiyat, İndirimliFiyat;

            Hfiyat = 8;
            Rfiyat = 18;
            Ofiyat = 5;
            Gfiyat = 3;
            // Değişkene atanmış fiyatlar

            Hadet = Convert.ToInt32(maskedTextBox1.Text);
            Radet = Convert.ToInt32(maskedTextBox2.Text);
            Oadet = Convert.ToInt32(maskedTextBox3.Text);
            Gadet = Convert.ToInt32(maskedTextBox4.Text);
            // Adet girişlerini aldık

            ToplamKitapAdedi = Hadet + Radet + Oadet + Gadet;
            NormalFiyat = Hadet * Hfiyat + Radet * Rfiyat + Oadet * Ofiyat + Gadet * Gfiyat;
            label18.Text = "İndirimsiz ödenecek tutar :" + NormalFiyat;
            // Normalde ödenecek fiyatı bulduk

            if (ToplamKitapAdedi <= 20 && ToplamKitapAdedi>0) //toplam adet yirmiden küçük veya eşitse
            {
                İndirimliFiyat = (NormalFiyat / 100) * 80; // %20 indirim
                label19.Text = "İndirimle ödenecek tutar :" + İndirimliFiyat;
            }
            if (ToplamKitapAdedi >= 21 && ToplamKitapAdedi <= 40 )
            {
                İndirimliFiyat = (NormalFiyat / 100) * 60; // %40 indirim
                label19.Text = "İndirimle ödenecek tutar :" + İndirimliFiyat;
            }
            if (ToplamKitapAdedi >= 41)
            {
                İndirimliFiyat = (NormalFiyat / 100) * 50; // %40 indirim
                label19.Text = "İndirimle ödenecek tutar :" + İndirimliFiyat;
            }
            
        }
    }
}
