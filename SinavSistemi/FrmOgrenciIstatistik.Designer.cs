namespace SinavSistemi
{
    partial class FrmOgrenciIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartKonu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKonu = new System.Windows.Forms.ComboBox();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.chartYuzde = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnCikti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartKonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYuzde)).BeginInit();
            this.SuspendLayout();
            // 
            // chartKonu
            // 
            this.chartKonu.BackColor = System.Drawing.Color.Transparent;
            this.chartKonu.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartKonu.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartKonu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartKonu.Legends.Add(legend1);
            this.chartKonu.Location = new System.Drawing.Point(176, 35);
            this.chartKonu.Name = "chartKonu";
            this.chartKonu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Chartreuse;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Dogru";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Yanlis";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.DarkGray;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Bos";
            this.chartKonu.Series.Add(series1);
            this.chartKonu.Series.Add(series2);
            this.chartKonu.Series.Add(series3);
            this.chartKonu.Size = new System.Drawing.Size(1060, 372);
            this.chartKonu.TabIndex = 0;
            this.chartKonu.Text = "Chart Konu";
            // 
            // cmbDers
            // 
            this.cmbDers.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(23, 67);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(147, 27);
            this.cmbDers.TabIndex = 1;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dersler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Konular";
            // 
            // cmbKonu
            // 
            this.cmbKonu.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKonu.FormattingEnabled = true;
            this.cmbKonu.Location = new System.Drawing.Point(23, 150);
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.Size = new System.Drawing.Size(147, 27);
            this.cmbKonu.TabIndex = 3;
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistik.Location = new System.Drawing.Point(23, 215);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(121, 31);
            this.btnIstatistik.TabIndex = 5;
            this.btnIstatistik.Text = "Istatistik Getir";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartYuzde
            // 
            chartArea2.Name = "ChartArea1";
            this.chartYuzde.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartYuzde.Legends.Add(legend2);
            this.chartYuzde.Location = new System.Drawing.Point(176, 446);
            this.chartYuzde.Name = "chartYuzde";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Yuzde";
            this.chartYuzde.Series.Add(series4);
            this.chartYuzde.Size = new System.Drawing.Size(638, 300);
            this.chartYuzde.TabIndex = 6;
            this.chartYuzde.Text = "chartYuzde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soru Bazli Istatistik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Konu Bazlı Istatistik";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(820, 522);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(74, 29);
            this.lblToplam.TabIndex = 9;
            this.lblToplam.Text = "label5";
            // 
            // btnCikti
            // 
            this.btnCikti.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikti.Location = new System.Drawing.Point(23, 284);
            this.btnCikti.Name = "btnCikti";
            this.btnCikti.Size = new System.Drawing.Size(121, 38);
            this.btnCikti.TabIndex = 10;
            this.btnCikti.Text = "Çıktı Alma";
            this.btnCikti.UseVisualStyleBackColor = true;
            this.btnCikti.Click += new System.EventHandler(this.btnCikti_Click);
            // 
            // FrmOgrenciIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1248, 752);
            this.Controls.Add(this.btnCikti);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartYuzde);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.chartKonu);
            this.Name = "FrmOgrenciIstatistik";
            this.Text = "Ogrenci Istatistik";
            this.Load += new System.EventHandler(this.FrmOgrenciIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartKonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYuzde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartKonu;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKonu;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYuzde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnCikti;
    }
}