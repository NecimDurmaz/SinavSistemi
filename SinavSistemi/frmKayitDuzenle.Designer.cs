namespace SinavSistemi
{
    partial class frmKayitDuzenle
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
            this.BtnKayıtOl = new System.Windows.Forms.Button();
            this.CmbGuvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.TxtGuvenlikCevap = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtKullaniciSoyisim = new System.Windows.Forms.TextBox();
            this.TxtKullaniciIsim = new System.Windows.Forms.TextBox();
            this.CmbKullaniciTip = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnKayıtOl
            // 
            this.BtnKayıtOl.Location = new System.Drawing.Point(297, 394);
            this.BtnKayıtOl.Name = "BtnKayıtOl";
            this.BtnKayıtOl.Size = new System.Drawing.Size(150, 34);
            this.BtnKayıtOl.TabIndex = 33;
            this.BtnKayıtOl.Text = "Kayıt Ol";
            this.BtnKayıtOl.UseVisualStyleBackColor = true;
            this.BtnKayıtOl.Click += new System.EventHandler(this.BtnKayıtOl_Click);
            // 
            // CmbGuvenlikSorusu
            // 
            this.CmbGuvenlikSorusu.FormattingEnabled = true;
            this.CmbGuvenlikSorusu.Location = new System.Drawing.Point(180, 303);
            this.CmbGuvenlikSorusu.Name = "CmbGuvenlikSorusu";
            this.CmbGuvenlikSorusu.Size = new System.Drawing.Size(276, 21);
            this.CmbGuvenlikSorusu.TabIndex = 32;
            // 
            // TxtGuvenlikCevap
            // 
            this.TxtGuvenlikCevap.Location = new System.Drawing.Point(180, 346);
            this.TxtGuvenlikCevap.Name = "TxtGuvenlikCevap";
            this.TxtGuvenlikCevap.Size = new System.Drawing.Size(276, 20);
            this.TxtGuvenlikCevap.TabIndex = 31;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(180, 262);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(276, 20);
            this.TxtSifre.TabIndex = 30;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(180, 225);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(276, 20);
            this.TxtMail.TabIndex = 29;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(180, 168);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(276, 20);
            this.TxtKullaniciAdi.TabIndex = 28;
            // 
            // TxtKullaniciSoyisim
            // 
            this.TxtKullaniciSoyisim.Location = new System.Drawing.Point(180, 119);
            this.TxtKullaniciSoyisim.Name = "TxtKullaniciSoyisim";
            this.TxtKullaniciSoyisim.Size = new System.Drawing.Size(276, 20);
            this.TxtKullaniciSoyisim.TabIndex = 27;
            // 
            // TxtKullaniciIsim
            // 
            this.TxtKullaniciIsim.Location = new System.Drawing.Point(180, 74);
            this.TxtKullaniciIsim.Name = "TxtKullaniciIsim";
            this.TxtKullaniciIsim.Size = new System.Drawing.Size(276, 20);
            this.TxtKullaniciIsim.TabIndex = 26;
            // 
            // CmbKullaniciTip
            // 
            this.CmbKullaniciTip.FormattingEnabled = true;
            this.CmbKullaniciTip.Location = new System.Drawing.Point(180, 22);
            this.CmbKullaniciTip.Name = "CmbKullaniciTip";
            this.CmbKullaniciTip.Size = new System.Drawing.Size(276, 21);
            this.CmbKullaniciTip.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Güvenlik Cevap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Güvenlik Sorusu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kullanici Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kullanıcı Soyisim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanici İsim";
            // 
            // frmKayitDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.BtnKayıtOl);
            this.Controls.Add(this.CmbGuvenlikSorusu);
            this.Controls.Add(this.TxtGuvenlikCevap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.TxtKullaniciSoyisim);
            this.Controls.Add(this.TxtKullaniciIsim);
            this.Controls.Add(this.CmbKullaniciTip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKayitDuzenle";
            this.Text = "frmKayitDuzenle";
            this.Load += new System.EventHandler(this.frmKayitDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKayıtOl;
        private System.Windows.Forms.ComboBox CmbGuvenlikSorusu;
        private System.Windows.Forms.TextBox TxtGuvenlikCevap;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtKullaniciSoyisim;
        private System.Windows.Forms.TextBox TxtKullaniciIsim;
        private System.Windows.Forms.ComboBox CmbKullaniciTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}