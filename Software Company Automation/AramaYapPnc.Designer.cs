namespace Software_Company_Automation
{
    partial class AramaYapPnc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.urun_listeleme_datagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.arama_bilgisi_tb = new System.Windows.Forms.TextBox();
            this.arama_yap_buton = new System.Windows.Forms.Button();
            this.tum_liste_buton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urun_listeleme_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // urun_listeleme_datagridview
            // 
            this.urun_listeleme_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urun_listeleme_datagridview.Location = new System.Drawing.Point(15, 57);
            this.urun_listeleme_datagridview.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.urun_listeleme_datagridview.Name = "urun_listeleme_datagridview";
            this.urun_listeleme_datagridview.ReadOnly = true;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.urun_listeleme_datagridview.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.urun_listeleme_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.urun_listeleme_datagridview.Size = new System.Drawing.Size(792, 276);
            this.urun_listeleme_datagridview.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "ÜRÜN ADI:";
            // 
            // arama_bilgisi_tb
            // 
            this.arama_bilgisi_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama_bilgisi_tb.Location = new System.Drawing.Point(94, 22);
            this.arama_bilgisi_tb.Name = "arama_bilgisi_tb";
            this.arama_bilgisi_tb.Size = new System.Drawing.Size(166, 21);
            this.arama_bilgisi_tb.TabIndex = 27;
            // 
            // arama_yap_buton
            // 
            this.arama_yap_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama_yap_buton.Location = new System.Drawing.Point(268, 20);
            this.arama_yap_buton.Name = "arama_yap_buton";
            this.arama_yap_buton.Size = new System.Drawing.Size(87, 27);
            this.arama_yap_buton.TabIndex = 28;
            this.arama_yap_buton.Text = "Arama Yap";
            this.arama_yap_buton.UseVisualStyleBackColor = true;
            this.arama_yap_buton.Click += new System.EventHandler(this.arama_yap_buton_Click);
            // 
            // tum_liste_buton
            // 
            this.tum_liste_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tum_liste_buton.Location = new System.Drawing.Point(690, 20);
            this.tum_liste_buton.Name = "tum_liste_buton";
            this.tum_liste_buton.Size = new System.Drawing.Size(117, 27);
            this.tum_liste_buton.TabIndex = 29;
            this.tum_liste_buton.Text = "Tüm Liste";
            this.tum_liste_buton.UseVisualStyleBackColor = true;
            this.tum_liste_buton.Click += new System.EventHandler(this.tum_liste_buton_Click);
            // 
            // AramaYapPnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 346);
            this.Controls.Add(this.tum_liste_buton);
            this.Controls.Add(this.arama_yap_buton);
            this.Controls.Add(this.arama_bilgisi_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urun_listeleme_datagridview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AramaYapPnc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARAMA YAP";
            this.Load += new System.EventHandler(this.AramaYapPnc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urun_listeleme_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView urun_listeleme_datagridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arama_bilgisi_tb;
        private System.Windows.Forms.Button arama_yap_buton;
        private System.Windows.Forms.Button tum_liste_buton;
    }
}