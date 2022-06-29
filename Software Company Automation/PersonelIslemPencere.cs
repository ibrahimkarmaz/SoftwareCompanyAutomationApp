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
    public partial class PersonelIslemPencere : Form
    {
        public PersonelIslemPencere()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
        private void musteriIslemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriAnaPencere MusteriIslem = new MusteriAnaPencere();
            MusteriIslem.ShowDialog();

        }

        private void PersonelIslemPencere_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            TarihBilgisi.BackColor = SaatBilgisi.BackColor = Color.Black;
            TarihBilgisi.ForeColor = SaatBilgisi.ForeColor = Color.White;
            iseGirisYapMenu.Visible = istenCikisYapMenu.Visible = YeniIsBilgisiGir.Visible = false;
            GirisCikisIslemleriniKontrolEt();
        }
        public static bool IS = false;
        private void GirisCikisIslemleriniKontrolEt()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from CalismaTablo where TC='" + GirisPencere.tc + "' and Tarih='" + DateTime.Now.ToShortDateString() + "'", baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                iseGirisYapMenu.Visible = false;
                IS = true;
                if (oku["BitisSaat"].ToString().Trim() == "")
                {
                    istenCikisYapMenu.Visible = YeniIsBilgisiGir.Visible = true;
                }
                else
                {
                    istenCikisYapMenu.Visible = YeniIsBilgisiGir.Visible = false;
                }
            }
            else
            {
                iseGirisYapMenu.Visible = true;
                istenCikisYapMenu.Visible = YeniIsBilgisiGir.Visible = false;
                IS = false;
            }
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SaatBilgisi.Text = "SAAT:" + (DateTime.Now.ToShortTimeString());
            TarihBilgisi.Text = "TARİH:" + (DateTime.Now.ToShortDateString());
        }

        private void PersonelIslemPencere_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void işeBaşlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniIsBilgisiGir YeniIs = new YeniIsBilgisiGir();
            YeniIs.ShowDialog();
        }

        private void iseGirisYapMenu_Click(object sender, EventArgs e)
        {
            GirisCikisIslemleri GirisYap = new GirisCikisIslemleri();
            GirisYap.ShowDialog();
            GirisCikisIslemleriniKontrolEt();//TEKRAR KONTROL EDİLECEK.
        }

        private void istenCikisYapMenu_Click(object sender, EventArgs e)
        {
            GirisCikisIslemleri CikisYap = new GirisCikisIslemleri();
            CikisYap.ShowDialog();
            GirisCikisIslemleriniKontrolEt();//TEKRAR KONTROL EDİLECEK.
        }
    }
}
