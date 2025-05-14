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
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtEmail = new TextBox();
            btnSifirlamaKoduGonder = new Button();
            groupBox2 = new GroupBox();
            btnOk = new Button();
            label1 = new Label();
            mtxtSifirlamaKodu = new MaskedTextBox();
            groupBox3 = new GroupBox();
            btnSifreyiGuncelle = new Button();
            txtYeniSifre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtYeniSifreTekrar = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSifirlamaKoduGonder);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(241, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 47);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 32);
            txtEmail.TabIndex = 1;
            // 
            // btnSifirlamaKoduGonder
            // 
            btnSifirlamaKoduGonder.Location = new Point(21, 85);
            btnSifirlamaKoduGonder.Name = "btnSifirlamaKoduGonder";
            btnSifirlamaKoduGonder.Size = new Size(266, 38);
            btnSifirlamaKoduGonder.TabIndex = 2;
            btnSifirlamaKoduGonder.Text = "Sıfırlama Kodu Gönder";
            btnSifirlamaKoduGonder.UseVisualStyleBackColor = true;
            btnSifirlamaKoduGonder.Click += btnSifirlamaKoduGonder_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mtxtSifirlamaKodu);
            groupBox2.Controls.Add(btnOk);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(241, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(409, 107);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(327, 42);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(76, 34);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Sıfırlama Kodu";
            // 
            // mtxtSifirlamaKodu
            // 
            mtxtSifirlamaKodu.Location = new Point(182, 44);
            mtxtSifirlamaKodu.Name = "mtxtSifirlamaKodu";
            mtxtSifirlamaKodu.Size = new Size(121, 32);
            mtxtSifirlamaKodu.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSifreyiGuncelle);
            groupBox3.Controls.Add(txtYeniSifreTekrar);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtYeniSifre);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(241, 305);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 199);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // btnSifreyiGuncelle
            // 
            btnSifreyiGuncelle.Location = new Point(31, 133);
            btnSifreyiGuncelle.Name = "btnSifreyiGuncelle";
            btnSifreyiGuncelle.Size = new Size(330, 38);
            btnSifreyiGuncelle.TabIndex = 2;
            btnSifreyiGuncelle.Text = "Şifreyi Güncelle";
            btnSifreyiGuncelle.UseVisualStyleBackColor = true;
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
            label3.Location = new Point(31, 47);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 0;
            label3.Text = "Yeni Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 85);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 0;
            label4.Text = "Yeni Şifre (Tekrar)";
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(195, 82);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(166, 32);
            txtYeniSifreTekrar.TabIndex = 1;
            // 
            // SifremiUnuttumEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 634);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "SifremiUnuttumEkrani";
            Text = "SifremiUnuttumEkrani";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtEmail;
        private Label label2;
        private Button btnSifirlamaKoduGonder;
        private GroupBox groupBox2;
        private MaskedTextBox mtxtSifirlamaKodu;
        private Button btnOk;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnSifreyiGuncelle;
        private TextBox txtYeniSifreTekrar;
        private Label label4;
        private TextBox txtYeniSifre;
        private Label label3;
    }
}