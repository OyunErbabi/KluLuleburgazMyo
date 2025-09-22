using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int sayi = Convert.ToInt32(comboBox1.Text);

            int i, sonuc;
            label1.Text = sayi + " Çarpım Tablosu";
            for (i = 1; i <= 10; i++)
            {
                sonuc = sayi * i;
                listBox1.Items.Add(sayi + " x " + i + " = " + sonuc);// listBox1.Items.Add(sayi.ToString() + " x " + i.ToString() + " = " + sonuc.ToString());
            }

        }
    }
}
