namespace KaloriTakipProgrami.UI
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
            grpSifirlamaKoduGonder = new GroupBox();
            btnSifirlamaKoduGonder = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            grpSifirlamaKodu = new GroupBox();
            mtxtSifirlamaKodu = new MaskedTextBox();
            btnOk = new Button();
            label1 = new Label();
            grpSifreGuncelleme = new GroupBox();
            btnSifreyiGuncelle = new Button();
            txtYeniSifreTekrar = new TextBox();
            label4 = new Label();
            txtYeniSifre = new TextBox();
            label3 = new Label();
            grpSifirlamaKoduGonder.SuspendLayout();
            grpSifirlamaKodu.SuspendLayout();
            grpSifreGuncelleme.SuspendLayout();
            SuspendLayout();
            // 
            // grpSifirlamaKoduGonder
            // 
            grpSifirlamaKoduGonder.Controls.Add(btnSifirlamaKoduGonder);
            grpSifirlamaKoduGonder.Controls.Add(txtEmail);
            grpSifirlamaKoduGonder.Controls.Add(label2);
            grpSifirlamaKoduGonder.Location = new Point(241, 30);
            grpSifirlamaKoduGonder.Name = "grpSifirlamaKoduGonder";
            grpSifirlamaKoduGonder.Size = new Size(346, 145);
            grpSifirlamaKoduGonder.TabIndex = 0;
            grpSifirlamaKoduGonder.TabStop = false;
            // 
            // btnSifirlamaKoduGonder
            // 
            btnSifirlamaKoduGonder.BackColor = Color.FromArgb(164, 172, 134);
            btnSifirlamaKoduGonder.Location = new Point(21, 85);
            btnSifirlamaKoduGonder.Name = "btnSifirlamaKoduGonder";
            btnSifirlamaKoduGonder.Size = new Size(266, 38);
            btnSifirlamaKoduGonder.TabIndex = 2;
            btnSifirlamaKoduGonder.Text = "Sıfırlama Kodu Gönder";
            btnSifirlamaKoduGonder.UseVisualStyleBackColor = false;
            btnSifirlamaKoduGonder.Click += btnSifirlamaKoduGonder_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 32);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(31, 47);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // grpSifirlamaKodu
            // 
            grpSifirlamaKodu.Controls.Add(mtxtSifirlamaKodu);
            grpSifirlamaKodu.Controls.Add(btnOk);
            grpSifirlamaKodu.Controls.Add(label1);
            grpSifirlamaKodu.Location = new Point(241, 181);
            grpSifirlamaKodu.Name = "grpSifirlamaKodu";
            grpSifirlamaKodu.Size = new Size(409, 107);
            grpSifirlamaKodu.TabIndex = 0;
            grpSifirlamaKodu.TabStop = false;
            // 
            // mtxtSifirlamaKodu
            // 
            mtxtSifirlamaKodu.Location = new Point(182, 44);
            mtxtSifirlamaKodu.Name = "mtxtSifirlamaKodu";
            mtxtSifirlamaKodu.Size = new Size(121, 32);
            mtxtSifirlamaKodu.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(164, 172, 134);
            btnOk.Location = new Point(327, 42);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(76, 34);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Sıfırlama Kodu";
            // 
            // grpSifreGuncelleme
            // 
            grpSifreGuncelleme.Controls.Add(btnSifreyiGuncelle);
            grpSifreGuncelleme.Controls.Add(txtYeniSifreTekrar);
            grpSifreGuncelleme.Controls.Add(label4);
            grpSifreGuncelleme.Controls.Add(txtYeniSifre);
            grpSifreGuncelleme.Controls.Add(label3);
            grpSifreGuncelleme.Location = new Point(241, 305);
            grpSifreGuncelleme.Name = "grpSifreGuncelleme";
            grpSifreGuncelleme.Size = new Size(384, 199);
            grpSifreGuncelleme.TabIndex = 0;
            grpSifreGuncelleme.TabStop = false;
            // 
            // btnSifreyiGuncelle
            // 
            btnSifreyiGuncelle.BackColor = Color.FromArgb(164, 172, 134);
            btnSifreyiGuncelle.Location = new Point(31, 133);
            btnSifreyiGuncelle.Name = "btnSifreyiGuncelle";
            btnSifreyiGuncelle.Size = new Size(330, 38);
            btnSifreyiGuncelle.TabIndex = 2;
            btnSifreyiGuncelle.Text = "Şifreyi Güncelle";
            btnSifreyiGuncelle.UseVisualStyleBackColor = false;
            btnSifreyiGuncelle.Click += btnSifreyiGuncelle_Click;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(195, 82);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(166, 32);
            txtYeniSifreTekrar.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(31, 85);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 0;
            label4.Text = "Yeni Şifre (Tekrar)";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(195, 44);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(166, 32);
            txtYeniSifre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(31, 47);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 0;
            label3.Text = "Yeni Şifre";
            // 
            // SifremiUnuttumEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1008, 634);
            Controls.Add(grpSifirlamaKodu);
            Controls.Add(grpSifreGuncelleme);
            Controls.Add(grpSifirlamaKoduGonder);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "SifremiUnuttumEkrani";
            Text = "SifremiUnuttumEkrani";
            WindowState = FormWindowState.Maximized;
            Load += SifremiUnuttumEkrani_Load;
            grpSifirlamaKoduGonder.ResumeLayout(false);
            grpSifirlamaKoduGonder.PerformLayout();
            grpSifirlamaKodu.ResumeLayout(false);
            grpSifirlamaKodu.PerformLayout();
            grpSifreGuncelleme.ResumeLayout(false);
            grpSifreGuncelleme.PerformLayout();
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
    }
}