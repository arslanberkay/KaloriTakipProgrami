namespace KaloriTakipProgrami.UI
{
    partial class KullaniciKayitOlEkrani
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
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label3 = new Label();
            txtSifreTekrar = new TextBox();
            label4 = new Label();
            txtAd = new TextBox();
            label5 = new Label();
            txtSoyad = new TextBox();
            label6 = new Label();
            mtxtDogumTarihi = new MaskedTextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            cbCinsiyet = new ComboBox();
            label9 = new Label();
            txtFotograf = new TextBox();
            btnFotografSec = new Button();
            btnKayitOl = new Button();
            pbFotograf = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFotografSec);
            groupBox1.Controls.Add(cbCinsiyet);
            groupBox1.Controls.Add(mtxtDogumTarihi);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFotograf);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSifreTekrar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(87, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 462);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt Ol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 63);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(182, 60);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(170, 32);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 105);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(182, 103);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(170, 32);
            txtSifre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 147);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 0;
            label3.Text = "Şifre (Tekrar)";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(182, 146);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(170, 32);
            txtSifreTekrar.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 189);
            label4.Name = "label4";
            label4.Size = new Size(35, 25);
            label4.TabIndex = 0;
            label4.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(182, 189);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(170, 32);
            txtAd.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 231);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 0;
            label5.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(182, 232);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(170, 32);
            txtSoyad.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 273);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 0;
            label6.Text = "Doğum Tarihi";
            // 
            // mtxtDogumTarihi
            // 
            mtxtDogumTarihi.Location = new Point(182, 275);
            mtxtDogumTarihi.Mask = "00/00/0000";
            mtxtDogumTarihi.Name = "mtxtDogumTarihi";
            mtxtDogumTarihi.Size = new Size(206, 32);
            mtxtDogumTarihi.TabIndex = 2;
            mtxtDogumTarihi.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 315);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 318);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 32);
            txtEmail.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 357);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 0;
            label8.Text = "Cinsiyet";
            // 
            // cbCinsiyet
            // 
            cbCinsiyet.FormattingEnabled = true;
            cbCinsiyet.Location = new Point(182, 361);
            cbCinsiyet.Name = "cbCinsiyet";
            cbCinsiyet.Size = new Size(180, 33);
            cbCinsiyet.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 399);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 0;
            label9.Text = "Fotoğraf ";
            // 
            // txtFotograf
            // 
            txtFotograf.Location = new Point(182, 400);
            txtFotograf.Name = "txtFotograf";
            txtFotograf.Size = new Size(170, 32);
            txtFotograf.TabIndex = 1;
            // 
            // btnFotografSec
            // 
            btnFotografSec.Location = new Point(358, 400);
            btnFotografSec.Name = "btnFotografSec";
            btnFotografSec.Size = new Size(71, 32);
            btnFotografSec.TabIndex = 4;
            btnFotografSec.Text = "Seç";
            btnFotografSec.UseVisualStyleBackColor = true;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(136, 526);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(379, 67);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            // 
            // pbFotograf
            // 
            pbFotograf.Location = new Point(616, 88);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(292, 228);
            pbFotograf.TabIndex = 6;
            pbFotograf.TabStop = false;
            // 
            // KullaniciKayitOlEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 724);
            Controls.Add(pbFotograf);
            Controls.Add(btnKayitOl);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "KullaniciKayitOlEkrani";
            Text = "KullaniciKayitOlEkrani";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbCinsiyet;
        private MaskedTextBox mtxtDogumTarihi;
        private TextBox txtAd;
        private TextBox txtSifre;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox txtFotograf;
        private TextBox txtEmail;
        private Label label8;
        private Label label9;
        private TextBox txtSoyad;
        private Label label7;
        private Label label5;
        private TextBox txtSifreTekrar;
        private Label label3;
        private TextBox txtKullaniciAdi;
        private Label label1;
        private Button btnFotografSec;
        private Button btnKayitOl;
        private PictureBox pbFotograf;
    }
}