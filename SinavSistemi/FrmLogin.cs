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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        int KullaniciID;
        string KullaniciAD;
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from Kullanicilar where Mail=@p1 and Sifre=@p2 and KullaniciTipID=@p3", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtMail.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSifre.Text);
            kmt.Parameters.AddWithValue("@p3",Convert.ToInt32(CmbKullaniciTipi.SelectedIndex+1));
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                KullaniciID=Convert.ToInt32(dr[0]);
                KullaniciAD=dr[3].ToString();

                if (CmbKullaniciTipi.SelectedIndex==0)
                {
                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.Show();
                    this.Hide();
                }
                else if (CmbKullaniciTipi.SelectedIndex==1)
                {
                    FrmOgrenci frmOgrenci = new FrmOgrenci ();
                    frmOgrenci.KullaniciID=KullaniciID;
                    frmOgrenci.KullaniciAD=KullaniciAD;
                    frmOgrenci.Mail=TxtMail.Text;
                    frmOgrenci.Show();
                    this.Hide();
                }
                else if (CmbKullaniciTipi.SelectedIndex==2)
                {
                    FrmSinavSorumlusAnaMenu frmSinavSorumlusAnaMenu = new FrmSinavSorumlusAnaMenu();
                    frmSinavSorumlusAnaMenu.Show();
                    this.Hide();
                }

               
            }
            else
            {
                MessageBox.Show("Yanlış Giriş yapildi.Lütfen tekrar giriniz..!!!");

            }
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
          
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
          KullaniciTipleri();
        }

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            FrmKullaniciKayitPaneli fr = new FrmKullaniciKayitPaneli();
            fr.Show();
             
        }

        private void LinkSifremiUnutum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremiUnuttum fr = new FrmSifremiUnuttum();
            fr.Show();
           
        }
    }
}
