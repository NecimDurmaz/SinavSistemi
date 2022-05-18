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
using System.Collections;
namespace SinavSistemi
{
    public partial class FrmOgrenciSinav : Form
    {
        public FrmOgrenciSinav()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        string DogruCevap = "";

        //*********** GLOBAL DİZİ VE PROPERTİES
        int[] SoruIDDizi = new int[0]; // Çekilen Soruların ID'sini tuttuğumuz dizi 
        int soruSayac; // kaç adet soru çekildiğini tuttuğumuz sayac
        string[] SoruCevapDizi = new string[0]; // Sorulara Verilen Cevapları tuttuğumuz dizi
        string[] DogruSoruCevapDizi = new string[0];  //  Çekilen Soruların Cevabını'sini tuttuğumuz dizi
        int DogruCevapSayac;//DogruSoruCevap dizine eklenen soru sayacı
        int KacinciSoru; // O anki gösterilen Sorunun ID'sini tuttuğumuz değişken
        
        bool SinavDurum = false;//Sınavın devam edip etmediğini tutuğumuz değişken
        private int kullaniciID;
        int toplamSoruSayac;// VERİTABANINDAKİ TOPLAM SORU SAYISINI GÖSTEREN DEGİSKEN
        int[] Sigma = new int[6];
        int IsaretlenenDogruSoruSayisi;
        int IsaretlenenYanlisSoruSayisi;
        int BosBirakilanSoruSayisi;
        int[] GorulenSorular = new int[0];
        int GorulenSorularSayac;
        int[] OncedenYanlisCozulenSorular = new int[0];
        int OncedenYanlisCozulenSorularSayac;
        int[] OnaylanmayanSorular = new int[0];
        int OnaylanmayanSorularSayac;
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

        //****  FONKSİYONLAR

        public void Baslangic()
        {
            OnaylanmayanSorularSayac=0;
            OncedenYanlisCozulenSorularSayac =0;
            DogruCevapSayac = 0;
            KacinciSoru = 0;
           
            IsaretlenenDogruSoruSayisi = 0;
            IsaretlenenYanlisSoruSayisi = 0;
            BosBirakilanSoruSayisi = 0;
            GorulenSorularSayac = 0;
            lblKullanici.Text = kullaniciAD;
            //Veritabanındaki Toplam soruları gösterir
            ToplamSoruSayisi();
            // Sigma sıklığını gösterir
            SigmaZaman();
            // Rastgele SoruID'leri olusturur
            SoruIdOlusturma();
            //Yanlis soru havuzundaki soruları cekme
            YanlisCozulenSorularıCekme();

            //sınav süresini başlatma
            if (Sinavturu=="NormalSinav")
            {
                pnlSure.Visible=true;
            timer1.Start();
            SinavSuresiOlusturma();

            }

            SinavDurum=true;
        }
        public void SigmaZaman()
        {

            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from SigmaSure where KullaniciID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", kullaniciID);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                for (int i = 0; i < 6; i++)
                {

                    Sigma[i]=(int)dr[i+2];
                }
            }
            dr.Close();
            bgl.baglanti().Close();
        }
        public void ToplamSoruSayisi()
        {

            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select Count(*) from SoruuHavuzu", bgl.baglanti());

            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
                toplamSoruSayac=(int)dr[0];
            dr.Close();
            bgl.baglanti().Close();
        }
        public void CevapKontrolPictureBox()
        {
            //Verdiğimiz cevapla doğru cevabı karsılastırıp ona göre resim getirme
            if (DogruSoruCevapDizi[KacinciSoru-1] == SoruCevapDizi[KacinciSoru-1])
            {
                CevapTrue.Visible = true;
            }
            else
            {
                CevapFalse.Visible = true;
            }
        }

