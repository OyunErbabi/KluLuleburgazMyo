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

        private void button1_Click(object sender, EventArgs e)
        {
            //if (radioButton1.Checked) MessageBox.Show(groupBox1.Text+" "+radioButton1.Text);
            //if (radioButton2.Checked) MessageBox.Show(groupBox1.Text + " " + radioButton2.Text);
            //if (radioButton3.Checked) MessageBox.Show(groupBox2.Text + " " + radioButton3.Text);
            //if (radioButton4.Checked) MessageBox.Show(groupBox2.Text + " " + radioButton4.Text);
            //if (radioButton5.Checked) MessageBox.Show(groupBox3.Text + " " + radioButton5.Text);


            foreach (Control item in groupBox1.Controls)
            {
               
                RadioButton rdb = (RadioButton)item;
                if (rdb.Checked)
                {
                    MessageBox.Show(groupBox1.Text + " " + rdb.Text);
                }
            }
        }
    }
}
