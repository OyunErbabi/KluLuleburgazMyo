using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "http://luleburgazmyo.klu.edu.tr";
            linkLabel2.Text = "lmyo@klu.edu.tr";
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "http://luleburgazmyo.klu.edu.tr");
            linkLabel2.Links.Add(0, 15, "lmyo@klu.edu.tr");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("mailto:" + e.Link.LinkData.ToString());
            System.Diagnostics.Process.Start("mailto:lmyo@klu.edu.tr?Subject= Hafta 11 Dersi Hakkinda");
            linkLabel2.LinkVisited = true;
        }
    }
}
