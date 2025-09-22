using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.SelectionLength > 0)
            {
                textBox1.SelectedText = textBox1.SelectedText.ToUpper();
            }
            else
            {
                textBox1.Text = textBox1.Text.ToUpper();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.SelectionLength > 0)
            {
                textBox1.SelectedText = textBox1.SelectedText.ToLower();
            }
            else
            {
                textBox1.Text = textBox1.Text.ToLower();
            }
        }
    }
}
