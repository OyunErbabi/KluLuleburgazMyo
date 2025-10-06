using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");
        OleDbCommand komut = new OleDbCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            try
            {
                komut = new OleDbCommand("SELECT * FROM sifreler Where k_adi ='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'", baglanti);
                //komut = new OleDbCommand(string.Format("SELECT * FROM sifreler WHERE k_adi=\"{0}\" AND sifre=\"{1}\"",textBox1.Text,textBox2.Text),baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();

                if (okuyucu.Read())
                {
                    MessageBox.Show("Merhaba"+ okuyucu["ad"]+" " + okuyucu["soyad"]+" Girisiniz Onaylanmistir");
                    baglanti.Close();
                    this.Hide();
                    Form2 frm = new Form2();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanici Adi ya da Sifre HATALI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
            }


        }
    }
}
