namespace Software_Company_Automation
{
    partial class GirisPenceresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisPenceresi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanici_adi_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parola_textbox = new System.Windows.Forms.TextBox();
            this.giris_yap_buton = new System.Windows.Forms.Button();
            this.giris_pb = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giris_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kullanici_adi_textbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.parola_textbox);
            this.groupBox1.Controls.Add(this.giris_yap_buton);
            this.groupBox1.Location = new System.Drawing.Point(13, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Size = new System.Drawing.Size(305, 150);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Penceresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // kullanici_adi_textbox
            // 
            this.kullanici_adi_textbox.Location = new System.Drawing.Point(111, 30);
            this.kullanici_adi_textbox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.kullanici_adi_textbox.Name = "kullanici_adi_textbox";
            this.kullanici_adi_textbox.Size = new System.Drawing.Size(173, 26);
            this.kullanici_adi_textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola:";
            // 
            // parola_textbox
            // 
            this.parola_textbox.Location = new System.Drawing.Point(111, 64);
            this.parola_textbox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.parola_textbox.Name = "parola_textbox";
            this.parola_textbox.Size = new System.Drawing.Size(173, 26);
            this.parola_textbox.TabIndex = 5;
            // 
            // giris_yap_buton
            // 
            this.giris_yap_buton.BackColor = System.Drawing.Color.White;
            this.giris_yap_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_yap_buton.Location = new System.Drawing.Point(111, 98);
            this.giris_yap_buton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.giris_yap_buton.Name = "giris_yap_buton";
            this.giris_yap_buton.Size = new System.Drawing.Size(173, 35);
            this.giris_yap_buton.TabIndex = 0;
            this.giris_yap_buton.Text = "Giriş Yap";
            this.giris_yap_buton.UseVisualStyleBackColor = false;
            this.giris_yap_buton.Click += new System.EventHandler(this.giris_yap_buton_Click);
            // 
            // giris_pb
            // 
            this.giris_pb.Image = ((System.Drawing.Image)(resources.GetObject("giris_pb.Image")));
            this.giris_pb.Location = new System.Drawing.Point(13, 13);
            this.giris_pb.Margin = new System.Windows.Forms.Padding(4);
            this.giris_pb.Name = "giris_pb";
            this.giris_pb.Size = new System.Drawing.Size(305, 122);
            this.giris_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.giris_pb.TabIndex = 22;
            this.giris_pb.TabStop = false;
            // 
            // GirisPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.giris_pb);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GirisPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisPenceresi";
            this.Load += new System.EventHandler(this.GirisPenceresi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giris_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullanici_adi_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parola_textbox;
        private System.Windows.Forms.Button giris_yap_buton;
        private System.Windows.Forms.PictureBox giris_pb;
    }
}