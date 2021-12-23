namespace MCD_RSSOkumaUygulaması
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
            this.lst_Baslik = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_RSS_Url = new System.Windows.Forms.TextBox();
            this.btn_Kaynagi_Getir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_Baslik
            // 
            this.lst_Baslik.FormattingEnabled = true;
            this.lst_Baslik.Location = new System.Drawing.Point(32, 118);
            this.lst_Baslik.Name = "lst_Baslik";
            this.lst_Baslik.Size = new System.Drawing.Size(395, 290);
            this.lst_Baslik.TabIndex = 0;
            this.lst_Baslik.SelectedIndexChanged += new System.EventHandler(this.lst_Baslik_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(433, 118);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(341, 290);
            this.webBrowser1.TabIndex = 1;
            // 
            // txt_RSS_Url
            // 
            this.txt_RSS_Url.Location = new System.Drawing.Point(32, 40);
            this.txt_RSS_Url.Name = "txt_RSS_Url";
            this.txt_RSS_Url.Size = new System.Drawing.Size(306, 20);
            this.txt_RSS_Url.TabIndex = 2;
            this.txt_RSS_Url.Text = "https://www.sabah.com.tr/rss/spor.xml";
            // 
            // btn_Kaynagi_Getir
            // 
            this.btn_Kaynagi_Getir.Location = new System.Drawing.Point(377, 40);
            this.btn_Kaynagi_Getir.Name = "btn_Kaynagi_Getir";
            this.btn_Kaynagi_Getir.Size = new System.Drawing.Size(98, 23);
            this.btn_Kaynagi_Getir.TabIndex = 3;
            this.btn_Kaynagi_Getir.Text = "Kaynagı Getir";
            this.btn_Kaynagi_Getir.UseVisualStyleBackColor = true;
            this.btn_Kaynagi_Getir.Click += new System.EventHandler(this.btn_Kaynagi_Getir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RSS Adresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Haber Başlığı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Haber Detayı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaynagi_Getir);
            this.Controls.Add(this.txt_RSS_Url);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lst_Baslik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Baslik;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txt_RSS_Url;
        private System.Windows.Forms.Button btn_Kaynagi_Getir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

