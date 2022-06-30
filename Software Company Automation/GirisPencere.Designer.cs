
namespace Software_Company_Automation
{
    partial class GirisPencere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisPencere));
            this.kapat_pb = new System.Windows.Forms.PictureBox();
            this.giris_fotograf_pb = new System.Windows.Forms.PictureBox();
            this.kullanici_adi_pb = new System.Windows.Forms.PictureBox();
            this.kullanici_adi_tb = new System.Windows.Forms.TextBox();
            this.parola_tb = new System.Windows.Forms.TextBox();
            this.parola_pb = new System.Windows.Forms.PictureBox();
            this.giris_yap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cikis_yap_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kapat_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giris_fotograf_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanici_adi_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parola_pb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kapat_pb
            // 
            this.kapat_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapat_pb.Image = ((System.Drawing.Image)(resources.GetObject("kapat_pb.Image")));
            this.kapat_pb.Location = new System.Drawing.Point(443, 3);
            this.kapat_pb.Name = "kapat_pb";
            this.kapat_pb.Size = new System.Drawing.Size(37, 28);
            this.kapat_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapat_pb.TabIndex = 25;
            this.kapat_pb.TabStop = false;
            this.kapat_pb.Click += new System.EventHandler(this.kapat_pb_Click);
            // 
            // giris_fotograf_pb
            // 
            this.giris_fotograf_pb.Image = ((System.Drawing.Image)(resources.GetObject("giris_fotograf_pb.Image")));
            this.giris_fotograf_pb.Location = new System.Drawing.Point(12, 12);
            this.giris_fotograf_pb.Name = "giris_fotograf_pb";
            this.giris_fotograf_pb.Size = new System.Drawing.Size(458, 315);
            this.giris_fotograf_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.giris_fotograf_pb.TabIndex = 24;
            this.giris_fotograf_pb.TabStop = false;
            // 
            // kullanici_adi_pb
            // 
            this.kullanici_adi_pb.Image = ((System.Drawing.Image)(resources.GetObject("kullanici_adi_pb.Image")));
            this.kullanici_adi_pb.Location = new System.Drawing.Point(27, 19);
            this.kullanici_adi_pb.Name = "kullanici_adi_pb";
            this.kullanici_adi_pb.Size = new System.Drawing.Size(32, 24);
            this.kullanici_adi_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kullanici_adi_pb.TabIndex = 7;
            this.kullanici_adi_pb.TabStop = false;
            // 
            // kullanici_adi_tb
            // 
            this.kullanici_adi_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_adi_tb.Location = new System.Drawing.Point(155, 19);
            this.kullanici_adi_tb.Name = "kullanici_adi_tb";
            this.kullanici_adi_tb.Size = new System.Drawing.Size(269, 24);
            this.kullanici_adi_tb.TabIndex = 0;
            this.kullanici_adi_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parola_tb
            // 
            this.parola_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola_tb.Location = new System.Drawing.Point(155, 49);
            this.parola_tb.Name = "parola_tb";
            this.parola_tb.Size = new System.Drawing.Size(269, 24);
            this.parola_tb.TabIndex = 4;
            this.parola_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.parola_tb.UseSystemPasswordChar = true;
            // 
            // parola_pb
            // 
            this.parola_pb.Image = ((System.Drawing.Image)(resources.GetObject("parola_pb.Image")));
            this.parola_pb.Location = new System.Drawing.Point(27, 49);
            this.parola_pb.Name = "parola_pb";
            this.parola_pb.Size = new System.Drawing.Size(32, 24);
            this.parola_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.parola_pb.TabIndex = 8;
            this.parola_pb.TabStop = false;
            // 
            // giris_yap
            // 
            this.giris_yap.BackColor = System.Drawing.Color.White;
            this.giris_yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_yap.Location = new System.Drawing.Point(155, 79);
            this.giris_yap.Name = "giris_yap";
            this.giris_yap.Size = new System.Drawing.Size(269, 28);
            this.giris_yap.TabIndex = 21;
            this.giris_yap.Text = "Giriş Yap";
            this.giris_yap.UseVisualStyleBackColor = false;
            this.giris_yap.Click += new System.EventHandler(this.giris_yap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Parola:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "T.C No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cikis_yap_btn);
            this.groupBox1.Controls.Add(this.kullanici_adi_pb);
            this.groupBox1.Controls.Add(this.kullanici_adi_tb);
            this.groupBox1.Controls.Add(this.giris_yap);
            this.groupBox1.Controls.Add(this.parola_tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.parola_pb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 158);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Penceresi";
            // 
            // cikis_yap_btn
            // 
            this.cikis_yap_btn.BackColor = System.Drawing.Color.White;
            this.cikis_yap_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_yap_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_yap_btn.Location = new System.Drawing.Point(155, 113);
            this.cikis_yap_btn.Name = "cikis_yap_btn";
            this.cikis_yap_btn.Size = new System.Drawing.Size(269, 28);
            this.cikis_yap_btn.TabIndex = 22;
            this.cikis_yap_btn.Text = "Çıkış Yap";
            this.cikis_yap_btn.UseVisualStyleBackColor = false;
            this.cikis_yap_btn.Click += new System.EventHandler(this.cikis_yap_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Software Company Automation";
            // 
            // GirisPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kapat_pb);
            this.Controls.Add(this.giris_fotograf_pb);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisPencere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisPencere";
            this.Load += new System.EventHandler(this.GirisPencere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kapat_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giris_fotograf_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanici_adi_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parola_pb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kapat_pb;
        private System.Windows.Forms.PictureBox giris_fotograf_pb;
        private System.Windows.Forms.PictureBox kullanici_adi_pb;
        private System.Windows.Forms.TextBox kullanici_adi_tb;
        private System.Windows.Forms.TextBox parola_tb;
        private System.Windows.Forms.PictureBox parola_pb;
        private System.Windows.Forms.Button giris_yap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cikis_yap_btn;
        private System.Windows.Forms.Label label1;
    }
}