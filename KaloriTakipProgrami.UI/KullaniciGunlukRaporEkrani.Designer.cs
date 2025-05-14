namespace KaloriTakipProgrami.UI
{
    partial class KullaniciGunlukRaporEkrani
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
            dtpTarih = new DateTimePicker();
            cmbOgunler = new ComboBox();
            dgvYemekTablo = new DataGridView();
            lblKalori = new Label();
            lblToplamKalori = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYemekTablo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Gün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 87);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Öğünler";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(98, 25);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 1;
            // 
            // cmbOgunler
            // 
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(98, 87);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(250, 28);
            cmbOgunler.TabIndex = 2;
            // 
            // dgvYemekTablo
            // 
            dgvYemekTablo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekTablo.Location = new Point(19, 166);
            dgvYemekTablo.Name = "dgvYemekTablo";
            dgvYemekTablo.RowHeadersWidth = 51;
            dgvYemekTablo.Size = new Size(516, 188);
            dgvYemekTablo.TabIndex = 3;
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.Location = new Point(475, 383);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(0, 20);
            lblKalori.TabIndex = 4;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamKalori.Location = new Point(313, 383);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(170, 20);
            lblToplamKalori.TabIndex = 5;
            lblToplamKalori.Text = "Toplam Kalori Miktarı =";
            // 
            // KullaniciGunlukRaporEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(lblToplamKalori);
            Controls.Add(lblKalori);
            Controls.Add(dgvYemekTablo);
            Controls.Add(cmbOgunler);
            Controls.Add(dtpTarih);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KullaniciGunlukRaporEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciGunlukRaporEkrani";
           
            ((System.ComponentModel.ISupportInitialize)dgvYemekTablo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpTarih;
        private ComboBox cmbOgunler;
        private DataGridView dgvYemekTablo;
        private Label lblKalori;
        private Label lblToplamKalori;
    }
}