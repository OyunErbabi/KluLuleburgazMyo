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
            if(textBox1.SelectionLength > 0)
            {
                textBox1.Cut();
            }
            else
            {
                MessageBox.Show("Secili alan yok.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
            else
            {
                MessageBox.Show("Secili alan yok.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Font, FontStyle.Bold);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Font, FontStyle.Italic);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(Font, FontStyle.Underline);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        Color renk;
        private void Form1_Load(object sender, EventArgs e)
        {
            renk = button1.BackColor;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = renk;
        }
    }
}
