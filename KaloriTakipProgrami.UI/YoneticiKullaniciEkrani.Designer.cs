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
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(46, 63);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.RowHeadersWidth = 51;
            dgvKullanicilar.Size = new Size(686, 330);
            dgvKullanicilar.TabIndex = 0;
            // 
            // YoneticiKullaniciEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKullanicilar);
            Name = "YoneticiKullaniciEkrani";
            Text = "YoneticiKullaniciEkrani";
            WindowState = FormWindowState.Maximized;
            Load += YoneticiKullaniciEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKullanicilar;
    }
}