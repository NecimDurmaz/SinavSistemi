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

    public partial class frmKayitDuzenle : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public frmKayitDuzenle()
        {
            InitializeComponent();
        }
        public int KullaniciID;
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
        public void KullaniciGuncelleme()
        {

            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("update Kullanicilar  set KullaniciIsim=@p1,KullaniciSoyisim=@p2,KullaniciAdi=@p3,Sifre=@p4,Mail=@p5,KullaniciTipID=@p6,GuvenlikSoruID=@p7,GuvenlikSorusuCevap=@p8 where KullaniciID=@p9", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtKullaniciIsim.Text);
            kmt.Parameters.AddWithValue("@p2", TxtKullaniciSoyisim.Text);
            kmt.Parameters.AddWithValue("@p3", TxtKullaniciAdi.Text);
            kmt.Parameters.AddWithValue("@p4", TxtSifre.Text);
            kmt.Parameters.AddWithValue("@p5", TxtMail.Text);
            kmt.Parameters.AddWithValue("@p6", CmbKullaniciTip.SelectedIndex+1);
            kmt.Parameters.AddWithValue("@p7", CmbGuvenlikSorusu.SelectedIndex);
            kmt.Parameters.AddWithValue("@p8", TxtGuvenlikCevap.Text);
            kmt.Parameters.AddWithValue("@p9", KullaniciID);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Kullanici Guncellendi.!!!!!");
            bgl.baglanti().Close();
            VeriDoldurma();
        }

        public void VeriDoldurma()
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from Kullanicilar where KullaniciID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", KullaniciID);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                TxtKullaniciIsim.Text=dr[1].ToString();
                TxtKullaniciSoyisim.Text=dr[2].ToString();
                TxtKullaniciAdi.Text=dr[3].ToString();
                TxtSifre.Text=dr[4].ToString();
                TxtMail.Text=dr[5].ToString();
                CmbKullaniciTip.SelectedIndex=(int)dr[6];
                CmbGuvenlikSorusu.SelectedIndex=(int)dr[7];
                TxtGuvenlikCevap.Text=dr[8].ToString();
            }
            dr.Close();
            bgl.baglanti().Close();
        }
        private void frmKayitDuzenle_Load(object sender, EventArgs e)
        {
            GuvenlikSorulari(); 
            KullaniciTipleri();
            VeriDoldurma();
        }

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleme();
        }
    }
}
