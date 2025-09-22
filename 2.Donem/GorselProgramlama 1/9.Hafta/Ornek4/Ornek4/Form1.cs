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

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Panel1")
            {
                panel1.Visible = true;
                panel2.Visible = false;
                button1.Text = "Panel2";
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = true;
                button1.Text = "Panel1";
            }
        }
    }
}
