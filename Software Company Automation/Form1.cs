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
    public partial class APencere : Form
    {
        public APencere()
        {
            InitializeComponent();
        }
        public static string global_baglanti_adresi = @"server=DESKTOP-5DGSRBQ;database=TA_StokDB;Trusted_Connection=yes";
        private void APencere_Load(object sender, EventArgs e)
        {

        }

        private void ekle_bt_Click(object sender, EventArgs e)
        {
            StokEkleGuncellePenceresi ac = new StokEkleGuncellePenceresi();
            ac.ShowDialog();
        }

        private void stok_listesi_Click(object sender, EventArgs e)
        {
            UrunListesiPencere ac = new UrunListesiPencere();
            ac.ShowDialog();
        }
        public static bool guncelleme_islemi_yap = false;
        private void guncelle_bt_Click(object sender, EventArgs e)
        {
            guncelleme_islemi_yap = true;
            StokEkleGuncellePenceresi ac = new StokEkleGuncellePenceresi();
            ac.ShowDialog();
            guncelleme_islemi_yap = false;
        }

        private void sil_bt_Click(object sender, EventArgs e)
        {
            UrunSilPnc sil = new UrunSilPnc();
            sil.ShowDialog();
        }

        private void arama_yap_bt_Click(object sender, EventArgs e)
        {
            AramaYapPnc AramaYapPenceresi = new AramaYapPnc();
            AramaYapPenceresi.ShowDialog();
        }

        private void APencere_FormClosing(object sender, FormClosingEventArgs e)
        {//EVENT OLAYIDIR FORM KAPATILDIĞINDA ÇALIŞIR
            Application.Exit();//TÜM UYGULAMAYI KAPATIR.
        }

    }
}
