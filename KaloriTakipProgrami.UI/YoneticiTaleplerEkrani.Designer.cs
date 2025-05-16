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
            btnTümü = new Button();
            btnOnaylanmis = new Button();
            btnReddedilmis = new Button();
            btnOkunmamis = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).BeginInit();
            SuspendLayout();
            // 
            // dgvTalepler
            // 
            dgvTalepler.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvTalepler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalepler.Location = new Point(80, 192);
            dgvTalepler.Margin = new Padding(4, 5, 4, 5);
            dgvTalepler.Name = "dgvTalepler";
            dgvTalepler.RowHeadersWidth = 51;
            dgvTalepler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTalepler.Size = new Size(1117, 452);
            dgvTalepler.TabIndex = 0;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(164, 172, 134);
            btnOnayla.FlatStyle = FlatStyle.Popup;
            btnOnayla.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnOnayla.Location = new Point(914, 654);
            btnOnayla.Margin = new Padding(4, 5, 4, 5);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(134, 47);
            btnOnayla.TabIndex = 30;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click_1;
            // 
            // btnReddedildi
            // 
            btnReddedildi.BackColor = Color.FromArgb(164, 172, 134);
            btnReddedildi.FlatStyle = FlatStyle.Popup;
            btnReddedildi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnReddedildi.Location = new Point(1056, 654);
            btnReddedildi.Margin = new Padding(4, 5, 4, 5);
            btnReddedildi.Name = "btnReddedildi";
            btnReddedildi.Size = new Size(142, 47);
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
            btnGeri.Location = new Point(4, 5);
            btnGeri.Margin = new Padding(4, 5, 4, 5);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(71, 51);
            btnGeri.TabIndex = 29;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(80, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(488, 69);
            label1.TabIndex = 31;
            label1.Text = "GELEN TALEPLER";
            // 
            // btnTümü
            // 
            btnTümü.BackColor = Color.FromArgb(164, 172, 134);
            btnTümü.FlatStyle = FlatStyle.Popup;
            btnTümü.Location = new Point(80, 138);
            btnTümü.Name = "btnTümü";
            btnTümü.Size = new Size(132, 46);
            btnTümü.TabIndex = 32;
            btnTümü.Text = "Tümü";
            btnTümü.UseVisualStyleBackColor = false;
            btnTümü.Click += btnTümü_Click;
            // 
            // btnOnaylanmis
            // 
            btnOnaylanmis.BackColor = Color.FromArgb(164, 172, 134);
            btnOnaylanmis.FlatStyle = FlatStyle.Popup;
            btnOnaylanmis.Location = new Point(455, 138);
            btnOnaylanmis.Name = "btnOnaylanmis";
            btnOnaylanmis.Size = new Size(238, 46);
            btnOnaylanmis.TabIndex = 32;
            btnOnaylanmis.Text = "Onaylanmış Talepler";
            btnOnaylanmis.UseVisualStyleBackColor = false;
            btnOnaylanmis.Click += btnOnaylanmis_Click;
            // 
            // btnReddedilmis
            // 
            btnReddedilmis.BackColor = Color.FromArgb(164, 172, 134);
            btnReddedilmis.FlatStyle = FlatStyle.Popup;
            btnReddedilmis.Location = new Point(705, 138);
            btnReddedilmis.Name = "btnReddedilmis";
            btnReddedilmis.Size = new Size(246, 46);
            btnReddedilmis.TabIndex = 32;
            btnReddedilmis.Text = "Reddedilmiş Talepler";
            btnReddedilmis.UseVisualStyleBackColor = false;
            btnReddedilmis.Click += btnReddedilmis_Click;
            // 
            // btnOkunmamis
            // 
            btnOkunmamis.BackColor = Color.FromArgb(164, 172, 134);
            btnOkunmamis.FlatStyle = FlatStyle.Popup;
            btnOkunmamis.Location = new Point(224, 138);
            btnOkunmamis.Name = "btnOkunmamis";
            btnOkunmamis.Size = new Size(219, 46);
            btnOkunmamis.TabIndex = 32;
            btnOkunmamis.Text = "Okunmamış";
            btnOkunmamis.UseVisualStyleBackColor = false;
            btnOkunmamis.Click += btnOkunmamis_Click;
            // 
            // YoneticiTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(btnReddedilmis);
            Controls.Add(btnOkunmamis);
            Controls.Add(btnOnaylanmis);
            Controls.Add(btnTümü);
            Controls.Add(label1);
            Controls.Add(btnGeri);
            Controls.Add(btnReddedildi);
            Controls.Add(btnOnayla);
            Controls.Add(dgvTalepler);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
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
        private Button btnTümü;
        private Button btnOnaylanmis;
        private Button btnReddedilmis;
        private Button btnOkunmamis;
    }
}