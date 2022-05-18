
namespace SinavSistemi
{
    partial class FrmOgrenciSinav
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.BtnOnceki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamSure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.CevapTrue = new System.Windows.Forms.PictureBox();
            this.LblA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblB = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.CevapFalse = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.lblBos = new System.Windows.Forms.Label();
            this.pnlSure = new System.Windows.Forms.Panel();
            this.btnAna = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlSayac = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CevapTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevapFalse)).BeginInit();
            this.pnlSure.SuspendLayout();
            this.pnlSayac.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(398, 181);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(12, 262);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(181, 47);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(12, 315);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(181, 47);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(12, 363);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(181, 47);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(12, 416);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(181, 47);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(143, 473);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(116, 33);
            this.BtnSonraki.TabIndex = 5;
            this.BtnSonraki.Text = "Sonraki";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // BtnOnceki
            // 
            this.BtnOnceki.Location = new System.Drawing.Point(12, 473);
            this.BtnOnceki.Name = "BtnOnceki";
            this.BtnOnceki.Size = new System.Drawing.Size(116, 33);
            this.BtnOnceki.TabIndex = 6;
            this.BtnOnceki.Text = "Önceki";
            this.BtnOnceki.UseVisualStyleBackColor = true;
            this.BtnOnceki.Click += new System.EventHandler(this.BtnOnceki_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Süre :";
            // 
            // lblToplamSure
            // 
            this.lblToplamSure.AutoSize = true;
            this.lblToplamSure.Location = new System.Drawing.Point(66, 23);
            this.lblToplamSure.Name = "lblToplamSure";
            this.lblToplamSure.Size = new System.Drawing.Size(110, 20);
            this.lblToplamSure.TabIndex = 9;
            this.lblToplamSure.Text = "lblToplamSure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kalan Sure";
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.Location = new System.Drawing.Point(66, 93);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(98, 20);
            this.lblKalanSure.TabIndex = 10;
            this.lblKalanSure.Text = "lblKalanSure";
            // 
            // CevapTrue
            // 
            this.CevapTrue.Image = global::SinavSistemi.Properties.Resources.green_light;
            this.CevapTrue.Location = new System.Drawing.Point(771, 473);
            this.CevapTrue.Name = "CevapTrue";
            this.CevapTrue.Size = new System.Drawing.Size(169, 141);
            this.CevapTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CevapTrue.TabIndex = 12;
            this.CevapTrue.TabStop = false;
            this.CevapTrue.Visible = false;
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(223, 275);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(35, 20);
            this.LblA.TabIndex = 13;
            this.LblA.Text = "lblA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(428, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(223, 328);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(35, 20);
            this.LblB.TabIndex = 15;
            this.LblB.Text = "lblB";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(223, 376);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(35, 20);
            this.LblC.TabIndex = 15;
            this.LblC.Text = "lblC";
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(223, 422);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(36, 20);
            this.LblD.TabIndex = 15;
            this.LblD.Text = "lblD";
            // 
            // CevapFalse
            // 
            this.CevapFalse.Image = global::SinavSistemi.Properties.Resources.redgif;
            this.CevapFalse.Location = new System.Drawing.Point(771, 473);
            this.CevapFalse.Name = "CevapFalse";
            this.CevapFalse.Size = new System.Drawing.Size(169, 141);
            this.CevapFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CevapFalse.TabIndex = 16;
            this.CevapFalse.TabStop = false;
            this.CevapFalse.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(286, 12);
            this.progressBar1.Maximum = 45;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(673, 40);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sınavı Bitir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(808, 69);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(93, 20);
            this.lblKullanici.TabIndex = 22;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.BackColor = System.Drawing.Color.Transparent;
            this.lblDogru.ForeColor = System.Drawing.Color.Lime;
            this.lblDogru.Location = new System.Drawing.Point(3, 48);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(50, 20);
            this.lblDogru.TabIndex = 23;
            this.lblDogru.Text = "dogru";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.ForeColor = System.Drawing.Color.Red;
            this.lblYanlis.Location = new System.Drawing.Point(173, 48);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(48, 20);
            this.lblYanlis.TabIndex = 24;
            this.lblYanlis.Text = "yanlis";
            // 
            // lblBos
            // 
            this.lblBos.AutoSize = true;
            this.lblBos.ForeColor = System.Drawing.Color.DimGray;
            this.lblBos.Location = new System.Drawing.Point(313, 48);
            this.lblBos.Name = "lblBos";
            this.lblBos.Size = new System.Drawing.Size(35, 20);
            this.lblBos.TabIndex = 25;
            this.lblBos.Text = "bos";
            // 
            // pnlSure
            // 
            this.pnlSure.Controls.Add(this.label1);
            this.pnlSure.Controls.Add(this.lblToplamSure);
            this.pnlSure.Controls.Add(this.lblKalanSure);
            this.pnlSure.Controls.Add(this.label3);
            this.pnlSure.Location = new System.Drawing.Point(674, 111);
            this.pnlSure.Name = "pnlSure";
            this.pnlSure.Size = new System.Drawing.Size(285, 127);
            this.pnlSure.TabIndex = 27;
            this.pnlSure.Visible = false;
            // 
            // btnAna
            // 
            this.btnAna.Location = new System.Drawing.Point(493, 466);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(168, 46);
            this.btnAna.TabIndex = 28;
            this.btnAna.Text = "Ana Menuye Don";
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Visible = false;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(313, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "bos";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(173, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "yanlis";
            this.label4.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(3, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "dogru";
            this.label7.Visible = false;
            // 
            // pnlSayac
            // 
            this.pnlSayac.Controls.Add(this.label7);
            this.pnlSayac.Controls.Add(this.label2);
            this.pnlSayac.Controls.Add(this.lblDogru);
            this.pnlSayac.Controls.Add(this.label4);
            this.pnlSayac.Controls.Add(this.lblYanlis);
            this.pnlSayac.Controls.Add(this.lblBos);
            this.pnlSayac.Location = new System.Drawing.Point(33, 521);
            this.pnlSayac.Name = "pnlSayac";
            this.pnlSayac.Size = new System.Drawing.Size(377, 85);
            this.pnlSayac.TabIndex = 32;
            this.pnlSayac.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(674, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Kullanıcı Adı";
            // 
            // FrmOgrenciSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(965, 614);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlSayac);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.pnlSure);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CevapFalse);
            this.Controls.Add(this.LblD);
            this.Controls.Add(this.LblC);
            this.Controls.Add(this.LblB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.CevapTrue);
            this.Controls.Add(this.BtnOnceki);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOgrenciSinav";
            this.Text = "Sınav Ekranı";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CevapTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevapFalse)).EndInit();
            this.pnlSure.ResumeLayout(false);
            this.pnlSure.PerformLayout();
            this.pnlSayac.ResumeLayout(false);
            this.pnlSayac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.Button BtnOnceki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.PictureBox CevapTrue;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.PictureBox CevapFalse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label lblBos;
        private System.Windows.Forms.Panel pnlSure;
        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlSayac;
        private System.Windows.Forms.Label label8;
    }
}