using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                return;
            }
            //else
            //{
            //    int index = listBox1.IndexFromPoint(e.Location);
            //    if (index != -1)
            //    {
            //        listBox1.SelectedIndex = index;
            //        listBox1.DoDragDrop(listBox1.Items[index], DragDropEffects.Move);
            //    }
            //}

            string deger= listBox1.Items[listBox1.IndexFromPoint(e.X,e.Y)].ToString();

            if(DoDragDrop(deger, DragDropEffects.All)==DragDropEffects.All)
            {
                listBox1.Items.RemoveAt(listBox1.IndexFromPoint(e.X, e.Y));
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                listBox2.Items.Add(e.Data.GetData(DataFormats.StringFormat));
            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
