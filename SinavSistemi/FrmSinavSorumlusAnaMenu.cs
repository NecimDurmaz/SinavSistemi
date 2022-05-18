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
    public partial class FrmSinavSorumlusAnaMenu : Form
    {
        public FrmSinavSorumlusAnaMenu()
        {
            InitializeComponent();
        }

        private void FrmSinavSorumlusAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSinavSoruEkle frmSoru = new FrmSinavSoruEkle();
            frmSoru.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmDersKonu frmDers = new frmDersKonu();
            frmDers.Show();
        }
    }
}
