namespace KaloriTakipProgrami.UI
{
    partial class YoneticiKullaniciGunlukRaporEkrani
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
            cbKullaniciAdlari = new ComboBox();
            label1 = new Label();
            dtpTarih = new DateTimePicker();
            label2 = new Label();
            lstvKullaniciGunlukRapor = new ListView();
            btnPdf = new Button();
            btnExcel = new Button();
            btnRaporGoruntule = new Button();
            btnGeri = new Button();
            SuspendLayout();
            // 
            // cbKullaniciAdlari
            // 
            cbKullaniciAdlari.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            cbKullaniciAdlari.FormattingEnabled = true;
            cbKullaniciAdlari.Location = new Point(257, 63);
            cbKullaniciAdlari.Margin = new Padding(4);
            cbKullaniciAdlari.Name = "cbKullaniciAdlari";

            cbKullaniciAdlari.Size = new Size(220, 28);

            cbKullaniciAdlari.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(115, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";

            label1.Size = new Size(92, 20);

            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dtpTarih.Location = new Point(257, 117);
            dtpTarih.Margin = new Padding(4);
            dtpTarih.Name = "dtpTarih";

            dtpTarih.Size = new Size(220, 27);

            dtpTarih.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(115, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";

            label2.Size = new Size(40, 20);

            label2.TabIndex = 1;
            label2.Text = "Tarih";
            // 
            // lstvKullaniciGunlukRapor
            // 
            lstvKullaniciGunlukRapor.BackColor = Color.FromArgb(202, 210, 197);
            lstvKullaniciGunlukRapor.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lstvKullaniciGunlukRapor.Location = new Point(115, 244);
            lstvKullaniciGunlukRapor.Margin = new Padding(4);
            lstvKullaniciGunlukRapor.Name = "lstvKullaniciGunlukRapor";
            lstvKullaniciGunlukRapor.Size = new Size(1148, 424);
            lstvKullaniciGunlukRapor.TabIndex = 3;
            lstvKullaniciGunlukRapor.UseCompatibleStateImageBehavior = false;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.FromArgb(164, 172, 134);
            btnPdf.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnPdf.Location = new Point(1029, 704);
            btnPdf.Margin = new Padding(4);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(106, 46);
            btnPdf.TabIndex = 4;
            btnPdf.Text = "PDF";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(164, 172, 134);
            btnExcel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnExcel.Location = new Point(1157, 704);
            btnExcel.Margin = new Padding(4);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(106, 46);
            btnExcel.TabIndex = 4;
            btnExcel.Text = "EXCEL";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnRaporGoruntule
            // 
            btnRaporGoruntule.BackColor = Color.FromArgb(164, 172, 134);
            btnRaporGoruntule.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnRaporGoruntule.Location = new Point(257, 167);
            btnRaporGoruntule.Name = "btnRaporGoruntule";
            btnRaporGoruntule.Size = new Size(284, 50);
            btnRaporGoruntule.TabIndex = 5;
            btnRaporGoruntule.Text = "Görüntüle";
            btnRaporGoruntule.UseVisualStyleBackColor = false;
            btnRaporGoruntule.Click += btnRaporGoruntule_Click;
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
            // YoneticiKullaniciGunlukRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);

            ClientSize = new Size(1000, 562);
            Controls.Add(btnGeri);

            Controls.Add(btnRaporGoruntule);
            Controls.Add(btnExcel);
            Controls.Add(btnPdf);
            Controls.Add(lstvKullaniciGunlukRapor);
            Controls.Add(dtpTarih);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbKullaniciAdlari);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "YoneticiKullaniciGunlukRaporEkrani";
            Text = "YoneticiKullaniciGunlukRaporEkrani";
            WindowState = FormWindowState.Maximized;
            Load += YoneticiKullaniciGunlukRaporEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKullaniciAdlari;
        private Label label1;
        private DateTimePicker dtpTarih;
        private Label label2;
        private ListView lstvKullaniciGunlukRapor;
        private Button btnPdf;
        private Button btnExcel;
        private Button btnRaporGoruntule;
        private Button btnGeri;
    }
}