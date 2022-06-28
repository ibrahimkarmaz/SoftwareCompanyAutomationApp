namespace Software_Company_Automation
{
    partial class DevamKontrolForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.devamsizlik_maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.secili_tarihi_sil = new System.Windows.Forms.Button();
            this.devamsizlik_listesi = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Devamsizlik_label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.devamsizlik_maskedTextBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 92);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ders İşlemleri";
            // 
            // devamsizlik_maskedTextBox1
            // 
            this.devamsizlik_maskedTextBox1.Location = new System.Drawing.Point(133, 24);
            this.devamsizlik_maskedTextBox1.Mask = "00/00/0000";
            this.devamsizlik_maskedTextBox1.Name = "devamsizlik_maskedTextBox1";
            this.devamsizlik_maskedTextBox1.Size = new System.Drawing.Size(152, 22);
            this.devamsizlik_maskedTextBox1.TabIndex = 44;
            this.devamsizlik_maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 25);
            this.button1.TabIndex = 43;
            this.button1.Text = "Devamsızlık Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Devamsizlik Tarihi:";
            // 
            // secili_tarihi_sil
            // 
            this.secili_tarihi_sil.Location = new System.Drawing.Point(12, 313);
            this.secili_tarihi_sil.Name = "secili_tarihi_sil";
            this.secili_tarihi_sil.Size = new System.Drawing.Size(291, 25);
            this.secili_tarihi_sil.TabIndex = 46;
            this.secili_tarihi_sil.Text = "Seçili Devamsızlığı Sil";
            this.secili_tarihi_sil.UseVisualStyleBackColor = true;
            this.secili_tarihi_sil.Click += new System.EventHandler(this.secili_tarihi_sil_Click);
            // 
            // devamsizlik_listesi
            // 
            this.devamsizlik_listesi.FormattingEnabled = true;
            this.devamsizlik_listesi.ItemHeight = 16;
            this.devamsizlik_listesi.Location = new System.Drawing.Point(12, 139);
            this.devamsizlik_listesi.Name = "devamsizlik_listesi";
            this.devamsizlik_listesi.Size = new System.Drawing.Size(291, 148);
            this.devamsizlik_listesi.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Devamsızlıklar";
            // 
            // Devamsizlik_label1
            // 
            this.Devamsizlik_label1.AutoSize = true;
            this.Devamsizlik_label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Devamsizlik_label1.Location = new System.Drawing.Point(12, 290);
            this.Devamsizlik_label1.Name = "Devamsizlik_label1";
            this.Devamsizlik_label1.Size = new System.Drawing.Size(205, 20);
            this.Devamsizlik_label1.TabIndex = 47;
            this.Devamsizlik_label1.Text = "Toplam Devamsiz Gün Sayısı:";
            // 
            // DevamKontrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 345);
            this.Controls.Add(this.Devamsizlik_label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.secili_tarihi_sil);
            this.Controls.Add(this.devamsizlik_listesi);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DevamKontrolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devamsızlık İşlemleri";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button secili_tarihi_sil;
        private System.Windows.Forms.ListBox devamsizlik_listesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox devamsizlik_maskedTextBox1;
        private System.Windows.Forms.Label Devamsizlik_label1;
    }
}