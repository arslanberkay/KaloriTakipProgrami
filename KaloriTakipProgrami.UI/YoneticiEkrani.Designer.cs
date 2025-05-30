﻿namespace KaloriTakipProgrami.UI
{
    partial class YoneticiEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiEkrani));
            groupBox1 = new GroupBox();
            btnKullaniciGunlukRaporu = new Button();
            btnTalepler = new Button();
            btnOgunlerKategorilerYemekler = new Button();
            btnKullanicilar = new Button();
            btnCikis = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKullaniciGunlukRaporu);
            groupBox1.Controls.Add(btnTalepler);
            groupBox1.Controls.Add(btnOgunlerKategorilerYemekler);
            groupBox1.Controls.Add(btnKullanicilar);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            groupBox1.Location = new Point(405, 140);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(451, 482);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnKullaniciGunlukRaporu
            // 
            btnKullaniciGunlukRaporu.BackColor = Color.FromArgb(164, 172, 134);
            btnKullaniciGunlukRaporu.FlatStyle = FlatStyle.Popup;
            btnKullaniciGunlukRaporu.Location = new Point(90, 261);
            btnKullaniciGunlukRaporu.Name = "btnKullaniciGunlukRaporu";
            btnKullaniciGunlukRaporu.Size = new Size(242, 76);
            btnKullaniciGunlukRaporu.TabIndex = 0;
            btnKullaniciGunlukRaporu.Text = "Kullanıcı Günlük Raporu";
            btnKullaniciGunlukRaporu.UseVisualStyleBackColor = false;
            btnKullaniciGunlukRaporu.Click += btnKullaniciGunlukRaporu_Click;
            // 
            // btnTalepler
            // 
            btnTalepler.BackColor = Color.FromArgb(164, 172, 134);
            btnTalepler.FlatStyle = FlatStyle.Popup;
            btnTalepler.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnTalepler.Location = new Point(90, 365);
            btnTalepler.Name = "btnTalepler";
            btnTalepler.Size = new Size(242, 59);
            btnTalepler.TabIndex = 1;
            btnTalepler.Text = "Talepler";
            btnTalepler.UseVisualStyleBackColor = false;
            btnTalepler.Click += btnTalepler_Click;
            // 
            // btnOgunlerKategorilerYemekler
            // 
            btnOgunlerKategorilerYemekler.BackColor = Color.FromArgb(164, 172, 134);
            btnOgunlerKategorilerYemekler.FlatStyle = FlatStyle.Popup;
            btnOgunlerKategorilerYemekler.Location = new Point(90, 150);
            btnOgunlerKategorilerYemekler.Name = "btnOgunlerKategorilerYemekler";
            btnOgunlerKategorilerYemekler.Size = new Size(242, 88);
            btnOgunlerKategorilerYemekler.TabIndex = 0;
            btnOgunlerKategorilerYemekler.Text = "Öğünler\r\nKategoriler \r\nYemekler";
            btnOgunlerKategorilerYemekler.UseVisualStyleBackColor = false;
            btnOgunlerKategorilerYemekler.Click += btnOgunlerKategorilerYemekler_Click;
            // 
            // btnKullanicilar
            // 
            btnKullanicilar.BackColor = Color.FromArgb(164, 172, 134);
            btnKullanicilar.FlatStyle = FlatStyle.Popup;
            btnKullanicilar.Location = new Point(90, 57);
            btnKullanicilar.Name = "btnKullanicilar";
            btnKullanicilar.Size = new Size(242, 72);
            btnKullanicilar.TabIndex = 0;
            btnKullanicilar.Text = "Kullanıcılar";
            btnKullanicilar.UseVisualStyleBackColor = false;
            btnKullanicilar.Click += btnKullanicilar_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(47, 62, 70);
            btnCikis.BackgroundImage = (Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.FlatStyle = FlatStyle.Popup;
            btnCikis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCikis.Location = new Point(1218, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(52, 48);
            btnCikis.TabIndex = 32;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // YoneticiEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(btnCikis);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "YoneticiEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiEkrani";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnKullaniciGunlukRaporu;
        private Button btnOgunlerKategorilerYemekler;
        private Button btnKullanicilar;
        private Button btnTalepler;
        private Button btnCikis;
    }
}