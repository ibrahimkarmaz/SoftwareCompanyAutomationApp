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
    public partial class UrunSilPnc : Form
    {
        public UrunSilPnc()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(APencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
        private void UrunSilPnc_Load(object sender, EventArgs e)
        {
            sil_bt.Enabled = false;
            UrunKodlariniCek();
        }
        private void UrunKodlariniCek()//ÜRÜN KODLARINI ÇEKME
        {
            try
            {
                Urun_Kodu_Combobox.Items.Clear();
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select UrunKodu from StokTablo", baglanti);
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                while (oku.Read())//OKUMA
                {
                    /*VERİLERİN TUTULDUĞU TEXTBOX VE COMBOBOXLARA AKTARILDIĞI YERDİR*/
                    Urun_Kodu_Combobox.Items.Add(oku["UrunKodu"].ToString());

                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                if (Urun_Kodu_Combobox.Items.Count>=1)
                {
                    sil_bt.Enabled = true;
                    Urun_Kodu_Combobox.SelectedIndex = 0;
                }
                else
                {
                    sil_bt.Enabled = false;
                }
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void Urun_Kodu_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SEÇİLEN ÜRÜN KODUNA GÖRE VERİLERİ GETİRME.
            try
            {
                bilgi_goster_lb.Text="";
                baglanti.Open();
                komut = new SqlCommand("select * from StokTablo where UrunKodu=@UK", baglanti);//ÜRÜN KODLARINI ÇEKME KOMUTU
                komut.Parameters.Add("@UK", Urun_Kodu_Combobox.SelectedItem.ToString());
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                while (oku.Read())//OKUMA
                {
                    bilgi_goster_lb.Text="ÜRÜN ADI: "+oku["UrunAd"].ToString()+"\n";
                    bilgi_goster_lb.Text+="ÜRÜN KATEGORİ: "+oku["UrunKategori"].ToString()+"\n";
                    bilgi_goster_lb.Text +="ÜRÜN FİYATİ: "+oku["UrunFiyat"].ToString()+" TL\n";
                    bilgi_goster_lb.Text +="ÜRÜN ADETİ:"+oku["UrunAdet"].ToString()+"\n";
                    bilgi_goster_lb.Text +="AÇIKLAMA:"+ oku["aciklama"].ToString();
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)//HATA OLURSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void sil_bt_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("delete from StokTablo where UrunKodu=@UK", baglanti);//ÜRÜN KODLARINI ÇEKME KOMUTU
                komut.Parameters.Add("@UK", Urun_Kodu_Combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                UrunKodlariniCek();
                bilgi_goster_lb.Text = "BİLGİ:Seçim Yapınız...";
                MessageBox.Show("ÜRÜN SİSTEMDEN SİLİNMİŞTİR.", "ÜRÜN SİLME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception HATA)//HATA OLURSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }
    }
}
