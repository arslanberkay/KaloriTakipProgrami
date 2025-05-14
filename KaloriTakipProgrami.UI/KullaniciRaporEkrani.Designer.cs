namespace KaloriTakipProgrami.UI
{
    partial class KullaniciRaporEkrani
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
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnEnCokYenilen = new Button();
            btnAzYenilenler = new Button();
            dgvYemekIstatistikleri = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvYemekIstatistikleri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(642, 45);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Bitiş Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(180, 45);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 1;
            label2.Text = "Başlangıç Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(180, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(406, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dateTimePicker2.Location = new Point(642, 82);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(415, 31);
            dateTimePicker2.TabIndex = 3;
            // 
            // btnEnCokYenilen
            // 
            btnEnCokYenilen.BackColor = Color.FromArgb(164, 172, 134);
            btnEnCokYenilen.FlatStyle = FlatStyle.Popup;
            btnEnCokYenilen.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnEnCokYenilen.Location = new Point(734, 149);
            btnEnCokYenilen.Name = "btnEnCokYenilen";
            btnEnCokYenilen.Size = new Size(240, 47);
            btnEnCokYenilen.TabIndex = 4;
            btnEnCokYenilen.Text = "En Çok Yenilen Yemekler";
            btnEnCokYenilen.UseVisualStyleBackColor = false;
            // 
            // btnAzYenilenler
            // 
            btnAzYenilenler.BackColor = Color.FromArgb(164, 172, 134);
            btnAzYenilenler.FlatStyle = FlatStyle.Popup;
            btnAzYenilenler.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnAzYenilenler.Location = new Point(267, 149);
            btnAzYenilenler.Name = "btnAzYenilenler";
            btnAzYenilenler.Size = new Size(240, 47);
            btnAzYenilenler.TabIndex = 5;
            btnAzYenilenler.Text = "En az Yenilen Yemekler";
            btnAzYenilenler.UseVisualStyleBackColor = false;
            // 
            // dgvYemekIstatistikleri
            // 
            dgvYemekIstatistikleri.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvYemekIstatistikleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekIstatistikleri.Location = new Point(47, 233);
            dgvYemekIstatistikleri.Name = "dgvYemekIstatistikleri";
            dgvYemekIstatistikleri.RowHeadersWidth = 51;
            dgvYemekIstatistikleri.Size = new Size(1155, 351);
            dgvYemekIstatistikleri.TabIndex = 6;
            // 
            // KullaniciRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1258, 629);
            Controls.Add(dgvYemekIstatistikleri);
            Controls.Add(btnAzYenilenler);
            Controls.Add(btnEnCokYenilen);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "KullaniciRaporEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciRaporEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvYemekIstatistikleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnEnCokYenilen;
        private Button btnAzYenilenler;
        private DataGridView dgvYemekIstatistikleri;
    }
}