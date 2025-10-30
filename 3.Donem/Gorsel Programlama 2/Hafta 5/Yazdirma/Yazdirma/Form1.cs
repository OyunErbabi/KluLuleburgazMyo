using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog resimac = new OpenFileDialog();
        PageSetupDialog sayfaayari = new PageSetupDialog();
        PrintDialog yaziciayar = new PrintDialog();
        PrintPreviewDialog onizleme = new PrintPreviewDialog();
        private void Form1_Load(object sender, EventArgs e)
        {
            resimac.FileName = "Dosya Sec";
            //resimac.Filter = "Resim Dosyalari |*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            resimac.Filter = "jpeg dosyalari(*.jpg)|*.jpg;*.jpeg|bmp dosyalari(*.bmp)|*.bmp";
            resimac.Title = "Resim Dosyasi Seciniz";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button_resimac_Click(object sender, EventArgs e)
        {
            if(resimac.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(resimac.OpenFile());
            }
        }

        private void button_onizleme_Click(object sender, EventArgs e)
        {
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
        }

        private void button_sayfayarlari_Click(object sender, EventArgs e)
        {
            sayfaayari.Document = printDocument1;
            sayfaayari.ShowDialog();
        }

        private void button_yaziciayarlari_Click(object sender, EventArgs e)
        {
            yaziciayar.Document = printDocument1;
            if(yaziciayar.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button_yazdir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font1 = new Font("Times New Roman", 24, FontStyle.Underline);
            Font font2 = new Font("Times New Roman", 12, FontStyle.Regular);

            //e.Graphics.DrawString(this.Text, font1,Brushes.Black, 200,50);
            e.Graphics.DrawString("Personel Bilgileri", font1, Brushes.Black, 200, 50);
            e.Graphics.DrawLine(Pens.Black, 180,40,480,40);
            e.Graphics.DrawLine(Pens.Black, 180, 100, 480, 100);
            e.Graphics.DrawString("Personelin " + label_ad.Text+textBox_Ad.Text, font2, Brushes.Black, 50, 130);
            e.Graphics.DrawString("Personelin " + label_soyad.Text + textBox_Soyad.Text, font2, Brushes.Black, 50, 160);
            e.Graphics.DrawString("Personelin " + label_birim.Text + textBox_birim.Text, font2, Brushes.Black, 50, 190);
            e.Graphics.DrawString("Personelin " + label_telefon.Text + textBox_telefon.Text, font2, Brushes.Black, 50, 220);
            e.Graphics.DrawString("Personelin " + label_eposta.Text + textBox_eposta.Text, font2, Brushes.Black, 50, 250);
            e.Graphics.DrawImage(pictureBox1.Image, 580, 110,130,130);


        }
    }
}
