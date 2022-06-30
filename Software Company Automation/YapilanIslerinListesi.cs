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
    public partial class YapilanIslerinListesi : Form
    {
        public YapilanIslerinListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti_adresi = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komut_veri_donusumu;//tablolari çekmek için kullanılıyor
        DataSet veriseti = new DataSet();//çekilen tablolari saklamak için kullanılır.
        private void YapilanIslerinListesi_Load(object sender, EventArgs e)
        {
            TarihMaskeText.Text = DateTime.Now.ToShortDateString();
            BilgileriGetir();
            tablo_duzen();
        }
        private void BilgileriGetir()
        {
            veriseti.Clear();//Saklanan eski tablolari siler.
            baglanti_adresi.Open();//veritabanına bağlanılır
            Komut_veri_donusumu = new SqlDataAdapter("SELECT  MusteriTC,(MusteriTablosu.ad) as 'MAd',(MusteriTablosu.soyad) as 'MSoyad',cep_telefonu,Kod,Tarih,BaslamaSaat,BitisSaat,Tanim,(PersonelTablosu.tc) as 'PTC',(PersonelTablosu.ad) as 'PAD',(PersonelTablosu.soyad) as 'PSOYAD' FROM IsBilgiTablo inner join MusteriTablosu on IsBilgiTablo.MusteriTC=MusteriTablosu.tcno inner join PersonelTablosu on IsBilgiTablo.isYapanTC=PersonelTablosu.tc where Tarih='"+TarihMaskeText.Text+"'", baglanti_adresi);//GEREKLİ BİLGİLERİ ÇEKME
            Komut_veri_donusumu.Fill(veriseti, "IsBilgiTablo");//TABLOYU KAYDET
            baglanti_adresi.Close();//BAĞLANTIYI KAPATMA
            Liste.DataSource = veriseti.Tables["IsBilgiTablo"];//KAYDEDILEN TABLOYU DATAGRİDDE GÖSTERME
        }
        private void tablo_duzen()
        {
            Liste.Columns["Kod"].HeaderText = "İŞ KODU";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            Liste.Columns["Tarih"].HeaderText = "TARİH";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ
            Liste.Columns["BaslamaSaat"].HeaderText = "BAŞLANGIÇ SAAT";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["BitisSaat"].HeaderText = "BİTİŞ SAAT";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["Tanim"].HeaderText = "TANIM";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["MusteriTC"].HeaderText = "MÜŞTERİ T.C NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["MAd"].HeaderText = "MÜŞTERİ AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["MSoyad"].HeaderText = "MÜŞTERİ SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["cep_telefonu"].HeaderText = "CEP TELEFONU";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["PTC"].HeaderText = "PERSONEL T.C NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["PAD"].HeaderText = "PERSONEL AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["PSOYAD"].HeaderText = "PERSONEL SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR

            Liste.Columns["Kod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["Tarih"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["BaslamaSaat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["BitisSaat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["Tanim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["MusteriTC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["MAd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["MSoyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["cep_telefonu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
        }
        public static string UKOD;
        public static bool KodTrue = false;
        private void alinanurunlerlistesiMenu_Click(object sender, EventArgs e)
        {
            UKOD = Liste.CurrentRow.Cells[4].Value.ToString();
            KodTrue = true;
            YapilanIsDetayListe DetayList = new YapilanIsDetayListe();
            DetayList.ShowDialog();
            UKOD = "";
            KodTrue = false;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            BilgileriGetir();
        }
    }
}
