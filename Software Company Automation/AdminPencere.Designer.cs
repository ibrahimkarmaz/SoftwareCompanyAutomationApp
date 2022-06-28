
namespace Software_Company_Automation
{
    partial class AdminPencere
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
            this.UstMenu = new System.Windows.Forms.MenuStrip();
            this.PersonelislemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aramaYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokEkleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stokDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stokListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UstMenu
            // 
            this.UstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonelislemMenu,
            this.stokİşlemleriToolStripMenuItem});
            this.UstMenu.Location = new System.Drawing.Point(0, 0);
            this.UstMenu.Name = "UstMenu";
            this.UstMenu.Size = new System.Drawing.Size(784, 24);
            this.UstMenu.TabIndex = 0;
            this.UstMenu.Text = "menuStrip1";
            // 
            // PersonelislemMenu
            // 
            this.PersonelislemMenu.Name = "PersonelislemMenu";
            this.PersonelislemMenu.Size = new System.Drawing.Size(111, 20);
            this.PersonelislemMenu.Text = "Personel İşlemleri";
            this.PersonelislemMenu.Click += new System.EventHandler(this.PersonelislemMenu_Click);
            // 
            // stokİşlemleriToolStripMenuItem
            // 
            this.stokİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aramaYapToolStripMenuItem,
            this.stokEkleToolStripMenuItem2,
            this.stokDuzenleToolStripMenuItem,
            this.stokSilToolStripMenuItem1,
            this.stokListesiToolStripMenuItem1});
            this.stokİşlemleriToolStripMenuItem.Name = "stokİşlemleriToolStripMenuItem";
            this.stokİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.stokİşlemleriToolStripMenuItem.Text = "Stok İşlemleri";
            // 
            // aramaYapToolStripMenuItem
            // 
            this.aramaYapToolStripMenuItem.Name = "aramaYapToolStripMenuItem";
            this.aramaYapToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.aramaYapToolStripMenuItem.Text = "Stok Arama Yap";
            this.aramaYapToolStripMenuItem.Click += new System.EventHandler(this.aramaYapToolStripMenuItem_Click);
            // 
            // stokEkleToolStripMenuItem2
            // 
            this.stokEkleToolStripMenuItem2.Name = "stokEkleToolStripMenuItem2";
            this.stokEkleToolStripMenuItem2.Size = new System.Drawing.Size(194, 22);
            this.stokEkleToolStripMenuItem2.Text = "Stok Ekle";
            this.stokEkleToolStripMenuItem2.Click += new System.EventHandler(this.stokEkleToolStripMenuItem2_Click);
            // 
            // stokDuzenleToolStripMenuItem
            // 
            this.stokDuzenleToolStripMenuItem.Name = "stokDuzenleToolStripMenuItem";
            this.stokDuzenleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.stokDuzenleToolStripMenuItem.Text = "Stok Bilgilerini Düzenle";
            this.stokDuzenleToolStripMenuItem.Click += new System.EventHandler(this.stokDuzenleToolStripMenuItem_Click);
            // 
            // stokSilToolStripMenuItem1
            // 
            this.stokSilToolStripMenuItem1.Name = "stokSilToolStripMenuItem1";
            this.stokSilToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.stokSilToolStripMenuItem1.Text = "Stok Sil";
            this.stokSilToolStripMenuItem1.Click += new System.EventHandler(this.stokSilToolStripMenuItem1_Click);
            // 
            // stokListesiToolStripMenuItem1
            // 
            this.stokListesiToolStripMenuItem1.Name = "stokListesiToolStripMenuItem1";
            this.stokListesiToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.stokListesiToolStripMenuItem1.Text = "Stok Listesi";
            this.stokListesiToolStripMenuItem1.Click += new System.EventHandler(this.stokListesiToolStripMenuItem1_Click);
            // 
            // AdminPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 427);
            this.Controls.Add(this.UstMenu);
            this.MainMenuStrip = this.UstMenu;
            this.Name = "AdminPencere";
            this.Text = "AdminPencere";
            this.UstMenu.ResumeLayout(false);
            this.UstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip UstMenu;
        private System.Windows.Forms.ToolStripMenuItem PersonelislemMenu;
        private System.Windows.Forms.ToolStripMenuItem stokİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aramaYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokEkleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stokDuzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokSilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stokListesiToolStripMenuItem1;
    }
}