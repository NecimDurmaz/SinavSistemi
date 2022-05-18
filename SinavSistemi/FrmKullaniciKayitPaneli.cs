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

namespace SinavSistemi
{
    public partial class FrmKullaniciKayitPaneli : Form
    {
        public FrmKullaniciKayitPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        int KullaniciID;
        bool KullaniciKayitDurum;

        public bool KayitSorgu()
        {
            //Kayit sorgulama
            KullaniciKayitDurum=false;
            bgl.baglanti();
            SqlCommand Kullanicikmt = new SqlCommand("Select Mail from Kullanicilar where Mail=@p1", bgl.baglanti());
            Kullanicikmt.Parameters.AddWithValue("@p1", TxtMail.Text);
            SqlDataReader dr = Kullanicikmt.ExecuteReader();
            if (dr.Read())
                KullaniciKayitDurum=true;
            dr.Close();
            bgl.baglanti().Close();
            return KullaniciKayitDurum;
        }
        
        public void KullaniciEkleme()
        {

            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("insert into Kullanicilar (KullaniciIsim,KullaniciSoyisim,KullaniciAdi,Sifre,Mail,KullaniciTipID,GuvenlikSoruID,GuvenlikSorusuCevap) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtKullaniciIsim.Text);
            kmt.Parameters.AddWithValue("@p2", TxtKullaniciSoyisim.Text);
            kmt.Parameters.AddWithValue("@p3", TxtKullaniciAdi.Text);
            kmt.Parameters.AddWithValue("@p4", TxtSifre.Text);
            kmt.Parameters.AddWithValue("@p5", TxtMail.Text);
            kmt.Parameters.AddWithValue("@p6", CmbKullaniciTip.SelectedValue);
            kmt.Parameters.AddWithValue("@p7", CmbGuvenlikSorusu.SelectedValue);
            kmt.Parameters.AddWithValue("@p8", TxtGuvenlikCevap.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Basariyla kayit oldunuz...!!!");
            bgl.baglanti().Close();
        }
        public void KullaniciIDAlma()
        {
            //Kullanici ID alma
            bgl.baglanti();
            SqlCommand IDkmt = new SqlCommand("Select KullaniciID from Kullanicilar where Mail=@p1", bgl.baglanti());
            IDkmt.Parameters.AddWithValue("@p1", TxtMail.Text);
            SqlDataReader dr = IDkmt.ExecuteReader();
            if (dr.Read())
                KullaniciID=(int)dr[0];
            dr.Close();
            bgl.baglanti().Close();
        }

        public void SigmaDoldurma()
        {
            //  otomatik Sigma 6 doldurma

            bgl.baglanti();
            SqlCommand SigmaKmt = new SqlCommand("insert into SigmaSure (Sigma1,Sigma2,Sigma3,Sigma4,Sigma5,Sigma6,KullaniciID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)  ", bgl.baglanti());
            SigmaKmt.Parameters.AddWithValue("@p1", 1);
            SigmaKmt.Parameters.AddWithValue("@p2", 2);
            SigmaKmt.Parameters.AddWithValue("@p3", 7);
            SigmaKmt.Parameters.AddWithValue("@p4", 30);
            SigmaKmt.Parameters.AddWithValue("@p5", 60);
            SigmaKmt.Parameters.AddWithValue("@p6", 180);
            SigmaKmt.Parameters.AddWithValue("@p7", KullaniciID);
            SigmaKmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            if (!KayitSorgu())
            {

                KullaniciEkleme();

                //ogrenci ise
                if (CmbKullaniciTip.SelectedIndex+1==2)
                {
                    KullaniciIDAlma();
                    SigmaDoldurma();

                }
            }
            else
            {
                MessageBox.Show("Zaten Kayitli Mail lütfen tekrar deneyiniz..!!");
            }
        }
        public void GuvenlikSorulari() //combobox'a soruları çekme
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from GuvenlikSorulari Where Durum=1", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(kmt.ExecuteReader());
            bgl.baglanti().Close();
            CmbGuvenlikSorusu.DataSource = dt;
            CmbGuvenlikSorusu.DisplayMember = "Soru";
            CmbGuvenlikSorusu.ValueMember = "GuvenlikSoruID";
            bgl.baglanti().Close();
        }
        public void KullaniciTipleri()  //combobox'a Kullanıcı tiplerini  çekme
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from KullaniciTipleri", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(kmt.ExecuteReader());
            bgl.baglanti().Close();
            CmbKullaniciTip.DataSource = dt;
            CmbKullaniciTip.DisplayMember = "KullaniciTipAdi";
            CmbKullaniciTip.ValueMember = "KullaniciTipID";
            bgl.baglanti().Close();

        }

        private void FrmKullaniciKayitPaneli_Load(object sender, EventArgs e)
        {
            GuvenlikSorulari();
            KullaniciTipleri();
        }

       
    }
}
