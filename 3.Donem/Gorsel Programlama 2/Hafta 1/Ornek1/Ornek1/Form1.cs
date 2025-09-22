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
            try
            {
                int bolunen, bolen, sonuc = 0;
                bolunen = Convert.ToInt32(textBox1.Text);
                bolen = Convert.ToInt32(textBox2.Text);
                sonuc = bolunen / bolen;
                textBox3.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu :"+ex.Message);
                MessageBox.Show(ex.ToString());

            }
        }

    }
}
