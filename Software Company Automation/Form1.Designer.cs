namespace Software_Company_Automation
{
    partial class APencere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APencere));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.satis_kiralama_listesi = new System.Windows.Forms.Button();
            this.satis_kiralama_bt = new System.Windows.Forms.Button();
            this.arama_yap_bt = new System.Windows.Forms.Button();
            this.stok_listesi = new System.Windows.Forms.Button();
            this.sil_bt = new System.Windows.Forms.Button();
            this.guncelle_bt = new System.Windows.Forms.Button();
            this.ekle_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // satis_kiralama_listesi
            // 
            this.satis_kiralama_listesi.BackColor = System.Drawing.Color.White;
            this.satis_kiralama_listesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satis_kiralama_listesi.Location = new System.Drawing.Point(475, 260);
            this.satis_kiralama_listesi.Name = "satis_kiralama_listesi";
            this.satis_kiralama_listesi.Size = new System.Drawing.Size(225, 55);
            this.satis_kiralama_listesi.TabIndex = 15;
            this.satis_kiralama_listesi.Text = "SATIŞ LİSTESİ";
            this.satis_kiralama_listesi.UseVisualStyleBackColor = false;
            // 
            // satis_kiralama_bt
            // 
            this.satis_kiralama_bt.BackColor = System.Drawing.Color.White;
            this.satis_kiralama_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satis_kiralama_bt.Location = new System.Drawing.Point(244, 259);
            this.satis_kiralama_bt.Name = "satis_kiralama_bt";
            this.satis_kiralama_bt.Size = new System.Drawing.Size(225, 56);
            this.satis_kiralama_bt.TabIndex = 14;
            this.satis_kiralama_bt.Text = "SATIŞ İŞLEMLERİ";
            this.satis_kiralama_bt.UseVisualStyleBackColor = false;
            // 
            // arama_yap_bt
            // 
            this.arama_yap_bt.BackColor = System.Drawing.Color.White;
            this.arama_yap_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama_yap_bt.Location = new System.Drawing.Point(12, 12);
            this.arama_yap_bt.Name = "arama_yap_bt";
            this.arama_yap_bt.Size = new System.Drawing.Size(225, 56);
            this.arama_yap_bt.TabIndex = 13;
            this.arama_yap_bt.Text = "ARAMA YAP";
            this.arama_yap_bt.UseVisualStyleBackColor = false;
            this.arama_yap_bt.Click += new System.EventHandler(this.arama_yap_bt_Click);
            // 
            // stok_listesi
            // 
            this.stok_listesi.BackColor = System.Drawing.Color.White;
            this.stok_listesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok_listesi.Location = new System.Drawing.Point(12, 259);
            this.stok_listesi.Name = "stok_listesi";
            this.stok_listesi.Size = new System.Drawing.Size(225, 56);
            this.stok_listesi.TabIndex = 12;
            this.stok_listesi.Text = "STOK LİSTESİ";
            this.stok_listesi.UseVisualStyleBackColor = false;
            this.stok_listesi.Click += new System.EventHandler(this.stok_listesi_Click);
            // 
            // sil_bt
            // 
            this.sil_bt.BackColor = System.Drawing.Color.White;
            this.sil_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_bt.Location = new System.Drawing.Point(12, 198);
            this.sil_bt.Name = "sil_bt";
            this.sil_bt.Size = new System.Drawing.Size(225, 56);
            this.sil_bt.TabIndex = 11;
            this.sil_bt.Text = "STOK SİL";
            this.sil_bt.UseVisualStyleBackColor = false;
            this.sil_bt.Click += new System.EventHandler(this.sil_bt_Click);
            // 
            // guncelle_bt
            // 
            this.guncelle_bt.BackColor = System.Drawing.Color.White;
            this.guncelle_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_bt.Location = new System.Drawing.Point(12, 136);
            this.guncelle_bt.Name = "guncelle_bt";
            this.guncelle_bt.Size = new System.Drawing.Size(225, 56);
            this.guncelle_bt.TabIndex = 10;
            this.guncelle_bt.Text = "STOK BİLGİLERİNİ GÜNCELLE";
            this.guncelle_bt.UseVisualStyleBackColor = false;
            this.guncelle_bt.Click += new System.EventHandler(this.guncelle_bt_Click);
            // 
            // ekle_bt
            // 
            this.ekle_bt.BackColor = System.Drawing.Color.White;
            this.ekle_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_bt.Location = new System.Drawing.Point(12, 74);
            this.ekle_bt.Name = "ekle_bt";
            this.ekle_bt.Size = new System.Drawing.Size(225, 56);
            this.ekle_bt.TabIndex = 9;
            this.ekle_bt.Text = "STOK EKLE";
            this.ekle_bt.UseVisualStyleBackColor = false;
            this.ekle_bt.Click += new System.EventHandler(this.ekle_bt_Click);
            // 
            // APencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 325);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.satis_kiralama_listesi);
            this.Controls.Add(this.satis_kiralama_bt);
            this.Controls.Add(this.arama_yap_bt);
            this.Controls.Add(this.stok_listesi);
            this.Controls.Add(this.sil_bt);
            this.Controls.Add(this.guncelle_bt);
            this.Controls.Add(this.ekle_bt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "APencere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genel Pencere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.APencere_FormClosing);
            this.Load += new System.EventHandler(this.APencere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button satis_kiralama_listesi;
        private System.Windows.Forms.Button satis_kiralama_bt;
        private System.Windows.Forms.Button arama_yap_bt;
        private System.Windows.Forms.Button stok_listesi;
        private System.Windows.Forms.Button sil_bt;
        private System.Windows.Forms.Button guncelle_bt;
        private System.Windows.Forms.Button ekle_bt;
    }
}

