﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Dosya Sec";
            openFileDialog1.Filter = "jpeg Dosyası|*.jpg|Tüm Dosyalar|*.*";
            openFileDialog1.Title = "Lütfen Bir Resim Dosyası Seçiniz";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog1.OpenFile());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Load(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Resim Bulunamadı");
            }
            
        }
    }
}
