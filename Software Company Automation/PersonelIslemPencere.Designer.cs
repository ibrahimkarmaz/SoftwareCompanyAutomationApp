
namespace Software_Company_Automation
{
    partial class PersonelIslemPencere
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iseGirisYapMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.istenCikisYapMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.YeniIsBilgisiGir = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriIslemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TarihBilgisi = new System.Windows.Forms.ToolStripMenuItem();
            this.SaatBilgisi = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelİşlemleriToolStripMenuItem,
            this.musteriIslemToolStripMenuItem,
            this.cikisYapToolStripMenuItem,
            this.TarihBilgisi,
            this.SaatBilgisi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "UstMenu";
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iseGirisYapMenu,
            this.istenCikisYapMenu,
            this.YeniIsBilgisiGir});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // iseGirisYapMenu
            // 
            this.iseGirisYapMenu.Name = "iseGirisYapMenu";
            this.iseGirisYapMenu.Size = new System.Drawing.Size(180, 22);
            this.iseGirisYapMenu.Text = "İşe Başlama Saati";
            this.iseGirisYapMenu.Click += new System.EventHandler(this.iseGirisYapMenu_Click);
            // 
            // istenCikisYapMenu
            // 
            this.istenCikisYapMenu.Name = "istenCikisYapMenu";
            this.istenCikisYapMenu.Size = new System.Drawing.Size(180, 22);
            this.istenCikisYapMenu.Text = "İşen Çıkış Saati";
            this.istenCikisYapMenu.Click += new System.EventHandler(this.istenCikisYapMenu_Click);
            // 
            // YeniIsBilgisiGir
            // 
            this.YeniIsBilgisiGir.Name = "YeniIsBilgisiGir";
            this.YeniIsBilgisiGir.Size = new System.Drawing.Size(180, 22);
            this.YeniIsBilgisiGir.Text = "Yeni İş Bilgisi Gir";
            this.YeniIsBilgisiGir.Click += new System.EventHandler(this.işeBaşlaToolStripMenuItem_Click);
            // 
            // musteriIslemToolStripMenuItem
            // 
            this.musteriIslemToolStripMenuItem.Name = "musteriIslemToolStripMenuItem";
            this.musteriIslemToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.musteriIslemToolStripMenuItem.Text = "Müşteri İşemleri";
            this.musteriIslemToolStripMenuItem.Click += new System.EventHandler(this.musteriIslemToolStripMenuItem_Click);
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // TarihBilgisi
            // 
            this.TarihBilgisi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TarihBilgisi.Name = "TarihBilgisi";
            this.TarihBilgisi.Size = new System.Drawing.Size(54, 20);
            this.TarihBilgisi.Text = "TARİH:";
            // 
            // SaatBilgisi
            // 
            this.SaatBilgisi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SaatBilgisi.Name = "SaatBilgisi";
            this.SaatBilgisi.Size = new System.Drawing.Size(49, 20);
            this.SaatBilgisi.Text = "SAAT:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PersonelIslemPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 406);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PersonelIslemPencere";
            this.Text = "PersonelIslemPencere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonelIslemPencere_FormClosing);
            this.Load += new System.EventHandler(this.PersonelIslemPencere_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem musteriIslemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iseGirisYapMenu;
        private System.Windows.Forms.ToolStripMenuItem istenCikisYapMenu;
        private System.Windows.Forms.ToolStripMenuItem YeniIsBilgisiGir;
        private System.Windows.Forms.ToolStripMenuItem TarihBilgisi;
        private System.Windows.Forms.ToolStripMenuItem SaatBilgisi;
        private System.Windows.Forms.Timer timer1;
    }
}