        public void GorulenSorularıCekme()
        {

            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select SoruID from DogruSoruHavuzu where KullaniciID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", kullaniciID);
            SqlDataReader dr = kmt.ExecuteReader();

            while (dr.Read())
            {
                GorulenSorularSayac++;
                Array.Resize(ref GorulenSorular, GorulenSorularSayac);
                GorulenSorular[GorulenSorularSayac-1]=(int)dr[0];
            }
            dr.Close();
            bgl.baglanti().Close();
        }
        public void OnaylanmayanSorularıCekme()
        {

            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select SoruID from SoruuHavuzu where SonDurum=0 and KullaniciID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", kullaniciID);
            SqlDataReader dr = kmt.ExecuteReader();

            while (dr.Read())
            {
                OnaylanmayanSorularSayac++;
                Array.Resize(ref OnaylanmayanSorular, OnaylanmayanSorularSayac);
                OnaylanmayanSorular[OnaylanmayanSorularSayac-1]=(int)dr[0];
            }
            dr.Close();
            bgl.baglanti().Close();
        }
        public void YanlisCozulenSorularıCekme()
        {

            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select SoruID from YanlisSoruHavuzu where KullaniciID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", kullaniciID);
            SqlDataReader dr = kmt.ExecuteReader();

            while (dr.Read())
            {
                OncedenYanlisCozulenSorularSayac++;
                Array.Resize(ref OncedenYanlisCozulenSorular, OncedenYanlisCozulenSorularSayac);
                OncedenYanlisCozulenSorular[OncedenYanlisCozulenSorularSayac-1]=(int)dr[0];
            }
            dr.Close();
            bgl.baglanti().Close();
        }
        public void CevapButonIslemleri()
        {
            if (SinavDurum)
            {
                if (SoruCevapDizi[KacinciSoru-1]!=null)
                {
                    CevapButonKapatma();
                    CevapRenkDegistirme();
                }
                else
                {

                    BtnA.Enabled = true;
                    BtnB.Enabled = true;
                    BtnC.Enabled = true;
                    BtnD.Enabled = true;
                }
            }
            else
            {
                CevapButonKapatma();
            }

        }


