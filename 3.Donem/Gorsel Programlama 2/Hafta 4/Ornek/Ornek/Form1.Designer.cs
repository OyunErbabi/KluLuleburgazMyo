namespace Ornek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_aranan = new System.Windows.Forms.TextBox();
            this.txt_ing = new System.Windows.Forms.TextBox();
            this.txt_turk = new System.Windows.Forms.TextBox();
            this.listsonuc = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aradığınız Kelimeyi Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sonuçlar";
            // 
            // txt_aranan
            // 
            this.txt_aranan.Location = new System.Drawing.Point(25, 39);
            this.txt_aranan.Name = "txt_aranan";
            this.txt_aranan.Size = new System.Drawing.Size(741, 20);
            this.txt_aranan.TabIndex = 2;
            this.txt_aranan.TextChanged += new System.EventHandler(this.txt_aranan_TextChanged);
            // 
            // txt_ing
            // 
            this.txt_ing.Location = new System.Drawing.Point(94, 128);
            this.txt_ing.Name = "txt_ing";
            this.txt_ing.Size = new System.Drawing.Size(100, 20);
            this.txt_ing.TabIndex = 3;
            // 
            // txt_turk
            // 
            this.txt_turk.Location = new System.Drawing.Point(503, 128);
            this.txt_turk.Name = "txt_turk";
            this.txt_turk.Size = new System.Drawing.Size(100, 20);
            this.txt_turk.TabIndex = 4;
            // 
            // listsonuc
            // 
            this.listsonuc.FormattingEnabled = true;
            this.listsonuc.Location = new System.Drawing.Point(25, 169);
            this.listsonuc.Name = "listsonuc";
            this.listsonuc.Size = new System.Drawing.Size(378, 433);
            this.listsonuc.TabIndex = 5;
            this.listsonuc.SelectedIndexChanged += new System.EventHandler(this.listsonuc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "İngilizce";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Türkçe";
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(434, 169);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(332, 433);
            this.txtsonuc.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ayarlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 611);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listsonuc);
            this.Controls.Add(this.txt_turk);
            this.Controls.Add(this.txt_ing);
            this.Controls.Add(this.txt_aranan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_aranan;
        private System.Windows.Forms.TextBox txt_ing;
        private System.Windows.Forms.TextBox txt_turk;
        private System.Windows.Forms.ListBox listsonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

