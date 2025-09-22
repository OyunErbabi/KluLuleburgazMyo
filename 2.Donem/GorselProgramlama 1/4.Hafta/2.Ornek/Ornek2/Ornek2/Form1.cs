using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            int i, j, k;
            for (i = 0; i <= 9; i++)
            {
                textBox1.Text = i.ToString();
                textBox1.Refresh();

                for(j = 0; j <= 9; j++)
                {
                    textBox2.Text = j.ToString();
                    textBox2.Refresh();                    

                    for (k = 0; k <= 9; k++)
                    {
                        textBox3.Text = k.ToString();
                        textBox3.Refresh();
                        Thread.Sleep(10);
                    }
                }
            }
        }
    }
}
