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
            //textbox1 içindeki ilk parametrede bulunan ifadeyi ikinci parametredeki ifadeyle değiştirir.
            textBox1.Text = textBox1.Text.Replace(textBox2.Text, textBox3.Text);
        }
    }
}
