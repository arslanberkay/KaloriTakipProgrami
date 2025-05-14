namespace KaloriTakipProgrami.UI
{
    partial class KullaniciOgunBilgiEkrani
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbYemekler = new ComboBox();
            cmbKategoriler = new ComboBox();
            cmbOgunler = new ComboBox();
            btnSil = new Button();
            btnGüncelle = new Button();
            btnPdfOlustur = new Button();
            btnExcelOlustur = new Button();
            btnEkle = new Button();
            label1 = new Label();
            lsvOgunBilgileri = new ListView();
            dtpTarih = new DateTimePicker();
            nudMiktar = new NumericUpDown();
            btnGeri = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Kategoriler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(20, 86);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Yemek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(30, 114);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Tarih";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(20, 141);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Miktar";
            // 
            // cmbYemekler
            // 
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(92, 80);
            cmbYemekler.Margin = new Padding(3, 2, 3, 2);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(133, 23);
            cmbYemekler.TabIndex = 5;
            cmbYemekler.SelectedIndexChanged += cmbYemekler_SelectedIndexChanged;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(92, 55);
            cmbKategoriler.Margin = new Padding(3, 2, 3, 2);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(133, 23);
            cmbKategoriler.TabIndex = 6;
            // 
            // cmbOgunler
            // 
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(92, 26);
            cmbOgunler.Margin = new Padding(3, 2, 3, 2);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(133, 23);
            cmbOgunler.TabIndex = 7;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(164, 172, 134);
            btnSil.Location = new Point(186, 184);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(82, 22);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.FromArgb(164, 172, 134);
            btnGüncelle.Location = new Point(318, 184);
            btnGüncelle.Margin = new Padding(3, 2, 3, 2);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(82, 22);
            btnGüncelle.TabIndex = 11;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.BackColor = Color.FromArgb(164, 172, 134);
            btnPdfOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPdfOlustur.Location = new Point(117, 365);
            btnPdfOlustur.Margin = new Padding(3, 2, 3, 2);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(82, 22);
            btnPdfOlustur.TabIndex = 12;
            btnPdfOlustur.Text = "PDF";
            btnPdfOlustur.UseVisualStyleBackColor = false;
            btnPdfOlustur.Click += btnPdfOlustur_Click;
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.BackColor = Color.FromArgb(164, 172, 134);
            btnExcelOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExcelOlustur.Location = new Point(259, 365);
            btnExcelOlustur.Margin = new Padding(3, 2, 3, 2);
            btnExcelOlustur.Name = "btnExcelOlustur";
            btnExcelOlustur.Size = new Size(82, 22);
            btnExcelOlustur.TabIndex = 13;
            btnExcelOlustur.Text = "EXCEL";
            btnExcelOlustur.UseVisualStyleBackColor = false;
            btnExcelOlustur.Click += btnExcelOlustur_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(164, 172, 134);
            btnEkle.Location = new Point(59, 184);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(82, 22);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Öğünler";
            // 
            // lsvOgunBilgileri
            // 
            lsvOgunBilgileri.BackColor = Color.FromArgb(202, 210, 197);
            lsvOgunBilgileri.Location = new Point(10, 211);
            lsvOgunBilgileri.Margin = new Padding(3, 2, 3, 2);
            lsvOgunBilgileri.Name = "lsvOgunBilgileri";
            lsvOgunBilgileri.Size = new Size(453, 151);
            lsvOgunBilgileri.TabIndex = 15;
            lsvOgunBilgileri.UseCompatibleStateImageBehavior = false;
            lsvOgunBilgileri.DoubleClick += lsvOgunBilgileri_DoubleClick;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(92, 110);
            dtpTarih.Margin = new Padding(3, 2, 3, 2);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(219, 23);
            dtpTarih.TabIndex = 16;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(93, 141);
            nudMiktar.Margin = new Padding(3, 2, 3, 2);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(131, 23);
            nudMiktar.TabIndex = 17;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(164, 172, 134);
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(388, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 30;
            btnGeri.Text = "<<< GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // KullaniciOgunBilgiEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(473, 394);
            Controls.Add(btnGeri);
            Controls.Add(nudMiktar);
            Controls.Add(dtpTarih);
            Controls.Add(lsvOgunBilgileri);
            Controls.Add(btnEkle);
            Controls.Add(btnExcelOlustur);
            Controls.Add(btnPdfOlustur);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(cmbOgunler);
            Controls.Add(cmbKategoriler);
            Controls.Add(cmbYemekler);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KullaniciOgunBilgiEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciOgunBilgiEkrani";
            WindowState = FormWindowState.Maximized;
            Load += KullaniciOgunBilgiEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbYemekler;
        private ComboBox cmbKategoriler;
        private ComboBox cmbOgunler;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnPdfOlustur;
        private Button btnExcelOlustur;
        private Button btnEkle;
        private Label label1;
        private ListView lsvOgunBilgileri;
        private DateTimePicker dtpTarih;
        private NumericUpDown nudMiktar;
        private Button btnGeri;
    }
}