using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Company_Automation
{
    public partial class AdminPencere : Form
    {
        public AdminPencere()
        {
            InitializeComponent();
        }
        /*BU PENCERE STOK,PERSONEL VB İŞLEMLERE YÖNLENDİREN PENCEREDİR.*/
        public static bool guncelleme_islemi_yap = false;

        private void PersonelislemMenu_Click(object sender, EventArgs e)
        {
            PersonelPencere PersonelProcess = new PersonelPencere();
            PersonelProcess.ShowDialog();
        }

        private void aramaYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AramaYapPnc AramaYap = new AramaYapPnc();
            AramaYap.ShowDialog();
        }

        private void stokEkleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StokEkleGuncellePenceresi Ekle = new StokEkleGuncellePenceresi();
            Ekle.ShowDialog();
        }

        private void stokDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelleme_islemi_yap = true;
            StokEkleGuncellePenceresi DuzenleYap = new StokEkleGuncellePenceresi();
            DuzenleYap.ShowDialog();
            guncelleme_islemi_yap = false;
        }

        private void stokSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UrunSilPnc Sil = new UrunSilPnc();
            Sil.ShowDialog();
        }

        private void stokListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UrunListesiPencere Liste = new UrunListesiPencere();
            Liste.ShowDialog();
        }
    }
}
