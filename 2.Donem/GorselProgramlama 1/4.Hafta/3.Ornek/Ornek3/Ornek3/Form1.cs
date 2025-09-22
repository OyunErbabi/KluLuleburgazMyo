using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, sayi,kontrol=0;

            sayi = Convert.ToInt32(textBox1.Text);

            for (i = 2; i <= sayi-1; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }

            if (kontrol == 0)
            {
                MessageBox.Show("Sayı Asaldır");
            }
            else
            {
                MessageBox.Show("Sayı Asal Değildir "+ i +" Sayisina Bölünür");
            }

        }
    }
}
