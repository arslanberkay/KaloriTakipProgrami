namespace KaloriTakipProgrami.UI
{
    partial class KullaniciGunlukRaporEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGunlukRaporEkrani));
            label1 = new Label();
            label2 = new Label();
            dtpTarih = new DateTimePicker();
            cmbOgunler = new ComboBox();
            lblToplamKaloriMiktari = new Label();
            lblKaloriBilgilendirme = new Label();
            btnGoruntule = new Button();
            lstvOgunYemekDetayliRapor = new ListView();
            btnGeri = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(16, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "Gün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 102);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 0;
            label2.Text = "Öğünler";
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dtpTarih.Location = new Point(115, 43);
            dtpTarih.Margin = new Padding(4);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(312, 31);
            dtpTarih.TabIndex = 1;
            // 
            // cmbOgunler
            // 
            cmbOgunler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgunler.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(115, 99);
            cmbOgunler.Margin = new Padding(4);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(312, 33);
            cmbOgunler.TabIndex = 2;
            // 
            // lblToplamKaloriMiktari
            // 
            lblToplamKaloriMiktari.AutoSize = true;
            lblToplamKaloriMiktari.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblToplamKaloriMiktari.ForeColor = SystemColors.ButtonHighlight;
            lblToplamKaloriMiktari.Location = new Point(1186, 298);
            lblToplamKaloriMiktari.Margin = new Padding(4, 0, 4, 0);
            lblToplamKaloriMiktari.Name = "lblToplamKaloriMiktari";
            lblToplamKaloriMiktari.Size = new Size(62, 25);
            lblToplamKaloriMiktari.TabIndex = 4;
            lblToplamKaloriMiktari.Text = "label3";
            // 
            // lblKaloriBilgilendirme
            // 
            lblKaloriBilgilendirme.AutoSize = true;
            lblKaloriBilgilendirme.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblKaloriBilgilendirme.ForeColor = SystemColors.ButtonHighlight;
            lblKaloriBilgilendirme.Location = new Point(1034, 298);
            lblKaloriBilgilendirme.Margin = new Padding(4, 0, 4, 0);
            lblKaloriBilgilendirme.Name = "lblKaloriBilgilendirme";
            lblKaloriBilgilendirme.Size = new Size(125, 25);
            lblKaloriBilgilendirme.TabIndex = 5;
            lblKaloriBilgilendirme.Text = "Toplam Kalori";
            // 
            // btnGoruntule
            // 
            btnGoruntule.BackColor = Color.FromArgb(164, 172, 134);
            btnGoruntule.FlatStyle = FlatStyle.Popup;
            btnGoruntule.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnGoruntule.Location = new Point(115, 154);
            btnGoruntule.Name = "btnGoruntule";
            btnGoruntule.Size = new Size(312, 52);
            btnGoruntule.TabIndex = 3;
            btnGoruntule.Text = "Görüntüle";
            btnGoruntule.UseVisualStyleBackColor = false;
            btnGoruntule.Click += btnGoruntule_Click;
            // 
            // lstvOgunYemekDetayliRapor
            // 
            lstvOgunYemekDetayliRapor.BackColor = Color.FromArgb(202, 210, 197);
            lstvOgunYemekDetayliRapor.Location = new Point(35, 344);
            lstvOgunYemekDetayliRapor.Name = "lstvOgunYemekDetayliRapor";
            lstvOgunYemekDetayliRapor.Size = new Size(1217, 307);
            lstvOgunYemekDetayliRapor.TabIndex = 7;
            lstvOgunYemekDetayliRapor.UseCompatibleStateImageBehavior = false;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(2, 1);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(57, 41);
            btnGeri.TabIndex = 4;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGoruntule);
            groupBox1.Controls.Add(cmbOgunler);
            groupBox1.Controls.Add(dtpTarih);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // KullaniciGunlukRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 703);
            Controls.Add(groupBox1);
            Controls.Add(btnGeri);
            Controls.Add(lstvOgunYemekDetayliRapor);
            Controls.Add(lblKaloriBilgilendirme);
            Controls.Add(lblToplamKaloriMiktari);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "KullaniciGunlukRaporEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciGunlukRaporEkrani";
            Load += KullaniciGunlukRaporEkrani_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpTarih;
        private ComboBox cmbOgunler;
        private Label lblToplamKaloriMiktari;
        private Label lblKaloriBilgilendirme;
        private Button btnGoruntule;
        private ListView lstvOgunYemekDetayliRapor;

        private Button btnGeri;
        private GroupBox groupBox1;
    }
}