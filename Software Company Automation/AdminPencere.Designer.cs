
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UstMenu = new System.Windows.Forms.MenuStrip();
            this.PersonelislemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aramaYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokEkleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stokDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stokListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonelGirisCikisMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonelIsKontrolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.UstMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // UstMenu
            // 
            this.UstMenu.BackColor = System.Drawing.Color.White;
            this.UstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonelislemMenu,
            this.stokİşlemleriToolStripMenuItem,
            this.PersonelGirisCikisMenu,
            this.PersonelIsKontrolMenu});
            this.UstMenu.Location = new System.Drawing.Point(0, 0);
            this.UstMenu.Name = "UstMenu";
            this.UstMenu.Size = new System.Drawing.Size(849, 24);
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
            // PersonelGirisCikisMenu
            // 
            this.PersonelGirisCikisMenu.Name = "PersonelGirisCikisMenu";
            this.PersonelGirisCikisMenu.Size = new System.Drawing.Size(175, 20);
            this.PersonelGirisCikisMenu.Text = "Personel Giriş/Çıkış Kontrol Et";
            this.PersonelGirisCikisMenu.Click += new System.EventHandler(this.PersonelGirisCikisMenu_Click);
            // 
            // PersonelIsKontrolMenu
            // 
            this.PersonelIsKontrolMenu.Name = "PersonelIsKontrolMenu";
            this.PersonelIsKontrolMenu.Size = new System.Drawing.Size(156, 20);
            this.PersonelIsKontrolMenu.Text = "Personel İşlerini Kontrol Et";
            this.PersonelIsKontrolMenu.Click += new System.EventHandler(this.PersonelIsKontrolMenu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(849, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "GÜNLÜK YAPILAN İŞLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Liste);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 375);
            this.panel1.TabIndex = 3;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Margin = new System.Windows.Forms.Padding(4);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(849, 375);
            this.Liste.TabIndex = 55;
            // 
            // AdminPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UstMenu);
            this.MainMenuStrip = this.UstMenu;
            this.Name = "AdminPencere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Penceresi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPencere_FormClosing);
            this.Load += new System.EventHandler(this.AdminPencere_Load);
            this.UstMenu.ResumeLayout(false);
            this.UstMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem PersonelGirisCikisMenu;
        private System.Windows.Forms.ToolStripMenuItem PersonelIsKontrolMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Liste;
    }
}