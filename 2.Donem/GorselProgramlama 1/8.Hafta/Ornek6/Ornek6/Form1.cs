using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(byte i = 0; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    comboBox1.Items.Add(i);
                }
            }
            label1.Text = comboBox1.Items.Count+ " adet çift sayı eklendi.";
             comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Seçilen sayı: " + comboBox1.SelectedItem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(0, -1);
            label1.Text = comboBox1.Items.Count + " adet çift sayı eklendi.";
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            label1.Text = comboBox1.Items.Count + " adet eleman var.";
            label2.Text = "Eleman Yok";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > 0)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
            else
            {
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }
    }
}
