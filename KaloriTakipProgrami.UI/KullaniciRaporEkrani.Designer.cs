namespace KaloriTakipProgrami.UI
{
    partial class KullaniciRaporEkrani
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnEnCokYenilen = new Button();
            btnAzYenilenler = new Button();
            dgvYemekIstatistikleri = new DataGridView();
            btnGeri = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvYemekIstatistikleri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(451, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Bitiş Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(164, 44);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Başlangıç Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(164, 61);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(451, 61);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // btnEnCokYenilen
            // 
            btnEnCokYenilen.BackColor = Color.FromArgb(164, 172, 134);
            btnEnCokYenilen.Location = new Point(451, 110);
            btnEnCokYenilen.Margin = new Padding(3, 2, 3, 2);
            btnEnCokYenilen.Name = "btnEnCokYenilen";
            btnEnCokYenilen.Size = new Size(183, 22);
            btnEnCokYenilen.TabIndex = 4;
            btnEnCokYenilen.Text = "En Çok Yenilen Yemekler";
            btnEnCokYenilen.UseVisualStyleBackColor = false;
            // 
            // btnAzYenilenler
            // 
            btnAzYenilenler.BackColor = Color.FromArgb(164, 172, 134);
            btnAzYenilenler.Location = new Point(200, 110);
            btnAzYenilenler.Margin = new Padding(3, 2, 3, 2);
            btnAzYenilenler.Name = "btnAzYenilenler";
            btnAzYenilenler.Size = new Size(183, 22);
            btnAzYenilenler.TabIndex = 5;
            btnAzYenilenler.Text = "En az Yenilen Yemekler";
            btnAzYenilenler.UseVisualStyleBackColor = false;
            // 
            // dgvYemekIstatistikleri
            // 
            dgvYemekIstatistikleri.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvYemekIstatistikleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekIstatistikleri.Location = new Point(164, 148);
            dgvYemekIstatistikleri.Margin = new Padding(3, 2, 3, 2);
            dgvYemekIstatistikleri.Name = "dgvYemekIstatistikleri";
            dgvYemekIstatistikleri.RowHeadersWidth = 51;
            dgvYemekIstatistikleri.Size = new Size(506, 141);
            dgvYemekIstatistikleri.TabIndex = 6;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(164, 172, 134);
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(12, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 30;
            btnGeri.Text = "<<< GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // KullaniciRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(982, 473);
            Controls.Add(btnGeri);
            Controls.Add(dgvYemekIstatistikleri);
            Controls.Add(btnAzYenilenler);
            Controls.Add(btnEnCokYenilen);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KullaniciRaporEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciRaporEkrani";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvYemekIstatistikleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnEnCokYenilen;
        private Button btnAzYenilenler;
        private DataGridView dgvYemekIstatistikleri;
        private Button btnGeri;
    }
}