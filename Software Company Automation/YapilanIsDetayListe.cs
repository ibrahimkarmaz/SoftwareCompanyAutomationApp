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
    public partial class YapilanIsDetayListe : Form
    {
        public YapilanIsDetayListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti_adresi = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komut_veri_donusumu;//tablolari çekmek için kullanılıyor
        DataSet veriseti = new DataSet();//çekilen tablolari saklamak için kullanılır.
        private void YapilanIsDetayListe_Load(object sender, EventArgs e)
        {
            BilgileriGetir();
            //tablo_duzen();
        }
        private void BilgileriGetir()
        {
            veriseti.Clear();//Saklanan eski tablolari siler.
            baglanti_adresi.Open();//veritabanına bağlanılır
            if (YapilanIslerinListesi.KodTrue==false)
            {
                Komut_veri_donusumu = new SqlDataAdapter("SELECT * from IsBilgiTabloDetay where Kod='"+PersonelIslemPencere.urunkod+"'", baglanti_adresi);//GEREKLİ BİLGİLERİ ÇEKME
            }
            else
            {
                Komut_veri_donusumu = new SqlDataAdapter("SELECT * from IsBilgiTabloDetay where Kod='" + YapilanIslerinListesi.UKOD+ "'", baglanti_adresi);//GEREKLİ BİLGİLERİ ÇEKME
            }
           
            Komut_veri_donusumu.Fill(veriseti, "IsBilgiTablo");//TABLOYU KAYDET
            baglanti_adresi.Close();//BAĞLANTIYI KAPATMA
            Liste.DataSource = veriseti.Tables["IsBilgiTablo"];//KAYDEDILEN TABLOYU DATAGRİDDE GÖSTERME
            tablo_duzen();//TABLO BAŞLIK ADLARINI DEĞİŞTİRME FOKSİYONU
        }
        private void tablo_duzen()
        {
            Liste.Columns["Kod"].HeaderText = "İŞ KODU";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            Liste.Columns["UrunKod"].HeaderText = "ÜRÜN KODU";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ
            Liste.Columns["UrunAd"].HeaderText = "ÜRÜN ADI";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["AlisAdet"].HeaderText = "ALIŞ ADETİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["AlisFiyat"].HeaderText = "ALIŞ FİYATİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR

            Liste.Columns["Kod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["UrunKod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["UrunAd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["AlisAdet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["AlisFiyat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
        }
    }
}
