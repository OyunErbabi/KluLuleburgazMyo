using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                int enbuyuk = Convert.ToInt32(listBox1.Items[0]);
                foreach (int sayi in listBox1.Items)
                {
                    if (sayi > enbuyuk)
                    {
                        enbuyuk = sayi;
                    }
                }
                textBox1.Text = enbuyuk.ToString();
            }
            else
            {
                MessageBox.Show("Listede eleman yok.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j, gecici;
            if(listBox1.Items.Count > 0)
            {
                if(radioButton1.Checked == true)
                {
                    for(i = 0; i <= listBox1.Items.Count-1; i++)
                    {
                        for (j = i; j <= listBox1.Items.Count-1; j++)
                        {
                            if(Convert.ToInt32(listBox1.Items[i]) > Convert.ToInt32(listBox1.Items[j]))
                            {
                                gecici = Convert.ToInt32(listBox1.Items[i]);
                                listBox1.Items[i] = listBox1.Items[j];
                                listBox1.Items[j] = gecici;
                            }
                        }
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    for (i = 0; i <= listBox1.Items.Count - 1; i++)
                    {
                        for (j = i; j <= listBox1.Items.Count - 1; j++)
                        {
                            if (Convert.ToInt32(listBox1.Items[i]) < Convert.ToInt32(listBox1.Items[j]))
                            {
                                gecici = Convert.ToInt32(listBox1.Items[i]);
                                listBox1.Items[i] = listBox1.Items[j];
                                listBox1.Items[j] = gecici;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Listede eleman yok.");
            }
        }
    }
}
