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
            label1 = new Label();
            label2 = new Label();
            cKiloG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cBoyG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)cKiloG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cBoyG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);

            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(490, 30);


            label1.Location = new Point(86, 88);

    

            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 0;
            label1.Text = "Kilo Grafiği";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);

            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(520, 400);


            label2.Location = new Point(530, 101);
            

            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 1;
            label2.Text = "Boy Grafiği";
            // 
            // cKiloG
            // 

            dgvKiloGrafikleri.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvKiloGrafikleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKiloGrafikleri.Location = new Point(46, 89);
            dgvKiloGrafikleri.Name = "dgvKiloGrafikleri";
            dgvKiloGrafikleri.RowHeadersWidth = 51;
            dgvKiloGrafikleri.Size = new Size(1054, 279);
            dgvKiloGrafikleri.TabIndex = 2;


            chartArea3.Name = "ChartArea1";
            cKiloG.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            cKiloG.Legends.Add(legend3);
            cKiloG.Location = new Point(38, 172);
            cKiloG.Name = "cKiloG";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            cKiloG.Series.Add(series3);
            cKiloG.Size = new Size(300, 300);
            cKiloG.TabIndex = 3;
            cKiloG.Text = "chart1";

          


            // 
            // cBoyG
            // 

            dgvBoyGrafikleri.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvBoyGrafikleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoyGrafikleri.Location = new Point(55, 467);
            dgvBoyGrafikleri.Name = "dgvBoyGrafikleri";
            dgvBoyGrafikleri.RowHeadersWidth = 51;
            dgvBoyGrafikleri.Size = new Size(1045, 296);
            dgvBoyGrafikleri.TabIndex = 2;


            chartArea4.Name = "ChartArea1";
            cBoyG.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            cBoyG.Legends.Add(legend4);
            cBoyG.Location = new Point(445, 172);
            cBoyG.Name = "cBoyG";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            cBoyG.Series.Add(series4);
            cBoyG.Size = new Size(300, 300);
            cBoyG.TabIndex = 4;
            cBoyG.Text = "chart2";


            // 
            // KullaniciGrafikEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1162, 792);
            Controls.Add(dgvBoyGrafikleri);
            Controls.Add(dgvKiloGrafikleri);


            ClientSize = new Size(786, 615);
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
    }
}