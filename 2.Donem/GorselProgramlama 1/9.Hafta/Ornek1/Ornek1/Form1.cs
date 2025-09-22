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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Font = checkBox1.Checked ? new Font(textBox1.Font, FontStyle.Bold) : new Font(textBox1.Font, FontStyle.Regular);
            textBox1.Font = new Font(textBox1.Font.Name,textBox1.Font.Size,textBox1.Font.Style^FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Underline);
        }
    }
}
