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
    public partial class GirisPenceresi : Form
    {
        public GirisPenceresi()
        {
            InitializeComponent();
        }
        public static string global_baglanti_adresi = @"server=DESKTOP-5DGSRBQ;database=MYS;Trusted_Connection=yes";
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.global_baglanti_adresi);//GENEL BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT//SQL KODLARI YAZDIĞIMIZ YER
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
        private void GirisPenceresi_Load(object sender, EventArgs e)
        {
            parola_textbox.UseSystemPasswordChar = true;//PAROLA KUTUSUNUN KARAKTERLERİNİ YUVARLAK(*) GÖSTERİR
            kullanici_adi_textbox.MaxLength = parola_textbox.MaxLength = 20;//VERİTABANİ KISITLAMASI (VERİTANİNDA EN FAZLA 20 KARAKTER GİRİŞİ YAPILABİLİR.)
        }

        private void giris_yap_buton_Click(object sender, EventArgs e)
        {
            giris_islemleri();//GİRİŞ İŞLEMLERİ
        }
        private void giris_islemleri()
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select * from giris_tablosu where kullanici_adi='" + kullanici_adi_textbox.Text + "' and parola='" + parola_textbox.Text + "'", baglanti);
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                if (oku.Read())//EĞER VERİLER OKUNUYORSA DOĞRU BLOĞUNA GİRER.
                {
                    //ANAPENCEREYİ PENCEREYİ AÇMA KOMUTU
                    MusteriAnaPencere ac = new MusteriAnaPencere();
                    ac.Show();
                    this.Hide();//BU PENCEREYİ GİZLEME KODU
                }
                else
                {
                    MessageBox.Show("KULLANICI ADI VEYA PAROLA YANLIŞTIR", "GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);//EĞER GİRİŞ YAPILAMADI İSE NEDENLERINI PENCEREDE GÖSTERME
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)
            {
                baglanti.Close();//EĞER HATA VERİRSE BAĞLANTIYI KAPATMA NEDENİ:BAĞLI YERE TEKRAR BAĞLANAMASSIN.
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }
    }
}
