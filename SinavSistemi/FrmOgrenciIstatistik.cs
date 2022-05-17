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
using System.Collections;
using System.Drawing.Printing;
namespace SinavSistemi
{
    public partial class FrmOgrenciIstatistik : Form
    {
        public FrmOgrenciIstatistik()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private int kullaniciID;
        int[] YanlisSoruID = new int[0];
        int[] YanlisSoruDersID = new int[0];
        int[] YanlisSoruKonuID = new int[0];
        string[] YanlisSoruDersAD = new string[0];
        string[] YanlisSoruKonuAD = new string[0];
        int[] YanlisSoruSayac = new int[0];
        int YanlisSoruAdet = 0;

        int[] DogruSoruDersID = new int[0];
        int[] DogruSoruKonuID = new int[0];
        string[] DogruSoruDersAD = new string[0];
        string[] DogruSoruKonuAD = new string[0];

        int[] DogruSoruID = new int[0];
        int[] DogruSoruIDSayac = new int[0];
        int DogruSoruIDAdet = 0;
        public int KullaniciID
        {
            get { return kullaniciID; }
            set { kullaniciID = value; }
        }
        private string kullaniciAD;

        public string KullaniciAD
        {
            get { return kullaniciAD; }
            set { kullaniciAD = value; }
        }

        //public void DersKonuAdCekme()
        //{
        //    for (int i = 1; i <= DogruSoruIDAdet; i++)
        //    {

        //        bgl.baglanti();
        //        SqlCommand kmt = new SqlCommand("select KonuIsim from Dersler where KonuID=@p1", bgl.baglanti());
        //        kmt.Parameters.AddWithValue("@p1", DogruSoruDersID[i-1]);
        //        SqlDataReader dr = kmt.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            DogruSoruDersAD[i-1]=(string)dr[0];
        //        }
        //        dr.Close();
        //        bgl.baglanti().Close();

