using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class FrmOgrenci : Form
    {
        private string kullaniciAD;

        public string KullaniciAD
        {
            get { return kullaniciAD; }
            set { kullaniciAD = value; }
        }

        private int kullaniciID;

        public int KullaniciID
        {
            get { return kullaniciID; }
            set { kullaniciID = value; }
        }


        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void btnSigmaAyar_Click(object sender, EventArgs e)
        {
            FrmSigmaAyari frmSigmaAyari = new FrmSigmaAyari();
            frmSigmaAyari.ID=kullaniciID;
            frmSigmaAyari.ShowDialog();
        }

        private void btnSinavBaslat_Click(object sender, EventArgs e)
        {
            FrmOgrenciSinav frmOgrenci = new FrmOgrenciSinav();
            frmOgrenci.KullaniciID=KullaniciID;
            frmOgrenci.KullaniciAD=KullaniciAD;
            frmOgrenci.Sinavturu="NormalSinav";
            frmOgrenci.Show();
            this.Hide();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmOgrenciIstatistik frmIstatistik = new FrmOgrenciIstatistik();
            frmIstatistik.KullaniciAD=kullaniciAD;
            frmIstatistik.KullaniciID=kullaniciID;
            frmIstatistik.Show();
        }

        private void btnEksik_Click(object sender, EventArgs e)
        {
            FrmOgrenciSinav frmOgrenci = new FrmOgrenciSinav();
            frmOgrenci.KullaniciID=KullaniciID;
            frmOgrenci.KullaniciAD=KullaniciAD;
            frmOgrenci.Sinavturu="OzelSinav";
            frmOgrenci.Show();
            this.Hide();
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {

        }
    }
}
