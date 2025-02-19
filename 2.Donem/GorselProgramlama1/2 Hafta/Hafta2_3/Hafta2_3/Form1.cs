using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "Mavi":
                    this.BackColor = Color.Blue;
                    break;
                case "Sari":
                    this.BackColor = Color.Yellow;
                    break;
                case "Siyah":
                    this.BackColor = Color.Black;
                    break;
                case "Kirmizi":
                    this.BackColor = Color.Red;
                    break;
                case "Yesil":
                    this.BackColor = Color.Green;
                    break;
                case "Mor":
                    this.BackColor = Color.Purple;
                    break;
            }
        }
    }
}
