namespace KaloriTakipProgrami.UI
{
    partial class KullaniciTaleplerimEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciTaleplerimEkrani));
            lstvTalepler = new ListView();
            label3 = new Label();
            btnGeri = new Button();
            btnYeniTalep = new Button();
            SuspendLayout();
            // 
            // lstvTalepler
            // 
            lstvTalepler.BackColor = Color.FromArgb(202, 210, 197);
            lstvTalepler.Location = new Point(101, 197);
            lstvTalepler.Name = "lstvTalepler";
            lstvTalepler.Size = new Size(1085, 487);
            lstvTalepler.TabIndex = 0;
            lstvTalepler.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(101, 66);
            label3.Name = "label3";
            label3.Size = new Size(286, 61);
            label3.TabIndex = 32;
            label3.Text = "TALEPLERİM";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(-1, 0);
            btnGeri.Margin = new Padding(3, 4, 3, 4);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(57, 41);
            btnGeri.TabIndex = 33;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnYeniTalep
            // 
            btnYeniTalep.BackColor = Color.FromArgb(164, 172, 134);
            btnYeniTalep.FlatStyle = FlatStyle.Popup;
            btnYeniTalep.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnYeniTalep.Location = new Point(961, 141);
            btnYeniTalep.Name = "btnYeniTalep";
            btnYeniTalep.Size = new Size(225, 50);
            btnYeniTalep.TabIndex = 34;
            btnYeniTalep.Text = "Yeni Talep";
            btnYeniTalep.UseVisualStyleBackColor = false;
            btnYeniTalep.Click += btnYeniTalep_Click;
            // 
            // KullaniciTaleplerimEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(btnYeniTalep);
            Controls.Add(btnGeri);
            Controls.Add(label3);
            Controls.Add(lstvTalepler);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "KullaniciTaleplerimEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciTaleplerimEkrani";
            Load += KullaniciTaleplerimEkrani_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstvTalepler;
        private Label label3;
        private Button btnGeri;
        private Button btnYeniTalep;
    }
}