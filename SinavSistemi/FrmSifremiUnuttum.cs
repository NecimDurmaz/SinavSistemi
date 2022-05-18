using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class FrmSifremiUnuttum : Form
    {
        SqlBaglanti bgl = new SqlBaglanti(); 
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }
        public void KullaniciTipleri()
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from KullaniciTipleri", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(kmt.ExecuteReader());
            bgl.baglanti().Close();
            CmbKullaniciTipi.DataSource = dt;
            CmbKullaniciTipi.DisplayMember = "KullaniciTipAdi";
            CmbKullaniciTipi.ValueMember = "KullaniciTipID";
            bgl.baglanti().Close();

        }
        public void GuvenlikSorulari()
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from GuvenlikSorulari Where Durum=1", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(kmt.ExecuteReader());
            bgl.baglanti().Close();
            cmbGuvenlikSorusu.DataSource = dt;
            cmbGuvenlikSorusu.DisplayMember = "Soru";
            cmbGuvenlikSorusu.ValueMember = "GuvenlikSoruID";
            bgl.baglanti().Close();
        }
        public void Guvenlik()
        {
            SqlCommand kmt = new SqlCommand("select * from Kullanicilar Where GuvenlikSoruID=@p1 and GuvenlikSorusuCevap=@p2 and Mail=@p3 and KullaniciTipID=@p4", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", Convert.ToInt32(cmbGuvenlikSorusu.SelectedValue));
            kmt.Parameters.AddWithValue("@p2", TxtGuncelikSorusuCevap.Text);
            kmt.Parameters.AddWithValue("@p3", TxtMail.Text);
            kmt.Parameters.AddWithValue("@p4", Convert.ToInt32(CmbKullaniciTipi.SelectedValue));
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand kmt2 = new SqlCommand("select Sifre from Kullanicilar Where Mail=@p1", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@p1", TxtMail.Text);
                SqlDataReader dr2 = kmt2.ExecuteReader();

                if (dr2.Read())
                {
                    MessageBox.Show("Sifreniz => " + dr2[0].ToString());
                }
            }
            else
            {
                MessageBox.Show("Guvenlik sorusu ve ya cevabi yanlis tekrar deneyiniz...!!!");
            }
        }

        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            KullaniciTipleri();
            GuvenlikSorulari();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guvenlik();
        }
    }
}
