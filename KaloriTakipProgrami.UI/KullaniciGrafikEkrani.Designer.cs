namespace KaloriTakipProgrami.UI
{
    partial class KullaniciGrafikEkrani
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGrafikEkrani));
            label1 = new Label();
            label2 = new Label();
            cKiloG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cBoyG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnGeri = new Button();
            btnKiloPdf = new Button();
            btnBoyPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)cKiloG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cBoyG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(185, 75);
            label1.Name = "label1";
            label1.Size = new Size(205, 48);
            label1.TabIndex = 0;
            label1.Text = "Kilo Grafiği";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(778, 75);
            label2.Name = "label2";
            label2.Size = new Size(178, 46);
            label2.TabIndex = 1;
            label2.Text = "Boy Grafiği";
            // 
            // cKiloG
            // 
            chartArea3.Name = "ChartArea1";
            cKiloG.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            cKiloG.Legends.Add(legend3);
            cKiloG.Location = new Point(12, 132);
            cKiloG.Name = "cKiloG";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            cKiloG.Series.Add(series3);
            cKiloG.Size = new Size(526, 349);
            cKiloG.TabIndex = 3;
            cKiloG.Text = "chart1";
            // 
            // cBoyG
            // 
            chartArea4.Name = "ChartArea1";
            cBoyG.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            cBoyG.Legends.Add(legend4);
            cBoyG.Location = new Point(570, 132);
            cBoyG.Name = "cBoyG";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            cBoyG.Series.Add(series4);
            cBoyG.Size = new Size(540, 349);
            cBoyG.TabIndex = 4;
            cBoyG.Text = "chart2";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(2, 2);
            btnGeri.Margin = new Padding(3, 2, 3, 2);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(50, 31);
            btnGeri.TabIndex = 1;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnKiloPdf
            // 
            btnKiloPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKiloPdf.Location = new Point(185, 504);
            btnKiloPdf.Name = "btnKiloPdf";
            btnKiloPdf.Size = new Size(101, 34);
            btnKiloPdf.TabIndex = 5;
            btnKiloPdf.Text = "Graafiği İndir";
            btnKiloPdf.UseVisualStyleBackColor = true;
            btnKiloPdf.Click += btnKiloPdf_Click;
            // 
            // btnBoyPdf
            // 
            btnBoyPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBoyPdf.Location = new Point(778, 504);
            btnBoyPdf.Name = "btnBoyPdf";
            btnBoyPdf.Size = new Size(101, 34);
            btnBoyPdf.TabIndex = 6;
            btnBoyPdf.Text = "Graafiği İndir";
            btnBoyPdf.UseVisualStyleBackColor = true;
            btnBoyPdf.Click += btnBoyPdf_Click;
            // 
            // KullaniciGrafikEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1122, 565);
            Controls.Add(btnBoyPdf);
            Controls.Add(btnKiloPdf);
            Controls.Add(btnGeri);
            Controls.Add(cBoyG);
            Controls.Add(cKiloG);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "KullaniciGrafikEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciGrafikEkrani";
            Load += KullaniciGrafikEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)cKiloG).EndInit();
            ((System.ComponentModel.ISupportInitialize)cBoyG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cKiloG;
        private System.Windows.Forms.DataVisualization.Charting.Chart cBoyG;
        private Button btnGeri;
        private Button btnKiloPdf;
        private Button btnBoyPdf;
    }
}