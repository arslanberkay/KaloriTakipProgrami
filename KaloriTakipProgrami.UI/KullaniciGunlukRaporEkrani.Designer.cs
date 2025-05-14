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
            label1 = new Label();
            label2 = new Label();
            dtpTarih = new DateTimePicker();
            cmbOgunler = new ComboBox();
            lblToplamKaloriMiktari = new Label();
            lblKaloriBilgilendirme = new Label();
            btnGoruntule = new Button();
            lstvOgunYemekDetayliRapor = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Gün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(24, 109);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Öğünler";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(122, 31);
            dtpTarih.Margin = new Padding(4);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(312, 32);
            dtpTarih.TabIndex = 1;
            // 
            // cmbOgunler
            // 
            cmbOgunler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(122, 109);
            cmbOgunler.Margin = new Padding(4);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(312, 33);
            cmbOgunler.TabIndex = 2;
            // 
            // lblToplamKaloriMiktari
            // 
            lblToplamKaloriMiktari.AutoSize = true;
            lblToplamKaloriMiktari.ForeColor = SystemColors.ButtonHighlight;
            lblToplamKaloriMiktari.Location = new Point(594, 482);
            lblToplamKaloriMiktari.Margin = new Padding(4, 0, 4, 0);
            lblToplamKaloriMiktari.Name = "lblToplamKaloriMiktari";
            lblToplamKaloriMiktari.Size = new Size(63, 25);
            lblToplamKaloriMiktari.TabIndex = 4;
            lblToplamKaloriMiktari.Text = "label3";
            // 
            // lblKaloriBilgilendirme
            // 
            lblKaloriBilgilendirme.AutoSize = true;
            lblKaloriBilgilendirme.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKaloriBilgilendirme.ForeColor = SystemColors.ButtonHighlight;
            lblKaloriBilgilendirme.Location = new Point(346, 486);
            lblKaloriBilgilendirme.Margin = new Padding(4, 0, 4, 0);
            lblKaloriBilgilendirme.Name = "lblKaloriBilgilendirme";
            lblKaloriBilgilendirme.Size = new Size(100, 20);
            lblKaloriBilgilendirme.TabIndex = 5;
            lblKaloriBilgilendirme.Text = "bilgilendirme";
            // 
            // btnGoruntule
            // 
            btnGoruntule.BackColor = Color.FromArgb(164, 172, 134);
            btnGoruntule.Location = new Point(122, 159);
            btnGoruntule.Name = "btnGoruntule";
            btnGoruntule.Size = new Size(312, 52);
            btnGoruntule.TabIndex = 6;
            btnGoruntule.Text = "Görüntüle";
            btnGoruntule.UseVisualStyleBackColor = false;
            btnGoruntule.Click += btnGoruntule_Click;
            // 
            // lstvOgunYemekDetayliRapor
            // 
            lstvOgunYemekDetayliRapor.BackColor = Color.FromArgb(202, 210, 197);
            lstvOgunYemekDetayliRapor.Location = new Point(47, 242);
            lstvOgunYemekDetayliRapor.Name = "lstvOgunYemekDetayliRapor";
            lstvOgunYemekDetayliRapor.Size = new Size(610, 193);
            lstvOgunYemekDetayliRapor.TabIndex = 7;
            lstvOgunYemekDetayliRapor.UseCompatibleStateImageBehavior = false;
            // 
            // KullaniciGunlukRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(736, 565);
            Controls.Add(lstvOgunYemekDetayliRapor);
            Controls.Add(btnGoruntule);
            Controls.Add(lblKaloriBilgilendirme);
            Controls.Add(lblToplamKaloriMiktari);
            Controls.Add(cmbOgunler);
            Controls.Add(dtpTarih);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "KullaniciGunlukRaporEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciGunlukRaporEkrani";
            WindowState = FormWindowState.Maximized;
            Load += KullaniciGunlukRaporEkrani_Load;
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
    }
}