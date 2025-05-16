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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciOgunBilgiEkrani));
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
            label2.Location = new Point(30, 102);
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
            label3.Location = new Point(58, 152);
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
            label4.Location = new Point(72, 203);
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
            label5.Location = new Point(59, 250);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Miktar";
            // 
            // cmbYemekler
            // 
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(146, 145);
            cmbYemekler.Margin = new Padding(3, 2, 3, 2);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(261, 33);
            cmbYemekler.TabIndex = 5;
            cmbYemekler.SelectedIndexChanged += cmbYemekler_SelectedIndexChanged;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(146, 95);
            cmbKategoriler.Margin = new Padding(3, 2, 3, 2);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(261, 33);
            cmbKategoriler.TabIndex = 6;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // cmbOgunler
            // 
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(144, 48);
            cmbOgunler.Margin = new Padding(3, 2, 3, 2);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(261, 33);
            cmbOgunler.TabIndex = 7;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(164, 172, 134);
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSil.Location = new Point(827, 329);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(111, 39);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.FromArgb(164, 172, 134);
            btnGüncelle.FlatStyle = FlatStyle.Popup;
            btnGüncelle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnGüncelle.Location = new Point(953, 329);
            btnGüncelle.Margin = new Padding(3, 2, 3, 2);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(109, 39);
            btnGüncelle.TabIndex = 11;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.BackColor = Color.FromArgb(164, 172, 134);
            btnPdfOlustur.FlatStyle = FlatStyle.Popup;
            btnPdfOlustur.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnPdfOlustur.Location = new Point(985, 674);
            btnPdfOlustur.Margin = new Padding(3, 2, 3, 2);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(110, 41);
            btnPdfOlustur.TabIndex = 12;
            btnPdfOlustur.Text = "PDF";
            btnPdfOlustur.UseVisualStyleBackColor = false;
            btnPdfOlustur.Click += btnPdfOlustur_Click;
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.BackColor = Color.FromArgb(164, 172, 134);
            btnExcelOlustur.FlatStyle = FlatStyle.Popup;
            btnExcelOlustur.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnExcelOlustur.Location = new Point(1121, 674);
            btnExcelOlustur.Margin = new Padding(3, 2, 3, 2);
            btnExcelOlustur.Name = "btnExcelOlustur";
            btnExcelOlustur.Size = new Size(111, 41);
            btnExcelOlustur.TabIndex = 13;
            btnExcelOlustur.Text = "EXCEL";
            btnExcelOlustur.UseVisualStyleBackColor = false;
            btnExcelOlustur.Click += btnExcelOlustur_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(164, 172, 134);
            btnEkle.FlatStyle = FlatStyle.Popup;
            btnEkle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnEkle.Location = new Point(693, 329);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(109, 38);
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
            label1.Location = new Point(45, 55);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 1;
            label1.Text = "Öğünler";
            // 
            // lsvOgunBilgileri
            // 
            lsvOgunBilgileri.BackColor = Color.FromArgb(202, 210, 197);
            lsvOgunBilgileri.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lsvOgunBilgileri.Location = new Point(65, 384);
            lsvOgunBilgileri.Margin = new Padding(3, 2, 3, 2);
            lsvOgunBilgileri.Name = "lsvOgunBilgileri";
            lsvOgunBilgileri.Size = new Size(1167, 274);
            lsvOgunBilgileri.TabIndex = 15;
            lsvOgunBilgileri.UseCompatibleStateImageBehavior = false;
            lsvOgunBilgileri.DoubleClick += lsvOgunBilgileri_DoubleClick;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(146, 197);
            dtpTarih.Margin = new Padding(3, 2, 3, 2);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(261, 31);
            dtpTarih.TabIndex = 16;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(146, 248);
            nudMiktar.Margin = new Padding(3, 2, 3, 2);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(261, 31);
            nudMiktar.TabIndex = 17;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(2, 2);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(57, 41);
            btnGeri.TabIndex = 30;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbYemekler);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nudMiktar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpTarih);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbKategoriler);
            groupBox1.Controls.Add(cmbOgunler);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(65, 59);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(610, 308);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÖĞÜN BİLGİLERİ";
            // 
            // KullaniciOgunBilgiEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(groupBox1);
            Controls.Add(btnGeri);
            Controls.Add(lsvOgunBilgileri);
            Controls.Add(btnEkle);
            Controls.Add(btnExcelOlustur);
            Controls.Add(btnPdfOlustur);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "KullaniciOgunBilgiEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciOgunBilgiEkrani";
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

        private Button btnGeri;
        private GroupBox groupBox1;
    }
}