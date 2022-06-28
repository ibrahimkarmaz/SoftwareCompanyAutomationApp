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
    public partial class MusteriArama : Form
    {
        public MusteriArama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPenceresi.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlDataAdapter Komutlar;//TABLO ÇEKMEK İÇİN KULLANILIR
        DataSet veriseti = new DataSet();//VERİ SETİDİR
        private void MusteriArama_Load(object sender, EventArgs e)
        {
            //ARAMA KONULARI
            konu_combo.Items.Add("T.C NO");
            konu_combo.Items.Add("MÜŞTERİ ADI");
            konu_combo.Items.Add("AÇIKLAMA");
            konu_combo.SelectedIndex = 0;

            tabloyu_getir();//TABLOYU GETİRME
            tabloyu_duzenle();//TABLOYU DÜZENLEME
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
        private void button1_Click(object sender, EventArgs e)
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
            if (konu_combo.Text == "T.C NO")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from MusteriTablosu where tcno like '%" + arama_tb.Text + "%' and arsiv=1", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            else if (konu_combo.Text == "MÜŞTERİ ADI")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from MusteriTablosu where ad like '%" + arama_tb.Text + "%' and arsiv=1", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            else if (konu_combo.Text == "AÇIKLAMA")//ARAMA KONUSU KONTROLU
            {
                Komutlar = new SqlDataAdapter("select * from MusteriTablosu where aciklama like '%" + arama_tb.Text + "%' and arsiv=1", baglanti);//ARAMA KONUSUNA GÖRE ARAMA KOMUTU OLUŞTURUR
            }
            Komutlar.Fill(veriseti, "MusteriTablosu");//TABLOYU YÜKLER
            baglanti.Close();//BAĞLANTIYI KAPATIR
            tablolari_listele_dgv.DataSource = veriseti.Tables["MusteriTablosu"];//TABLOYU PENCEREDE GÖSTERİR
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabloyu_getir();
        }

        private void arama_tb_TextChanged(object sender, EventArgs e)
        {
            if (otomatik_arama_cb.Checked == true)//OTOMATİK ARAMA İŞARETLİ İSE;
            {
                arama_yap();//ARAMA YAPAR
            }
        }
    }
}
