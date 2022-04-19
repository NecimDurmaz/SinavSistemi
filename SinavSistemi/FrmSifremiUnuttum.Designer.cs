
namespace SinavSistemi
{
    partial class FrmSifremiUnuttum
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
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbKullaniciTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGuvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGuncelikSorusuCevap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(136, 75);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(263, 26);
            this.TxtMail.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kullanıcı Tipi :";
            // 
            // CmbKullaniciTipi
            // 
            this.CmbKullaniciTipi.FormattingEnabled = true;
            this.CmbKullaniciTipi.Location = new System.Drawing.Point(136, 26);
            this.CmbKullaniciTipi.Name = "CmbKullaniciTipi";
            this.CmbKullaniciTipi.Size = new System.Drawing.Size(263, 28);
            this.CmbKullaniciTipi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mail :";
            // 
            // cmbGuvenlikSorusu
            // 
            this.cmbGuvenlikSorusu.FormattingEnabled = true;
            this.cmbGuvenlikSorusu.Items.AddRange(new object[] {
            "ANNENİZİN KIZLIK SOYADI",
            "EN SEVDİĞİNİZ MEYVE",
            "İLK HAYVANINIZIN ADI"});
            this.cmbGuvenlikSorusu.Location = new System.Drawing.Point(137, 117);
            this.cmbGuvenlikSorusu.Name = "cmbGuvenlikSorusu";
            this.cmbGuvenlikSorusu.Size = new System.Drawing.Size(263, 28);
            this.cmbGuvenlikSorusu.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Guvenlik Sorusu";
            // 
            // TxtGuncelikSorusuCevap
            // 
            this.TxtGuncelikSorusuCevap.Location = new System.Drawing.Point(136, 163);
            this.TxtGuncelikSorusuCevap.Name = "TxtGuncelikSorusuCevap";
            this.TxtGuncelikSorusuCevap.Size = new System.Drawing.Size(264, 26);
            this.TxtGuncelikSorusuCevap.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtGuncelikSorusuCevap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGuvenlikSorusu);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbKullaniciTipi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSifremiUnuttum";
            this.Text = "FrmSifremiUnuttum";
            this.Load += new System.EventHandler(this.FrmSifremiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbKullaniciTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGuvenlikSorusu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGuncelikSorusuCevap;
        private System.Windows.Forms.Button button1;
    }
}