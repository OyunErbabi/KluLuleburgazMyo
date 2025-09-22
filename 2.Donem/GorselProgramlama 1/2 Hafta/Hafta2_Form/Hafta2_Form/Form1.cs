using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta2_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final;
            double ortalama;
            vize = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            ortalama = (vize * 0.4) + (final * 0.6);
            if (ortalama <= 41)
            {
                MessageBox.Show("Ortalamaniz : "+ ortalama + "- Harf Notu : FF");
            }
            else if (ortalama <= 44)
            {
                MessageBox.Show("Ortalamaniz : " + ortalama + "- Harf Notu : DD");
            }
            else if(ortalama <=49)
            {
                MessageBox.Show("Ortalamaniz : " + ortalama + "- Harf Notu : DC");
            }
            else if(ortalama<=54)
            {
                MessageBox.Show("Ortalamaniz : " + ortalama + "- Harf Notu : CC");
            }
            else if (ortalama <= 59)
            {
                MessageBox.Show("Ortalamaniz : " + ortalama + "- Harf Notu : CB");
            }
            else if (ortalama <= 69)
            {
                MessageBox.Show("Ortalamaniz : " + ortalama + "- Harf Notu : BB");
            }
            else if (ortalama <= 79)
            {
                MessageBox.Show("Ortalamaniz : " + ortalama + "- Harf Notu : BA");
            }
            else if (ortalama <= 100)
            {
                MessageBox.Show("Ortalamaniz : " + ortalama + "- Harf Notu : AA");
            }

        }
    }
}
