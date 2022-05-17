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
            this.SuspendLayout();
            // 
            // btnSinavBaslat
            // 
            this.btnSinavBaslat.Location = new System.Drawing.Point(12, 33);
            this.btnSinavBaslat.Name = "btnSinavBaslat";
            this.btnSinavBaslat.Size = new System.Drawing.Size(151, 74);
            this.btnSinavBaslat.TabIndex = 0;
            this.btnSinavBaslat.Text = "Sınavı Başlat";
            this.btnSinavBaslat.UseVisualStyleBackColor = true;
            this.btnSinavBaslat.Click += new System.EventHandler(this.btnSinavBaslat_Click);
            // 
            // btnSigmaAyar
            // 
            this.btnSigmaAyar.Location = new System.Drawing.Point(12, 147);
            this.btnSigmaAyar.Name = "btnSigmaAyar";
            this.btnSigmaAyar.Size = new System.Drawing.Size(151, 74);
            this.btnSigmaAyar.TabIndex = 1;
            this.btnSigmaAyar.Text = "Sigma Sıklık Süresi Ayarlama";
            this.btnSigmaAyar.UseVisualStyleBackColor = true;
            this.btnSigmaAyar.Click += new System.EventHandler(this.btnSigmaAyar_Click);
            // 
            // btnEksik
            // 
            this.btnEksik.Location = new System.Drawing.Point(12, 246);
            this.btnEksik.Name = "btnEksik";
            this.btnEksik.Size = new System.Drawing.Size(151, 74);
            this.btnEksik.TabIndex = 3;
            this.btnEksik.Text = "Eksik Konular hakkında sinav";
            this.btnEksik.UseVisualStyleBackColor = true;
            this.btnEksik.Click += new System.EventHandler(this.btnEksik_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(12, 355);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(151, 74);
            this.btnIstatistik.TabIndex = 4;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 545);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnEksik);
            this.Controls.Add(this.btnSigmaAyar);
            this.Controls.Add(this.btnSinavBaslat);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinavBaslat;
        private System.Windows.Forms.Button btnSigmaAyar;
        private System.Windows.Forms.Button btnEksik;
        private System.Windows.Forms.Button btnIstatistik;
    }
}