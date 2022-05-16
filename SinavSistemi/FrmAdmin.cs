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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenindex = dataGridView1.SelectedCells[0].RowIndex;
            int SoruId = Convert.ToInt32(dataGridView1.Rows[secilenindex].Cells[0].Value);
            frmSoruOnay frmSoru = new frmSoruOnay();
            frmSoru.SoruID=SoruId;
            frmSoru.Show();
            //bgl.baglanti();
            //int durum = Convert.ToInt32(dataGridView1.Rows[secilenindex].Cells[11].Value);
            //DialogResult dialogResult = MessageBox.Show("Secilen sorunun durumunu değiştirmek istediğinizden emin misiniz?", "Onay Kutusu", MessageBoxButtons.YesNo);

            //if (dialogResult == DialogResult.Yes)
            //{
            //    SqlCommand komut = new SqlCommand("update SoruHavuzu set SoruDurum=@p1 where SoruID=@p2", bgl.baglanti());
            //    if (durum == 1)
            //        durum = 0;
            //    else
            //        durum = 1;
            //    komut.Parameters.AddWithValue("@p1", durum);
            //    komut.Parameters.AddWithValue("@p2", SoruId);
            //    komut.ExecuteNonQuery();
            //    bgl.baglanti().Close();
            //    SoruHavuzuDoldur();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    MessageBox.Show("Secilen sorunun durumunu değiştirme işlemi iptal edildi.");
            //}
            //bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
