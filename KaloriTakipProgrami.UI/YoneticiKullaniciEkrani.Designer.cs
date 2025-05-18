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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiKullaniciEkrani));
            btnGeri = new Button();
            label1 = new Label();
            lstvKullanicilar = new ListView();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(3, 3);
            btnGeri.Margin = new Padding(4, 6, 4, 6);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(78, 57);
            btnGeri.TabIndex = 30;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(61, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(660, 76);
            label1.TabIndex = 31;
            label1.Text = "KULLANICI BİLGİLERİ";
            // 
            // lstvKullanicilar
            // 
            lstvKullanicilar.BackColor = Color.FromArgb(202, 210, 197);
            lstvKullanicilar.Location = new Point(79, 182);
            lstvKullanicilar.Name = "lstvKullanicilar";
            lstvKullanicilar.Size = new Size(1122, 487);
            lstvKullanicilar.TabIndex = 32;
            lstvKullanicilar.UseCompatibleStateImageBehavior = false;
            // 
            // YoneticiKullaniciEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(lstvKullanicilar);
            Controls.Add(label1);
            Controls.Add(btnGeri);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "YoneticiKullaniciEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiKullaniciEkrani";
            Load += YoneticiKullaniciEkrani_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnGeri;
        private Label label1;
        private ListView lstvKullanicilar;
    }
}