using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek11
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
            sb.AppendFormat("{0:C}",250);
            sb.AppendLine();
            sb.AppendFormat("{0:hh:mm:ss}", DateTime.Now);
            sb.AppendLine();
            sb.AppendFormat("{0:HH:mm:ss}", DateTime.Now);
            sb.AppendLine();
            sb.AppendFormat("{0:dd.MM.yyyy}", DateTime.Now);
            sb.AppendLine();
            sb.AppendFormat("{0:dd.MMM.yyyy}", DateTime.Now);
            sb.AppendLine();
            sb.AppendFormat("{0:dd.MMMM.yyyy}", DateTime.Now);
            sb.AppendLine();
            sb.AppendFormat("{0:HH:mm:ss dd.MM.yyyy}", DateTime.Now);

            textBox1.AppendText(sb.ToString());// textBox1.Text = sb.ToString();

        }
    }
}