        //        bgl.baglanti();
        //        SqlCommand kmt2 = new SqlCommand("select KonuIsim from Dersler where KonuID=@p1", bgl.baglanti());
        //        kmt2.Parameters.AddWithValue("@p1", DogruSoruDersID[i-1]);
        //        SqlDataReader dr2 = kmt2.ExecuteReader();
        //        while (dr2.Read())
        //        {
        //            DogruSoruKonuAD[i-1]=(string)dr2[0];
        //        }
        //        dr2.Close();
        //        bgl.baglanti().Close();
        //    }
        //}
        public void DersKonuIDCekme()
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("select  ds.DogruSoruID,ds.Sayac,sh.DersID,sh.KonuID from SoruuHavuzu sh INNER JOIN DogruSoruHavuzu " +
                "ds on sh.SoruID=ds.SoruID where ds.KullaniciID=@p1 ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", kullaniciID);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                //todo
                DogruSoruIDAdet++;
                Array.Resize(ref DogruSoruID, DogruSoruIDAdet);
                Array.Resize(ref DogruSoruIDSayac, DogruSoruIDAdet);
                Array.Resize(ref DogruSoruDersID, DogruSoruIDAdet);
                Array.Resize(ref DogruSoruKonuID, DogruSoruIDAdet);
                DogruSoruID[DogruSoruIDAdet-1]=(int)dr[0];
                DogruSoruIDSayac[DogruSoruIDAdet-1]=(int)dr[1];
                DogruSoruDersID[DogruSoruIDAdet-1]=(int)dr[2];
                DogruSoruKonuID[DogruSoruIDAdet-1]=(int)dr[2];

            }
            dr.Close();
            bgl.baglanti().Close();
            Array.Resize(ref DogruSoruDersAD, DogruSoruIDAdet);
            Array.Resize(ref DogruSoruKonuAD, DogruSoruIDAdet);
            bgl.baglanti();
            SqlCommand kmt2 = new SqlCommand("select ys.YanlisSoruID,ys.Sayac,sh.DersID,sh.KonuIDfrom SoruuHavuzu sh INNER JOIN YanlisSoruHavuzu ys on sh.SoruID=ys.SoruID " +
                "where ds.KullaniciID=@p1", bgl.baglanti());
            kmt2.Parameters.AddWithValue("@p1", KullaniciID);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                //todo
                YanlisSoruAdet++;
                Array.Resize(ref YanlisSoruID, YanlisSoruAdet);
                Array.Resize(ref YanlisSoruSayac, YanlisSoruAdet);
                Array.Resize(ref YanlisSoruDersID, YanlisSoruAdet);
                Array.Resize(ref YanlisSoruKonuID, YanlisSoruAdet);
                YanlisSoruID[YanlisSoruAdet-1]=(int)dr[0];
                YanlisSoruSayac[YanlisSoruAdet-1]=(int)dr[1];
                YanlisSoruDersID[YanlisSoruAdet-1]=(int)dr[2];
                YanlisSoruKonuID[YanlisSoruAdet-1]=(int)dr[2];
            }
            dr2.Close();
            bgl.baglanti().Close();
            Array.Resize(ref YanlisSoruDersID, DogruSoruIDAdet);
            Array.Resize(ref YanlisSoruKonuID, DogruSoruIDAdet);
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
        int Dogru = 0;
        int Yanlis = 0;
        int Bos = 0;
        int toplam = 0;
        public void GrafikDoldur()
        {
            //Point leri temizleme.
            foreach (var series in chartKonu.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chartYuzde.Series)
            {
                series.Points.Clear();
            }
            Dogru = 0;
            Yanlis = 0;
            Bos = 0;
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select I.SoruID,I.BosSayac,I.DogruSayac,I.YanlisSayac,K.KonuIsim from (IstatistikSoru I Inner join SoruuHavuzu S on I.SoruID=S.SoruID)" +
                " Inner Join Konular k on k.KonuID=s.KonuID where K.KonuIsim=@p1  order by I.SoruID asc ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", cmbKonu.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            int i = 0;


            while (dr.Read())
            {
                i++;


                chartKonu.Series["Bos"].Points.AddXY(dr[0], (int)dr[1]);
                chartKonu.Series["Dogru"].Points.AddXY(dr[0], (int)dr[2]);
                chartKonu.Series["Yanlis"].Points.AddXY(dr[0], (int)dr[3]);


                Bos+=(int)dr[1];
                Dogru+=(int)dr[2];
                Yanlis+=(int)dr[3];

            }
            toplam=Bos+Dogru+Yanlis;
            lblToplam.Text= "%"+(100*Dogru)/toplam+" oranında basarili.!!!";
            chartYuzde.Series["Yuzde"].Points.AddXY("Bos", Bos);
            chartYuzde.Series["Yuzde"].Points.AddXY("Dogru", Dogru);
            chartYuzde.Series["Yuzde"].Points.AddXY("Yanlis", Yanlis);
            chartYuzde.Series["Yuzde"].Points[0].Color =Color.DarkGray;
            chartYuzde.Series["Yuzde"].Points[1].Color =Color.Chartreuse;
            chartYuzde.Series["Yuzde"].Points[2].Color = Color.Red;


        }
        string GenelVeri = " ";

        public void CiktiVeri()
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand(" Select  K.KonuIsim,sum(I.BosSayac) ,sum(I.DogruSayac),sum(I.YanlisSayac) from (IstatistikSoru I Inner join SoruuHavuzu S on I.SoruID=S.SoruID)" +
                                             "Inner Join Konular k on k.KonuID=s.KonuID   where KullaniciID=@p1 group by k.KonuIsim ", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", KullaniciID);
            SqlDataReader dr = kmt.ExecuteReader();
            int yuzde;
            int toplam;
            while (dr.Read())
            {
                toplam= ((int)dr[1]+(int)dr[2]+(int)dr[3]);
                yuzde = (100*(int)dr[2])/toplam;
                GenelVeri += dr[0].ToString()+" konusunda toplamda "+dr[1].ToString()+" bos "+dr[2].ToString() +" dogru "+dr[3].ToString()+" yanlis sayiniz vardir."+"%"+yuzde+" oranında soruları basarili cozdunuz.!!! \n\n";
            }
             
            dr.Close();
            bgl.baglanti().Close();
        }
        private void FrmOgrenciIstatistik_Load(object sender, EventArgs e)
        {
            CmbDoldur();
        }
        public void KonuCekme()
        {

            bgl.baglanti();
            SqlCommand kmt2 = new SqlCommand("select * from konular k INNER JOIN dersler d  on k.DersID=d.DersID where d.DersIsim=@p1", bgl.baglanti());
            kmt2.Parameters.AddWithValue("@p1", cmbDers.Text);
            DataTable dt2 = new DataTable();
            dt2.Load(kmt2.ExecuteReader());
            bgl.baglanti().Close();
            cmbKonu.DataSource = dt2;
            cmbKonu.DisplayMember = "konuIsim";
            cmbKonu.ValueMember = "konuID";

        }
        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {


            KonuCekme();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //btnGrafik
            GrafikDoldur();

        }
        PrintDialog PRD = new PrintDialog();

        private void btnCikti_Click(object sender, EventArgs e)
        {
            CiktiVeri();
            PrintDocument Kagit = new PrintDocument();
            DialogResult yazdirmaislemi;
            yazdirmaislemi= PRD.ShowDialog();
            Kagit.PrintPage +=Kagit_PrintPage;
            if (yazdirmaislemi==DialogResult.OK)
            {
                Kagit.Print();
            }
        }

        private void Kagit_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font YaziAilesi = new Font("Arial", 12);
            SolidBrush kalem = new SolidBrush(Color.Black);
            e.Graphics.DrawString=(GenelVeri, YaziAilesi, kalem, 10, 20);
        }
    }
}
