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
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).BeginInit();
            SuspendLayout();
            // 
            // dgvTalepler
            // 
            dgvTalepler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalepler.Location = new Point(81, 127);
            dgvTalepler.Name = "dgvTalepler";
            dgvTalepler.RowHeadersWidth = 51;
            dgvTalepler.Size = new Size(685, 226);
            dgvTalepler.TabIndex = 0;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(164, 172, 134);
            btnOnayla.FlatStyle = FlatStyle.Popup;
            btnOnayla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOnayla.Location = new Point(242, 379);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(132, 54);
            btnOnayla.TabIndex = 1;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnReddedildi
            // 
            btnReddedildi.BackColor = Color.FromArgb(164, 172, 134);
            btnReddedildi.FlatStyle = FlatStyle.Popup;
            btnReddedildi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnReddedildi.Location = new Point(455, 379);
            btnReddedildi.Name = "btnReddedildi";
            btnReddedildi.Size = new Size(144, 54);
            btnReddedildi.TabIndex = 1;
            btnReddedildi.Text = "Reddet";
            btnReddedildi.UseVisualStyleBackColor = false;
            btnReddedildi.Click += btnReddedildi_Click;
            // 
            // YoneticiTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(865, 543);
            Controls.Add(btnReddedildi);
            Controls.Add(btnOnayla);
            Controls.Add(dgvTalepler);
            Name = "YoneticiTaleplerEkrani";
            Text = "YoneticiTaleplerEkrani";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTalepler;
        private Button btnOnayla;
        private Button btnReddedildi;
    }
}