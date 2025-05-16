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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciTaleplerEkrani));
            label1 = new Label();
            txtKonu = new TextBox();
            txtMesaj = new TextBox();
            label2 = new Label();
            btnGönder = new Button();
            btnGeri = new Button();
            label3 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(137, 244);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Mesaj";
            // 
            // txtKonu
            // 
            txtKonu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtKonu.Location = new Point(215, 188);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(877, 31);
            txtKonu.TabIndex = 1;
            // 
            // txtMesaj
            // 
            txtMesaj.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtMesaj.Location = new Point(215, 244);
            txtMesaj.Multiline = true;
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(877, 293);
            txtMesaj.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(137, 187);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 0;
            label2.Text = "Konu";
            // 
            // btnGönder
            // 
            btnGönder.BackColor = Color.FromArgb(164, 172, 134);
            btnGönder.FlatStyle = FlatStyle.Popup;
            btnGönder.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnGönder.Location = new Point(984, 554);
            btnGönder.Name = "btnGönder";
            btnGönder.Size = new Size(108, 39);
            btnGönder.TabIndex = 3;
            btnGönder.Text = "Gönder";
            btnGönder.UseVisualStyleBackColor = false;
            btnGönder.Click += btnGönder_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(2, 3);
            btnGeri.Margin = new Padding(3, 4, 3, 4);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(57, 41);
            btnGeri.TabIndex = 30;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(215, 1);
            label3.Name = "label3";
            label3.Size = new Size(221, 61);
            label3.TabIndex = 31;
            label3.Text = "TALEPLER";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(186, 199, 167);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 65);
            panel1.TabIndex = 32;
            // 
            // KullaniciTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(panel1);
            Controls.Add(btnGeri);
            Controls.Add(btnGönder);
            Controls.Add(txtMesaj);
            Controls.Add(txtKonu);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "KullaniciTaleplerEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciTaleplerEkrani";
            panel1.ResumeLayout(false);
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
        private Label label3;
        private Panel panel1;
    }
}