        public void PictureBoxGizleme()
        {
            CevapTrue.Visible=false;
            CevapFalse.Visible=false;
        }
        public void CevapButonKapatma()
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }

        public void SoruCekme(int cekilecekSoruID, int KacinciSoru)
        {
            //Veritabanından Soruları çekme



            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select * from SoruuHavuzu where SoruID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", cekilecekSoruID);
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
                //dogru cevapları diziye atama
                if (DogruSoruCevapDizi[KacinciSoru] == null)
                {
                    DogruCevapSayac++;

                    DogruSoruCevapDizi[DogruCevapSayac-1] = DogruCevap;
                }

            }
            dr.Close();
            bgl.baglanti().Close();


        }
            int SinavSuresi = 0;
            int dakika = 0;
            int saniye = 0;
        public void SinavSuresiOlusturma()
        {
            for (int i = 1; i <= soruSayac; i++)
            {
                bgl.baglanti();
                SqlCommand kmt2 = new SqlCommand("select ZorlukSeviyesi from SoruuHavuzu where SoruID=@p1", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@p1", SoruIDDizi[i-1]);
                SqlDataReader dr2 = kmt2.ExecuteReader();
                if (dr2.Read())
                {
                    SinavSuresi += 30*(Convert.ToInt32(dr2[0]));
                }
                dr2.Close();
                bgl.baglanti().Close();
            }
            dakika = SinavSuresi/60;
            dakika++;
            saniye=SinavSuresi%60;
            lblToplamSure.Text=dakika.ToString()+" Dakika "+saniye.ToString()+" Saniye ";
            progressBar1.Maximum=SinavSuresi;
        
        }
        public string Sinavturu = " ";
        public void SoruIdOlusturma()
        {

            if (Sinavturu== "NormalSinav")
            {


                bgl.baglanti();
                SqlCommand kmt = new SqlCommand("select SoruID,Tarih,Sayac from DogruSoruHavuzu where KullaniciID=@p1 and Sayac<7", bgl.baglanti());
                //TODO
                kmt.Parameters.AddWithValue("@p1", KullaniciID);
                SqlDataReader dr = kmt.ExecuteReader();
                DateTime Bugun = new DateTime();
                Bugun= DateTime.Now;
                while (dr.Read())
                {

                    //BUGÜNÜN TARİHİNDEN SORUNUN ÇÖZÜLDÜĞÜNÜ GÜNÜ ÇIKARIYO
                    int yeniDogruSoruID = Convert.ToInt32(dr[0]);
                    DateTime yeniDogruSoruTarih = Convert.ToDateTime(dr[1]);
                    int yeniDogruSoruSayac = Convert.ToInt32(dr[2]);
                    TimeSpan günFarki = (Bugun-yeniDogruSoruTarih);
                    int günFarkiSayi = Convert.ToInt32(günFarki.Days);

                    // 6 SİGMAYA UYGUN OLUP OLMADIĞINI Sorguluyor
                    if ((günFarkiSayi==Sigma[0] &&yeniDogruSoruSayac==1) ||(günFarkiSayi==Sigma[1] &&yeniDogruSoruSayac==2) ||(günFarkiSayi==Sigma[2] &&yeniDogruSoruSayac==3) ||
                       (günFarkiSayi==Sigma[3] &&yeniDogruSoruSayac==4) || (günFarkiSayi==Sigma[4] &&yeniDogruSoruSayac==5) ||(günFarkiSayi==Sigma[5] &&yeniDogruSoruSayac==6))
                    {
                        soruSayac++;
                        Array.Resize(ref SoruIDDizi, soruSayac);
                        SoruIDDizi[soruSayac-1] = Convert.ToInt32(dr[0]);
                    }


                }
                dr.Close();
                bgl.baglanti().Close();
                int whilei = 0;
                while (whilei <10)
                {
                    bool durum = false;// daha önceden o ID'de soru olup olmadığına baktığımız değişken

                    Random rnd = new Random();
                    int soruID = rnd.Next(1, toplamSoruSayac);

                    //soru Id karsilastirip birbirinden farklı Id'de olusturma
                    for (int i = 0; i < soruSayac; i++)
                    {
                        if (SoruIDDizi[i] == soruID)
                        {
                            durum = true;
                        }
                    }
                    for (int i = 0; i < OnaylanmayanSorularSayac; i++)
                    {
                        if (OnaylanmayanSorular[i]==soruID)
                        {
                            durum = true;
                        }
                    }

                    //eğer daha önce o ID'de soru olusturulmamışsa
                    if (!durum)
                    {
                        //  daha önce o ID'de soru gorulmüş mü diye kontrol etme
                        for (int i = 0; i <GorulenSorularSayac; i++)
                        {
                            if (GorulenSorular[i] == soruID)
                            {
                                durum = true;
                            }
                        }
                        //sorunun ıd'sini soruların IDsini tuttuğumuz diziye atma  
                        soruSayac++;
                        Array.Resize(ref SoruIDDizi, soruSayac);
                        SoruIDDizi[soruSayac-1] = soruID;
                        whilei++;
                    }


                }
                // Collections kütüphanesinin Array.Resize komutu ile dizinin boyutunu arttırıyoruz
                Array.Resize(ref SoruCevapDizi, soruSayac);
                Array.Resize(ref DogruSoruCevapDizi, soruSayac);
            }
            // eksik oldugu konulara göre soruID
            else if (Sinavturu=="OzelSinav")
            {
                bgl.baglanti();
                SqlCommand kmt = new SqlCommand("Select SoruID from YanlisSoruHavuzu", bgl.baglanti());
                SqlDataReader dr = kmt.ExecuteReader();
                int whilei = 1;
                while (dr.Read() && whilei<=10)
                {
                    soruSayac++;
                    Array.Resize(ref SoruIDDizi, soruSayac);
                    SoruIDDizi[soruSayac-1] = (int)dr[0];
                    whilei++;
                }
            }
            // Collections kütüphanesinin Array.Resize komutu ile dizinin boyutunu soru sayısı kadar arttırıyoruz
            Array.Resize(ref SoruCevapDizi, soruSayac);
            Array.Resize(ref DogruSoruCevapDizi, soruSayac);
        }


        public void CevapRenkDüzeltme()
        {
            LblA.ForeColor=Color.Black;
            LblB.ForeColor=Color.Black;
            LblC.ForeColor=Color.Black;
            LblD.ForeColor=Color.Black;

        }
        public void CevapRenkDegistirme()
        {

            //cevap verilmiş ise
            if (SoruCevapDizi[KacinciSoru-1]!=null)
            {

                if (DogruSoruCevapDizi[KacinciSoru-1]==LblA.Text)
                    LblA.ForeColor=Color.Green;
                else if (DogruSoruCevapDizi[KacinciSoru-1]==LblB.Text)
                    LblB.ForeColor=Color.Green;
                else if (DogruSoruCevapDizi[KacinciSoru-1]==LblC.Text)
                    LblC.ForeColor=Color.Green;
                else if (DogruSoruCevapDizi[KacinciSoru-1]==LblD.Text)
                    LblD.ForeColor=Color.Green;

                if (DogruSoruCevapDizi[KacinciSoru-1]!=SoruCevapDizi[KacinciSoru-1])
                {

                    if (SoruCevapDizi[KacinciSoru-1]==LblA.Text)
                        LblA.ForeColor=Color.Red;
                    else if (SoruCevapDizi[KacinciSoru-1]==LblB.Text)
                        LblB.ForeColor=Color.Red;
                    else if (SoruCevapDizi[KacinciSoru-1]==LblC.Text)
                        LblC.ForeColor=Color.Red;
                    else if (SoruCevapDizi[KacinciSoru-1]==LblD.Text)
                        LblD.ForeColor=Color.Red;
                }
            }

        }

        public void SinavSonuc()
        {
            for (int i = 0; i<soruSayac; i++)
            {
                if (SoruCevapDizi[i]==null)
                {
                    BosBirakilanSoruSayisi++;
                }
            }
            IsaretlenenYanlisSoruSayisi=soruSayac-(IsaretlenenDogruSoruSayisi+BosBirakilanSoruSayisi);

            lblBos.Text ="Bos "+BosBirakilanSoruSayisi.ToString();
            lblDogru.Text ="Dogru "+IsaretlenenDogruSoruSayisi.ToString();
            lblYanlis.Text ="Yanlis "+IsaretlenenYanlisSoruSayisi.ToString();
            pnlSayac.Visible = true;
            SinavDurum=false;
            button1.Enabled = false;
        }
        //********************************************************
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            Baslangic();

            //Form açıldığında ilk soruyu getirme
            BtnSonraki.PerformClick();
            

            BtnOnceki.Enabled = false;
            //      SoruCekme(SoruIDDizi[0],1);
            //BtnSonraki.PerformClick();
        }


        private void BtnA_Click(object sender, EventArgs e)
        {
            SoruCevapDizi[KacinciSoru - 1]=LblA.Text;
            CevapButonKapatma();
            CevapKontrolPictureBox();
            CevapRenkDegistirme();
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            SoruCevapDizi[KacinciSoru - 1] = LblB.Text;
            CevapButonKapatma();
            CevapKontrolPictureBox();
            CevapRenkDegistirme();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            SoruCevapDizi[KacinciSoru - 1] = LblC.Text;
            CevapButonKapatma();
            CevapKontrolPictureBox();
            CevapRenkDegistirme();
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            SoruCevapDizi[KacinciSoru - 1] = LblD.Text;
            CevapButonKapatma();
            CevapKontrolPictureBox();
            CevapRenkDegistirme();
        }


        private void BtnOnceki_Click(object sender, EventArgs e)
        {
            PictureBoxGizleme();
            CevapRenkDüzeltme();
            if (KacinciSoru==soruSayac)
            {
                BtnSonraki.Enabled = true;
            }
            KacinciSoru--;
            SoruCekme(SoruIDDizi[KacinciSoru-1], KacinciSoru-1);

            //sınav devam ediyorsa
            if (SinavDurum==true)
            {
                CevapButonIslemleri();
              
            }
            else
            {
                CevapRenkDegistirme();
                CevapKontrolPictureBox();
            }

            if (KacinciSoru == 1)
                BtnOnceki.Enabled = false;

        }
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            PictureBoxGizleme();
            CevapRenkDüzeltme();
            BtnOnceki.Enabled = true;
            KacinciSoru++;
            SoruCekme(SoruIDDizi[KacinciSoru-1], KacinciSoru-1);

            //sınav devam ediyorsa
            if (SinavDurum==true)
            {
                CevapButonIslemleri();
               
            }
            else
            {
                CevapRenkDegistirme();
            }

            if (KacinciSoru == soruSayac)
                BtnSonraki.Enabled = false;


        }
        public void YanlisSoruDurumGuncelleme()
        {
            for (int i = 1; i <= soruSayac; i++)
            {
                //boş değilse  
                if (SoruCevapDizi[i-1]!=null)
                {
                    //asla olmicak bir sayiya eşlenir
                    int EslenenSoruID = OncedenYanlisCozulenSorularSayac+1;
                    bool YanlisSoruDurum = false;
                    for (int k = 1; k <= OncedenYanlisCozulenSorularSayac; k++)
                    {
                        //soru var mı diye kontrol ediliyor
                        if (OncedenYanlisCozulenSorular[k-1]==SoruIDDizi[i-1])
                        {
                            YanlisSoruDurum=true;
                            EslenenSoruID=k;
                        }
                    }
                    //eğer soru yanlış ise
                    if (SoruCevapDizi[i-1]!=DogruSoruCevapDizi[i-1])
                    {
                        //soru var ise sayac arttırılıyor
                        if (YanlisSoruDurum==true)
                        {
                            bgl.baglanti();
                            SqlCommand kmtUpdate = new SqlCommand("update YanlisSoruHavuzu set Sayac=Sayac+1 where KullaniciID=@p1 and SoruID=@p2", bgl.baglanti());
                            kmtUpdate.Parameters.AddWithValue("@p1", kullaniciID);
                            kmtUpdate.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                            kmtUpdate.ExecuteNonQuery();

                            bgl.baglanti().Close();
                        }
                        //soru yok ise soru ekleniyor
                        else if (YanlisSoruDurum==false)
                        {
                            bgl.baglanti();
                            SqlCommand kmtEkle = new SqlCommand("insert into   YanlisSoruHavuzu  (KullaniciID,SoruID,Sayac) values (@p1,@p2,@p3)", bgl.baglanti());
                            kmtEkle.Parameters.AddWithValue("@p1", kullaniciID);
                            kmtEkle.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                            kmtEkle.Parameters.AddWithValue("@p3", 1);
                            kmtEkle.ExecuteNonQuery();

                            bgl.baglanti().Close();
                        }
                    }
                    //eğer soru dogru ise
                    else if (SoruCevapDizi[i-1]==DogruSoruCevapDizi[i-1])
                    {

                        //soru var ise siliniyor
                        if (EslenenSoruID!=OncedenYanlisCozulenSorularSayac+1)
                        {
                            
                            bgl.baglanti();
                            SqlCommand kmtDelete = new SqlCommand("delete From YanlisSoruHavuzu where KullaniciID=@p1 and SoruID=@p2", bgl.baglanti());
                            kmtDelete.Parameters.AddWithValue("@p1", kullaniciID);
                            kmtDelete.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                            kmtDelete.ExecuteNonQuery();

                            bgl.baglanti().Close();
                        }

                    }
                }
            }
        }
        int[] SoruIstatistikID = new int[0];
        int SoruIstatistikIDSayac;
        public void SoruIstatistik()
        {
            bgl.baglanti();
            SqlCommand kmt = new SqlCommand("Select SoruID From IstatistikSoru where KullaniciID=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", kullaniciID);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                SoruIstatistikIDSayac++;
                Array.Resize(ref SoruIstatistikID, SoruIstatistikIDSayac);
                SoruIstatistikID[SoruIstatistikIDSayac-1]=(int)dr[0];
            }
            dr.Close();
            bgl.baglanti().Close();

            for (int i = 1; i<=soruSayac; i++)
            {
                bool durum = false;
                //soru veritabanında var mı diye bakılıyor
                for (int j = 1; j<=SoruIstatistikIDSayac; j++)
                {
                    if (SoruIstatistikID[j-1]==SoruIDDizi[i-1])
                    {
                        durum=true;
                    }
                }

                //eğer soru boş ise
                if (SoruCevapDizi[i-1]==null)
                {
                    if (durum==true)
                    {
                        bgl.baglanti();
                        SqlCommand kmtD = new SqlCommand("update IstatistikSoru set BosSayac=BosSayac+1 where KullaniciID=@p1 and SoruID=@p2", bgl.baglanti());
                        kmtD.Parameters.AddWithValue("@p1", kullaniciID);
                        kmtD.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                        kmtD.ExecuteNonQuery();
                        bgl.baglanti().Close();
                    }
                    else
                    {
                        bgl.baglanti();
                        SqlCommand kmtD = new SqlCommand("insert into   IstatistikSoru  (KullaniciID,SoruID,BosSayac,DogruSayac,YanlisSayac) values (@p1,@p2,1,0,0) ", bgl.baglanti());
                        kmtD.Parameters.AddWithValue("@p1", kullaniciID);
                        kmtD.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                        kmtD.ExecuteNonQuery();
                        bgl.baglanti().Close();
                    }
                }
                //eğer soru dogru ise
                else if (SoruCevapDizi[i-1]==DogruSoruCevapDizi[i-1])
                {
                    if (durum==true)
                    {
                        bgl.baglanti();
                        SqlCommand kmtD = new SqlCommand("update IstatistikSoru set DogruSayac=DogruSayac+1 where KullaniciID=@p1 and SoruID=@p2", bgl.baglanti());
                        kmtD.Parameters.AddWithValue("@p1", kullaniciID);
                        kmtD.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                        kmtD.ExecuteNonQuery();
                        bgl.baglanti().Close();
                    }
                    else
                    {
                        bgl.baglanti();
                        SqlCommand kmtD = new SqlCommand("insert into   IstatistikSoru  (KullaniciID,SoruID,DogruSayac,BosSayac,YanlisSayac) values (@p1,@p2,1,0,0) ", bgl.baglanti());
                        kmtD.Parameters.AddWithValue("@p1", kullaniciID);
                        kmtD.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                        kmtD.ExecuteNonQuery();
                        bgl.baglanti().Close();
                    }
                }
                //eğer soru yanlis ise
                else
                {
                    if (durum==true)
                    {
                        bgl.baglanti();
                        SqlCommand kmtD = new SqlCommand("update IstatistikSoru set YanlisSayac=YanlisSayac+1 where KullaniciID=@p1 and SoruID=@p2", bgl.baglanti());
                        kmtD.Parameters.AddWithValue("@p1", kullaniciID);
                        kmtD.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                        kmtD.ExecuteNonQuery();
                        bgl.baglanti().Close();
                    }
                    else
                    {
                        bgl.baglanti();
                        SqlCommand kmtD = new SqlCommand("insert into   IstatistikSoru  (KullaniciID,SoruID,YanlisSayac,BosSayac,DogruSayac) values (@p1,@p2,1,0,0) ", bgl.baglanti());
                        kmtD.Parameters.AddWithValue("@p1", kullaniciID);
                        kmtD.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                        kmtD.ExecuteNonQuery();
                        bgl.baglanti().Close();
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //sinavi bitir butonu

            // DOGRU SORU HAVUZU DISINDAKİ 10 SORU

            for (int i = soruSayac; i>soruSayac-10; i--)
            {
                //cevap boş bırakılmamışsa
                if (SoruCevapDizi[i-1]!=null)
                {
                    //cevabi doğru olan soruları dogru soru havuzuna ID'lerini atma
                    if (DogruSoruCevapDizi[i-1] == SoruCevapDizi[i-1])
                    {
                        IsaretlenenDogruSoruSayisi++;
                        bgl.baglanti();
                        SqlCommand kmt = new SqlCommand("insert into DogruSoruHavuzu (KullaniciID,SoruID,Tarih,Sayac) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                        kmt.Parameters.AddWithValue("@p1", kullaniciID);
                        kmt.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                        kmt.Parameters.AddWithValue("@p3", DateTime.Now.ToString("dd-MM-yyyy"));
                        kmt.Parameters.AddWithValue("@p4", 1);
                        kmt.ExecuteNonQuery();

                        bgl.baglanti().Close();



                    }

                }


            }

            //DOGRU SORU HAVUZUNDAN GELEN SORULAR

            for (int i = soruSayac-10; i>0; i--)
            {

                if (SoruCevapDizi[i-1]!=null)
                {
                    //soru dogru ise sayacını 1 ekleme
                    if (DogruSoruCevapDizi[i-1]==SoruCevapDizi[i-1])
                    {
                        IsaretlenenDogruSoruSayisi++;
                        bgl.baglanti();
                        SqlCommand kmt = new SqlCommand("update DogruSoruHavuzu set Sayac=Sayac+1 where KullaniciID=@p1 and SoruID=@p2", bgl.baglanti());
                        kmt.Parameters.AddWithValue("@p1", kullaniciID);
                        kmt.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                        kmt.ExecuteNonQuery();
                        bgl.baglanti().Close();
                    }
                    //soru yanlış ise  
                    else
                    {
                        //soruyu dogru soru havuzundan silme
                        bgl.baglanti();
                        SqlCommand kmt = new SqlCommand("delete from DogruSoruHavuzu  where KullaniciID=@p1 and SoruID=@p2", bgl.baglanti());
                        kmt.Parameters.AddWithValue("@p1", kullaniciID);
                        kmt.Parameters.AddWithValue("@p2", SoruIDDizi[i-1]);
                        kmt.ExecuteNonQuery();
                        bgl.baglanti().Close();


                    }
                }


            }
            //todo
            YanlisSoruDurumGuncelleme();
            SoruIstatistik();
            timer1.Stop();
                dakika=0;
                saniye=0;
            lblKalanSure.Text="Sinav Bitmistir.!!!!!";
            MessageBox.Show("Sinav bitmistir.Dogru ve Yanlıs sorularinizi gorebilirsiniz.");

            SinavSonuc();
            btnAna.Visible=true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            timer1.Interval=1000;//1sn
            if(saniye==0)
            {
                saniye=60;
                dakika--;
            }
            saniye=saniye-1;
            lblKalanSure.Text=dakika.ToString()+" Dakika " +saniye.ToString()+" Saniye";
            if (dakika==-1)
            {
                timer1.Stop();
                lblKalanSure.Text="Sinav suresi bitmistir.!!!";
                //sinavi bitirme butonu
                button1.PerformClick();
            }
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            FrmOgrenci frmOgrenci = new FrmOgrenci();
            frmOgrenci.KullaniciAD=kullaniciAD;
            frmOgrenci.KullaniciID=kullaniciID;
            frmOgrenci.Show();
            this.Hide();
        }
    }
}
