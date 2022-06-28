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
    public partial class Musteri_islemleri_penceresi : Form
    {
        public Musteri_islemleri_penceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT/
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
        private void Form1_Load(object sender, EventArgs e)
        {
            //MAİL UZANTILARI
            mail_uzantisi_combo.Items.Add("mail.google.com");
            mail_uzantisi_combo.Items.Add("hotmail.com");
            mail_uzantisi_combo.Items.Add("gmail.com");
            mail_uzantisi_combo.Items.Add("windowslive.com");
            mail_uzantisi_combo.Items.Add("mail.yandex.com");
            mail_uzantisi_combo.Items.Add("mail.yahoo.com");
            mail_uzantisi_combo.Items.Add("mail.mynet.com");
            mail_uzantisi_combo.SelectedIndex = 1;//hotmail.com seçme
            kisitlamalar_ve_duzenlemeler();
            illeri_cek();//İLLERİ EKLEME FOKSİYONU
            this.Text = "Müşteri Ekleme Penceresi";

            if (Anapencere.guncelleme_islemi_icin_tc != "")
            {
                personel_bilgilerini_cek();//PERSONEL BİLGİLERİNİ GETİRME
                this.Text = "Müşteri Bilgilerini Güncelle Penceresi";
                musteri_button.Text = "Güncelle";
            }
        }
        private void personel_bilgilerini_cek()
        {
            try//HATA ÖNLEME KODU
            {
                string il = "", ilce = "";//İL İLÇE VERİTABANİNDAN ÇEKİLDİĞİ İÇİN BAĞLANTI İÇİN DE BAĞLANTI AÇMAYA ÇALIŞIRDIĞINDA HATA VERİYOR ONUN İÇİN SADECE İL İLÇEYİ SAKLAMA SONRADAN SEÇME İŞLEMİNE GİDİYORUZ.
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select * from MusteriTablosu where tcno='" + Anapencere.guncelleme_islemi_icin_tc + "' and arsiv=1", baglanti);//VERİLERİ ÇEKME KOMUTU
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT//ÇALIŞTIRMA VE ALMA
                if (oku.Read())//EĞER BİLGİ VARSA (BİRDEN FAZLA) ÇALIŞTIR
                {
                    tc_masketb.Text = oku["tcno"].ToString();//VERİLERİ KUTUYA ÇEKME
                    ad_tb.Text = oku["ad"].ToString();//VERİLERİ KUTUYA ÇEKME
                    soyad_tb.Text = oku["soyad"].ToString();//VERİLERİ KUTUYA ÇEKME
                    if (oku["cinsiyet"].ToString() == "Erkek")//ERKEK KADIN ?
                    {
                        erkek_rb.Checked = true;//SEÇME
                    }
                    else
                    {
                        kadin_rb.Checked = true;//SEÇME
                    }
                    il = oku["il"].ToString();//VERİLERİ KUTUYA ÇEKME
                    ilce = oku["ilce"].ToString();//VERİLERİ KUTUYA ÇEKME
                    cep_masketb.Text = oku["cep_telefonu"].ToString();//VERİLERİ KUTUYA ÇEKME
                    ev_masketb.Text = oku["ev_telefonu"].ToString();//VERİLERİ KUTUYA ÇEKME
                    mail_tb.Text = oku["eposta"].ToString().Split('@')[0].ToString();//AYRILMA VE VERİLERİ KUTUYA ÇEKME
                    mail_uzantisi_combo.SelectedItem = oku["eposta"].ToString().Split('@')[1].ToString();//AYRILMA VE VERİLERİ KUTUYA ÇEKME
                    adres_tb.Text = oku["ev_adresi"].ToString();//VERİLERİ KUTUYA ÇEKME
                    aciklama_tb.Text = oku["aciklama"].ToString();//VERİLERİ KUTUYA ÇEKME
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI

                il_combo.SelectedItem = il;
                ilce_combo.SelectedItem = ilce;
            }
            catch (Exception HATA)//HATA OLACAKSA GİRECEĞİ YER
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI//VERİTABANI BAĞLANTISINI KAPATMA//BAĞLANTIYI KAPATMA
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }
        private void kisitlamalar_ve_duzenlemeler()
        {
            ad_tb.MaxLength = soyad_tb.MaxLength = 20;//VERİTABANINDAN KAYNALI EN FAZLA GİRİLEN KARAKTER
            mail_tb.MaxLength = 50;//VERİTABANINDAN KAYNALI EN FAZLA GİRİLEN KARAKTER
            adres_tb.MaxLength = aciklama_tb.MaxLength = 150;//VERİTABANINDAN KAYNALI EN FAZLA GİRİLEN KARAKTER

        }
        private void illeri_cek()
        {
            try//HATA ENGELLEYİCİ
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI//VERİTABANI BAĞLANTISI//VERİTABANI BAĞLANTISI
                komut = new SqlCommand("select RTRIM(sehir) AS sehir from iller", baglanti);// ŞEHİRLERİ ÇEKTİĞİMİZ KOMUT
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT//ÇALIŞTIRIP VERİLERİ TUTUĞUMUZ KOMUT
                while (oku.Read())//VERİ VARSA ÇALIŞACAK YER
                {
                    il_combo.Items.Add(oku["sehir"]);//İL SEÇİM KUTUSUNA EKLEME İŞLEMİ.
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI//VERİTABANI BAĞLANTISINI KAPATMA
                il_combo.SelectedIndex = 33;//İL SEÇİM KUTUSUNDA SEÇİLEN İL 'İSTANBUL'
            }
            catch (Exception HATA)//HATA OLURSA GİRECEĞİ YER
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI//VERİTABANI BAĞLANTISINI KAPATMA//BAĞLANTI KAPATMA
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.//PENCEREDE HATAYI GÖRTERME //HATA BİLGİSİNİ GÖSTERME
            }
        }

        private void il_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce_combo.Items.Clear();//İLÇELER SİLİNİR
            try//HATA ENGELLEME
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI//VERİTABANI BAĞLANTISI
                komut = new SqlCommand("select RTRIM(ilce) as ilce from ilceler where sehir='" + (il_combo.SelectedIndex + 1).ToString() + "'", baglanti);//İLE GÖRE İLÇE BİLGİLERİNİ SEÇME KOMUTU
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                while (oku.Read())//VARSA VERİLERİ ÇALIŞTIRMA
                {
                    ilce_combo.Items.Add(oku["ilce"]);//VERİLERİ İLÇE SEÇİM KUTUSUNA EKLEME
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI//VERİTABANI BAĞLANTISINI KAPATMA//VERİTABANI BAĞLANTISINI KAPATMA//VERİTABANI BAĞLANTISINI KAPATMA
                ilce_combo.SelectedIndex = 0;//SEÇİM KUTUSUNDAKİ 1.SIRADAKI VERİYİ SEÇME 
            }
            catch (Exception HATA)//HATA VARSA ÇALIŞACAK YER
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.//PENCEREDE HATAYI GÖRTERME //PENCEREDE HATAYI GÖRTERME //PENCEREDE HATAYI GÖRTERME 
            }

        }

        private void musteri_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tc_masketb.Text) == false)//TC NONUN BOŞ OLMAMA DURUMU
            {
                if (tc_masketb.Text.Count() == 11)//TC NONUN EKSİK GİRİRME DURUMU
                {
                    if (Anapencere.guncelleme_islemi_icin_tc != "")//EĞER GÜNCELLEME BUTONUNA BASILIP GELİNDİ İSE SAYFAYA
                    {
                        Musteri_Bilgilerini_Guncelle();//GÜNCELLEME İŞLEMİ YAPILIR
                    }
                    else//KAYIT İŞLEMİ YAPILIR.
                    {
                        kaydet();//KAYIT İŞLEMLERİ
                    }

                }
                else
                {
                    MessageBox.Show("TC KİMLİK NUMARANIZ EKSİKTİR...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
                }
            }
            else
            {
                MessageBox.Show("TC KİMLİK NUMARANIZI DOLDURUNUZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }

        private void kaydet()
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                if (erkek_rb.Checked == true)//ERKEK İÇİN ÇALISILACAK YER
                {
                    komut = new SqlCommand("insert into MusteriTablosu values('" + tc_masketb.Text + "','" + ad_tb.Text + "','" + soyad_tb.Text + "','Erkek','" + il_combo.Text + "','" + ilce_combo.Text + "','" + cep_masketb.Text + "','" + ev_masketb.Text + "','" + (mail_tb.Text + "@" + mail_uzantisi_combo.Text) + "','" + adres_tb.Text + "','" + aciklama_tb.Text + "',1)", baglanti);//ERKEK MÜŞTERİ BAŞVURU BİLGİLERİ

                }
                else if (kadin_rb.Checked == true)//KADIN İÇİN ÇALISILACAK YER
                {
                    komut = new SqlCommand("insert into MusteriTablosu values('" + tc_masketb.Text + "','" + ad_tb.Text + "','" + soyad_tb.Text + "','Kadın','" + il_combo.Text + "','" + ilce_combo.Text + "','" + cep_masketb.Text + "','" + ev_masketb.Text + "','" + (mail_tb.Text + "@" + mail_uzantisi_combo.Text) + "','" + adres_tb.Text + "','" + aciklama_tb.Text + "',1)", baglanti);//ERKEK MÜŞTERİ BAŞVURU BİLGİLERİ
                }
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞTIRIRDIĞI YER
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(tc_masketb.Text + " TC KİMLİK NOLU ADI:" + ad_tb.Text.ToUpper() + " SOYADI:" + soyad_tb.Text.ToUpper() + "\nSİSTEME EKLENDİ.", "EKLEME İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//MÜŞTERİ EKLENDİĞİ HAKKINDA MESAJ BİLGİ.
            }
            catch (Exception)//HATA VARSA AŞAĞAYA
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA MESAJI
            }
        }
        private void Musteri_Bilgilerini_Guncelle()
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI//VERİTABANI BAĞLANTISI
                if (erkek_rb.Checked == true)//ERKEK İÇİN ÇALISILACAK YER
                {
                    komut = new SqlCommand("update MusteriTablosu set tcno='" + tc_masketb.Text + "',ad='" + ad_tb.Text + "',soyad='" + soyad_tb.Text + "',cinsiyet='Erkek',il='" + il_combo.Text + "',ilce='" + ilce_combo.Text + "',cep_telefonu='" + cep_masketb.Text + "',ev_telefonu='" + ev_masketb.Text + "',eposta='" + (mail_tb.Text + "@" + mail_uzantisi_combo.Text) + "',ev_adresi='" + adres_tb.Text + "',aciklama='" + aciklama_tb.Text + "' where tcno='" + Anapencere.guncelleme_islemi_icin_tc + "'", baglanti);//MÜŞTERİ BİLGİLERİNİ DÜZENLEME İŞLEMLERİ
                }
                else if (kadin_rb.Checked == true)//KADIN İÇİN ÇALISILACAK YER
                {
                    komut = new SqlCommand("update MusteriTablosu set tcno='" + tc_masketb.Text + "',ad='" + ad_tb.Text + "',soyad='" + soyad_tb.Text + "',cinsiyet='Kadın',il='" + il_combo.Text + "',ilce='" + ilce_combo.Text + "',cep_telefonu='" + cep_masketb.Text + "',ev_telefonu='" + ev_masketb.Text + "',eposta='" + (mail_tb.Text + "@" + mail_uzantisi_combo.Text) + "',ev_adresi='" + adres_tb.Text + "',aciklama='" + aciklama_tb.Text + "' where tcno='" + Anapencere.guncelleme_islemi_icin_tc + "'", baglanti);//MÜŞTERİ BİLGİLERİNİ DÜZENLEME İŞLEMLERİ
                }
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞTIRIRDIĞI YER
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(tc_masketb.Text + " TC KİMLİK NOLU ADI:" + ad_tb.Text.ToUpper() + " SOYADI:" + soyad_tb.Text.ToUpper() + "\nSİSTEME GÜNCELLENDİ.", "GÜNCELLEME İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//MÜŞTERİ GÜNCELLENDİĞİ HAKKINDA MESAJ BİLGİ.
            }
            catch (Exception)//HATA VARSA AŞAĞAYA
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("MÜŞTERİ BİLGİLERİNİ DÜZENLEME İŞLEMİ BAŞARISIZ OLDU.", "MÜŞTERİ BİLGİLERİNİ DÜZENLEME İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Error);//İLK BAŞTA TC HATA VEREBİLİR (VAR OLDUĞUNDAN) ONU ENGELLEME VE BİLGİLENDİRME
            }
        }

        private void iptal_et_buton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
