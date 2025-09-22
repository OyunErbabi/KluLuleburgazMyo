using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte i;
            bool kontrol = false;

            for (i = 0; i <= comboBox1.Items.Count-1; i++)
            {
                if (Convert.ToInt32(comboBox1.Items[i]) == Convert.ToInt32(textBox2.Text))
                {
                    kontrol = true;
                    comboBox1.SelectedIndex = i;
                    break;
                }
            }

            if(kontrol == true) //if(kontrol) şeklinde de yazılabilir.
            {
                MessageBox.Show("Aranan sayı "+(i+1)+ ".sırada bulunmaktadır.");
            }
            else
            {
                MessageBox.Show("Aranan sayı listede bulunmamaktadır.");
            }
        }


    }
}
