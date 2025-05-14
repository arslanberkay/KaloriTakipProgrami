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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(105, 151);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Mesaj";
            // 
            // txtKonu
            // 
            txtKonu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtKonu.Location = new Point(198, 95);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(822, 31);
            txtKonu.TabIndex = 1;
            // 
            // txtMesaj
            // 
            txtMesaj.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtMesaj.Location = new Point(203, 151);
            txtMesaj.Multiline = true;
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(817, 483);
            txtMesaj.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(105, 96);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 0;
            label2.Text = "Konu";
            // 
            // btnGönder
            // 
            btnGönder.BackColor = Color.FromArgb(164, 172, 134);
            btnGönder.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnGönder.Location = new Point(827, 661);
            btnGönder.Name = "btnGönder";
            btnGönder.Size = new Size(193, 46);
            btnGönder.TabIndex = 3;
            btnGönder.Text = "Gönder";
            btnGönder.UseVisualStyleBackColor = false;
            btnGönder.Click += btnGönder_Click;
            // 
            // KullaniciTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1224, 770);
            Controls.Add(btnGönder);
            Controls.Add(txtMesaj);
            Controls.Add(txtKonu);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}