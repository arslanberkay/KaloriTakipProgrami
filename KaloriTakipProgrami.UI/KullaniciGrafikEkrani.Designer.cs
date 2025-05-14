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
            label1 = new Label();
            label2 = new Label();
            dgvKiloGrafikleri = new DataGridView();
            dgvBoyGrafikleri = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKiloGrafikleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBoyGrafikleri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(190, 25);
            label1.Name = "label1";
            label1.Size = new Size(197, 43);
            label1.TabIndex = 0;
            label1.Text = "Kilo Grafiği";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(190, 319);
            label2.Name = "label2";
            label2.Size = new Size(167, 41);
            label2.TabIndex = 1;
            label2.Text = "Boy Grafiği";
            // 
            // dgvKiloGrafikleri
            // 
            dgvKiloGrafikleri.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvKiloGrafikleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKiloGrafikleri.Location = new Point(46, 91);
            dgvKiloGrafikleri.Name = "dgvKiloGrafikleri";
            dgvKiloGrafikleri.RowHeadersWidth = 51;
            dgvKiloGrafikleri.Size = new Size(469, 188);
            dgvKiloGrafikleri.TabIndex = 2;
            // 
            // dgvBoyGrafikleri
            // 
            dgvBoyGrafikleri.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvBoyGrafikleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoyGrafikleri.Location = new Point(46, 378);
            dgvBoyGrafikleri.Name = "dgvBoyGrafikleri";
            dgvBoyGrafikleri.RowHeadersWidth = 51;
            dgvBoyGrafikleri.Size = new Size(469, 188);
            dgvBoyGrafikleri.TabIndex = 2;
            // 
            // KullaniciGrafikEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(569, 622);
            Controls.Add(dgvBoyGrafikleri);
            Controls.Add(dgvKiloGrafikleri);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KullaniciGrafikEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciGrafikEkrani";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvKiloGrafikleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBoyGrafikleri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvKiloGrafikleri;
        private DataGridView dgvBoyGrafikleri;
    }
}