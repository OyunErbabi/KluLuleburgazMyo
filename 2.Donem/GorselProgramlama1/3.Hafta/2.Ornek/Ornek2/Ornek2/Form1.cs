using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, sayi, fakt = 1;
            sayi = Convert.ToInt32(textBox1.Text);
            for (i = sayi; i >= 1; i--)
            {
                fakt = fakt * i;
            }
            textBox3.Text = fakt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, taban, us, sonuc = 1;
            taban = Convert.ToInt32(textBox1.Text);
            us = Convert.ToInt32(textBox2.Text);

            for (i = 1; i <= us; i++)
            {
                sonuc = sonuc * taban;
            }

            textBox4.Text = sonuc.ToString();
        }
    }
}
