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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(37, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Kategoriler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(37, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Yemek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(37, 183);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 3;
            label4.Text = "Tarih";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(37, 230);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Miktar";
            // 
            // cmbYemekler
            // 
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(180, 136);
            cmbYemekler.Margin = new Padding(4, 4, 4, 4);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(250, 33);
            cmbYemekler.TabIndex = 5;
            cmbYemekler.SelectedIndexChanged += cmbYemekler_SelectedIndexChanged;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(180, 89);
            cmbKategoriler.Margin = new Padding(4, 4, 4, 4);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(250, 33);
            cmbKategoriler.TabIndex = 6;
            // 
            // cmbOgunler
            // 
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(180, 42);
            cmbOgunler.Margin = new Padding(4, 4, 4, 4);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(250, 33);
            cmbOgunler.TabIndex = 7;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(164, 172, 134);
            btnSil.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSil.Location = new Point(292, 366);
            btnSil.Margin = new Padding(4, 4, 4, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 42);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.FromArgb(164, 172, 134);
            btnGüncelle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnGüncelle.Location = new Point(429, 366);
            btnGüncelle.Margin = new Padding(4, 4, 4, 4);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(112, 42);
            btnGüncelle.TabIndex = 11;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.BackColor = Color.FromArgb(164, 172, 134);
            btnPdfOlustur.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnPdfOlustur.Location = new Point(928, 812);
            btnPdfOlustur.Margin = new Padding(4, 4, 4, 4);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(118, 41);
            btnPdfOlustur.TabIndex = 12;
            btnPdfOlustur.Text = "PDF";
            btnPdfOlustur.UseVisualStyleBackColor = false;
            btnPdfOlustur.Click += btnPdfOlustur_Click;
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.BackColor = Color.FromArgb(164, 172, 134);
            btnExcelOlustur.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnExcelOlustur.Location = new Point(1066, 812);
            btnExcelOlustur.Margin = new Padding(4, 4, 4, 4);
            btnExcelOlustur.Name = "btnExcelOlustur";
            btnExcelOlustur.Size = new Size(118, 41);
            btnExcelOlustur.TabIndex = 13;
            btnExcelOlustur.Text = "EXCEL";
            btnExcelOlustur.UseVisualStyleBackColor = false;
            btnExcelOlustur.Click += btnExcelOlustur_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(164, 172, 134);
            btnEkle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnEkle.Location = new Point(149, 366);
            btnEkle.Margin = new Padding(4, 4, 4, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 42);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(37, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 1;
            label1.Text = "Öğünler";
            // 
            // lsvOgunBilgileri
            // 
            lsvOgunBilgileri.BackColor = Color.FromArgb(202, 210, 197);
            lsvOgunBilgileri.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lsvOgunBilgileri.Location = new Point(112, 437);
            lsvOgunBilgileri.Margin = new Padding(4, 4, 4, 4);
            lsvOgunBilgileri.Name = "lsvOgunBilgileri";
            lsvOgunBilgileri.Size = new Size(1072, 348);
            lsvOgunBilgileri.TabIndex = 15;
            lsvOgunBilgileri.UseCompatibleStateImageBehavior = false;
            lsvOgunBilgileri.DoubleClick += lsvOgunBilgileri_DoubleClick;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(180, 183);
            dtpTarih.Margin = new Padding(4, 4, 4, 4);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 31);
            dtpTarih.TabIndex = 16;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(180, 228);
            nudMiktar.Margin = new Padding(5, 5, 5, 5);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(250, 31);
            nudMiktar.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudMiktar);
            groupBox1.Controls.Add(dtpTarih);
            groupBox1.Controls.Add(cmbOgunler);
            groupBox1.Controls.Add(cmbKategoriler);
            groupBox1.Controls.Add(cmbYemekler);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            groupBox1.Location = new Point(112, 58);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(487, 286);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // KullaniciOgunBilgiEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1288, 898);
            Controls.Add(groupBox1);
            Controls.Add(lsvOgunBilgileri);
            Controls.Add(btnEkle);
            Controls.Add(btnExcelOlustur);
            Controls.Add(btnPdfOlustur);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "KullaniciOgunBilgiEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciOgunBilgiEkrani";
            WindowState = FormWindowState.Maximized;
            Load += KullaniciOgunBilgiEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
    }
}