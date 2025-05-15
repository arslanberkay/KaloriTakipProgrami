namespace KaloriTakipProgrami.UI
{
    partial class YoneticiTaleplerEkrani
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
            dgvTalepler = new DataGridView();
            btnOnayla = new Button();
            btnReddedildi = new Button();
            btnGeri = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).BeginInit();
            SuspendLayout();
            // 
            // dgvTalepler
            // 
            dgvTalepler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalepler.Location = new Point(93, 73);
            dgvTalepler.Name = "dgvTalepler";
            dgvTalepler.RowHeadersWidth = 51;
            dgvTalepler.Size = new Size(685, 226);
            dgvTalepler.TabIndex = 0;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(164, 172, 134);
            btnOnayla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOnayla.Location = new Point(147, 326);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(100, 42);
            btnOnayla.TabIndex = 30;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click_1;
            // 
            // btnReddedildi
            // 
            btnReddedildi.BackColor = Color.FromArgb(164, 172, 134);
            btnReddedildi.FlatStyle = FlatStyle.Popup;
            btnReddedildi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReddedildi.Location = new Point(555, 326);
            btnReddedildi.Name = "btnReddedildi";
            btnReddedildi.Size = new Size(104, 42);
            btnReddedildi.TabIndex = 1;
            btnReddedildi.Text = "Reddedildi";
            btnReddedildi.UseVisualStyleBackColor = false;
            btnReddedildi.Click += btnReddedildi_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(164, 172, 134);
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(12, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(77, 33);
            btnGeri.TabIndex = 29;
            btnGeri.Text = "< GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // YoneticiTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(806, 402);
            Controls.Add(btnGeri);
            Controls.Add(btnReddedildi);
            Controls.Add(btnOnayla);
            Controls.Add(dgvTalepler);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "YoneticiTaleplerEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiTaleplerEkrani";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTalepler;
        private Button btnOnayla;
        private Button btnReddedildi;
        private Button btnGeri;
    }
}