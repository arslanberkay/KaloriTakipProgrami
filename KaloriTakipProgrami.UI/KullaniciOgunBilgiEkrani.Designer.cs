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
            label2.Location = new Point(11, 65);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Kategoriler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(39, 102);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Yemek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(53, 143);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Tarih";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(42, 183);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Miktar";
            // 
            // cmbYemekler
            // 
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(127, 95);
            cmbYemekler.Margin = new Padding(3, 2, 3, 2);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(219, 27);
            cmbYemekler.TabIndex = 5;
            cmbYemekler.SelectedIndexChanged += cmbYemekler_SelectedIndexChanged;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(127, 58);
            cmbKategoriler.Margin = new Padding(3, 2, 3, 2);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(219, 27);
            cmbKategoriler.TabIndex = 6;
            // 
            // cmbOgunler
            // 
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(127, 22);
            cmbOgunler.Margin = new Padding(3, 2, 3, 2);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(219, 27);
            cmbOgunler.TabIndex = 7;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(164, 172, 134);
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSil.Location = new Point(224, 256);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(77, 35);
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
            btnGüncelle.Location = new Point(377, 257);
            btnGüncelle.Margin = new Padding(3, 2, 3, 2);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(88, 34);
            btnGüncelle.TabIndex = 11;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.BackColor = Color.FromArgb(164, 172, 134);
            btnPdfOlustur.FlatStyle = FlatStyle.Popup;
            btnPdfOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPdfOlustur.Location = new Point(156, 491);
            btnPdfOlustur.Margin = new Padding(3, 2, 3, 2);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(75, 27);
            btnPdfOlustur.TabIndex = 12;
            btnPdfOlustur.Text = "PDF";
            btnPdfOlustur.UseVisualStyleBackColor = false;
            btnPdfOlustur.Click += btnPdfOlustur_Click;
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.BackColor = Color.FromArgb(164, 172, 134);
            btnExcelOlustur.FlatStyle = FlatStyle.Popup;
            btnExcelOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExcelOlustur.Location = new Point(327, 491);
            btnExcelOlustur.Margin = new Padding(3, 2, 3, 2);
            btnExcelOlustur.Name = "btnExcelOlustur";
            btnExcelOlustur.Size = new Size(78, 27);
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
            btnEkle.Location = new Point(87, 257);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(82, 34);
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
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Öğünler";
            // 
            // lsvOgunBilgileri
            // 
            lsvOgunBilgileri.BackColor = Color.FromArgb(202, 210, 197);
            lsvOgunBilgileri.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lsvOgunBilgileri.Location = new Point(58, 316);
            lsvOgunBilgileri.Margin = new Padding(3, 2, 3, 2);
            lsvOgunBilgileri.Name = "lsvOgunBilgileri";
            lsvOgunBilgileri.Size = new Size(453, 151);
            lsvOgunBilgileri.TabIndex = 15;
            lsvOgunBilgileri.UseCompatibleStateImageBehavior = false;
            lsvOgunBilgileri.DoubleClick += lsvOgunBilgileri_DoubleClick;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(127, 137);
            dtpTarih.Margin = new Padding(3, 2, 3, 2);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(219, 27);
            dtpTarih.TabIndex = 16;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(129, 181);
            nudMiktar.Margin = new Padding(3, 2, 3, 2);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(217, 27);
            nudMiktar.TabIndex = 17;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(164, 172, 134);
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(551, 29);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(74, 33);
            btnGeri.TabIndex = 30;
            btnGeri.Text = "< GERİ";
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
            groupBox1.Location = new Point(59, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(452, 233);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÖĞÜN BİLGİLERİ";
            // 
            // KullaniciOgunBilgiEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(699, 549);
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