namespace KaloriTakipProgrami.UI
{
    partial class YoneticiKullaniciEkrani
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
            dgvKullanicilar = new DataGridView();
            btnGeri = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(40, 47);
            dgvKullanicilar.Margin = new Padding(3, 2, 3, 2);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.RowHeadersWidth = 51;

            dgvKullanicilar.Size = new Size(600, 248);

            dgvKullanicilar.TabIndex = 0;
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
            // YoneticiKullaniciEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);

            ClientSize = new Size(700, 338);
            Controls.Add(btnGeri);

            Controls.Add(dgvKullanicilar);

            MaximizeBox = false;

            Margin = new Padding(3, 2, 3, 2);

            Name = "YoneticiKullaniciEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiKullaniciEkrani";
            Load += YoneticiKullaniciEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKullanicilar;
        private Button btnGeri;
    }
}