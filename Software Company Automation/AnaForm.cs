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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        public static string globel_baglantisi_adresi = @"server=DESKTOP-5DGSRBQ;database=PDKS;Trusted_Connection=yes";
        SqlConnection baglanti = new SqlConnection(AnaForm.globel_baglantisi_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        SqlCommand komut;//SQL İFADELERİ İÇİN KULLANILIR
        SqlDataReader oku;//ÇEKİLEN VERİLERİN ALANLARINA GÖRE TEKER TEKER OKUMA
        DataSet veriseti = new DataSet();//VERİ SETİDİR
        private void Form1_Load(object sender, EventArgs e)
        {
            //MaxLength'ler ;veritabanında alanların karakter sayısıdır.sınırlamassak hata verir örnek tc-11 karakterli 12 giriş yapılmaması için maxkullanıldı.

            tcno_masked.MaxLength = 11;

            adi_textbox.MaxLength = soyadi_textbox.MaxLength = 20;
            telefon_maskedtextbox.MaxLength = 10;
            getir_buton.Enabled = false;

            cinsiyet_combobox.Items.Add("BAY");//cinsiyet seçim kutusu
            cinsiyet_combobox.Items.Add("BAYAN");//cinsiyet seçim kutusu
            cinsiyet_combobox.SelectedIndex = 0;//cinsiyet seçimi otomatik

            tabloyu_getir();
            tabloyu_duzenle();

            personel_bilgileri_guncelle_buton.Enabled = false;//KAPATILMA NEDENİ TC NUMARASI GİRİLDİKTEN SONRA İLK BİLGİLERİN GETİRİLMESİNİ SAĞLAMAK
        }
        private void tabloyu_getir()
        {
            veriseti.Clear();//TABLOLARI SİLER 
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                Komutlar = new SqlDataAdapter("select * from PersonelTablosu", baglanti);//SİSTEMDE AKTİF OLAN PERSONELLERİ ÇAĞIRMA
                Komutlar.Fill(veriseti, "PersonelTablosu");//TABLOYU SAKLAMA
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                tablolari_listele_dgv.DataSource = veriseti.Tables["PersonelTablosu"];//SAKLANAN TABLOYU GÖSTERME
            }
            catch (Exception)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
        }
        private void tabloyu_duzenle()
        {
            tablolari_listele_dgv.Columns["tc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["soyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["cinsiyet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["tel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["kayit_tarihi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["maas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ


            tablolari_listele_dgv.Columns["tc"].HeaderText = "T.C NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["ad"].HeaderText = "AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ
            tablolari_listele_dgv.Columns["soyad"].HeaderText = "SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            tablolari_listele_dgv.Columns["cinsiyet"].HeaderText = "CİNSİYET";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            tablolari_listele_dgv.Columns["tel"].HeaderText = "TELEFON";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["kayit_tarihi"].HeaderText = "KAYIT TARİHİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["maas"].HeaderText = "MAAŞ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
        }
        private void temizle()
        {
            tcno_masked.Text = adi_textbox.Text = soyadi_textbox.Text = maas_tb.Text = telefon_maskedtextbox.Text = "";
            cinsiyet_combobox.SelectedIndex = 0;
        }

        private void personel_ekle_buton_Click(object sender, EventArgs e)
        {
            if (tcno_masked.Text != "" && tcno_masked.TextLength == 11)//TC KUTUSU BOŞ GEÇİLEMEZ VE 11 KARAKTER OLMALI
            {
                if (adi_textbox.Text != "" && soyadi_textbox.Text != "")//AD SOYAD BOŞ OLAMAZ
                {
                    personel_kaydet();//YENİ PERSONEL KAYDI FOKSİYONU
                    tabloyu_getir();//TABLOYU YENİDEN GETİRİR.(GÜNCELLEME İŞLEMİ)
                    temizle();
                }
                else
                {
                    MessageBox.Show("AD VEYA SOYAD KUTULARI BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
                }

            }
            else
            {
                MessageBox.Show("T.C KİMLİK NO BOŞ GEÇİLEMEZ VEYA TC EKSİK GİRİLMİŞ OLABİLİR...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void personel_kaydet()//PERSONEL BİLGİLERİ EKLEME FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("insert into PersonelTablosu values('" + tcno_masked.Text + "','" + adi_textbox.Text + "','" + soyadi_textbox.Text + "','" + cinsiyet_combobox.Text + "','" + telefon_maskedtextbox.Text + "','" + kayit_dateTimePicker1.Text + "'," + maas_tb.Text + ")", baglanti);//PERSONEL VERİ KAYDI
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("PERSONEL T.C KİMLİK NO:" + tcno_masked.Text + "\nPERSONEL ADI SOYADI:" + adi_textbox.Text + " " + soyadi_textbox.Text + "\nPERSONEL SİSTEME EKLENDI.", "PERSONEL EKLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//PERSONEL EKLENDİĞİ HAKKINDA BİLGİ VERİR.
            }
            catch (Exception)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU\nSEBEP:\nBU T.C KİMLİK NONA AİT PERSONEL OLABİLİR\nSİSTEMSEL HATALAR", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void getir_buton_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI
                komut = new SqlCommand("select * from PersonelTablosu where tc='" + tcno_masked.Text + "'", baglanti);//T.C GÖRE ARAMA YAPAN KOMUT
                oku = komut.ExecuteReader();//KOMUTU ÇALIŞTIRMA
                if (oku.Read())//VERİ VAR İSE;
                {//VERİTABANINDAN BİLGİLERİ TEXTBOX VE COMBOBOXLARA GETİR.
                    adi_textbox.Text = oku["ad"].ToString();
                    soyadi_textbox.Text = oku["soyad"].ToString();
                    if (oku["cinsiyet"].ToString() == "BAY")
                    {
                        cinsiyet_combobox.SelectedIndex = 0;//BAY İSE 0
                    }
                    else
                    {
                        cinsiyet_combobox.SelectedIndex = 1;//BAYAN İSE 1
                    }
                    telefon_maskedtextbox.Text = oku["tel"].ToString();
                    kayit_dateTimePicker1.Value = Convert.ToDateTime(oku["kayit_tarihi"]);
                    maas_tb.Text = oku["maas"].ToString();
                    personel_bilgileri_guncelle_buton.Enabled = true;
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }
        bool sistemde_varmi = false;
        private void tcno_masked_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI
                komut = new SqlCommand("select tc from PersonelTablosu where tc='" + tcno_masked.Text + "'", baglanti);//BU T.C AİT VERİ VAR MI KONTROLU
                oku = komut.ExecuteReader();//KOMUTU ÇALIŞTIRMA VERİ ALMA
                if (oku.Read())//VERİ VAR İSE;
                {
                    sistemde_varmi = true;//BU T.C SİSTEMDE VAR DEMEK
                    getir_buton.Enabled = true;//EĞER SİSTEMDE VAR İSE BİLGİLERİ GETİREBİLMESİ İÇİN GEREKEN BUTONU AKTIFLEŞTİR.
                }
                else//VERİ YOK İSE;
                {
                    sistemde_varmi = false;//BU T.C SİSTEMDE YOK DEMEK
                    getir_buton.Enabled = false;//EĞER SİSTEMDE YOK İSE BİLGİLERİ GETİREBİLMESİ İÇİN GEREKEN BUTONU PASİFLEŞTİR.
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void personel_bilgileri_guncelle_buton_Click(object sender, EventArgs e)
        {
            if (tcno_masked.Text != "" && tcno_masked.TextLength == 11)//TC KUTUSU BOŞ GEÇİLEMEZ VE 11 KARAKTER OLMALI
            {
                if (adi_textbox.Text != "" && soyadi_textbox.Text != "")//AD SOYAD BOŞ OLAMAZ
                {
                    personel_bilgilerini_guncelle();//PERSONEL BİLGİLERİ GÜNCELLER
                    tabloyu_getir();//TABLOYU YENİLEME
                    personel_bilgileri_guncelle_buton.Enabled = false;//GÜNCELLEME İŞLEMİ YAPILDIKTAN SONRA KAPATILIR.
                    temizle();
                }
                else
                {
                    MessageBox.Show("AD VEYA SOYAD KUTULARI BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
                }

            }
            else
            {
                MessageBox.Show("T.C KİMLİK NO BOŞ GEÇİLEMEZ VEYA TC EKSİK GİRİLMİŞ OLABİLİR...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void personel_bilgilerini_guncelle()//PERSONEL BİLGİLERİ GÜNCELLEME FOKSİYONU
        {
            /*"GETİR BUTONUNA BASILDIKTAN SONRA BİLGİLER DEĞİŞTİRİLİR VE GÜNCELLEME İŞLEMİ YAPILIR."*/
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("update PersonelTablosu set ad='" + adi_textbox.Text + "',soyad='" + soyadi_textbox.Text + "',cinsiyet='" + cinsiyet_combobox.Text + "',tel='" + telefon_maskedtextbox.Text + "',kayit_tarihi='" + kayit_dateTimePicker1.Text + "',maas=" + maas_tb.Text + " where tc='" + tcno_masked.Text + "'", baglanti);//PERSONEL BİLGİLERİNİ GÜNCELLEME FOKSİYONU
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("PERSONEL T.C KİMLİK NO:" + tcno_masked.Text + "\nPERSONEL ADI SOYADI:" + adi_textbox.Text + " " + soyadi_textbox.Text + "\nPERSONEL BİLGİLERİ GÜNCELLENDİ.", "PERSONEL GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void personel_cikar_buton_Click(object sender, EventArgs e)
        {
            if (tcno_masked.Text != "" && tcno_masked.TextLength == 11)//TC KUTUSU BOŞ GEÇİLEMEZ VE 11 KARAKTER OLMALI
            {
                if (sistemde_varmi == true)//SİSTEMDE VAR MI KONTROLU
                {
                    if (MessageBox.Show("PERSONEL SİSTEMDEN ÇIKARILSIN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//PERSONELİ ÇIKARMAK İSTEDİĞİNİZDEN EMİNMİSİNİZ KONTROLU CEVAP YES İSE;
                    {
                        personel_cikar();//PERSONEL ÇIKARMA FOKSİYONU
                        temizle();
                    }
                }
                else
                {
                    MessageBox.Show("SİSTEMDE ÇIKARMAK İSTEDİĞİNİZ T.C KİMLİK NOLU PERSONEL BULUNAMADI...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
                }
            }
            else
            {
                MessageBox.Show("SİSTEMDEN ÇIKARMAK İÇİN T.C KİMLİK NUMARASI GEREKMEKTEDİR...[T.C KUTUSUNU DOLDURUNUZ...]", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void personel_cikar()//PERSONEL ÇIKARMA FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("delete from PersonelTablosu where tc='" + tcno_masked.Text + "'", baglanti);//ÇIKARMA KOMUTU
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show(tcno_masked.Text + " T.C KİMLİK NOLU PERSONEL SİSTEMDEN ÇIKARILDI.", "PERSONEL ÇIKARMA İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//PERSONEL SİLİNDİĞİNDE HAKKINDA BİLGİ VERİR.
                tabloyu_getir();//TABLOYU YENİLEME
            }
            catch (Exception HATA)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU" + HATA, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void pecereyi_kapat_buton_Click(object sender, EventArgs e)
        {
            this.Close();//PENCEREYİ KAPATMA
        }

        private void tumunu_goster_buton_Click(object sender, EventArgs e)
        {
            tabloyu_getir();//TABLOYU YENİLEME
        }

        private void arama_yap_buton_Click(object sender, EventArgs e)
        {
            if (arama_tb.Text != "")//ARAMA KONUSU BOŞ DEĞİLSE;
            {
                arama_yap();//ARAMA YAP
            }
            else
            {
                MessageBox.Show("ARAMA BİLGİSİ BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void arama_yap()
        {
            veriseti.Clear();//SAKLANAN ESKİ TABLOLAR SİLİNİR.
            baglanti.Open();//BAĞLANTIYI AÇAR
            Komutlar = new SqlDataAdapter("select * from PersonelTablosu where tc like '%" + arama_tb.Text + "%'", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            Komutlar.Fill(veriseti, "PersonelTablosu");//TABLOYU YÜKLER
            baglanti.Close();//BAĞLANTIYI KAPATIR
            tablolari_listele_dgv.DataSource = veriseti.Tables["PersonelTablosu"];//TABLOYU PENCEREDE GÖSTERİR
        }
        public static string devamsizlik_islemleri_icin_tc = "";
        private void devamsizlik_islemleri_buton_Click(object sender, EventArgs e)
        {
            //SEÇİLİ PERSONEL DEVAMSIZLIK BİLGİLERİNİ DÜZENLEME EKRANI
            try
            {
                devamsizlik_islemleri_icin_tc = "";//SIFIRLAMA
                if (tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    devamsizlik_islemleri_icin_tc = tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString();//PERSONELİN TCSINI ALMA
                    DevamKontrolForm duzenleme_penceresi = new DevamKontrolForm();//PENCERE TANIMLAMA 
                    duzenleme_penceresi.ShowDialog();//PENCERE AÇMA
                    tabloyu_getir();//TABLOYU GÜNCELLEME
                    devamsizlik_islemleri_icin_tc = "";
                }
                else
                {
                    MessageBox.Show("PERSONEL SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PERSONEL SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
