namespace Software_Company_Automation
{
    partial class UrunListesiPencere
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.urun_listeleme_datagridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.urun_listeleme_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // urun_listeleme_datagridview
            // 
            this.urun_listeleme_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urun_listeleme_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urun_listeleme_datagridview.Location = new System.Drawing.Point(0, 0);
            this.urun_listeleme_datagridview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urun_listeleme_datagridview.Name = "urun_listeleme_datagridview";
            this.urun_listeleme_datagridview.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.urun_listeleme_datagridview.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.urun_listeleme_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.urun_listeleme_datagridview.Size = new System.Drawing.Size(851, 404);
            this.urun_listeleme_datagridview.TabIndex = 24;
            // 
            // UrunListesiPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 404);
            this.Controls.Add(this.urun_listeleme_datagridview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UrunListesiPencere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN LİSTESİ PENCERESİ";
            this.Load += new System.EventHandler(this.UrunListesiPencere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urun_listeleme_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView urun_listeleme_datagridview;
    }
}