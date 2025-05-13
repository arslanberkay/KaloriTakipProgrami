namespace KaloriTakipProgrami.UI
{
    partial class KullaniciGirisEkrani
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
            chkSifreGoster = new CheckBox();
            lnkKayitOl = new LinkLabel();
            lnkSifremiUnuttum = new LinkLabel();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(170, 227, 193);
            groupBox1.Controls.Add(chkSifreGoster);
            groupBox1.Controls.Add(lnkKayitOl);
            groupBox1.Controls.Add(lnkSifremiUnuttum);
            groupBox1.Controls.Add(btnGirisYap);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 497);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chkSifreGoster.ForeColor = Color.FromArgb(50, 52, 79);
            chkSifreGoster.Location = new Point(127, 235);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(147, 29);
            chkSifreGoster.TabIndex = 5;
            chkSifreGoster.Text = "Şifreyi Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // lnkKayitOl
            // 
            lnkKayitOl.AutoSize = true;
            lnkKayitOl.BackColor = Color.FromArgb(170, 227, 193);
            lnkKayitOl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lnkKayitOl.LinkColor = Color.FromArgb(50, 52, 79);
            lnkKayitOl.Location = new Point(290, 406);
            lnkKayitOl.Name = "lnkKayitOl";
            lnkKayitOl.Size = new Size(77, 25);
            lnkKayitOl.TabIndex = 4;
            lnkKayitOl.TabStop = true;
            lnkKayitOl.Text = "Kayıt Ol";
            lnkKayitOl.LinkClicked += lnkKayitOl_LinkClicked;
            // 
            // lnkSifremiUnuttum
            // 
            lnkSifremiUnuttum.AutoSize = true;
            lnkSifremiUnuttum.BackColor = Color.FromArgb(170, 227, 193);
            lnkSifremiUnuttum.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lnkSifremiUnuttum.LinkColor = Color.FromArgb(50, 52, 79);
            lnkSifremiUnuttum.Location = new Point(43, 406);
            lnkSifremiUnuttum.Name = "lnkSifremiUnuttum";
            lnkSifremiUnuttum.Size = new Size(152, 25);
            lnkSifremiUnuttum.TabIndex = 3;
            lnkSifremiUnuttum.TabStop = true;
            lnkSifremiUnuttum.Text = "Şifremi Unuttum";
            lnkSifremiUnuttum.LinkClicked += lnkSifremiUnuttum_LinkClicked;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(96, 158, 124);
            btnGirisYap.FlatStyle = FlatStyle.Popup;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.ForeColor = Color.FromArgb(50, 52, 79);
            btnGirisYap.Location = new Point(127, 307);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(186, 45);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(127, 197);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(186, 32);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(127, 109);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(186, 32);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(50, 52, 79);
            label2.Location = new Point(127, 169);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(170, 227, 193);
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(50, 52, 79);
            label1.Location = new Point(127, 77);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı ";
            // 
            // KullaniciGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 244, 242);
            ClientSize = new Size(491, 487);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "KullaniciGirisEkrani";
            Text = "KullaniciGirisEkrani";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkSifreGoster;
        private LinkLabel lnkKayitOl;
        private LinkLabel lnkSifremiUnuttum;
        private Button btnGirisYap;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
    }
}