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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adaptor = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private void Form2_Load(object sender, EventArgs e)
        {
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            try
            {
                komut = new OleDbCommand("SELECT * FROM sozcukler", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if(okuyucu.Read())
                {
                    textBox1.Text = okuyucu["ingilizce"].ToString();
                    textBox2.Text = okuyucu.GetString(2).ToString();
                }
                adaptor.SelectCommand = new OleDbCommand("SELECT ingilizce,turkce FROM sozcukler", baglanti);
                adaptor.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                komut = new OleDbCommand("SELECT COUNT(*) FROM sozcukler", baglanti);
                label3.Text = "Veri tabanında " + komut.ExecuteScalar().ToString() + " tane kelime var";
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! " + ex.Message);
                baglanti.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            komut = new OleDbCommand("INSERT INTO sozcukler(ingilizce,turkce) VALUES('"+textBox1.Text+"','"+textBox2.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            ds.Clear();
            adaptor.SelectCommand = new OleDbCommand("SELECT ingilizce,turkce FROM sozcukler", baglanti);
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("Kayıt Eklendi!");
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            komut = new OleDbCommand("UPDATE sozcukler SET turkce='"+textBox2.Text+"'WHERE ingilizce ='"+textBox1.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            ds.Clear();
            adaptor.SelectCommand = new OleDbCommand("SELECT ingilizce,turkce FROM sozcukler", baglanti);
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("Kayıt Guncellendi!");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            komut = new OleDbCommand("DELETE FROM sozcukler WHERE ingilizce='"+textBox1.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            ds.Clear();
            adaptor.SelectCommand = new OleDbCommand("SELECT ingilizce,turkce FROM sozcukler", baglanti);
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("Kayıt Silindi!");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satirno = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[satirno].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satirno].Cells[1].Value.ToString();
        }
    }
}
