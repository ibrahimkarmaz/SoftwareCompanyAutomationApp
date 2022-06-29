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
    public partial class MusteriAnaPencere : Form
    {
        public MusteriAnaPencere()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPencere.global_baglanti_adresi);//BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLOLARIN ÇEKİLMESİNDE KULLANILAN KOMUT
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        DataSet veriseti = new DataSet();//ÇEKİLEN TABLOLARI SAKLAMAK İÇİN GEREK KOMUT
        private void Anapencere_Load(object sender, EventArgs e)
        {
            tabloyu_getir();
            tabloyu_duzenle();
        }
        private void tabloyu_getir()//TABLOYU GETİRME
        {
            veriseti.Clear();//TABLOLARI SİLER 
            baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
            Komutlar = new SqlDataAdapter("select * from MusteriTablosu where arsiv=1", baglanti);//MÜŞTERİ BİLGİLERİ
            Komutlar.Fill(veriseti, "MusteriTablosu");
            baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            tablolari_listele_dgv.DataSource = veriseti.Tables["MusteriTablosu"];//MÜŞTERİ TABLOSUNDA GÖSTERME

        }
        private void tabloyu_duzenle()//ALANLARI DÜZENLEME
        {
            tablolari_listele_dgv.Columns["arsiv"].Visible = false;//TABLO ARŞİV ALANINI GİZLEME
            tablolari_listele_dgv.Columns["tcno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["soyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["cinsiyet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["il"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["ilce"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["cep_telefonu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["ev_telefonu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["eposta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["ev_adresi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["aciklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ



            tablolari_listele_dgv.Columns["tcno"].HeaderText = "TC NO";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["ad"].HeaderText = "AD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ
            tablolari_listele_dgv.Columns["soyad"].HeaderText = "SOYAD";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR
            tablolari_listele_dgv.Columns["cinsiyet"].HeaderText = "CİNSİYET";
            tablolari_listele_dgv.Columns["il"].HeaderText = "İL";
            tablolari_listele_dgv.Columns["ilce"].HeaderText = "İLÇE";
            tablolari_listele_dgv.Columns["cep_telefonu"].HeaderText = "CEP TELEFONU";
            tablolari_listele_dgv.Columns["ev_telefonu"].HeaderText = "EV TELEFONU";
            tablolari_listele_dgv.Columns["eposta"].HeaderText = "E-POSTA ADRESİ";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["ev_adresi"].HeaderText = "EV ADRESİ";
            tablolari_listele_dgv.Columns["aciklama"].HeaderText = "AÇIKLAMA";
        }
        public static string guncelleme_islemi_icin_tc = "";
        private void musterininBilgileriniGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SEÇİLİ MÜŞTERİNNİ BİLGİLERİNİ DÜZENLEME EKRANI
            try
            {
                guncelleme_islemi_icin_tc = "";//SIFIRLAMA
                if (tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    guncelleme_islemi_icin_tc = tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString();//MÜŞTERİNİN TCSINI ALMA
                    MusteriEklePencere duzenleme_penceresi = new MusteriEklePencere();//PENCERE TANIMLAMA 
                    duzenleme_penceresi.ShowDialog();//PENCERE AÇMA
                    tabloyu_getir();//TABLOYU GÜNCELLEME
                    guncelleme_islemi_icin_tc = "";
                }
                else
                {
                    MessageBox.Show("MÜŞTERİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("MÜŞTERİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEklePencere musteri_ekle = new MusteriEklePencere();//PENCERE TANIMLAMA 
            musteri_ekle.ShowDialog();//PENCERE AÇMA
            tabloyu_getir();//TABLOYU GÜNCELLEME
        }

        private void musteriAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriArama arama_yap = new MusteriArama();
            arama_yap.ShowDialog();
        }

        private void musteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*MÜŞTERİ ÇIKARMA KOMUTLARI*/
            try
            {
                if (tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() != "")//TABLODAN VERİ VAR MI KONTROLU
                {
                    if (MessageBox.Show("SEÇİLEN TC NO:" + tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() + " MÜŞTERİ ÇIKARILSIN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//VARSA VERİYİ GETİRİR VE EMİN OLMAK İÇİN SORAR
                    {
                        musteri_sil();//MÜŞTERİYİ SİLME 
                        tabloyu_getir();//TABLOYU GÜNCELLEME
                    }
                }
                else
                {
                    MessageBox.Show("MÜŞTERİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//SORUN VAR İSE UYARI VERİLİR
                }
            }
            catch (Exception)
            {
                MessageBox.Show("MÜŞTERİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//SORUN VAR İSE UYARI VERİLİR
            }
        }
        private void musteri_sil()//MÜŞTERİ ÇIKARMA KOMUTLARI
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("delete from MusteriTablosu where tcno='" + tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI

                MessageBox.Show(tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() + " TC KİMLİK NOLU ADI:" + tablolari_listele_dgv.CurrentRow.Cells[1].Value.ToString() + " SOYADI:" + tablolari_listele_dgv.CurrentRow.Cells[2].Value.ToString() + "\nMÜŞTERİ ÇIKARILDI.", "MÜŞTERİ ÇIKARMA İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void musteriyiArsivleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*MÜŞTERİ ARŞİVLEME KOMUTLARI*/
            try
            {
                if (tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() != "")//TABLODAN VERİ VAR MI KONTROLU
                {
                    if (MessageBox.Show("SEÇİLEN TC NO:" + tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() + " MÜŞTERİ ARŞİVLENSIN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//VARSA VERİYİ GETİRİR VE EMİN OLMAK İÇİN SORAR
                    {
                        Musteriyi_Arsivle();//MÜŞTERİYİ ARŞİVLEME
                        tabloyu_getir();//TABLOYU GÜNCELLEME
                    }
                }
                else
                {
                    MessageBox.Show("MÜŞTERİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//SORUN VAR İSE UYARI VERİLİR
                }
            }
            catch (Exception)
            {
                MessageBox.Show("MÜŞTERİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//SORUN VAR İSE UYARI VERİLİR
            }
        }

        private void Musteriyi_Arsivle()
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("update MusteriTablosu set arsiv=0 where tcno='" + tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString()+"'", baglanti);//MÜŞTERİ BİLGİLERİNİ ARŞİVLEME İŞLEMLERİ
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞTIRIRDIĞI YER
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("MÜŞTERİ BİLGİLERİ ARŞİVLENDİ.", "ARŞİV İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//MÜŞTERİ ARŞİVLEME
            }
            catch (Exception)//HATA VARSA AŞAĞAYA
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("MÜŞTERİ ARŞİVLENDİ İŞLEMİ BAŞARISIZ OLDU.", "MÜŞTERİ ARŞİVLENDİ İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Error);//İLK BAŞTA TC HATA VEREBİLİR (VAR OLDUĞUNDAN) ONU ENGELLEME VE BİLGİLENDİRME
            }
        }

        private void musteriArsiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriArsivi arsiv = new MusteriArsivi();//DİĞER PENCEREYE ULAŞMA
            arsiv.ShowDialog();//AÇMA
            tabloyu_getir();//TABLOYU GÜNCELLEME EĞER BİR İŞLEM YAPILIRSA DİYE
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
