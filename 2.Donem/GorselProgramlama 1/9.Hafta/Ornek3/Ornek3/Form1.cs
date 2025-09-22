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

        private void Form1_Load(object sender, EventArgs e)
        {
            GroupBox groupBox1 = new GroupBox();
            groupBox1.Text = "Ornek Uygulama";

            Label label1 = new Label();
            label1.Location = new Point(10, 30);
            label1.Text = "Bölümünüz :";
            label1.AutoSize = true;

            TextBox textBox1 = new TextBox();
            textBox1.Text = "Bilgisayar Programcılığı";
            textBox1.Size = new Size(130, 30);
            textBox1.Location = new Point(90, 25);

            Controls.Add(groupBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(20, 20);
            groupBox1.AutoSize = true;

        }
    }
}
