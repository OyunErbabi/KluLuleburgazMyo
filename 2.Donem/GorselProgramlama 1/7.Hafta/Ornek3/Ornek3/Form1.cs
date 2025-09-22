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
            byte i;
            string[] yazi;
            yazi = textBox1.Text.Split(Convert.ToChar(textBox2.Text));
            listBox1.Items.Clear();
            for (i = 0; i < yazi.Length; i++)
            {
                listBox1.Items.Add(yazi[i]);
            }
        }
    }
}
