using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //void RenkDegistir()
        //{
        //    foreach(Control nesne in this.Controls)
        //    {
        //        if (nesne is TextBox)
        //        {
        //            nesne.Text = "Deneme";
        //            nesne.BackColor = Color.Blue;
        //            nesne.ForeColor = Color.Yellow;
        //        }
        //    }
        //}

        //void RenkDegistir(Control nesne)
        //{
        //    if (nesne is TextBox)
        //    {
        //        nesne.Text = "Deneme";
        //        nesne.BackColor = Color.Blue;
        //        nesne.ForeColor = Color.Yellow;
        //    }
        //    else if(nesne is Label)
        //    {
        //        nesne.Text = "Ornek";
        //        nesne.BackColor = Color.Yellow;
        //        nesne.ForeColor = Color.Black;
        //    }

        //}

        void RenkDegistir(Control nesne, string yazi ="Ornek Deger",Boolean egikmi = false)
        {
            if (nesne is TextBox)
            {                
                nesne.BackColor = Color.Blue;
                nesne.ForeColor = Color.Yellow;
            }
            else if (nesne is Label)
            {                
                nesne.BackColor = Color.Yellow;
                nesne.ForeColor = Color.Black;
            }
            nesne.Text = yazi;

            if (egikmi==true)
            {
                nesne.Font = new Font(nesne.Font, FontStyle.Italic);
            }
            else
            {
                nesne.Font = new Font(nesne.Font, FontStyle.Regular);
            }
                        
            //nesne.Font = egikmi ? new Font(nesne.Font, FontStyle.Italic) : new Font(nesne.Font, FontStyle.Regular);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Metod Cagirilmadan Once");
            //RenkDegistir();            
            //MessageBox.Show("Metodtan sonda");

            //RenkDegistir(textBox1);
            //RenkDegistir(label1);

            RenkDegistir(textBox1);
            RenkDegistir(label1,"Adi Soyadi");
            RenkDegistir(textBox2, egikmi:true);
            RenkDegistir(textBox3, "Ozcan Eken", true);
        }

    }
}
