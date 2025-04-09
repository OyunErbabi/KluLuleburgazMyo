using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                dizi[i] = listBox1.Items[i].ToString();
            }
            textBox1.Text = string.Join(",", dizi);
        }
    }
}
