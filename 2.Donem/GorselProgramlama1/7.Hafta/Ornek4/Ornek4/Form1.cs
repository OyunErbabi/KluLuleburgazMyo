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
            //int arama = textBox1.Text.IndexOf(textBox2.Text); // ilk bulduğu yeri verir
            int arama = textBox1.Text.LastIndexOf(textBox2.Text); // son bulduğu yeri verir

            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen aramak istediğiniz kelimeyi ve arama kelimesini giriniz.");
                
            }
            else if (arama == -1)
            {
                MessageBox.Show("Aradığınız kelime bulunamadı.");
            }
            else
            {
                textBox1.SelectionStart = arama;
                textBox1.SelectionLength = textBox2.Text.Length;
                textBox1.Focus();
                MessageBox.Show("Aradığınız kelime bulundu. Konumu: "+arama);
            }
        }
    }
}
