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
using System.Drawing.Imaging;

namespace SinavSistemi
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        string DogruCevap = "";
        
        public void CevapKontrol(string Cevap)
        {
            if (DogruCevap == Cevap)
            {
                CevapTrue.Visible = true;
            }
            else
            {
                CevapFalse.Visible = true;
            }
        }
        public void CevapButonKapatma()
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
        public void CevapButonAcma()
        {
            CevapTrue.Visible = false;
            CevapFalse.Visible = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
        }
        int DogruCevapSayac=0;
        public void SoruCekme(int sayi,int KacinciSoru)
        {
           
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from SoruuHavuzu where SoruID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = kmt.ExecuteReader();

            if (dr.Read())
            {
                richTextBox1.Text = dr[1].ToString();
                LblA.Text = dr[7].ToString();
                LblB.Text = dr[8].ToString();
                LblC.Text = dr[9].ToString();
                LblD.Text = dr[10].ToString();
                DogruCevap = dr[11].ToString();
                pictureBox1.ImageLocation = dr[3].ToString();
                if (DogruSoruCevap[KacinciSoru] == null){
                DogruSoruCevap[DogruCevapSayac] = DogruCevap;
                DogruCevapSayac++;
                }
 
            }
            dr.Close();
            bgl.baglanti().Close();


        }
        int[] Sorular = new int[8];
        string[] SoruCevap = new string[8];
        string[] DogruSoruCevap = new string[8];
        int KacinciSoru = 0;
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {

            
            int soruAdeti = 0;
            SinavSuresi();
            BtnSonraki.PerformClick();
            timer1.Start();

            while (soruAdeti <8)
            {
                bool durum = false;

                Random rnd = new Random();
                int soruID = rnd.Next(1, 9);

                //soru karsilastirma
                for (int i = 0; i < soruAdeti; i++)
                {
                    if (Sorular[i] == soruID)
                    {
                        durum = true;
                    }
                }

                //sorunun ıd'sini sorular dizisine atma ve form'a çekme
                if (!durum)
                {
                    Sorular[soruAdeti] = soruID;
                    soruAdeti++;
                }


            }
            BtnOnceki.Enabled = false;
            SoruCekme(Sorular[0],1);
            //BtnSonraki.PerformClick();
        }
       

        private void BtnA_Click(object sender, EventArgs e)
        {
            SoruCevap[KacinciSoru - 1]=LblA.Text;
            CevapButonKapatma();
            CevapKontrol(LblA.Text);
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            SoruCevap[KacinciSoru - 1] = LblB.Text;
            CevapButonKapatma();
            CevapKontrol(LblB.Text);
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            SoruCevap[KacinciSoru - 1] = LblC.Text;
            CevapButonKapatma();
            CevapKontrol(LblC.Text);
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            SoruCevap[KacinciSoru - 1] = LblD.Text;
            CevapButonKapatma();
            CevapKontrol(LblD.Text);
        }
        public int SinavSuresi()
        {
            int sinavsuresi=0 ;
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("select SinavSuresi from Dersler where DersID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                sinavsuresi = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            bgl.baglanti().Close();
            return sinavsuresi;
        }
        int sayac = 0; //Zamanlayıcı İcin Kullandigimiz Sayac
        private void timer1_Tick(object sender, EventArgs e)
        { 
            sayac++;
            timer1.Interval = SinavSuresi() * 60;
            if(sayac >= SinavSuresi()*60)
            {
                timer1.Stop();
            }
            progressBar1.Maximum = SinavSuresi() * 60;
            progressBar1.Value = sayac;
            label3.Text = ((SinavSuresi() * 60 )- sayac).ToString();
        }
         
        private void BtnOnceki_Click(object sender, EventArgs e)
        {
            
            if (KacinciSoru==8)
            BtnSonraki.Enabled = true;
            KacinciSoru--;
            SoruCekme(Sorular[KacinciSoru-1],KacinciSoru-1);

            label6.Text = KacinciSoru.ToString();

            if (KacinciSoru == 1)
                BtnOnceki.Enabled = false;
            
        }
        private void BtnSonraki_Click(object sender, EventArgs e)
        {

            
                BtnOnceki.Enabled = true;
            CevapButonAcma();
            KacinciSoru++;
            SoruCekme(Sorular[KacinciSoru-1],KacinciSoru-1);
            
            label6.Text = KacinciSoru.ToString();
            if (KacinciSoru == 8)
                BtnSonraki.Enabled = false;
            

        }

        private void BtnSonraki_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                
                if(DogruSoruCevap[i] == SoruCevap[i])
                {
                    bgl.baglanti();
                    SqlCommand kmt = new SqlCommand("insert into DogruSoruHavuzu (KullaniciID,SoruID,Tarih,Sayac) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", 3);
                    kmt.Parameters.AddWithValue("@p2", Sorular[i]);
                    kmt.Parameters.AddWithValue("@p3", DateTime.Now.ToString("dd-MMM-yyyy"));
                    kmt.Parameters.AddWithValue("@p4", 1);
                    kmt.ExecuteNonQuery();
                    
                    bgl.baglanti().Close();
                }

            }
                    MessageBox.Show("Okey");
        }
    }
}
