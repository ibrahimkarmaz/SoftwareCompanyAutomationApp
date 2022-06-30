using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminPencere_Load(object sender, EventArgs e)
        {
            BilgileriGetir();
            tablo_duzen();
        }
        SqlConnection baglanti_adresi = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komut_veri_donusumu;//tablolari çekmek için kullanılıyor
        DataSet veriseti = new DataSet();//çekilen tablolari saklamak için kullanılır.
        private void BilgileriGetir()
        {
            veriseti.Clear();//Saklanan eski tablolari siler.
            baglanti_adresi.Open();//veritabanına bağlanılır
            Komut_veri_donusumu = new SqlDataAdapter("SELECT Kod,Tarih,BaslamaSaat,BitisSaat,Tanim,tcno,ad,soyad,cep_telefonu FROM IsBilgiTablo inner join MusteriTablosu on IsBilgiTablo.MusteriTC=MusteriTablosu.tcno where Tarih='" + DateTime.Now.ToShortDateString() + "'", baglanti_adresi);//GEREKLİ BİLGİLERİ ÇEKME
            Komut_veri_donusumu.Fill(veriseti, "IsBilgiTablo");//TABLOYU KAYDET
            baglanti_adresi.Close();//BAĞLANTIYI KAPATMA
            Liste.DataSource = veriseti.Tables["IsBilgiTablo"];//KAYDEDILEN TABLOYU DATAGRİDDE GÖSTERME
            tablo_duzen();//TABLO BAŞLIK ADLARINI DEĞİŞTİRME FOKSİYONU
        }
        private void tablo_duzen()
        {
            Liste.Columns["Kod"].HeaderText = "İŞ KODU";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            Liste.Columns["Tarih"].HeaderText = "TARİH";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ
            Liste.Columns["BaslamaSaat"].HeaderText = "BAŞLANGIÇ SAAT";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["BitisSaat"].HeaderText = "BİTİŞ SAAT";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["Tanim"].HeaderText = "TANIM";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["tcno"].HeaderText = "MÜŞTERİ T.C NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["ad"].HeaderText = "MÜŞTERİ AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["soyad"].HeaderText = "MÜŞTERİ SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["cep_telefonu"].HeaderText = "CEP TELEFONU";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR

            Liste.Columns["Kod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["Tarih"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["BaslamaSaat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["BitisSaat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["Tanim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["tcno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["soyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["cep_telefonu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
        }

        private void PersonelGirisCikisMenu_Click(object sender, EventArgs e)
        {
            PersonelGirisCikisKontrol PGCK = new PersonelGirisCikisKontrol();
            PGCK.ShowDialog();
        }

        private void PersonelIsKontrolMenu_Click(object sender, EventArgs e)
        {
            YapilanIslerinListesi Liste = new YapilanIslerinListesi();
            Liste.ShowDialog();
        }

        private void AdminPencere_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
