using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, baslangic, bitis, toplam = 0;
            baslangic = Convert.ToInt32(textBox1.Text);
            bitis = Convert.ToInt32(textBox2.Text);
            for (i = baslangic; i <= bitis; i++)
            {
                toplam = toplam + i;
            }
            MessageBox.Show(""+toplam);
        }
    }
}
