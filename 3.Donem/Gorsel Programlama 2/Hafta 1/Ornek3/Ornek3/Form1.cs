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

        void PasifYap(bool onay,params Button[] btn)
        {

            byte i = 0;
            if(onay==true)
            {
                for(i=0;i<btn.Length;i++)
                {
                    btn[i].Enabled = false;
                }
            }
            else
            {
                for (i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = true;
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasifYap(true, button2, button3, button4,button5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasifYap(false, button2, button5);
            PasifYap(true, button1, button3, button4);
        }
    }
}
