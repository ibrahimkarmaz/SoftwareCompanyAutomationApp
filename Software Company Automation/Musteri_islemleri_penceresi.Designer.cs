namespace Software_Company_Automation
{
    partial class Musteri_islemleri_penceresi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aciklama_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adres_tb = new System.Windows.Forms.TextBox();
            this.adres_label = new System.Windows.Forms.Label();
            this.ev_masketb = new System.Windows.Forms.MaskedTextBox();
            this.cep_masketb = new System.Windows.Forms.MaskedTextBox();
            this.e_label = new System.Windows.Forms.Label();
            this.mail_uzantisi_combo = new System.Windows.Forms.ComboBox();
            this.ilce_combo = new System.Windows.Forms.ComboBox();
            this.il_combo = new System.Windows.Forms.ComboBox();
            this.kadin_rb = new System.Windows.Forms.RadioButton();
            this.erkek_rb = new System.Windows.Forms.RadioButton();
            this.tc_masketb = new System.Windows.Forms.MaskedTextBox();
            this.mail_tb = new System.Windows.Forms.TextBox();
            this.mail_label = new System.Windows.Forms.Label();
            this.ev_label = new System.Windows.Forms.Label();
            this.cep_label = new System.Windows.Forms.Label();
            this.ilce_label = new System.Windows.Forms.Label();
            this.il_label = new System.Windows.Forms.Label();
            this.cinsiyet_label = new System.Windows.Forms.Label();
            this.soyad_tb = new System.Windows.Forms.TextBox();
            this.soyad_label = new System.Windows.Forms.Label();
            this.ad_tb = new System.Windows.Forms.TextBox();
            this.ad_label = new System.Windows.Forms.Label();
            this.tc_label = new System.Windows.Forms.Label();
            this.musteri_button = new System.Windows.Forms.Button();
            this.iptal_et_buton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aciklama_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.adres_tb);
            this.groupBox1.Controls.Add(this.adres_label);
            this.groupBox1.Controls.Add(this.ev_masketb);
            this.groupBox1.Controls.Add(this.cep_masketb);
            this.groupBox1.Controls.Add(this.e_label);
            this.groupBox1.Controls.Add(this.mail_uzantisi_combo);
            this.groupBox1.Controls.Add(this.ilce_combo);
            this.groupBox1.Controls.Add(this.il_combo);
            this.groupBox1.Controls.Add(this.kadin_rb);
            this.groupBox1.Controls.Add(this.erkek_rb);
            this.groupBox1.Controls.Add(this.tc_masketb);
            this.groupBox1.Controls.Add(this.mail_tb);
            this.groupBox1.Controls.Add(this.mail_label);
            this.groupBox1.Controls.Add(this.ev_label);
            this.groupBox1.Controls.Add(this.cep_label);
            this.groupBox1.Controls.Add(this.ilce_label);
            this.groupBox1.Controls.Add(this.il_label);
            this.groupBox1.Controls.Add(this.cinsiyet_label);
            this.groupBox1.Controls.Add(this.soyad_tb);
            this.groupBox1.Controls.Add(this.soyad_label);
            this.groupBox1.Controls.Add(this.ad_tb);
            this.groupBox1.Controls.Add(this.ad_label);
            this.groupBox1.Controls.Add(this.tc_label);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 348);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // aciklama_tb
            // 
            this.aciklama_tb.Location = new System.Drawing.Point(418, 151);
            this.aciklama_tb.Multiline = true;
            this.aciklama_tb.Name = "aciklama_tb";
            this.aciklama_tb.Size = new System.Drawing.Size(167, 102);
            this.aciklama_tb.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(320, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Açıklama:";
            // 
            // adres_tb
            // 
            this.adres_tb.Location = new System.Drawing.Point(418, 26);
            this.adres_tb.Multiline = true;
            this.adres_tb.Name = "adres_tb";
            this.adres_tb.Size = new System.Drawing.Size(167, 102);
            this.adres_tb.TabIndex = 57;
            // 
            // adres_label
            // 
            this.adres_label.AutoSize = true;
            this.adres_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres_label.Location = new System.Drawing.Point(320, 25);
            this.adres_label.Name = "adres_label";
            this.adres_label.Size = new System.Drawing.Size(92, 23);
            this.adres_label.TabIndex = 56;
            this.adres_label.Text = "Ev Adresi:";
            // 
            // ev_masketb
            // 
            this.ev_masketb.Location = new System.Drawing.Point(137, 247);
            this.ev_masketb.Mask = "(000) 000-0000";
            this.ev_masketb.Name = "ev_masketb";
            this.ev_masketb.Size = new System.Drawing.Size(167, 26);
            this.ev_masketb.TabIndex = 53;
            // 
            // cep_masketb
            // 
            this.cep_masketb.Location = new System.Drawing.Point(137, 215);
            this.cep_masketb.Mask = "(000) 000-0000";
            this.cep_masketb.Name = "cep_masketb";
            this.cep_masketb.Size = new System.Drawing.Size(167, 26);
            this.cep_masketb.TabIndex = 51;
            // 
            // e_label
            // 
            this.e_label.AutoSize = true;
            this.e_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.e_label.Location = new System.Drawing.Point(133, 313);
            this.e_label.Name = "e_label";
            this.e_label.Size = new System.Drawing.Size(25, 23);
            this.e_label.TabIndex = 50;
            this.e_label.Text = "@";
            // 
            // mail_uzantisi_combo
            // 
            this.mail_uzantisi_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mail_uzantisi_combo.FormattingEnabled = true;
            this.mail_uzantisi_combo.Location = new System.Drawing.Point(162, 311);
            this.mail_uzantisi_combo.Name = "mail_uzantisi_combo";
            this.mail_uzantisi_combo.Size = new System.Drawing.Size(142, 26);
            this.mail_uzantisi_combo.TabIndex = 49;
            // 
            // ilce_combo
            // 
            this.ilce_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ilce_combo.FormattingEnabled = true;
            this.ilce_combo.Location = new System.Drawing.Point(137, 183);
            this.ilce_combo.Name = "ilce_combo";
            this.ilce_combo.Size = new System.Drawing.Size(167, 26);
            this.ilce_combo.TabIndex = 48;
            // 
            // il_combo
            // 
            this.il_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.il_combo.FormattingEnabled = true;
            this.il_combo.Location = new System.Drawing.Point(137, 151);
            this.il_combo.Name = "il_combo";
            this.il_combo.Size = new System.Drawing.Size(167, 26);
            this.il_combo.TabIndex = 47;
            this.il_combo.SelectedIndexChanged += new System.EventHandler(this.il_combo_SelectedIndexChanged);
            // 
            // kadin_rb
            // 
            this.kadin_rb.AutoSize = true;
            this.kadin_rb.Location = new System.Drawing.Point(244, 125);
            this.kadin_rb.Name = "kadin_rb";
            this.kadin_rb.Size = new System.Drawing.Size(60, 22);
            this.kadin_rb.TabIndex = 46;
            this.kadin_rb.Text = "Kadın";
            this.kadin_rb.UseVisualStyleBackColor = true;
            // 
            // erkek_rb
            // 
            this.erkek_rb.AutoSize = true;
            this.erkek_rb.Checked = true;
            this.erkek_rb.Location = new System.Drawing.Point(137, 125);
            this.erkek_rb.Name = "erkek_rb";
            this.erkek_rb.Size = new System.Drawing.Size(61, 22);
            this.erkek_rb.TabIndex = 45;
            this.erkek_rb.TabStop = true;
            this.erkek_rb.Text = "Erkek";
            this.erkek_rb.UseVisualStyleBackColor = true;
            // 
            // tc_masketb
            // 
            this.tc_masketb.Location = new System.Drawing.Point(137, 25);
            this.tc_masketb.Mask = "00000000000";
            this.tc_masketb.Name = "tc_masketb";
            this.tc_masketb.Size = new System.Drawing.Size(167, 26);
            this.tc_masketb.TabIndex = 44;
            // 
            // mail_tb
            // 
            this.mail_tb.Location = new System.Drawing.Point(137, 279);
            this.mail_tb.Name = "mail_tb";
            this.mail_tb.Size = new System.Drawing.Size(167, 26);
            this.mail_tb.TabIndex = 40;
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail_label.Location = new System.Drawing.Point(6, 279);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(136, 23);
            this.mail_label.TabIndex = 39;
            this.mail_label.Text = "E-Posta Adresi:";
            // 
            // ev_label
            // 
            this.ev_label.AutoSize = true;
            this.ev_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ev_label.Location = new System.Drawing.Point(6, 247);
            this.ev_label.Name = "ev_label";
            this.ev_label.Size = new System.Drawing.Size(107, 23);
            this.ev_label.TabIndex = 36;
            this.ev_label.Text = "Ev Telefonu:";
            // 
            // cep_label
            // 
            this.cep_label.AutoSize = true;
            this.cep_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cep_label.Location = new System.Drawing.Point(6, 215);
            this.cep_label.Name = "cep_label";
            this.cep_label.Size = new System.Drawing.Size(117, 23);
            this.cep_label.TabIndex = 33;
            this.cep_label.Text = "Cep Telefonu:";
            // 
            // ilce_label
            // 
            this.ilce_label.AutoSize = true;
            this.ilce_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilce_label.Location = new System.Drawing.Point(6, 181);
            this.ilce_label.Name = "ilce_label";
            this.ilce_label.Size = new System.Drawing.Size(116, 23);
            this.ilce_label.TabIndex = 24;
            this.ilce_label.Text = "Yaşadığı İlçe:";
            // 
            // il_label
            // 
            this.il_label.AutoSize = true;
            this.il_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.il_label.Location = new System.Drawing.Point(6, 149);
            this.il_label.Name = "il_label";
            this.il_label.Size = new System.Drawing.Size(99, 23);
            this.il_label.TabIndex = 21;
            this.il_label.Text = "Yaşadığı İl:";
            // 
            // cinsiyet_label
            // 
            this.cinsiyet_label.AutoSize = true;
            this.cinsiyet_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiyet_label.Location = new System.Drawing.Point(6, 119);
            this.cinsiyet_label.Name = "cinsiyet_label";
            this.cinsiyet_label.Size = new System.Drawing.Size(81, 23);
            this.cinsiyet_label.TabIndex = 18;
            this.cinsiyet_label.Text = "Cinsiyeti:";
            // 
            // soyad_tb
            // 
            this.soyad_tb.Location = new System.Drawing.Point(137, 89);
            this.soyad_tb.Name = "soyad_tb";
            this.soyad_tb.Size = new System.Drawing.Size(167, 26);
            this.soyad_tb.TabIndex = 16;
            // 
            // soyad_label
            // 
            this.soyad_label.AutoSize = true;
            this.soyad_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad_label.Location = new System.Drawing.Point(6, 89);
            this.soyad_label.Name = "soyad_label";
            this.soyad_label.Size = new System.Drawing.Size(67, 23);
            this.soyad_label.TabIndex = 15;
            this.soyad_label.Text = "Soyadı:";
            // 
            // ad_tb
            // 
            this.ad_tb.Location = new System.Drawing.Point(137, 57);
            this.ad_tb.Name = "ad_tb";
            this.ad_tb.Size = new System.Drawing.Size(167, 26);
            this.ad_tb.TabIndex = 13;
            // 
            // ad_label
            // 
            this.ad_label.AutoSize = true;
            this.ad_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_label.Location = new System.Drawing.Point(6, 57);
            this.ad_label.Name = "ad_label";
            this.ad_label.Size = new System.Drawing.Size(42, 23);
            this.ad_label.TabIndex = 12;
            this.ad_label.Text = "Adı:";
            // 
            // tc_label
            // 
            this.tc_label.AutoSize = true;
            this.tc_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_label.Location = new System.Drawing.Point(6, 22);
            this.tc_label.Name = "tc_label";
            this.tc_label.Size = new System.Drawing.Size(116, 23);
            this.tc_label.TabIndex = 9;
            this.tc_label.Text = "TC Kimlik No:";
            // 
            // musteri_button
            // 
            this.musteri_button.BackColor = System.Drawing.Color.White;
            this.musteri_button.Location = new System.Drawing.Point(469, 366);
            this.musteri_button.Name = "musteri_button";
            this.musteri_button.Size = new System.Drawing.Size(144, 37);
            this.musteri_button.TabIndex = 11;
            this.musteri_button.Text = "Müşteri Ekle";
            this.musteri_button.UseVisualStyleBackColor = false;
            this.musteri_button.Click += new System.EventHandler(this.musteri_button_Click);
            // 
            // iptal_et_buton
            // 
            this.iptal_et_buton.BackColor = System.Drawing.Color.White;
            this.iptal_et_buton.Location = new System.Drawing.Point(319, 366);
            this.iptal_et_buton.Name = "iptal_et_buton";
            this.iptal_et_buton.Size = new System.Drawing.Size(144, 37);
            this.iptal_et_buton.TabIndex = 12;
            this.iptal_et_buton.Text = "İptal Et";
            this.iptal_et_buton.UseVisualStyleBackColor = false;
            this.iptal_et_buton.Click += new System.EventHandler(this.iptal_et_buton_Click);
            // 
            // Musteri_islemleri_penceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 410);
            this.Controls.Add(this.iptal_et_buton);
            this.Controls.Add(this.musteri_button);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Musteri_islemleri_penceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox ev_masketb;
        private System.Windows.Forms.MaskedTextBox cep_masketb;
        private System.Windows.Forms.Label e_label;
        private System.Windows.Forms.ComboBox mail_uzantisi_combo;
        private System.Windows.Forms.ComboBox ilce_combo;
        private System.Windows.Forms.ComboBox il_combo;
        private System.Windows.Forms.RadioButton kadin_rb;
        private System.Windows.Forms.RadioButton erkek_rb;
        private System.Windows.Forms.MaskedTextBox tc_masketb;
        private System.Windows.Forms.TextBox mail_tb;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.Label ev_label;
        private System.Windows.Forms.Label cep_label;
        private System.Windows.Forms.Label ilce_label;
        private System.Windows.Forms.Label il_label;
        private System.Windows.Forms.Label cinsiyet_label;
        private System.Windows.Forms.TextBox soyad_tb;
        private System.Windows.Forms.Label soyad_label;
        private System.Windows.Forms.TextBox ad_tb;
        private System.Windows.Forms.Label ad_label;
        private System.Windows.Forms.Label tc_label;
        private System.Windows.Forms.TextBox aciklama_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adres_tb;
        private System.Windows.Forms.Label adres_label;
        private System.Windows.Forms.Button musteri_button;
        private System.Windows.Forms.Button iptal_et_buton;
    }
}

