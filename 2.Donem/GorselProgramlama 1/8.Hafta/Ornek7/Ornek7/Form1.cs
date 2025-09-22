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
            for(byte i = 0; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        Boolean bulundu = false;
        private void button1_Click(object sender, EventArgs e)
        {
            for(byte i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == textBox1.Text)
                {
                    bulundu = true;
                    //listBox1.SetSelected(i, true);
                    listBox1.SelectedIndex= Convert.ToInt32(listBox1.Items[i]);
                    break;
                }
            }

            if (bulundu)
            {
                MessageBox.Show("Bulundu");
            }
            else
            {
                MessageBox.Show("Bulunamadı");
            }

            bulundu = false;
        }
    }
}
