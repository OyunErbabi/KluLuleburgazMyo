using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Calisma
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + Application.StartupPath + "/sozluk.accdb");
        OleDbCommand komut;
        OleDbDataAdapter adaptor;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //"C:\Github\Other\KluLuleburgazMyo\3.Donem\Gorsel Programlama 2\Çalışma Soruları\sozluk.accdb"
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" + Application.StartupPath + "/sozluk.accdb");
            baglanti.Open();
            komut = new OleDbCommand("select * from sozcukler",baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            okuyucu.Read();

            if(okuyucu.HasRows)
            {
                //txt_english.Text = okuyucu["ingilizce"].ToString();
                //txt_english.Text = okuyucu.GetName(1);
                //txt_turkish.Text = okuyucu.GetName(2);

                //add to datagridview
                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridView1.DataSource = dt;


            }
            else
            {
                label1.Text = "Kayıt Bulunamadı";
            }

        }

        private void OnTextChanged(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            /*
            adaptor = new OleDbDataAdapter("SELECT * FROM sozcukler WHERE İngilizce LIKE '" + txt_english.Text + "%'", baglanti);
            ds = new DataSet();
            adaptor.Fill(ds,"turkce");

            dataGridView1.DataSource = ds.Tables["turkce"]; // sonuçları tabloya aktar

            */
            dataGridView1.DataSource = new OleDbDataAdapter($"SELECT * FROM sozcukler WHERE İngilizce LIKE '{txt_english.Text}%'", "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=sozluk.accdb").Fill(new DataSet(), "turkce");
            baglanti.Close();



            /*
            try
            {
                DataSet ds = new DataSet();

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                //OleDbDataAdapter adp = new OleDbDataAdapter("select * from sozcukler where ingilizce like '" + txt_english.Text + "%'", baglanti);


                string SorguTexti = "select * from sozcukler where ingilizce like '" + txt_english.Text + "%'";
                komut = new OleDbCommand(SorguTexti, baglanti);

                OleDbDataReader okuyucu = komut.ExecuteReader();

                if(okuyucu.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(okuyucu);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }

                //adaptor = new OleDbDataAdapter(komut);
                //adaptor.Fill(ds);
                //dataGridView1.DataSource = ds.Tables[0];
                //dataGridView1.DisplayeMember = "sozcukler";
                //dataGridView1.DataBindings.Add("Text", ds.Tables[0],"Turkce");
                baglanti.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
