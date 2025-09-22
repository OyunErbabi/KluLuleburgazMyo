using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder sb = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            sb.Append("Programlama");
            sb.Append("Dilleri");
            sb.AppendLine();
            sb.AppendLine("C#");
            sb.AppendLine("Java");
            sb.AppendLine("Asp.Net");
            sb.AppendLine("C++");
            textBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sb.Insert(20, "Python"+Environment.NewLine,3);
            textBox1.Text = sb.ToString();
        }
    }
}
