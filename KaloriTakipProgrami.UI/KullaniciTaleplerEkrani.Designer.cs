namespace KaloriTakipProgrami.UI
{
    partial class KullaniciTaleplerEkrani
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
            txtKonu = new TextBox();
            txtMesaj = new TextBox();
            label2 = new Label();
            btnGönder = new Button();
            btnGeri = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;

            label1.Location = new Point(52, 110);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);

            label1.TabIndex = 0;
            label1.Text = "Mesaj";
            // 
            // txtKonu
            // 

            txtKonu.Location = new Point(106, 67);
            txtKonu.Margin = new Padding(3, 2, 3, 2);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(217, 23);

            txtKonu.TabIndex = 1;
            // 
            // txtMesaj
            // 

            txtMesaj.Location = new Point(110, 109);
            txtMesaj.Margin = new Padding(3, 2, 3, 2);
            txtMesaj.Multiline = true;
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(212, 152);

            txtMesaj.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;

            label2.Location = new Point(52, 67);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);

            label2.TabIndex = 0;
            label2.Text = "Konu";
            // 
            // btnGönder
            // 
            btnGönder.BackColor = Color.FromArgb(164, 172, 134);

            btnGönder.Location = new Point(240, 278);
            btnGönder.Margin = new Padding(3, 2, 3, 2);
            btnGönder.Name = "btnGönder";
            btnGönder.Size = new Size(82, 22);

            btnGönder.TabIndex = 3;
            btnGönder.Text = "Gönder";
            btnGönder.UseVisualStyleBackColor = false;
            btnGönder.Click += btnGönder_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(164, 172, 134);
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(12, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 30;
            btnGeri.Text = "<<< GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // KullaniciTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);

            ClientSize = new Size(380, 322);
            Controls.Add(btnGeri);

            Controls.Add(btnGönder);
            Controls.Add(txtMesaj);
            Controls.Add(txtKonu);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KullaniciTaleplerEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciTaleplerEkrani";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKonu;
        private TextBox txtMesaj;
        private Label label2;
        private Button btnGönder;
        private Button btnGeri;
    }
}