
namespace Software_Company_Automation
{
    partial class GirisCikisIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbGirisSaat = new System.Windows.Forms.MaskedTextBox();
            this.TbCikisSaat = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbTarih = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnIslem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChbGirisDegistir = new System.Windows.Forms.CheckBox();
            this.ChbCikisDegistir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşe Giriş Saat:";
            // 
            // TbGirisSaat
            // 
            this.TbGirisSaat.Location = new System.Drawing.Point(123, 38);
            this.TbGirisSaat.Mask = "00:00";
            this.TbGirisSaat.Name = "TbGirisSaat";
            this.TbGirisSaat.Size = new System.Drawing.Size(100, 22);
            this.TbGirisSaat.TabIndex = 1;
            this.TbGirisSaat.ValidatingType = typeof(System.DateTime);
            // 
            // TbCikisSaat
            // 
            this.TbCikisSaat.Location = new System.Drawing.Point(123, 66);
            this.TbCikisSaat.Mask = "00:00";
            this.TbCikisSaat.Name = "TbCikisSaat";
            this.TbCikisSaat.Size = new System.Drawing.Size(100, 22);
            this.TbCikisSaat.TabIndex = 3;
            this.TbCikisSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşten Çıkış Saati:";
            // 
            // TbTarih
            // 
            this.TbTarih.Location = new System.Drawing.Point(123, 10);
            this.TbTarih.Mask = "00/00/0000";
            this.TbTarih.Name = "TbTarih";
            this.TbTarih.Size = new System.Drawing.Size(121, 22);
            this.TbTarih.TabIndex = 5;
            this.TbTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "İş Tarihi:";
            // 
            // BtnIslem
            // 
            this.BtnIslem.BackColor = System.Drawing.Color.White;
            this.BtnIslem.Location = new System.Drawing.Point(16, 312);
            this.BtnIslem.Name = "BtnIslem";
            this.BtnIslem.Size = new System.Drawing.Size(228, 41);
            this.BtnIslem.TabIndex = 6;
            this.BtnIslem.Text = "BAŞLA";
            this.BtnIslem.UseVisualStyleBackColor = false;
            this.BtnIslem.Click += new System.EventHandler(this.BtnIslem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Açıklama:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 190);
            this.textBox1.TabIndex = 8;
            // 
            // ChbGirisDegistir
            // 
            this.ChbGirisDegistir.AutoSize = true;
            this.ChbGirisDegistir.Location = new System.Drawing.Point(229, 43);
            this.ChbGirisDegistir.Name = "ChbGirisDegistir";
            this.ChbGirisDegistir.Size = new System.Drawing.Size(15, 14);
            this.ChbGirisDegistir.TabIndex = 10;
            this.ChbGirisDegistir.UseVisualStyleBackColor = true;
            this.ChbGirisDegistir.CheckedChanged += new System.EventHandler(this.ChbGirisDegistir_CheckedChanged);
            // 
            // ChbCikisDegistir
            // 
            this.ChbCikisDegistir.AutoSize = true;
            this.ChbCikisDegistir.Location = new System.Drawing.Point(229, 70);
            this.ChbCikisDegistir.Name = "ChbCikisDegistir";
            this.ChbCikisDegistir.Size = new System.Drawing.Size(15, 14);
            this.ChbCikisDegistir.TabIndex = 11;
            this.ChbCikisDegistir.UseVisualStyleBackColor = true;
            this.ChbCikisDegistir.CheckedChanged += new System.EventHandler(this.ChbCikisDegistir_CheckedChanged);
            // 
            // GirisCikisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 361);
            this.Controls.Add(this.ChbCikisDegistir);
            this.Controls.Add(this.ChbGirisDegistir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnIslem);
            this.Controls.Add(this.TbTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbCikisSaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbGirisSaat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirisCikisIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞE GİRİŞ/ÇIKIŞ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.GirisCikisIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TbGirisSaat;
        private System.Windows.Forms.MaskedTextBox TbCikisSaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TbTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnIslem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ChbGirisDegistir;
        private System.Windows.Forms.CheckBox ChbCikisDegistir;
    }
}