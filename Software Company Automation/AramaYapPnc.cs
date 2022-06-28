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
    public partial class AramaYapPnc : Form
    {
        public AramaYapPnc()
        {
            InitializeComponent();
        }
        SqlConnection baglanti_adresi = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komut_veri_donusumu;//tablolari çekmek için kullanılıyor
        DataSet veriseti = new DataSet();//çekilen tablolari saklamak için kullanılır.
        private void AramaYapPnc_Load(object sender, EventArgs e)
        {
            TabloyuCek();//TABLOYU ÇEKME
            tablo_duzen();//TABLO BAŞLIK ADLARINI DEĞİŞTİRME FOKSİYONU
        }
        private void TabloyuCek()
        {
            veriseti.Clear();//Saklanan eski tablolari siler.
            baglanti_adresi.Open();//veritabanına bağlanılır
            Komut_veri_donusumu = new SqlDataAdapter("select * from StokTablo", baglanti_adresi);//GEREKLİ BİLGİLERİ ÇEKME
            Komut_veri_donusumu.Fill(veriseti, "StokTablo");//TABLOYU KAYDET
            baglanti_adresi.Close();//BAĞLANTIYI KAPATMA
            urun_listeleme_datagridview.DataSource = veriseti.Tables["StokTablo"];//KAYDEDILEN TABLOYU DATAGRİDDE GÖSTERME
            
        }
        private void tablo_duzen()
        {
            urun_listeleme_datagridview.Columns["UrunKodu"].HeaderText = "ÜRÜN KODU";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            urun_listeleme_datagridview.Columns["UrunAd"].HeaderText = "ÜRÜN AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ
            urun_listeleme_datagridview.Columns["UrunKategori"].HeaderText = "ÜRÜN KATEGORİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            urun_listeleme_datagridview.Columns["UrunFiyat"].HeaderText = "ÜRÜN FİYATİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            urun_listeleme_datagridview.Columns["UrunAdet"].HeaderText = "ÜRÜN ADET";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            urun_listeleme_datagridview.Columns["aciklama"].HeaderText = "AÇIKLAMA";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR


            urun_listeleme_datagridview.Columns["UrunKodu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            urun_listeleme_datagridview.Columns["UrunAd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            urun_listeleme_datagridview.Columns["UrunKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            urun_listeleme_datagridview.Columns["UrunFiyat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            urun_listeleme_datagridview.Columns["UrunAdet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            urun_listeleme_datagridview.Columns["aciklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
        }

        private void arama_yap_buton_Click(object sender, EventArgs e)
        {
            try
            {
                veriseti.Clear();//Saklanan eski tablolari siler.
                baglanti_adresi.Open();//VERİTABANINA BAĞLANTI AÇILDI
                Komut_veri_donusumu = new SqlDataAdapter("select * from StokTablo where UrunAd like '%"+arama_bilgisi_tb.Text+"%'", baglanti_adresi);
                Komut_veri_donusumu.Fill(veriseti, "StokTablo");//TABLOYU KAYDET
                baglanti_adresi.Close();//BAĞLANTIYI KAPATMA
                urun_listeleme_datagridview.DataSource = veriseti.Tables["StokTablo"];//KAYDEDILEN TABLOYU DATAGRİDDE GÖSTERME
            }
            catch (Exception HATA)
            {
                baglanti_adresi.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void tum_liste_buton_Click(object sender, EventArgs e)
        {
            TabloyuCek();
        }
    }
}
