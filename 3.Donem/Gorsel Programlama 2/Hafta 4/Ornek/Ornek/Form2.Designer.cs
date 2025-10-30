namespace Ornek
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listsonuc = new System.Windows.Forms.ListBox();
            this.txt_turk = new System.Windows.Forms.TextBox();
            this.txt_ing = new System.Windows.Forms.TextBox();
            this.txt_aranan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ilk = new System.Windows.Forms.Button();
            this.btn_onceki = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_son = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(440, 73);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(332, 433);
            this.txtsonuc.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Türkçe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "İngilizce";
            // 
            // listsonuc
            // 
            this.listsonuc.FormattingEnabled = true;
            this.listsonuc.Location = new System.Drawing.Point(31, 73);
            this.listsonuc.Name = "listsonuc";
            this.listsonuc.Size = new System.Drawing.Size(378, 433);
            this.listsonuc.TabIndex = 17;
            this.listsonuc.SelectedIndexChanged += new System.EventHandler(this.listsonuc_SelectedIndexChanged);
            // 
            // txt_turk
            // 
            this.txt_turk.Location = new System.Drawing.Point(509, 32);
            this.txt_turk.Name = "txt_turk";
            this.txt_turk.Size = new System.Drawing.Size(100, 20);
            this.txt_turk.TabIndex = 16;
            // 
            // txt_ing
            // 
            this.txt_ing.Location = new System.Drawing.Point(100, 32);
            this.txt_ing.Name = "txt_ing";
            this.txt_ing.Size = new System.Drawing.Size(100, 20);
            this.txt_ing.TabIndex = 15;
            // 
            // txt_aranan
            // 
            this.txt_aranan.Location = new System.Drawing.Point(31, -57);
            this.txt_aranan.Name = "txt_aranan";
            this.txt_aranan.Size = new System.Drawing.Size(741, 20);
            this.txt_aranan.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, -12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sonuçlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, -87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aradığınız Kelimeyi Giriniz";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(44, 546);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 23;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(249, 546);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 24;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ilk
            // 
            this.btn_ilk.Location = new System.Drawing.Point(44, 601);
            this.btn_ilk.Name = "btn_ilk";
            this.btn_ilk.Size = new System.Drawing.Size(75, 23);
            this.btn_ilk.TabIndex = 25;
            this.btn_ilk.Text = "İlk Kayıt";
            this.btn_ilk.UseVisualStyleBackColor = true;
            this.btn_ilk.Click += new System.EventHandler(this.btn_ilk_Click);
            // 
            // btn_onceki
            // 
            this.btn_onceki.Location = new System.Drawing.Point(249, 601);
            this.btn_onceki.Name = "btn_onceki";
            this.btn_onceki.Size = new System.Drawing.Size(75, 23);
            this.btn_onceki.TabIndex = 26;
            this.btn_onceki.Text = "Önceki Kayıt";
            this.btn_onceki.UseVisualStyleBackColor = true;
            this.btn_onceki.Click += new System.EventHandler(this.btn_onceki_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(440, 546);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 27;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.Location = new System.Drawing.Point(440, 601);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(88, 23);
            this.btn_sonraki.TabIndex = 28;
            this.btn_sonraki.Text = "Sonraki Kayıt ";
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Location = new System.Drawing.Point(697, 546);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(75, 23);
            this.btn_anasayfa.TabIndex = 29;
            this.btn_anasayfa.Text = "Ana Sayfa";
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // btn_son
            // 
            this.btn_son.Location = new System.Drawing.Point(697, 601);
            this.btn_son.Name = "btn_son";
            this.btn_son.Size = new System.Drawing.Size(75, 23);
            this.btn_son.TabIndex = 30;
            this.btn_son.Text = "Son Kayıt";
            this.btn_son.UseVisualStyleBackColor = true;
            this.btn_son.Click += new System.EventHandler(this.btn_son_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.btn_son);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_onceki);
            this.Controls.Add(this.btn_ilk);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listsonuc);
            this.Controls.Add(this.txt_turk);
            this.Controls.Add(this.txt_ing);
            this.Controls.Add(this.txt_aranan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listsonuc;
        private System.Windows.Forms.TextBox txt_turk;
        private System.Windows.Forms.TextBox txt_ing;
        private System.Windows.Forms.TextBox txt_aranan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ilk;
        private System.Windows.Forms.Button btn_onceki;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_son;
    }
}