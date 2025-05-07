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
            char[] dizi=textBox1.Text.ToCharArray();
            Array.Reverse(dizi);
            string tersi = new string(dizi);
            textBox2.Text = tersi;
        }
    }
}
