using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder sb = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            sb.AppendLine("C#");
            sb.AppendLine("Java");
            sb.AppendLine("Asp.Net");
            sb.AppendLine("C++");
            textBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sb.Clear();
            textBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sb.Remove(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox1.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sb.Replace(textBox4.Text, textBox5.Text);
            textBox1.Text = sb.ToString();
        }
    }
}
