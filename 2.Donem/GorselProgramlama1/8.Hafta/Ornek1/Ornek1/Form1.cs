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

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            this.Controls.Add(label1);
            label1.Text = "Luleburgaz Meslek Yüksekokulu\n Bilgisayar Programcılığı";
            label1.Font = new Font("Comic Sans MS", 20, FontStyle.Italic);
            label1.ForeColor = Color.DarkBlue;
            label1.AutoSize = true;
        }
    }
}
