
namespace SinavSistemi
{
    partial class FrmAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTumSorular = new System.Windows.Forms.Button();
            this.btnOnaySoru = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblSoyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1160, 539);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnTumSorular
            // 
            this.btnTumSorular.Location = new System.Drawing.Point(-6, 224);
            this.btnTumSorular.Name = "btnTumSorular";
            this.btnTumSorular.Size = new System.Drawing.Size(250, 50);
            this.btnTumSorular.TabIndex = 1;
            this.btnTumSorular.Text = "Tüm Sorular";
            this.btnTumSorular.UseVisualStyleBackColor = true;
            this.btnTumSorular.Click += new System.EventHandler(this.btnTumSorular_Click);
            // 
            // btnOnaySoru
            // 
            this.btnOnaySoru.Location = new System.Drawing.Point(-6, 267);
            this.btnOnaySoru.Name = "btnOnaySoru";
            this.btnOnaySoru.Size = new System.Drawing.Size(250, 50);
            this.btnOnaySoru.TabIndex = 2;
            this.btnOnaySoru.Text = "Onaylanmayı Bekleyen Sorular";
            this.btnOnaySoru.UseVisualStyleBackColor = true;
            this.btnOnaySoru.Click += new System.EventHandler(this.btnOnaySoru_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(-6, 314);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(250, 50);
            this.btnKayit.TabIndex = 3;
            this.btnKayit.Text = "Kayıtları Görüntüle ve Düzenle";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(-6, 361);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(250, 50);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin\r\n--------------\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soyad";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(84, 106);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(35, 13);
            this.LblAd.TabIndex = 10;
            this.LblAd.Text = "label4";
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(84, 136);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(35, 13);
            this.LblSoyad.TabIndex = 11;
            this.LblSoyad.Text = "label5";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 538);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnOnaySoru);
            this.Controls.Add(this.btnTumSorular);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTumSorular;
        private System.Windows.Forms.Button btnOnaySoru;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblSoyad;
    }
}