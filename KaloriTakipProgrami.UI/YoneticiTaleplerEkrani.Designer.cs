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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiTaleplerEkrani));
            dgvTalepler = new DataGridView();
            btnOnayla = new Button();
            btnReddedildi = new Button();
            btnGeri = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).BeginInit();
            SuspendLayout();
            // 
            // dgvTalepler
            // 
            dgvTalepler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalepler.Location = new Point(93, 154);
            dgvTalepler.Margin = new Padding(3, 4, 3, 4);
            dgvTalepler.Name = "dgvTalepler";
            dgvTalepler.RowHeadersWidth = 51;
            dgvTalepler.Size = new Size(1106, 502);
            dgvTalepler.TabIndex = 0;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(164, 172, 134);
            btnOnayla.FlatStyle = FlatStyle.Popup;
            btnOnayla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOnayla.Location = new Point(960, 664);
            btnOnayla.Margin = new Padding(3, 4, 3, 4);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(114, 56);
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
            btnReddedildi.Location = new Point(1080, 664);
            btnReddedildi.Margin = new Padding(3, 4, 3, 4);
            btnReddedildi.Name = "btnReddedildi";
            btnReddedildi.Size = new Size(119, 56);
            btnReddedildi.TabIndex = 1;
            btnReddedildi.Text = "Reddet";
            btnReddedildi.UseVisualStyleBackColor = false;
            btnReddedildi.Click += btnReddedildi_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(3, 4);
            btnGeri.Margin = new Padding(3, 4, 3, 4);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(57, 41);
            btnGeri.TabIndex = 29;
            btnGeri.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(93, 84);
            label1.Name = "label1";
            label1.Size = new Size(390, 55);
            label1.TabIndex = 31;
            label1.Text = "GELEN TALEPLER";
            // 
            // YoneticiTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(label1);
            Controls.Add(btnGeri);
            Controls.Add(btnReddedildi);
            Controls.Add(btnOnayla);
            Controls.Add(dgvTalepler);
            MaximizeBox = false;
            Name = "YoneticiTaleplerEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiTaleplerEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTalepler;
        private Button btnOnayla;
        private Button btnReddedildi;
        private Button btnGeri;
        private Label label1;
    }
}