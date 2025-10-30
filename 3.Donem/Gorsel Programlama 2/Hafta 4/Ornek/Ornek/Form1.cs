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

namespace Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"/sozluk.accdb");

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        //        OleDbDataAdapter adp = new OleDbDataAdapter("Select * From sozcukler", baglanti);
        //        adp.Fill(ds, "sozcukler");
        //        listsonuc.DataSource = ds.Tables[0];
        //        listsonuc.DisplayMember = "ingilizce";
        //        txtsonuc.DataBindings.Clear();
        //        txtsonuc.DataBindings.Add("text", ds.Tables[0], "turkce");
        //        baglanti.Close();
        //        listsonuc.SelectedIndex = 0;
        //        txt_ing.Text = listsonuc.Text;
        //        txt_turk.Text = txtsonuc.Text;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("sozcukler");

                
                dt.Columns.Add("ingilizce", typeof(string));
                dt.Columns.Add("turkce", typeof(string));

                
                OleDbCommand komut = new OleDbCommand("SELECT * FROM sozcukler", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();

                
                while (okuyucu.Read())
                {
                    DataRow satir = dt.NewRow();
                    satir["ingilizce"] = okuyucu["ingilizce"].ToString();
                    satir["turkce"] = okuyucu["turkce"].ToString();
                    dt.Rows.Add(satir);
                }

                
                ds.Tables.Add(dt);

                
                listsonuc.DataSource = ds.Tables["sozcukler"];
                listsonuc.DisplayMember = "ingilizce";

                txt_ing.DataBindings.Clear();
                txt_turk.DataBindings.Clear();
                txt_ing.DataBindings.Add("Text", ds.Tables["sozcukler"], "ingilizce");
                txt_turk.DataBindings.Add("Text", ds.Tables["sozcukler"], "turkce");

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listsonuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_ing.Text = listsonuc.Text;
            //txt_turk.Text = txtsonuc.Text;
            txt_ing.DataBindings.Clear();
            txt_turk.DataBindings.Clear();
            txt_ing.DataBindings.Add("Text", listsonuc.DataSource, "ingilizce");
            txt_turk.DataBindings.Add("Text", listsonuc.DataSource, "turkce");
        }

        //private void txt_aranan_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        //        OleDbDataAdapter adp = new OleDbDataAdapter("Select * From sozcukler where ingilizce LIKE'"+txt_aranan.Text+"%'", baglanti);
        //        adp.Fill(ds, "sozcukler");
        //        listsonuc.DataSource = ds.Tables[0];
        //        listsonuc.DisplayMember = "ingilizce";
        //        txtsonuc.DataBindings.Clear();
        //        txtsonuc.DataBindings.Add("text", ds.Tables[0], "turkce");
        //        baglanti.Close();
        //        if(listsonuc.Items.Count>0)
        //        {
        //            listsonuc.SelectedIndex = 0;
        //            txt_ing.Text = listsonuc.Text;
        //            txt_turk.Text = txtsonuc.Text;
        //        }else
        //        {
        //            txt_ing.Clear();
        //            txt_turk.Clear();
        //            txtsonuc.Clear();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void txt_aranan_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("sozcukler");


                dt.Columns.Add("ingilizce", typeof(string));
                dt.Columns.Add("turkce", typeof(string));


                OleDbCommand komut = new OleDbCommand("SELECT * FROM sozcukler WHERE ingilizce LIKE '" + txt_aranan.Text+ "%'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();


                while (okuyucu.Read())
                {
                    DataRow satir = dt.NewRow();
                    satir["ingilizce"] = okuyucu["ingilizce"].ToString();
                    satir["turkce"] = okuyucu["turkce"].ToString();
                    dt.Rows.Add(satir);
                }


                ds.Tables.Add(dt);


                listsonuc.DataSource = ds.Tables["sozcukler"];
                listsonuc.DisplayMember = "ingilizce";

                txt_ing.DataBindings.Clear();
                txt_turk.DataBindings.Clear();
                txt_ing.DataBindings.Add("Text", ds.Tables["sozcukler"], "ingilizce");
                txt_turk.DataBindings.Add("Text", ds.Tables["sozcukler"], "turkce");

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
