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
    public partial class PersonelIslemPencere : Form
    {
        public PersonelIslemPencere()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
       
        private void musteriIslemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriAnaPencere MusteriIslem = new MusteriAnaPencere();
            MusteriIslem.ShowDialog();

        }

        private void PersonelIslemPencere_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            TarihBilgisi.BackColor = SaatBilgisi.BackColor = Color.Black;
            TarihBilgisi.ForeColor = SaatBilgisi.ForeColor = Color.White;
            iseGirisYapMenu.Visible = istenCikisYapMenu.Visible = YeniIsBilgisiGir.Visible = false;
            GirisCikisIslemleriniKontrolEt();
            BilgileriGetir();
            tablo_duzen();
        }
        public static bool IS = false;
        private void GirisCikisIslemleriniKontrolEt()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from CalismaTablo where TC='" + GirisPencere.tc + "' and Tarih='" + DateTime.Now.ToShortDateString() + "'", baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                iseGirisYapMenu.Visible = false;
                IS = true;
                if (oku["BitisSaat"].ToString().Trim() == "")
                {
                    istenCikisYapMenu.Visible = YeniIsBilgisiGir.Visible = true;
                }
                else
                {
                    istenCikisYapMenu.Visible = YeniIsBilgisiGir.Visible = false;
                }
            }
            else
            {
                iseGirisYapMenu.Visible = true;
                istenCikisYapMenu.Visible = YeniIsBilgisiGir.Visible = false;
                IS = false;
            }
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SaatBilgisi.Text = "SAAT:" + (DateTime.Now.ToShortTimeString());
            TarihBilgisi.Text = "TARİH:" + (DateTime.Now.ToShortDateString());
        }

        private void PersonelIslemPencere_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void işeBaşlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniIsBilgisiGir YeniIs = new YeniIsBilgisiGir();
            YeniIs.ShowDialog();
            BilgileriGetir();
        }

        private void iseGirisYapMenu_Click(object sender, EventArgs e)
        {
            GirisCikisIslemleri GirisYap = new GirisCikisIslemleri();
            GirisYap.ShowDialog();
            GirisCikisIslemleriniKontrolEt();//TEKRAR KONTROL EDİLECEK.
        }

        private void istenCikisYapMenu_Click(object sender, EventArgs e)
        {
            GirisCikisIslemleri CikisYap = new GirisCikisIslemleri();
            CikisYap.ShowDialog();
            GirisCikisIslemleriniKontrolEt();//TEKRAR KONTROL EDİLECEK.
        }
        SqlConnection baglanti_adresi = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komut_veri_donusumu;//tablolari çekmek için kullanılıyor
        DataSet veriseti = new DataSet();//çekilen tablolari saklamak için kullanılır.
        private void BilgileriGetir()
        {
            veriseti.Clear();//Saklanan eski tablolari siler.
            baglanti_adresi.Open();//veritabanına bağlanılır
            Komut_veri_donusumu = new SqlDataAdapter("SELECT Kod,Tarih,BaslamaSaat,BitisSaat,Tanim,tcno,ad,soyad,cep_telefonu FROM IsBilgiTablo inner join MusteriTablosu on IsBilgiTablo.MusteriTC=MusteriTablosu.tcno where Tarih='"+DateTime.Now.ToShortDateString()+"' and isYapanTC='"+GirisPencere.tc+"'", baglanti_adresi);//GEREKLİ BİLGİLERİ ÇEKME
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
            Liste.Columns["Tanim"].HeaderText = "İŞ TANIM";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["tcno"].HeaderText = "MÜŞTERİ T.C NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["ad"].HeaderText = "MÜŞTERİ AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["soyad"].HeaderText = "MÜŞTERİ SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["cep_telefonu"].HeaderText = "CEP TELEFONU";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR

            Liste.Columns["Kod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["Tarih"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["BaslamaSaat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["BitisSaat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["Tanim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["tcno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["soyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["cep_telefonu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
        }
        public static string urunkod;
        private void UrunleriListeleMenu_Click(object sender, EventArgs e)
        {
            urunkod = Liste.CurrentRow.Cells[0].Value.ToString();
            YapilanIsDetayListe DetayList = new YapilanIsDetayListe();
            DetayList.ShowDialog();
            urunkod = "";
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
