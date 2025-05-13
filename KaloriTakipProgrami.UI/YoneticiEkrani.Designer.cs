namespace KaloriTakipProgrami.UI
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
            groupBox1 = new GroupBox();
            btnKullanicilar = new Button();
            btnOgunlerKategorilerYemekler = new Button();
            btnKullaniciGunlukRaporu = new Button();
            btnTalepler = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKullaniciGunlukRaporu);
            groupBox1.Controls.Add(btnOgunlerKategorilerYemekler);
            groupBox1.Controls.Add(btnKullanicilar);
            groupBox1.Location = new Point(209, 112);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(418, 414);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnKullanicilar
            // 
            btnKullanicilar.Location = new Point(77, 55);
            btnKullanicilar.Name = "btnKullanicilar";
            btnKullanicilar.Size = new Size(242, 77);
            btnKullanicilar.TabIndex = 0;
            btnKullanicilar.Text = "Kullanıcılar";
            btnKullanicilar.UseVisualStyleBackColor = true;
            // 
            // btnOgunlerKategorilerYemekler
            // 
            btnOgunlerKategorilerYemekler.Location = new Point(77, 145);
            btnOgunlerKategorilerYemekler.Name = "btnOgunlerKategorilerYemekler";
            btnOgunlerKategorilerYemekler.Size = new Size(242, 118);
            btnOgunlerKategorilerYemekler.TabIndex = 0;
            btnOgunlerKategorilerYemekler.Text = "Öğünler\r\nKategoriler \r\nYemekler";
            btnOgunlerKategorilerYemekler.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciGunlukRaporu
            // 
            btnKullaniciGunlukRaporu.Location = new Point(77, 276);
            btnKullaniciGunlukRaporu.Name = "btnKullaniciGunlukRaporu";
            btnKullaniciGunlukRaporu.Size = new Size(242, 85);
            btnKullaniciGunlukRaporu.TabIndex = 0;
            btnKullaniciGunlukRaporu.Text = "Kullanıcı Günlük Raporu";
            btnKullaniciGunlukRaporu.UseVisualStyleBackColor = true;
            // 
            // btnTalepler
            // 
            btnTalepler.Location = new Point(708, 12);
            btnTalepler.Name = "btnTalepler";
            btnTalepler.Size = new Size(103, 85);
            btnTalepler.TabIndex = 1;
            btnTalepler.Text = "Talepler";
            btnTalepler.UseVisualStyleBackColor = true;
            // 
            // YoneticiEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 645);
            Controls.Add(btnTalepler);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "YoneticiEkrani";
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
    }
}