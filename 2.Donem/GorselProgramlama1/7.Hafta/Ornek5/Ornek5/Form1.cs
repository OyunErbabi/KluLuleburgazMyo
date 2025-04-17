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

        private void button1_Click(object sender, EventArgs e)
        {
            int pozisyon, uzunluk;
            string cumle, cekilen;
            cumle = textBox1.Text;
            pozisyon = textBox1.Text.IndexOf(".")+1;
            uzunluk = cumle.Length - pozisyon;

            cekilen = cumle.Substring(pozisyon, uzunluk);
            MessageBox.Show(cekilen);
        }
    }
}
