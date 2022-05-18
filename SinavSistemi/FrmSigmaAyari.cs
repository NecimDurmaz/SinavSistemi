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
    public partial class FrmSigmaAyari : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public int ID;
        public FrmSigmaAyari()
        {
            InitializeComponent();
        }
        public void SigmaGetir()
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("select * from SigmaSure where KullaniciID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", ID);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                txtSigma1.Text = Convert.ToInt32(dr[7]).ToString();
                txtSigma2.Text = Convert.ToInt32(dr[6]).ToString();
                txtSigma3.Text = Convert.ToInt32(dr[5]).ToString();
                txtSigma4.Text = Convert.ToInt32(dr[4]).ToString();
                txtSigma5.Text = Convert.ToInt32(dr[3]).ToString();
                txtSigma6.Text = Convert.ToInt32(dr[2]).ToString();
            }
            dr.Close();
            bgl.baglanti().Close();


        }

        private void FrmSigmaAyari_Load(object sender, EventArgs e)
        {
            SigmaGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSigma1.Text)<Convert.ToInt32(txtSigma2.Text) && Convert.ToInt32(txtSigma2.Text)<Convert.ToInt32(txtSigma3.Text) && Convert.ToInt32(txtSigma3.Text)<Convert.ToInt32(txtSigma4.Text)
                && Convert.ToInt32(txtSigma4.Text)<Convert.ToInt32(txtSigma5.Text)&&Convert.ToInt32(txtSigma5.Text)<Convert.ToInt32(txtSigma6.Text))
            {
                bgl.baglanti();
                SqlCommand kmt = new SqlCommand("update SigmaSure Set Sigma1=@p1,Sigma2=@p2,Sigma3=@p3,Sigma4=@p4,Sigma5=@p5,Sigma6=@p6 " +
                    "where  KullaniciID=@p7", bgl.baglanti());
                kmt.Parameters.AddWithValue("p1", txtSigma1.Text);
                kmt.Parameters.AddWithValue("p2", txtSigma2.Text);
                kmt.Parameters.AddWithValue("p3", txtSigma3.Text);
                kmt.Parameters.AddWithValue("p4", txtSigma4.Text);
                kmt.Parameters.AddWithValue("p5", txtSigma5.Text);
                kmt.Parameters.AddWithValue("p6", txtSigma6.Text);
                kmt.Parameters.AddWithValue("p7", ID);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Başarılı");
            }
            else { MessageBox.Show("Sigmasal hata"); }

        }
    }
}
