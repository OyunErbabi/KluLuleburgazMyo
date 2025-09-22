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
            string cumcle = textBox1.Text;
            char karakter = Convert.ToChar(textBox2.Text);

            int adet = 0, i;

            for (i = 0; i < cumcle.Length; i++)
            {
                if (cumcle[i] == karakter)
                {
                    adet++;
                }
            }

            MessageBox.Show(karakter+ " karakterinden " + adet + " adet bulunmaktadır.");
        }
    }
}
