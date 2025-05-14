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
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Kategoriler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(23, 115);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Yemek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(34, 152);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Tarih";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(23, 188);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Miktar";
            // 
            // cmbYemekler
            // 
            cmbYemekler.FormattingEnabled = true;
            cmbYemekler.Location = new Point(105, 107);
            cmbYemekler.Name = "cmbYemekler";
            cmbYemekler.Size = new Size(151, 28);
            cmbYemekler.TabIndex = 5;
            cmbYemekler.SelectedIndexChanged += cmbYemekler_SelectedIndexChanged;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(105, 73);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(151, 28);
            cmbKategoriler.TabIndex = 6;
            // 
            // cmbOgunler
            // 
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(105, 34);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(151, 28);
            cmbOgunler.TabIndex = 7;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(213, 245);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 30);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(363, 245);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(94, 30);
            btnGüncelle.TabIndex = 11;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPdfOlustur.Location = new Point(134, 487);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(94, 29);
            btnPdfOlustur.TabIndex = 12;
            btnPdfOlustur.Text = "PDF";
            btnPdfOlustur.UseVisualStyleBackColor = true;
            btnPdfOlustur.Click += btnPdfOlustur_Click;
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExcelOlustur.Location = new Point(296, 487);
            btnExcelOlustur.Name = "btnExcelOlustur";
            btnExcelOlustur.Size = new Size(94, 29);
            btnExcelOlustur.TabIndex = 13;
            btnExcelOlustur.Text = "EXCEL";
            btnExcelOlustur.UseVisualStyleBackColor = true;
            btnExcelOlustur.Click += btnExcelOlustur_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(67, 245);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 30);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Öğünler";
            // 
            // lsvOgunBilgileri
            // 
            lsvOgunBilgileri.Location = new Point(12, 281);
            lsvOgunBilgileri.Name = "lsvOgunBilgileri";
            lsvOgunBilgileri.Size = new Size(517, 200);
            lsvOgunBilgileri.TabIndex = 15;
            lsvOgunBilgileri.UseCompatibleStateImageBehavior = false;
            lsvOgunBilgileri.DoubleClick += lsvOgunBilgileri_DoubleClick;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(105, 147);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 16;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(106, 188);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(150, 27);
            nudMiktar.TabIndex = 17;
            // 
            // KullaniciOgunBilgiEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 525);
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
            Name = "KullaniciOgunBilgiEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciOgunBilgiEkrani";
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
    }
}