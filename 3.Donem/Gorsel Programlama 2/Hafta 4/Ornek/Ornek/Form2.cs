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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/sozluk.accdb");
        BindingManagerBase bmb;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                OleDbDataAdapter adp = new OleDbDataAdapter("Select * From sozcukler", baglanti);
                adp.Fill(ds, "sozcukler");
                listsonuc.DataSource = ds.Tables[0];
                listsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add("text", ds.Tables[0], "turkce");
                baglanti.Close();
                listsonuc.SelectedIndex = 0;
                txt_ing.Text = listsonuc.Text;
                txt_turk.Text = txtsonuc.Text;
                bmb = this.BindingContext[ds.Tables[0]];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listsonuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ing.Text = listsonuc.Text;
            txt_turk.Text = txtsonuc.Text;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btn_ilk_Click(object sender, EventArgs e)
        {
            if(bmb.Position == 0)
            {
                MessageBox.Show("İlk Kayıttasınız");
            }
            else
            {
                bmb.Position = 0;
            }
        }

        private void btn_onceki_Click(object sender, EventArgs e)
        {
            if (bmb.Position == 0)
            {
                MessageBox.Show("İlk Kayıttasınız");
            }
            else
            {
                bmb.Position = bmb.Position - 1;
            }
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {

            if (bmb.Position == bmb.Count - 1)
            {
                MessageBox.Show("Son Kayıttasınız");
            }
            else
            {
                bmb.Position = bmb.Position + 1;
            }


        }

        private void btn_son_Click(object sender, EventArgs e)
        {

            if (bmb.Position == bmb.Count - 1)
            {
                MessageBox.Show("Son Kayıttasınız");
            }
            else
            {
                bmb.Position = bmb.Count - 1;

            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_ing.Text) || string.IsNullOrEmpty(txt_turk.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
                return;
            }

            try
            {

                DataSet ds = new DataSet();
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter("insert into sozcukler (ingilizce,turkce) values ('"+txt_ing.Text +"','" +txt_turk.Text+"')", baglanti);
                adp.Fill(ds);
                ds.Clear();

                adp = new OleDbDataAdapter("Select * From sozcukler", baglanti);
                adp.Fill(ds, "sozcukler");
                listsonuc.DataSource = ds.Tables[0];
                listsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add("text", ds.Tables[0], "turkce");
                baglanti.Close();
                listsonuc.SelectedIndex = 0;
                txt_ing.Text = listsonuc.Text;
                txt_turk.Text = txtsonuc.Text;
                bmb = this.BindingContext[ds.Tables[0]];
                MessageBox.Show("Kayıt Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ing.Text) || string.IsNullOrEmpty(txt_turk.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
                return;
            }

            try
            {
                DataSet ds = new DataSet();
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter("update sozcukler set turkce = '"+txt_turk.Text+"' where ingilizce ='"+txt_ing.Text+"'", baglanti);
                adp.Fill(ds);
                ds.Clear();

                adp = new OleDbDataAdapter("Select * From sozcukler", baglanti);
                adp.Fill(ds, "sozcukler");
                listsonuc.DataSource = ds.Tables[0];
                listsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add("text", ds.Tables[0], "turkce");
                baglanti.Close();
                listsonuc.SelectedIndex = 0;
                txt_ing.Text = listsonuc.Text;
                txt_turk.Text = txtsonuc.Text;
                bmb = this.BindingContext[ds.Tables[0]];
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ing.Text) )
            {
                MessageBox.Show("Lütfen ingilizce metin kutusunu doldurunuz");
                return;
            }

            try
            {
                DataSet ds = new DataSet();
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter("delete from sozcukler where ingilizce = '" + txt_ing.Text + "'", baglanti);
                adp.Fill(ds);
                ds.Clear();

                adp = new OleDbDataAdapter("Select * From sozcukler", baglanti);
                adp.Fill(ds, "sozcukler");
                listsonuc.DataSource = ds.Tables[0];
                listsonuc.DisplayMember = "ingilizce";
                txtsonuc.DataBindings.Clear();
                txtsonuc.DataBindings.Add("text", ds.Tables[0], "turkce");
                baglanti.Close();
                listsonuc.SelectedIndex = 0;
                txt_ing.Text = listsonuc.Text;
                txt_turk.Text = txtsonuc.Text;
                bmb = this.BindingContext[ds.Tables[0]];
                MessageBox.Show("Kayıt Silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
        }
    }
}
