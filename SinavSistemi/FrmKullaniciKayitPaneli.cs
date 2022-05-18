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
        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("insert into Kullanicilar (KullaniciIsim,KullaniciSoyisim,KullaniciAdi,Sifre,Mail,KullaniciTipID,GuvenlikSoruID,GuvenlikSorusuCevap) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtKullaniciIsim.Text);
            kmt.Parameters.AddWithValue("@p2", TxtKullaniciSoyisim.Text);
            kmt.Parameters.AddWithValue("@p3", TxtKullaniciAdi.Text);
            kmt.Parameters.AddWithValue("@p4", TxtSifre.Text);
            kmt.Parameters.AddWithValue("@p5", TxtMail.Text);
            kmt.Parameters.AddWithValue("@p6", CmbKullaniciTip.SelectedIndex);
            kmt.Parameters.AddWithValue("@p7", CmbGuvenlikSorusu.SelectedIndex);
            kmt.Parameters.AddWithValue("@p8", TxtGuvenlikCevap.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Okey");
            bgl.baglanti().Close();
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
