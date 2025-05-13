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
            button1 = new Button();
            button2 = new Button();
            btnRaporGoruntule = new Button();
            SuspendLayout();
            // 
            // cbKullaniciAdlari
            // 
            cbKullaniciAdlari.FormattingEnabled = true;
            cbKullaniciAdlari.Location = new Point(322, 42);
            cbKullaniciAdlari.Margin = new Padding(4);
            cbKullaniciAdlari.Name = "cbKullaniciAdlari";
            cbKullaniciAdlari.Size = new Size(220, 33);
            cbKullaniciAdlari.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(322, 100);
            dtpTarih.Margin = new Padding(4);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(220, 32);
            dtpTarih.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "Tarih";
            // 
            // lstvKullaniciGunlukRapor
            // 
            lstvKullaniciGunlukRapor.Location = new Point(188, 224);
            lstvKullaniciGunlukRapor.Margin = new Padding(4);
            lstvKullaniciGunlukRapor.Name = "lstvKullaniciGunlukRapor";
            lstvKullaniciGunlukRapor.Size = new Size(565, 212);
            lstvKullaniciGunlukRapor.TabIndex = 3;
            lstvKullaniciGunlukRapor.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(512, 456);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(106, 56);
            button1.TabIndex = 4;
            button1.Text = "PDF";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(640, 456);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(106, 56);
            button2.TabIndex = 4;
            button2.Text = "EXCEL";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnRaporGoruntule
            // 
            btnRaporGoruntule.Location = new Point(322, 151);
            btnRaporGoruntule.Name = "btnRaporGoruntule";
            btnRaporGoruntule.Size = new Size(220, 48);
            btnRaporGoruntule.TabIndex = 5;
            btnRaporGoruntule.Text = "Görüntüle";
            btnRaporGoruntule.UseVisualStyleBackColor = true;
            btnRaporGoruntule.Click += btnRaporGoruntule_Click;
            // 
            // YoneticiKullaniciGunlukRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnRaporGoruntule);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstvKullaniciGunlukRapor);
            Controls.Add(dtpTarih);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbKullaniciAdlari);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "YoneticiKullaniciGunlukRaporEkrani";
            Text = "YoneticiKullaniciGunlukRaporEkrani";
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
        private Button button1;
        private Button button2;
        private Button btnRaporGoruntule;
    }
}