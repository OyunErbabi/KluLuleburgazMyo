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

        byte NotHesapla(byte sinavnotu)
        {
            byte puan = 0;
            if (sinavnotu < 45)
            {
                puan = 1;
            }
            else if (sinavnotu < 55)
            {
                puan = 2;
            }
            else if (sinavnotu < 70)
            {
                puan = 3;
            }
            else if (sinavnotu < 85)
            {
                puan = 4;
            }
            else if (sinavnotu <= 100)
            {
                puan = 5;
            }
            else
            {
                MessageBox.Show("Not 0-100 arasında olmalıdır.");                
            }

            return puan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte notdegeri, sonuc = 0;
            notdegeri = Convert.ToByte(textBox1.Text);

            sonuc = NotHesapla(notdegeri);

            MessageBox.Show("Puaniniz: " + sonuc);
        }
    }
}
