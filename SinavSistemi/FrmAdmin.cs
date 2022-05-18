using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class FrmAdmin : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public void SoruHavuzuDoldur()
        {
            bgl.baglanti();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from SoruuHavuzu", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        public void OnayBekleyenSorular()
        {
            bgl.baglanti();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from SoruuHavuzu Where SonDurum=1", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        public void Kayitlar()
        {
            bgl.baglanti();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kullanicilar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            SoruHavuzuDoldur();
        }
        string BasilanButon = " ";
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (BasilanButon=="OnayBekliyen")
            {

                int secilenindex = dataGridView1.SelectedCells[0].RowIndex;
                int SoruId = Convert.ToInt32(dataGridView1.Rows[secilenindex].Cells[0].Value);
                frmSoruOnay frmSoru = new frmSoruOnay();
                frmSoru.SoruID=SoruId;
                frmSoru.Show();
            }
            else if(BasilanButon=="Kayitlar")
            {
                
                int secilenindex = dataGridView1.SelectedCells[0].RowIndex;
                int KullaniciID = Convert.ToInt32(dataGridView1.Rows[secilenindex].Cells[0].Value);
                frmKayitDuzenle frmKayit = new frmKayitDuzenle();
                frmKayit.KullaniciID=KullaniciID;
                frmKayit.Show();
            }

        }

        private void btnTumSorular_Click(object sender, EventArgs e)
        {
            SoruHavuzuDoldur();
            BasilanButon="TumSorular";
        }

        private void btnOnaySoru_Click(object sender, EventArgs e)
        {
            OnayBekleyenSorular();
            BasilanButon="OnayBekliyen";
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Kayitlar();
            BasilanButon="Kayitlar";
        }

     
    }
}
