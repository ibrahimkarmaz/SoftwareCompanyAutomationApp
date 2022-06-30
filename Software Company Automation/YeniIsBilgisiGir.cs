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
    public partial class YeniIsBilgisiGir : Form
    {
        public YeniIsBilgisiGir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
        SqlDataAdapter Komut_veri_donusumu;//tablolari çekmek için kullanılıyor
        DataSet veriseti = new DataSet();//çekilen tablolari saklamak için kullanılır.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YeniIsBilgisiGir_Load(object sender, EventArgs e)
        {
            TbTarih.Text = DateTime.Now.ToShortDateString();
            TbTarih.ReadOnly = true;
            TbYeniIS.ReadOnly = true;
            YeniISKoduOlustur();
            MusteriTCCek();
            UrunTabloCek();
            tablo_duzen();
            gridAyari();
            Tablo.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
        }
        void UrunTabloCek()
        {
            veriseti.Clear();//Saklanan eski tablolari siler.
            baglanti.Open();//veritabanına bağlanılır
            Komut_veri_donusumu = new SqlDataAdapter("select * from StokTablo", baglanti);//GEREKLİ BİLGİLERİ ÇEKME
            Komut_veri_donusumu.Fill(veriseti, "StokTablo");//TABLOYU KAYDET
            baglanti.Close();//BAĞLANTIYI KAPATMA
            urun_listeleme_datagridview.DataSource = veriseti.Tables["StokTablo"];//KAYDEDILEN TABLOYU DATAGRİDDE GÖSTERME
            tablo_duzen();//TABLO BAŞLIK ADLARINI DEĞİŞTİRME FOKSİYONU
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
        Random Yeniiskodu = new Random();
        private void YeniISKoduOlustur()//8 HANELI KOD
        {
            TbYeniIS.Text = Yeniiskodu.Next(10000000, 99999999).ToString();
        }

        private void MusteriTCCek()//MÜŞTERİ TC ÇEKME
        {
            try
            {
                CBMusteri.Items.Clear();
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select tcno from MusteriTablosu where arsiv=1", baglanti);
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                while (oku.Read())//OKUMA
                {
                    /*VERİLERİN TUTULDUĞU TEXTBOX VE COMBOBOXLARA AKTARILDIĞI YERDİR*/
                    CBMusteri.Items.Add(oku["tcno"].ToString());
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                if (CBMusteri.Items.Count >= 1)
                {
                    CBMusteri.SelectedIndex = 0;//EĞER 1 VE 1DEN FAZLA DEĞER VARSA İLK DEĞERİ SEÇ
                }
                baglanti.Close();
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void BtnBilgi_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select * from MusteriTablosu where tcno='" + CBMusteri.Text+"' and arsiv=1", baglanti);
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                if(oku.Read())//OKUMA
                {
                    MessageBox.Show("TC:"+CBMusteri.Text+"\nAD SOYAD:"+oku["ad"]+" "+ oku["soyad"]+"\nCEP TELEFONU:"+ oku["cep_telefonu"]);
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }
        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Tablo.Rows.Add(urun_listeleme_datagridview.CurrentRow.Cells[0].Value.ToString(), urun_listeleme_datagridview.CurrentRow.Cells[1].Value.ToString(),1, urun_listeleme_datagridview.CurrentRow.Cells[3].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("EKLENECEK ÜRÜN SEÇİLMEDİ","SEÇİM HATASI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        void gridAyari()
        {
            Tablo.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            Tablo.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
            Tablo.ColumnCount = 4; //Kaç kolon olacağı belirleniyor…
            Tablo.Columns[0].Name = "UrunKod";//Kolonların adı belirleniyor
            Tablo.Columns[1].Name = "UrunAd";
            Tablo.Columns[2].Name = "AlisAdet";
            Tablo.Columns[3].Name = "AlisFiyat";

            Tablo.Columns[2].HeaderText = "ALIŞ ADET";//GÖRSELLİKLER
            Tablo.Columns[0].HeaderText = "ÜRÜN KOD";
            Tablo.Columns[1].HeaderText = "ÜRÜN AD";
            Tablo.Columns[3].HeaderText = "ALIŞ FİYATİ";
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("insert into IsBilgiTablo values('"+TbYeniIS.Text+"','"+TbTarih.Text+"','"+TbGirisSaat.Text+"','"+TbCikisSaat.Text+"','"+textBox1.Text+"','"+CBMusteri.Text+"','"+GirisPencere.tc+"')",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Console.WriteLine(Tablo.Rows[0].Cells[0].Value.ToString() );
                for (int i = 0; i < Tablo.RowCount-1; i++)
                {
                    baglanti.Open();
                    komut = new SqlCommand("insert into IsBilgiTabloDetay values('"+TbYeniIS.Text+"','"+Tablo.Rows[i].Cells[0].Value.ToString()+"','"+ Tablo.Rows[i].Cells[1].Value.ToString()+"',"+ Tablo.Rows[i].Cells[2].Value.ToString()+","+ Tablo.Rows[i].Cells[3].Value.ToString()+")",baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

                for (int i = 0; i < Tablo.RowCount - 1; i++)
                {
                    baglanti.Open();
                    komut = new SqlCommand("UPDATE StokTablo set UrunAdet=UrunAdet-1 where UrunKodu='"+ Tablo.Rows[i].Cells[0].Value.ToString()+"'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("YENİ İŞ BAŞARILI BİR ŞEKİLDE EKLENDİ", "EKLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("KAYIT ESNASINDA HATA OLUŞTU","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
