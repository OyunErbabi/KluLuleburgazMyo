using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ornek_8;

namespace Ornek_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 nesne = new Class1();

        private void Form1_Load(object sender, EventArgs e)
        {
            nesne.pasif(true, button2, button3, button4, button5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nesne.pasif(false, button2, button5);
            nesne.pasif(true, button1, button3, button4);
        }
    }
}
