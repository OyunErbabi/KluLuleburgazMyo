﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                MessageBox.Show("Yükleme Tamamlandı");
                this.Close();
            }
            else
            {
                progressBar1.Value += 1;
                if (progressBar1.Value == 100)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Yükleme Tamamlandı");
                    this.Close();
                }
            }
        }
    }
}
