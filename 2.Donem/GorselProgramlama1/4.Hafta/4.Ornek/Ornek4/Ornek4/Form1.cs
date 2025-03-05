using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string sifrelimetin = "";

            int i;


            for (i = 0; i <= metin.Length-1; i++)
            {
                //sifrelimetin += (char)(metin[i] + 18);
                sifrelimetin = sifrelimetin+ Convert.ToChar(Convert.ToInt32(metin[i]+18)%255);
            }

            textBox2.Text = sifrelimetin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = textBox2.Text;
            string sifrelimetin = "";

            int i;


            for (i = 0; i <= metin.Length - 1; i++)
            {
                if(Convert.ToInt32(metin[i] - 18) < 0)
                {
                    sifrelimetin = sifrelimetin + Convert.ToChar(Convert.ToInt32(metin[i] - 18) + 255);
                }
                else
                {
                    sifrelimetin = sifrelimetin + Convert.ToChar(Convert.ToInt32(metin[i] - 18) % 255);
                }
            }

            textBox3.Text = sifrelimetin;
        }
    }
}
