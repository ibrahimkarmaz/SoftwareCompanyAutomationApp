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
    public partial class GirisCikisIslemleri : Form
    {
        public GirisCikisIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(GirisPencere.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
        private void GirisCikisIslemleri_Load(object sender, EventArgs e)
        {
            TbTarih.Enabled = TbCikisSaat.Enabled = TbGirisSaat.Enabled = ChbGirisDegistir.Enabled = ChbCikisDegistir.Enabled=textBox1.Enabled = false;
            BtnIslem.Visible = true;
            TbTarih.Text = DateTime.Now.ToShortDateString();
            if (PersonelIslemPencere.IS == false)
            {
                TbGirisSaat.Text = DateTime.Now.ToShortTimeString();
                ChbGirisDegistir.Enabled = true;
            }
            else if (PersonelIslemPencere.IS == true)
            {
                GirisBilgileriniGetir();
                TbCikisSaat.Text = DateTime.Now.ToShortTimeString();
                ChbCikisDegistir.Enabled = true;
                BtnIslem.Text = "BİTİR";
            }
        }
        short CalismaID;
        string aciklamabilgisi = "";
        void GirisBilgileriniGetir()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from CalismaTablo where TC='"+GirisPencere.tc+"' and Tarih='"+DateTime.Now.ToShortDateString()+"'",baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                CalismaID =Convert.ToInt16(oku["ID"]);
                TbGirisSaat.Text = oku["BaslangicSaat"].ToString();
                if (oku["Aciklama"].ToString()!="")
                textBox1.Text= aciklamabilgisi= oku["Aciklama"].ToString();
            }
            baglanti.Close();
        }
        private void ChbGirisDegistir_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbGirisDegistir.Checked)
            {
                TbGirisSaat.Enabled = textBox1.Enabled = true;
                MessageBox.Show("GİRİŞ SAATINI DEĞİŞTİRME İLE İLGİLİ OLARAK AÇIKLAMA SATIRINA EN AZ 15 HANELI BİLGİ YAZILMALI.","AÇIKLAMA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                TbGirisSaat.Enabled = textBox1.Enabled = false;
                TbGirisSaat.Text = DateTime.Now.ToShortTimeString();
                textBox1.Text = null;
            }
        }

        private void BtnIslem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (PersonelIslemPencere.IS == false)
            {
                if (ChbGirisDegistir.Checked)
                    komut = new SqlCommand("insert into CalismaTablo(TC,Tarih,BaslangicSaat,Aciklama) values('"+GirisPencere.tc+"','"+TbTarih.Text+"','"+TbGirisSaat.Text+"','"+textBox1.Text+"')",baglanti);
                else
                    komut = new SqlCommand("insert into CalismaTablo(TC,Tarih,BaslangicSaat) values('" + GirisPencere.tc + "','" + TbTarih.Text + "','" + TbGirisSaat.Text + "')", baglanti); 
            }
            else
            {
                if (ChbCikisDegistir.Checked)
                    komut = new SqlCommand("update CalismaTablo set BitisSaat='"+TbCikisSaat.Text+ "',Aciklama='"+textBox1.Text+ "' where ID="+CalismaID,baglanti);
                else
                    komut = new SqlCommand("update CalismaTablo set BitisSaat='" + TbCikisSaat.Text + "' where ID=" + CalismaID, baglanti);
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
          

        }

        private void ChbCikisDegistir_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbCikisDegistir.Checked)
            {
                TbCikisSaat.Enabled = textBox1.Enabled = true;
                MessageBox.Show("GİRİŞ SAATINI DEĞİŞTİRME İLE İLGİLİ OLARAK AÇIKLAMA SATIRINA EN AZ 15 HANELI BİLGİ YAZILMALI.", "AÇIKLAMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TbCikisSaat.Enabled = textBox1.Enabled = false;
                TbCikisSaat.Text = DateTime.Now.ToShortTimeString();
                textBox1.Text = aciklamabilgisi;
            }
        }
    }
}
