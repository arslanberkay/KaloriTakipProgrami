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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciRaporEkrani));
            label1 = new Label();
            label2 = new Label();
            dtpBaslangicTarihi = new DateTimePicker();
            dtpBitisTarihi = new DateTimePicker();
            btnEnCokYenilen = new Button();
            btnAzYenilenler = new Button();
            btnGeri = new Button();
            lstOgunYemekRaporu = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(670, 98);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Bitiş Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(266, 98);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 1;
            label2.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dtpBaslangicTarihi.Location = new Point(266, 146);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(359, 31);
            dtpBaslangicTarihi.TabIndex = 2;
            dtpBaslangicTarihi.ValueChanged += dtpBaslangicTarihi_ValueChanged;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dtpBitisTarihi.Location = new Point(670, 146);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(359, 31);
            dtpBitisTarihi.TabIndex = 3;
            dtpBitisTarihi.ValueChanged += dtpBitisTarihi_ValueChanged;
            // 
            // btnEnCokYenilen
            // 
            btnEnCokYenilen.BackColor = Color.FromArgb(164, 172, 134);
            btnEnCokYenilen.FlatStyle = FlatStyle.Popup;
            btnEnCokYenilen.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnEnCokYenilen.Location = new Point(670, 206);
            btnEnCokYenilen.Name = "btnEnCokYenilen";
            btnEnCokYenilen.Size = new Size(242, 47);
            btnEnCokYenilen.TabIndex = 4;
            btnEnCokYenilen.Text = "En Çok Yenilen Yemekler";
            btnEnCokYenilen.UseVisualStyleBackColor = false;
            btnEnCokYenilen.Click += btnEnCokYenilen_Click;
            // 
            // btnAzYenilenler
            // 
            btnAzYenilenler.BackColor = Color.FromArgb(164, 172, 134);
            btnAzYenilenler.FlatStyle = FlatStyle.Popup;
            btnAzYenilenler.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnAzYenilenler.Location = new Point(266, 206);
            btnAzYenilenler.Name = "btnAzYenilenler";
            btnAzYenilenler.Size = new Size(227, 47);
            btnAzYenilenler.TabIndex = 5;
            btnAzYenilenler.Text = "En az Yenilen Yemekler";
            btnAzYenilenler.UseVisualStyleBackColor = false;
            btnAzYenilenler.Click += btnAzYenilenler_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(3, 2);
            btnGeri.Margin = new Padding(3, 4, 3, 4);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(57, 41);
            btnGeri.TabIndex = 30;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // lstOgunYemekRaporu
            // 
            lstOgunYemekRaporu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstOgunYemekRaporu.BackColor = Color.FromArgb(202, 210, 197);
            lstOgunYemekRaporu.Location = new Point(35, 306);
            lstOgunYemekRaporu.Name = "lstOgunYemekRaporu";
            lstOgunYemekRaporu.Size = new Size(1208, 396);
            lstOgunYemekRaporu.TabIndex = 31;
            lstOgunYemekRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // KullaniciRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(lstOgunYemekRaporu);
            Controls.Add(btnGeri);
            Controls.Add(btnAzYenilenler);
            Controls.Add(btnEnCokYenilen);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "KullaniciRaporEkrani";
            StartPosition = FormStartPosition.Manual;
            Text = "KullaniciRaporEkrani";
            WindowState = FormWindowState.Maximized;
            Load += KullaniciRaporEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpBaslangicTarihi;
        private DateTimePicker dtpBitisTarihi;
        private Button btnEnCokYenilen;
        private Button btnAzYenilenler;
        private Button btnGeri;
        private ListView lstOgunYemekRaporu;
    }
}