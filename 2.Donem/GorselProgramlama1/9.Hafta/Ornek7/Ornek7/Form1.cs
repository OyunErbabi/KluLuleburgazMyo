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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 20;
            hScrollBar1.Value = 1;
            hScrollBar1.LargeChange = 1;
        }

        Boolean son = false;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if(hScrollBar1.Value == hScrollBar1.Maximum)
            {
                son = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Basla")
            {
                button1.Text = "Dur";
                //timer1.Start();
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "Basla";
                timer1.Enabled = false;
                //timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (son == false)
            {
                label1.Text = hScrollBar1.Value.ToString();
                if(hScrollBar1.Value == 100)
                {
                    son = true;
                    return;
                }
                hScrollBar1.Value = hScrollBar1.Value + 1;
            }
            else
            {
                label1.Text = hScrollBar1.Value.ToString();
                if (hScrollBar1.Value == 1)
                {
                    son = false;
                    return;
                }
                hScrollBar1.Value = hScrollBar1.Value - 1;
            }
        }
    }
}
