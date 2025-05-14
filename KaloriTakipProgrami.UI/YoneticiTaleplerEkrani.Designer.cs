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

            btnGeri = new Button();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(164, 172, 134);
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(12, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 29;
            btnGeri.Text = "<<< GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;

            dgvTalepler = new DataGridView();
            btnEkle = new Button();
            btnReddedildi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).BeginInit();
            SuspendLayout();
            // 
            // dgvTalepler
            // 
            dgvTalepler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalepler.Location = new Point(126, 72);
            dgvTalepler.Name = "dgvTalepler";
            dgvTalepler.RowHeadersWidth = 51;
            dgvTalepler.Size = new Size(685, 226);
            dgvTalepler.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(226, 355);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Onaylandı";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnReddedildi
            // 
            btnReddedildi.Location = new Point(679, 355);
            btnReddedildi.Name = "btnReddedildi";
            btnReddedildi.Size = new Size(94, 29);
            btnReddedildi.TabIndex = 1;
            btnReddedildi.Text = "Reddedildi";
            btnReddedildi.UseVisualStyleBackColor = true;

            // 
            // YoneticiTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);

            ClientSize = new Size(700, 338);
            Controls.Add(btnGeri);
            Margin = new Padding(3, 2, 3, 2);

            ClientSize = new Size(1266, 738);
            Controls.Add(btnReddedildi);
            Controls.Add(btnEkle);
            Controls.Add(dgvTalepler);

            Name = "YoneticiTaleplerEkrani";
            Text = "YoneticiTaleplerEkrani";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Button btnGeri;

        private DataGridView dgvTalepler;
        private Button btnEkle;
        private Button btnReddedildi;

    }
}