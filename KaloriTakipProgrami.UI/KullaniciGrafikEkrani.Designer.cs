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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGrafikEkrani));
            label1 = new Label();
            label2 = new Label();
            cKiloG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cBoyG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnGeri = new Button();
            btnKiloPdf = new Button();
            btnBoyPdf = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)cKiloG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cBoyG).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(187, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 42);
            label1.TabIndex = 0;
            label1.Text = "Kilo Grafiği";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(867, 12);
            label2.Name = "label2";
            label2.Size = new Size(166, 39);
            label2.TabIndex = 1;
            label2.Text = "Boy Grafiği";
            // 
            // cKiloG
            // 
            chartArea1.Name = "ChartArea1";
            cKiloG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            cKiloG.Legends.Add(legend1);
            cKiloG.Location = new Point(14, 176);
            cKiloG.Margin = new Padding(3, 4, 3, 4);
            cKiloG.Name = "cKiloG";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            cKiloG.Series.Add(series1);
            cKiloG.Size = new Size(601, 465);
            cKiloG.TabIndex = 3;
            cKiloG.Text = "chart1";
            // 
            // cBoyG
            // 
            chartArea2.Name = "ChartArea1";
            cBoyG.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            cBoyG.Legends.Add(legend2);
            cBoyG.Location = new Point(651, 176);
            cBoyG.Margin = new Padding(3, 4, 3, 4);
            cBoyG.Name = "cBoyG";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            cBoyG.Series.Add(series2);
            cBoyG.Size = new Size(617, 465);
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
            btnGeri.ForeColor = Color.FromArgb(47, 62, 70);
            btnGeri.Location = new Point(2, 3);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(57, 41);
            btnGeri.TabIndex = 1;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnKiloPdf
            // 
            btnKiloPdf.BackColor = Color.FromArgb(164, 172, 134);
            btnKiloPdf.FlatStyle = FlatStyle.Popup;
            btnKiloPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKiloPdf.Location = new Point(211, 672);
            btnKiloPdf.Margin = new Padding(3, 4, 3, 4);
            btnKiloPdf.Name = "btnKiloPdf";
            btnKiloPdf.Size = new Size(115, 45);
            btnKiloPdf.TabIndex = 5;
            btnKiloPdf.Text = "Grafiği İndir";
            btnKiloPdf.UseVisualStyleBackColor = false;
            btnKiloPdf.Click += btnKiloPdf_Click;
            // 
            // btnBoyPdf
            // 
            btnBoyPdf.BackColor = Color.FromArgb(164, 172, 134);
            btnBoyPdf.FlatStyle = FlatStyle.Popup;
            btnBoyPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBoyPdf.Location = new Point(889, 672);
            btnBoyPdf.Margin = new Padding(3, 4, 3, 4);
            btnBoyPdf.Name = "btnBoyPdf";
            btnBoyPdf.Size = new Size(115, 45);
            btnBoyPdf.TabIndex = 6;
            btnBoyPdf.Text = "Grafiği İndir";
            btnBoyPdf.UseVisualStyleBackColor = false;
            btnBoyPdf.Click += btnBoyPdf_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(186, 199, 167);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-7, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 61);
            panel1.TabIndex = 7;
            // 
            // KullaniciGrafikEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(panel1);
            Controls.Add(btnBoyPdf);
            Controls.Add(btnKiloPdf);
            Controls.Add(btnGeri);
            Controls.Add(cBoyG);
            Controls.Add(cKiloG);
            MaximizeBox = false;
            Name = "KullaniciGrafikEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciGrafikEkrani";
            Load += KullaniciGrafikEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)cKiloG).EndInit();
            ((System.ComponentModel.ISupportInitialize)cBoyG).EndInit();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
    }
}