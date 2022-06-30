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
    public partial class PersonelGirisCikisKontrol : Form
    {
        public PersonelGirisCikisKontrol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti_adresi = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komut_veri_donusumu;//tablolari çekmek için kullanılıyor
        DataSet veriseti = new DataSet();//çekilen tablolari saklamak için kullanılır.
        private void BilgileriGetir()
        {
            veriseti.Clear();//Saklanan eski tablolari siler.
            baglanti_adresi.Open();//veritabanına bağlanılır
            Komut_veri_donusumu = new SqlDataAdapter("select CalismaTablo.TC,ad,soyad,tel,Tarih,BaslangicSaat,BitisSaat,Aciklama from CalismaTablo inner join PersonelTablosu on CalismaTablo.TC=PersonelTablosu.tc where Tarih='" + TarihMaskeText.Text+"'", baglanti_adresi);//GEREKLİ BİLGİLERİ ÇEKME
            Komut_veri_donusumu.Fill(veriseti, "CalismaTablo");//TABLOYU KAYDET
            baglanti_adresi.Close();//BAĞLANTIYI KAPATMA
            Liste.DataSource = veriseti.Tables["CalismaTablo"];//KAYDEDILEN TABLOYU DATAGRİDDE GÖSTERME
            tablo_duzen();//TABLO BAŞLIK ADLARINI DEĞİŞTİRME FOKSİYONU
        }
        private void tablo_duzen()
        {
            Liste.Columns["TC"].HeaderText = "T.C NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            Liste.Columns["ad"].HeaderText = "AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ
            Liste.Columns["soyad"].HeaderText = "SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["tel"].HeaderText = "TELEFON";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["Tarih"].HeaderText = "TARİH";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["BaslangicSaat"].HeaderText = "İŞE BAŞLAMA SAATİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["BitisSaat"].HeaderText = "İŞTEN ÇIKIŞ SAATİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            Liste.Columns["Aciklama"].HeaderText = "AÇIKLAMA";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR

            Liste.Columns["TC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["soyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["tel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["Tarih"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["BaslangicSaat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["BitisSaat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
            Liste.Columns["Aciklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATIK BOYUTLANDIRMA
        }


        private void PersonelGirisCikisKontrol_Load(object sender, EventArgs e)
        {
            TarihMaskeText.Text = DateTime.Now.ToShortDateString();
            BilgileriGetir();
            tablo_duzen();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            BilgileriGetir();
        }
    }
}
