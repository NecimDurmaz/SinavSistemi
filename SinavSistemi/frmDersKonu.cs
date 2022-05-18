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
    public partial class frmDersKonu : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public frmDersKonu()
        {
            InitializeComponent();
        }

        private void frmDersKonu_Load(object sender, EventArgs e)
        {
            CmbDoldur();
        }

        public void CmbDoldur()
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from Dersler", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(kmt.ExecuteReader());
            bgl.baglanti().Close();
            cmbDers.DataSource = dt;
            cmbDers.DisplayMember = "DersIsim";
            cmbDers.ValueMember = "DersID";
        }
        private void btnDers_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("insert into Dersler(DersIsim) values (@p1) ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtDers.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ders basariyla Eklendi...!!!");
            CmbDoldur();
        }

        private void btnKonu_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("insert into Konular(KonuIsim,DersID) values (@p1,@p2) ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtKonu.Text);
            kmt.Parameters.AddWithValue("@p2", cmbDers.SelectedValue);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Konu basariyla Eklendi...!!!");
            CmbDoldur();
        }
 
    }
}
