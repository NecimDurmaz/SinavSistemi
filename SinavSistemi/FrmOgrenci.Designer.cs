namespace SinavSistemi
{
    partial class FrmOgrenci
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
            this.btnSinavBaslat = new System.Windows.Forms.Button();
            this.btnSigmaAyar = new System.Windows.Forms.Button();
            this.btnEksik = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSinavBaslat
            // 
            this.btnSinavBaslat.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavBaslat.Location = new System.Drawing.Point(223, 33);
            this.btnSinavBaslat.Name = "btnSinavBaslat";
            this.btnSinavBaslat.Size = new System.Drawing.Size(151, 74);
            this.btnSinavBaslat.TabIndex = 0;
            this.btnSinavBaslat.Text = "Sınavı Başlat";
            this.btnSinavBaslat.UseVisualStyleBackColor = true;
            this.btnSinavBaslat.Click += new System.EventHandler(this.btnSinavBaslat_Click);
            // 
            // btnSigmaAyar
            // 
            this.btnSigmaAyar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSigmaAyar.Location = new System.Drawing.Point(394, 33);
            this.btnSigmaAyar.Name = "btnSigmaAyar";
            this.btnSigmaAyar.Size = new System.Drawing.Size(151, 74);
            this.btnSigmaAyar.TabIndex = 1;
            this.btnSigmaAyar.Text = "Sigma Sıklık Süresi Ayarlama";
            this.btnSigmaAyar.UseVisualStyleBackColor = true;
            this.btnSigmaAyar.Click += new System.EventHandler(this.btnSigmaAyar_Click);
            // 
            // btnEksik
            // 
            this.btnEksik.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEksik.Location = new System.Drawing.Point(223, 153);
            this.btnEksik.Name = "btnEksik";
            this.btnEksik.Size = new System.Drawing.Size(151, 74);
            this.btnEksik.TabIndex = 3;
            this.btnEksik.Text = "Eksik Konular hakkında sinav";
            this.btnEksik.UseVisualStyleBackColor = true;
            this.btnEksik.Click += new System.EventHandler(this.btnEksik_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistik.Location = new System.Drawing.Point(394, 153);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(151, 74);
            this.btnIstatistik.TabIndex = 4;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "    OGRENCI\r\n-----------------------\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "KullaniciAdi";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Corbel Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.Location = new System.Drawing.Point(8, 120);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(47, 23);
            this.lblIsim.TabIndex = 7;
            this.lblIsim.Text = "lblAd";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Corbel Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(8, 204);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(59, 23);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "lblMail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail";
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(578, 274);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnEksik);
            this.Controls.Add(this.btnSigmaAyar);
            this.Controls.Add(this.btnSinavBaslat);
            this.Name = "FrmOgrenci";
            this.Text = "Ogrenci Ekranı";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinavBaslat;
        private System.Windows.Forms.Button btnSigmaAyar;
        private System.Windows.Forms.Button btnEksik;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label label4;
    }
}