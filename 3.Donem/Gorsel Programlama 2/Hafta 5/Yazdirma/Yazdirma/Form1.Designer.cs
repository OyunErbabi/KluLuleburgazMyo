namespace Yazdirma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_ad = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_birim = new System.Windows.Forms.Label();
            this.label_telefon = new System.Windows.Forms.Label();
            this.label_eposta = new System.Windows.Forms.Label();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.textBox_birim = new System.Windows.Forms.TextBox();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.textBox_eposta = new System.Windows.Forms.TextBox();
            this.button_onizleme = new System.Windows.Forms.Button();
            this.button_sayfayarlari = new System.Windows.Forms.Button();
            this.button_yaziciayarlari = new System.Windows.Forms.Button();
            this.button_yazdir = new System.Windows.Forms.Button();
            this.button_resimac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(205, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Location = new System.Drawing.Point(13, 29);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(23, 13);
            this.label_ad.TabIndex = 1;
            this.label_ad.Text = "Ad:";
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(13, 55);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(40, 13);
            this.label_soyad.TabIndex = 2;
            this.label_soyad.Text = "Soyad:";
            // 
            // label_birim
            // 
            this.label_birim.AutoSize = true;
            this.label_birim.Location = new System.Drawing.Point(13, 81);
            this.label_birim.Name = "label_birim";
            this.label_birim.Size = new System.Drawing.Size(32, 13);
            this.label_birim.TabIndex = 3;
            this.label_birim.Text = "Birim:";
            // 
            // label_telefon
            // 
            this.label_telefon.AutoSize = true;
            this.label_telefon.Location = new System.Drawing.Point(13, 107);
            this.label_telefon.Name = "label_telefon";
            this.label_telefon.Size = new System.Drawing.Size(46, 13);
            this.label_telefon.TabIndex = 4;
            this.label_telefon.Text = "Telefon:";
            // 
            // label_eposta
            // 
            this.label_eposta.AutoSize = true;
            this.label_eposta.Location = new System.Drawing.Point(13, 133);
            this.label_eposta.Name = "label_eposta";
            this.label_eposta.Size = new System.Drawing.Size(46, 13);
            this.label_eposta.TabIndex = 5;
            this.label_eposta.Text = "E-posta:";
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(78, 26);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ad.TabIndex = 6;
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(78, 52);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Soyad.TabIndex = 7;
            // 
            // textBox_birim
            // 
            this.textBox_birim.Location = new System.Drawing.Point(78, 78);
            this.textBox_birim.Name = "textBox_birim";
            this.textBox_birim.Size = new System.Drawing.Size(100, 20);
            this.textBox_birim.TabIndex = 8;
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Location = new System.Drawing.Point(78, 104);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(100, 20);
            this.textBox_telefon.TabIndex = 9;
            // 
            // textBox_eposta
            // 
            this.textBox_eposta.Location = new System.Drawing.Point(78, 130);
            this.textBox_eposta.Name = "textBox_eposta";
            this.textBox_eposta.Size = new System.Drawing.Size(100, 20);
            this.textBox_eposta.TabIndex = 10;
            // 
            // button_onizleme
            // 
            this.button_onizleme.Location = new System.Drawing.Point(422, 24);
            this.button_onizleme.Name = "button_onizleme";
            this.button_onizleme.Size = new System.Drawing.Size(145, 23);
            this.button_onizleme.TabIndex = 11;
            this.button_onizleme.Text = "Ön İzleme";
            this.button_onizleme.UseVisualStyleBackColor = true;
            this.button_onizleme.Click += new System.EventHandler(this.button_onizleme_Click);
            // 
            // button_sayfayarlari
            // 
            this.button_sayfayarlari.Location = new System.Drawing.Point(422, 55);
            this.button_sayfayarlari.Name = "button_sayfayarlari";
            this.button_sayfayarlari.Size = new System.Drawing.Size(145, 23);
            this.button_sayfayarlari.TabIndex = 12;
            this.button_sayfayarlari.Text = "Sayfa Ayarları";
            this.button_sayfayarlari.UseVisualStyleBackColor = true;
            this.button_sayfayarlari.Click += new System.EventHandler(this.button_sayfayarlari_Click);
            // 
            // button_yaziciayarlari
            // 
            this.button_yaziciayarlari.Location = new System.Drawing.Point(422, 84);
            this.button_yaziciayarlari.Name = "button_yaziciayarlari";
            this.button_yaziciayarlari.Size = new System.Drawing.Size(145, 23);
            this.button_yaziciayarlari.TabIndex = 13;
            this.button_yaziciayarlari.Text = "Yazıcı Ayarları";
            this.button_yaziciayarlari.UseVisualStyleBackColor = true;
            this.button_yaziciayarlari.Click += new System.EventHandler(this.button_yaziciayarlari_Click);
            // 
            // button_yazdir
            // 
            this.button_yazdir.Location = new System.Drawing.Point(422, 113);
            this.button_yazdir.Name = "button_yazdir";
            this.button_yazdir.Size = new System.Drawing.Size(145, 23);
            this.button_yazdir.TabIndex = 14;
            this.button_yazdir.Text = "Yazdır";
            this.button_yazdir.UseVisualStyleBackColor = true;
            this.button_yazdir.Click += new System.EventHandler(this.button_yazdir_Click);
            // 
            // button_resimac
            // 
            this.button_resimac.Location = new System.Drawing.Point(253, 197);
            this.button_resimac.Name = "button_resimac";
            this.button_resimac.Size = new System.Drawing.Size(102, 23);
            this.button_resimac.TabIndex = 15;
            this.button_resimac.Text = "Resim Aç";
            this.button_resimac.UseVisualStyleBackColor = true;
            this.button_resimac.Click += new System.EventHandler(this.button_resimac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 234);
            this.Controls.Add(this.button_resimac);
            this.Controls.Add(this.button_yazdir);
            this.Controls.Add(this.button_yaziciayarlari);
            this.Controls.Add(this.button_sayfayarlari);
            this.Controls.Add(this.button_onizleme);
            this.Controls.Add(this.textBox_eposta);
            this.Controls.Add(this.textBox_telefon);
            this.Controls.Add(this.textBox_birim);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.textBox_Ad);
            this.Controls.Add(this.label_eposta);
            this.Controls.Add(this.label_telefon);
            this.Controls.Add(this.label_birim);
            this.Controls.Add(this.label_soyad);
            this.Controls.Add(this.label_ad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_birim;
        private System.Windows.Forms.Label label_telefon;
        private System.Windows.Forms.Label label_eposta;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.TextBox textBox_birim;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.TextBox textBox_eposta;
        private System.Windows.Forms.Button button_onizleme;
        private System.Windows.Forms.Button button_sayfayarlari;
        private System.Windows.Forms.Button button_yaziciayarlari;
        private System.Windows.Forms.Button button_yazdir;
        private System.Windows.Forms.Button button_resimac;
    }
}

