namespace Software_Company_Automation
{
    partial class UrunSilPnc
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
            this.sil_bt = new System.Windows.Forms.Button();
            this.bilgi_goster_lb = new System.Windows.Forms.Label();
            this.Urun_Kodu_Combobox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sil_bt
            // 
            this.sil_bt.BackColor = System.Drawing.Color.White;
            this.sil_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_bt.Location = new System.Drawing.Point(15, 285);
            this.sil_bt.Name = "sil_bt";
            this.sil_bt.Size = new System.Drawing.Size(254, 33);
            this.sil_bt.TabIndex = 67;
            this.sil_bt.Text = "EMLAK BİLGİLERİNİ SİL";
            this.sil_bt.UseVisualStyleBackColor = false;
            this.sil_bt.Click += new System.EventHandler(this.sil_bt_Click);
            // 
            // bilgi_goster_lb
            // 
            this.bilgi_goster_lb.AutoSize = true;
            this.bilgi_goster_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgi_goster_lb.Location = new System.Drawing.Point(12, 45);
            this.bilgi_goster_lb.Name = "bilgi_goster_lb";
            this.bilgi_goster_lb.Size = new System.Drawing.Size(153, 18);
            this.bilgi_goster_lb.TabIndex = 66;
            this.bilgi_goster_lb.Text = "BİLGİ:Seçim Yapınız...";
            // 
            // Urun_Kodu_Combobox
            // 
            this.Urun_Kodu_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Urun_Kodu_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Urun_Kodu_Combobox.FormattingEnabled = true;
            this.Urun_Kodu_Combobox.Location = new System.Drawing.Point(101, 6);
            this.Urun_Kodu_Combobox.Name = "Urun_Kodu_Combobox";
            this.Urun_Kodu_Combobox.Size = new System.Drawing.Size(168, 26);
            this.Urun_Kodu_Combobox.TabIndex = 64;
            this.Urun_Kodu_Combobox.SelectedIndexChanged += new System.EventHandler(this.Urun_Kodu_Combobox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label18.Location = new System.Drawing.Point(12, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 18);
            this.label18.TabIndex = 65;
            this.label18.Text = "Ürün Kodu:";
            // 
            // UrunSilPnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 331);
            this.Controls.Add(this.sil_bt);
            this.Controls.Add(this.bilgi_goster_lb);
            this.Controls.Add(this.Urun_Kodu_Combobox);
            this.Controls.Add(this.label18);
            this.Name = "UrunSilPnc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN SİL";
            this.Load += new System.EventHandler(this.UrunSilPnc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sil_bt;
        private System.Windows.Forms.Label bilgi_goster_lb;
        private System.Windows.Forms.ComboBox Urun_Kodu_Combobox;
        private System.Windows.Forms.Label label18;
    }
}