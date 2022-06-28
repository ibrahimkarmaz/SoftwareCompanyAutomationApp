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
    public partial class StokEkleGuncellePenceresi : Form
    {
        public StokEkleGuncellePenceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
        private void StokEkleGuncellePenceresi_Load(object sender, EventArgs e)
        {
            UrunKoduOlustur();
            urun_kodu_textBox1.ReadOnly = true;

            //VERİTABANINDAN KAYNAKLI KISITLAMALAR (HATA ENGELLEMEK İÇİN ÖRNEK VERİTABANINDA KARAKTER SAYISI 30 İSE BURDA 30+ FAZLA GİRİNCE HATA ALIRIZ.)
            urun_ad_textBox2.MaxLength = 30;
            aciklama_textBox6.MaxLength = 500;

            //STOK'A EKLEMEK İÇİN MİN 1 ÜRÜN EN FAZLA 1000 ÜRÜN VE EKLEME BUTONU İSE 1'ER 1'ER ARTIŞ YAPSIN.
            urun_adet_numericUpDown1.Minimum = 1;
            urun_adet_numericUpDown1.Increment = 1;
            urun_adet_numericUpDown1.Maximum = 1000;

            //KATEGORİLER.
            KategorileriGetir();


            Urun_Kodu_Combobox.Visible = false;//Sadece güncelleme işleminde kullanılacak.
            if (AdminPencere.guncelleme_islemi_yap == true)//GÜNCELLEME İŞLEMLERİ İÇİN AKTİF HALE GETİRİLDİ.
            {
                urun_adet_numericUpDown1.Minimum = 0;//ÜRÜN SATIŞA ÇIKTU İSE ADET MİKTARİ SIFIR OLABİLİR
                Urun_Ekle_Guncelle_button1.Enabled = false;
                urun_kodu_textBox1.Visible = button1.Visible = false;
                Urun_Kodu_Combobox.Visible = true;
                Urun_Ekle_Guncelle_button1.Text = "ÜRÜN GÜNCELLE";
                UrunKodlariniCek();
                if (Urun_Kodu_Combobox.Items.Count>=1)
                {
                    Urun_Kodu_Combobox.SelectedIndex = 0;
                    Urun_Ekle_Guncelle_button1.Enabled = true;
                }
                
            }
        }
        Random UrunKoduRasgele = new Random();
        private void UrunKoduOlustur()//8 HANELI KOD
        {
            urun_kodu_textBox1.Text = UrunKoduRasgele.Next(10000000, 99999999).ToString();
        }
        private void KategorileriGetir()
        {//ÜRÜN KATEGORİ
            urun_kategori_comboBox1.Items.Clear();
            urun_kategori_comboBox1.Items.Add("DONANIM");
            urun_kategori_comboBox1.Items.Add("YAZILIM");



            urun_kategori_comboBox1.SelectedIndex = 0;
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

            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void Urun_Ekle_Guncelle_button1_Click(object sender, EventArgs e)
        {
            if (urun_ad_textBox2.TextLength >= 2)//AÇIKLAMA KUTUSU BOŞ GEÇİLEMEZ
            {
                if (urun_fiyat_textBox4.Text != "")//AÇIKLAMA KUTUSU BOŞ GEÇİLEMEZ
                {
                    if (urun_fiyat_textBox4.Text != "")//AÇIKLAMA KUTUSU BOŞ GEÇİLEMEZ
                    {
                        if (AdminPencere.guncelleme_islemi_yap==false)
                        {
                            veritabanina_ekle();
                        }
                        else if (AdminPencere.guncelleme_islemi_yap == true)
                        {
                            veritabanina_guncelleme_yap();
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ÜRÜN FİYATI BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//YANLIŞ GİRİŞTE VERİLEN UYARI MESAJI
                    }
                }
                else
                {
                    MessageBox.Show("ÜRÜN FİYATI BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//YANLIŞ GİRİŞTE VERİLEN UYARI MESAJI
                }
            }
            else
            {
                MessageBox.Show("ÜRÜN ADI İKİ HANEDEN FAZLA OLMALIDIR...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//YANLIŞ GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void veritabanina_ekle()//YENİ STOK EKLEME FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("insert into StokTablo values(@kod,@ad,@kategori,@fiyat,@adet,@aciklama)", baglanti);
                komut.Parameters.AddWithValue("@kod", urun_kodu_textBox1.Text);
                komut.Parameters.AddWithValue("@ad", urun_ad_textBox2.Text);
                komut.Parameters.AddWithValue("@kategori", urun_kategori_comboBox1.Text);
                komut.Parameters.AddWithValue("@fiyat", urun_fiyat_textBox4.Text);
                komut.Parameters.AddWithValue("@adet", urun_adet_numericUpDown1.Value);
                komut.Parameters.AddWithValue("@aciklama", aciklama_textBox6.Text);
                komut.ExecuteNonQuery();//KOMUTLARI ÇALIŞTIRMA
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("YENİ ÜRÜN EKLENDİ.", "ÜRÜN EKLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);//EKLEME HAKKINDA BİLGİ
                // temizle();//TEKRAR GİRİŞ YAPILABİLMESİ İÇİN VARSAYILANA DÖNÜNÜR(KUTULA SİLİNİR SEÇİM KUTUSU DÜZENLENIR)
            }
            catch (Exception)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("SİSTEM DIŞI HATA OLUŞTU\nÜRÜN FİYATINI KONTROL EDİNİZ EĞER KUSURATLI İSE , YERİNE . KOYUNUZ...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void veritabanina_guncelleme_yap()//STOK BİLGİLERİ GÜNCELLEME
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("update StokTablo set UrunAd=@ad,UrunKategori=@kategori,UrunFiyat=@fiyat,UrunAdet=@adet,aciklama=@aciklama where UrunKodu=@kod", baglanti);
                komut.Parameters.AddWithValue("@ad", urun_ad_textBox2.Text);
                komut.Parameters.AddWithValue("@kategori", urun_kategori_comboBox1.Text);
                komut.Parameters.AddWithValue("@fiyat", urun_fiyat_textBox4.Text);
                komut.Parameters.AddWithValue("@adet", urun_adet_numericUpDown1.Value);
                komut.Parameters.AddWithValue("@aciklama", aciklama_textBox6.Text);
                komut.Parameters.AddWithValue("@kod", Urun_Kodu_Combobox.Text);
                komut.ExecuteNonQuery();//KOMUTLARI ÇALIŞTIRMA
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("ÜRÜN BİLGİLERİ GÜNCELLEDİ.", "ÜRÜN GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);//GÜNCELLEME HAKKINDA BİLGİ
            }
            catch (Exception)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("SİSTEM DIŞI HATA OLUŞTU\nÜRÜN FİYATINI KONTROL EDİNİZ EĞER KUSURATLI İSE , YERİNE . KOYUNUZ...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }
        private void iptal_et_button2_Click(object sender, EventArgs e)
        {
            this.Close();//PENCEREYİ KAPATMA
        }

        private void Urun_Kodu_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {//SEÇİLEN ÜRÜN KODUNA GÖRE VERİLERİ GETİRME.
            try
            {
                baglanti.Open();
                komut = new SqlCommand("select * from StokTablo where UrunKodu=@UK", baglanti);//ÜRÜN KODLARINI ÇEKME KOMUTU
                komut.Parameters.Add("@UK",Urun_Kodu_Combobox.SelectedItem.ToString());
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                while (oku.Read())//OKUMA
                {
                    urun_ad_textBox2.Text = oku["UrunAd"].ToString();
                    urun_kategori_comboBox1.SelectedItem = oku["UrunKategori"].ToString();
                    urun_fiyat_textBox4.Text = oku["UrunFiyat"].ToString();
                    urun_adet_numericUpDown1.Value = Convert.ToInt32(oku["UrunAdet"]);
                    aciklama_textBox6.Text = oku["aciklama"].ToString();
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)//HATA OLURSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunKoduOlustur();
        }

    }
}
