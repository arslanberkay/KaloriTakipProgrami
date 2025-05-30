﻿namespace KaloriTakipProgrami.UI
{
    partial class SifremiUnuttumEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttumEkrani));
            grpSifirlamaKoduGonder = new GroupBox();
            btnSifirlamaKoduGonder = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            grpSifreGuncelleme = new GroupBox();
            lblKullaniciAdi = new Label();
            label5 = new Label();
            btnSifreyiGuncelle = new Button();
            txtYeniSifreTekrar = new TextBox();
            label4 = new Label();
            txtYeniSifre = new TextBox();
            label3 = new Label();
            grpSifirlamaKodu = new GroupBox();
            mtxtSifirlamaKodu = new MaskedTextBox();
            btnOk = new Button();
            label1 = new Label();
            btnGeri = new Button();
            grpSifirlamaKoduGonder.SuspendLayout();
            grpSifreGuncelleme.SuspendLayout();
            grpSifirlamaKodu.SuspendLayout();
            SuspendLayout();
            // 
            // grpSifirlamaKoduGonder
            // 
            grpSifirlamaKoduGonder.Controls.Add(btnSifirlamaKoduGonder);
            grpSifirlamaKoduGonder.Controls.Add(txtEmail);
            grpSifirlamaKoduGonder.Controls.Add(label2);
            grpSifirlamaKoduGonder.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            grpSifirlamaKoduGonder.Location = new Point(381, 44);
            grpSifirlamaKoduGonder.Name = "grpSifirlamaKoduGonder";
            grpSifirlamaKoduGonder.Size = new Size(503, 176);
            grpSifirlamaKoduGonder.TabIndex = 0;
            grpSifirlamaKoduGonder.TabStop = false;
            // 
            // btnSifirlamaKoduGonder
            // 
            btnSifirlamaKoduGonder.BackColor = Color.FromArgb(164, 172, 134);
            btnSifirlamaKoduGonder.FlatStyle = FlatStyle.Popup;
            btnSifirlamaKoduGonder.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSifirlamaKoduGonder.ForeColor = SystemColors.ActiveCaptionText;
            btnSifirlamaKoduGonder.Location = new Point(121, 112);
            btnSifirlamaKoduGonder.Name = "btnSifirlamaKoduGonder";
            btnSifirlamaKoduGonder.Size = new Size(266, 40);
            btnSifirlamaKoduGonder.TabIndex = 2;
            btnSifirlamaKoduGonder.Text = "Sıfırlama Kodu Gönder";
            btnSifirlamaKoduGonder.UseVisualStyleBackColor = false;
            btnSifirlamaKoduGonder.Click += btnSifirlamaKoduGonder_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 53);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 31);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(58, 56);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // grpSifreGuncelleme
            // 
            grpSifreGuncelleme.Controls.Add(lblKullaniciAdi);
            grpSifreGuncelleme.Controls.Add(label5);
            grpSifreGuncelleme.Controls.Add(btnSifreyiGuncelle);
            grpSifreGuncelleme.Controls.Add(txtYeniSifreTekrar);
            grpSifreGuncelleme.Controls.Add(label4);
            grpSifreGuncelleme.Controls.Add(txtYeniSifre);
            grpSifreGuncelleme.Controls.Add(label3);
            grpSifreGuncelleme.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            grpSifreGuncelleme.Location = new Point(381, 353);
            grpSifreGuncelleme.Name = "grpSifreGuncelleme";
            grpSifreGuncelleme.Size = new Size(503, 239);
            grpSifreGuncelleme.TabIndex = 0;
            grpSifreGuncelleme.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.ForeColor = SystemColors.ButtonHighlight;
            lblKullaniciAdi.Location = new Point(226, 38);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(0, 25);
            lblKullaniciAdi.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(52, 38);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 3;
            label5.Text = "Kullanıcı Adı";
            // 
            // btnSifreyiGuncelle
            // 
            btnSifreyiGuncelle.BackColor = Color.FromArgb(164, 172, 134);
            btnSifreyiGuncelle.FlatStyle = FlatStyle.Popup;
            btnSifreyiGuncelle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSifreyiGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            btnSifreyiGuncelle.Location = new Point(226, 167);
            btnSifreyiGuncelle.Name = "btnSifreyiGuncelle";
            btnSifreyiGuncelle.Size = new Size(166, 40);
            btnSifreyiGuncelle.TabIndex = 2;
            btnSifreyiGuncelle.Text = "Şifreyi Güncelle";
            btnSifreyiGuncelle.UseVisualStyleBackColor = false;
            btnSifreyiGuncelle.Click += btnSifreyiGuncelle_Click;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(226, 112);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(166, 31);
            txtYeniSifreTekrar.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(52, 114);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 0;
            label4.Text = "Yeni Şifre (Tekrar)";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(226, 72);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(166, 31);
            txtYeniSifre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(52, 76);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 0;
            label3.Text = "Yeni Şifre";
            // 
            // grpSifirlamaKodu
            // 
            grpSifirlamaKodu.Controls.Add(mtxtSifirlamaKodu);
            grpSifirlamaKodu.Controls.Add(btnOk);
            grpSifirlamaKodu.Controls.Add(label1);
            grpSifirlamaKodu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            grpSifirlamaKodu.Location = new Point(381, 226);
            grpSifirlamaKodu.Name = "grpSifirlamaKodu";
            grpSifirlamaKodu.Size = new Size(503, 121);
            grpSifirlamaKodu.TabIndex = 0;
            grpSifirlamaKodu.TabStop = false;
            // 
            // mtxtSifirlamaKodu
            // 
            mtxtSifirlamaKodu.Location = new Point(171, 49);
            mtxtSifirlamaKodu.Mask = "0000";
            mtxtSifirlamaKodu.Name = "mtxtSifirlamaKodu";
            mtxtSifirlamaKodu.Size = new Size(121, 31);
            mtxtSifirlamaKodu.TabIndex = 3;
            mtxtSifirlamaKodu.ValidatingType = typeof(int);
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(164, 172, 134);
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnOk.ForeColor = SystemColors.ActiveCaptionText;
            btnOk.Location = new Point(328, 44);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(102, 34);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 52);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Sıfırlama Kodu";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(2, 3);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(57, 41);
            btnGeri.TabIndex = 30;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // SifremiUnuttumEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(btnGeri);
            Controls.Add(grpSifirlamaKodu);
            Controls.Add(grpSifreGuncelleme);
            Controls.Add(grpSifirlamaKoduGonder);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "SifremiUnuttumEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SifremiUnuttumEkrani";
            Load += SifremiUnuttumEkrani_Load;
            grpSifirlamaKoduGonder.ResumeLayout(false);
            grpSifirlamaKoduGonder.PerformLayout();
            grpSifreGuncelleme.ResumeLayout(false);
            grpSifreGuncelleme.PerformLayout();
            grpSifirlamaKodu.ResumeLayout(false);
            grpSifirlamaKodu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSifirlamaKoduGonder;
        private TextBox txtEmail;
        private Label label2;
        private Button btnSifirlamaKoduGonder;
        private GroupBox grpSifirlamaKodu;
        private MaskedTextBox mtxtSifirlamaKodu;
        private Button btnOk;
        private Label label1;
        private GroupBox grpSifreGuncelleme;
        private Button btnSifreyiGuncelle;
        private TextBox txtYeniSifreTekrar;
        private Label label4;
        private TextBox txtYeniSifre;
        private Label label3;
        private Button btnGeri;
        private Label lblKullaniciAdi;
        private Label label5;
    }
}