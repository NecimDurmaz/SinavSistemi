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
    public partial class FrmSinavSoruEkle : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public int DersID,KonuID;
        public FrmSinavSoruEkle()
        {
            InitializeComponent();
        }
        public void CmbDersCek()
        {
            bgl.baglanti();
            SqlCommand komut2 = new SqlCommand("select * from Dersler",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbDers.Items.Add(dr2[1]);
                
                
            }
            bgl.baglanti().Close();
        }

        private void FrmSinavSoruEkle_Load(object sender, EventArgs e)
        {
            CmbDersCek();
            
        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            bgl.baglanti();
            CmbKonu.Items.Clear();
            SqlCommand komut = new SqlCommand("Select * from Konular WHERE DersID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbDers.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbKonu.Items.Add(dr[1]);
               
               
            }
            CmbKonu.Text = "";
            bgl.baglanti().Close();

        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName;
        }

      
        private void BtnSoruEkle_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("insert into SoruuHavuzu (SoruIcerik,KonuID,ResimYolu,DersID,ZorlukSeviyesi,SoruDurum,Cevap1,Cevap2,Cevap3,Cevap4,DogruCevap) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@9,@p10,@p11)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",RchSoruIcerik.Text);
            kmt.Parameters.AddWithValue("@p2",Convert.ToInt32(CmbKonu.SelectedIndex+1));
            kmt.Parameters.AddWithValue("@p3",TxtResim.Text);
            kmt.Parameters.AddWithValue("@p4", Convert.ToInt32(CmbDers.SelectedIndex+1));
            kmt.Parameters.AddWithValue("@p5",CmbZorlukSeviyesi.Text);
            kmt.Parameters.AddWithValue("@p6",0);
            kmt.Parameters.AddWithValue("@p7", TxtCevap1.Text);
            kmt.Parameters.AddWithValue("@p8", TxtCevap2.Text);
            kmt.Parameters.AddWithValue("@p9", TxtCevap3.Text);
            kmt.Parameters.AddWithValue("@p10", TxtCevap4.Text);
            kmt.Parameters.AddWithValue("@p11", TxtDogruCevap.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
           
            MessageBox.Show("Soru basariyla eklendi...!!!");
        }
    }
}
