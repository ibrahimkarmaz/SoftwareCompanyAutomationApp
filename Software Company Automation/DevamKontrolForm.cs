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
    public partial class DevamKontrolForm : Form
    {
        public DevamKontrolForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//tablolari çekmek için kullanılıyor
        SqlCommand komut;//sql ifadeleri özellikle insert,delete,update vss...
        SqlDataReader oku;//çekilen verileri teker teker okumamızı sağlar
        private void Form2_Load(object sender, EventArgs e)
        {
            devamsizliklari_getir();
        }
        private void devamsizliklari_getir()
        {
            try
            {
                devamsizlik_listesi.Items.Clear();
                baglanti.Open();//VERİTABANINA BAĞLANTI
                komut = new SqlCommand("select * from DevamsizlikTablosu where tc='"+PersonelPencere.devamsizlik_islemleri_icin_tc+"'", baglanti);//TÜM DERSLERİ GETİREN KOMUT
                oku = komut.ExecuteReader();//KOMUTU ÇALIŞTIRMA
                while (oku.Read())//OKUMA VERİ VARSA;
                {
                    devamsizlik_listesi.Items.Add(oku["devamsizlik_gunu"]);//DEVAMSIZLIKLARI LİSTEYE EKLER
                }
                baglanti.Close();//BAĞLANTI KAPATILIR
                Devamsizlik_label1.Text = "Toplam Devamsiz Gün Sayısı:" + devamsizlik_listesi.Items.Count.ToString();
            }
            catch (Exception)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (devamsizlik_maskedTextBox1.Text != "")//DEVAMSIZLIK TARİHİ BOŞ DEĞİLSE
            {
                Devamsizlik_ekle();//DEVAMSIZLIK EKLE
                devamsizliklari_getir();//DEVAMSIZLIKLARI YENİLE
            }
            else
            {
                MessageBox.Show("DERS ADI BOŞ GEÇİLEMEZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void Devamsizlik_ekle()
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("insert into DevamsizlikTablosu values('" +PersonelPencere.devamsizlik_islemleri_icin_tc + "','"+devamsizlik_maskedTextBox1.Text+"')", baglanti);//DEVAMSIZLIK EKLEME KOMUTU
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("DEVAMSIZLIK BİLGİSİ EKLENDI.", "DEVAMSIZLIK İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//BİLGİ VERİR

            }
            catch (Exception)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }

        private void secili_tarihi_sil_Click(object sender, EventArgs e)
        {
            if (devamsizlik_listesi.SelectedIndex != -1)//DEVAMSIZLIK LİSTESİNDE SEÇİM VAR İSE;
            {
                devamsizlik_sil();//DEVAMSIZLIK SİL
                devamsizliklari_getir();//DEVAMSIZLIK GÜNCELLE
            }
            else
            {
                MessageBox.Show("DEVAMSIZLIK LİSTESİNDEN SEÇİM YAPINIZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);//HATALI GİRİŞTE VERİLEN UYARI MESAJI
            }
        }
        private void devamsizlik_sil()//DEVAMSIZLIK SİLME FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANIR
                komut = new SqlCommand("delete from DevamsizlikTablosu where tc='" + PersonelPencere.devamsizlik_islemleri_icin_tc + "' and devamsizlik_gunu='"+devamsizlik_listesi.SelectedItem+"'", baglanti);//DEVAMSIZLIK SİLME KOMUTU
                komut.ExecuteNonQuery();//SQL İFADELERİNİN ÇALIŞIR
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("DEVAMSIZLIK BİLGİSİ SİLİNDİ.", "DEVAMSIZLIK İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);//BİLGİ VERİR

            }
            catch (Exception)//HATA VARSA;
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILIR
                MessageBox.Show("HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA HAKKINDA BİLGİ VERİRLİR.
            }
        }
    }
}
