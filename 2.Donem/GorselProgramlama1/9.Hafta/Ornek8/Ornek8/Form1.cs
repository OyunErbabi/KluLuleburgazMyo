﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 saniye
            timer1.Start(); // Timer'ı başlat
            label1.Text = DateTime.Now.ToString("HH:mm:ss"); // Başlangıçta label'ı güncelle
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss"); // Label'ı güncelle
        }
    }
}
