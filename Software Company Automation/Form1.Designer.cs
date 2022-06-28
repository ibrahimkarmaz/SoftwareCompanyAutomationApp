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
            this.arama_yap_bt = new System.Windows.Forms.Button();
            this.stok_listesi = new System.Windows.Forms.Button();
            this.sil_bt = new System.Windows.Forms.Button();
            this.guncelle_bt = new System.Windows.Forms.Button();
            this.ekle_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.ClientSize = new System.Drawing.Size(247, 325);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button arama_yap_bt;
        private System.Windows.Forms.Button stok_listesi;
        private System.Windows.Forms.Button sil_bt;
        private System.Windows.Forms.Button guncelle_bt;
        private System.Windows.Forms.Button ekle_bt;
    }
}

