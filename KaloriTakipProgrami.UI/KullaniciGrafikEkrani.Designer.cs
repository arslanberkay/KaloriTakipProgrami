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
            label1 = new Label();
            label2 = new Label();
            cKiloG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cBoyG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnGeri = new Button();
            ((System.ComponentModel.ISupportInitialize)cKiloG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cBoyG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(112, 101);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 0;
            label1.Text = "Kilo Grafiği";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(524, 101);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 1;
            label2.Text = "Boy Grafiği";
            // 
            // cKiloG
            // 
            chartArea1.Name = "ChartArea1";
            cKiloG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            cKiloG.Legends.Add(legend1);
            cKiloG.Location = new Point(28, 172);
            cKiloG.Name = "cKiloG";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            cKiloG.Series.Add(series1);
            cKiloG.Size = new Size(349, 377);
            cKiloG.TabIndex = 3;
            cKiloG.Text = "chart1";
            // 
            // cBoyG
            // 
            chartArea2.Name = "ChartArea1";
            cBoyG.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            cBoyG.Legends.Add(legend2);
            cBoyG.Location = new Point(424, 172);
            cBoyG.Name = "cBoyG";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            cBoyG.Series.Add(series2);
            cBoyG.Size = new Size(340, 377);
            cBoyG.TabIndex = 4;
            cBoyG.Text = "chart2";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(164, 172, 134);
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(28, 22);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 28;
            btnGeri.Text = "<<< GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // KullaniciGrafikEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(786, 615);
            Controls.Add(btnGeri);
            Controls.Add(cBoyG);
            Controls.Add(cKiloG);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}