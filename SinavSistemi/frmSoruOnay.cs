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
    public partial class frmSoruOnay : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public frmSoruOnay()
        {
            InitializeComponent();
        }
        public int SoruID;
        public string DogruCevap;
        public void SoruCekme()
        {
            //Veritabanından Soruları çekme



            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from SoruuHavuzu where SoruID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", SoruID);
            SqlDataReader dr = kmt.ExecuteReader();

            if (dr.Read())
            {
                rchtKonu.Text = dr[1].ToString();
                lblZorluk.Text = dr[5].ToString();
                LblA.Text = dr[7].ToString();
                LblB.Text = dr[8].ToString();
                LblC.Text = dr[9].ToString();
                LblD.Text = dr[10].ToString();

                DogruCevap = dr[11].ToString();
                pictureSoru.ImageLocation = dr[3].ToString();
            }
            dr.Close();
            bgl.baglanti().Close();
            DogruCevapRenk();

        }

        public void DogruCevapRenk()
        {
            LblA.ForeColor=Color.Black;
            LblB.ForeColor=Color.Black;
            LblC.ForeColor=Color.Black;
            LblD.ForeColor=Color.Black;
            if (LblA.Text==DogruCevap)
                LblA.ForeColor=Color.Green;
            else if (LblB.Text==DogruCevap)
                LblB.ForeColor=Color.Green;
            else if (LblC.Text==DogruCevap)
                LblC.ForeColor=Color.Green;
            else if (LblD.Text==DogruCevap)
                LblD.ForeColor=Color.Green;
        }
        private void frmSoruOnay_Load(object sender, EventArgs e)
        {
            SoruCekme();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Secilen soruyu silmek  istediğinizden emin misiniz?", "Onay Kutusu", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                bgl.baglanti();
                SqlCommand kmt = new SqlCommand("delete   SoruuHavuzu where SoruID=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", SoruID);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Soru basariyla silindi.!!!!");
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Soru silme islemi iptal edildi.!!!!");
            }
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Secilen soruyu eklemek  istediğinizden emin misiniz?", "Onay Kutusu", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                bgl.baglanti();
                SqlCommand kmt = new SqlCommand("update   SoruuHavuzu set SonDurum=1 where SoruID=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", SoruID);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Soru basariyla eklendi.!!!!");
                this.Hide();
            }
            else
            {

                MessageBox.Show("Soru ekleme islemi iptal edildi.!!!!");
            }
        }
    }
}
