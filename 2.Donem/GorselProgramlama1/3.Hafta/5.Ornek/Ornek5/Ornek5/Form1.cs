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
            //int i = 0;
            foreach (Control nesne in this.Controls)
            {
                //i++;
                if (nesne is TextBox)
                {
                    nesne.Text = "Deneme";
                    nesne.BackColor = Color.Blue;
                    nesne.ForeColor = Color.White;
                }
                else if (nesne is Label)
                {                    
                    nesne.BackColor = Color.Black;
                    nesne.ForeColor = Color.Yellow;
                }

                //nesne.Text = i.ToString();  
            }
        }
    }
}
