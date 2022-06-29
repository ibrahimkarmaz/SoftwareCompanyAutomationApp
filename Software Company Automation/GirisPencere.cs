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
    public partial class GirisPencere : Form
    {
        public GirisPencere()
        {
            InitializeComponent();
        }
        public static string global_baglanti_adresi = @"server=DESKTOP-5DGSRBQ;database=SCA;Trusted_Connection=yes";
        SqlConnection baglanti = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        private void GirisPencere_Load(object sender, EventArgs e)
        {
        }

        private void kapat_pb_Click(object sender, EventArgs e)
        {
            Application.Exit();//UYGULAMAYI KAPATIR.
        }

        private void cikis_yap_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();//UYGULAMAYI KAPATIR.
        }
        public static string tc = "";
        private void giris_yap_Click(object sender, EventArgs e)
        {
            tc = kullanici_adi_tb.Text;
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM GirisTablosu WHERE Tcno='"+kullanici_adi_tb.Text+ "' and Parola='"+parola_tb.Text+"'", baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                if (Convert.ToBoolean(oku["Durum"]))
                {
                    AdminPencere Yonetici = new AdminPencere();
                    Yonetici.Show();
                    Hide();
                }
                else
                {
                    PersonelIslemPencere Personel = new PersonelIslemPencere();
                    Personel.Show();
                    Hide(); 
                }
            }
            else
            {
                MessageBox.Show("T.C NUMARASI VEYA PAROLANIZ YANLIŞTIR","GİRİŞ İŞLEMLERİ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
    }
}
