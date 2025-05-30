﻿namespace KaloriTakipProgrami.UI
{
    partial class YoneticiOgunKategoriYemekEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiOgunKategoriYemekEkrani));
            txtOgunAdi = new TextBox();
            dgvOgunler = new DataGridView();
            btnOgunGuncelle = new Button();
            btnOgunSil = new Button();
            btnOgunEkle = new Button();
            label1 = new Label();
            tpYemekIslemleri = new TabControl();
            tabPage1 = new TabPage();
            btnGeri = new Button();
            grpKategoriler = new GroupBox();
            dgvKategoriler = new DataGridView();
            txtKategoriAdi = new TextBox();
            btnKategoriGuncelle = new Button();
            btnKategoriSil = new Button();
            btnKategoriEkle = new Button();
            label2 = new Label();
            grpOgunler = new GroupBox();
            tabPage2 = new TabPage();
            grpYemekler = new GroupBox();
            cbKategori = new ComboBox();
            nudKalori = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            txtYemekAdi = new TextBox();
            dgvYemekler = new DataGridView();
            btnYemekGuncelle = new Button();
            btnYemekSil = new Button();
            btnYemekEkle = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).BeginInit();
            tpYemekIslemleri.SuspendLayout();
            tabPage1.SuspendLayout();
            grpKategoriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).BeginInit();
            grpOgunler.SuspendLayout();
            tabPage2.SuspendLayout();
            grpYemekler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            SuspendLayout();
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(125, 47);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.Size = new Size(247, 31);
            txtOgunAdi.TabIndex = 3;
            // 
            // dgvOgunler
            // 
            dgvOgunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgunler.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunler.Location = new Point(27, 141);
            dgvOgunler.Name = "dgvOgunler";
            dgvOgunler.ReadOnly = true;
            dgvOgunler.RowHeadersWidth = 51;
            dgvOgunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgunler.Size = new Size(900, 159);
            dgvOgunler.TabIndex = 2;
            dgvOgunler.CellClick += dgvOgunler_CellClick;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.BackColor = Color.FromArgb(164, 172, 134);
            btnOgunGuncelle.FlatStyle = FlatStyle.Popup;
            btnOgunGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunGuncelle.Location = new Point(261, 94);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(111, 35);
            btnOgunGuncelle.TabIndex = 1;
            btnOgunGuncelle.Text = "Güncelle";
            btnOgunGuncelle.UseVisualStyleBackColor = false;
            btnOgunGuncelle.Click += btnOgunGuncelle_Click;
            // 
            // btnOgunSil
            // 
            btnOgunSil.BackColor = Color.FromArgb(164, 172, 134);
            btnOgunSil.FlatStyle = FlatStyle.Popup;
            btnOgunSil.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunSil.Location = new Point(142, 94);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(111, 35);
            btnOgunSil.TabIndex = 1;
            btnOgunSil.Text = "Sil";
            btnOgunSil.UseVisualStyleBackColor = false;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.BackColor = Color.FromArgb(164, 172, 134);
            btnOgunEkle.FlatStyle = FlatStyle.Popup;
            btnOgunEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunEkle.Location = new Point(27, 94);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(111, 35);
            btnOgunEkle.TabIndex = 1;
            btnOgunEkle.Text = "Ekle";
            btnOgunEkle.UseVisualStyleBackColor = false;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 50);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Öğün Adı";
            // 
            // tpYemekIslemleri
            // 
            tpYemekIslemleri.Controls.Add(tabPage1);
            tpYemekIslemleri.Controls.Add(tabPage2);
            tpYemekIslemleri.Location = new Point(2, -2);
            tpYemekIslemleri.Name = "tpYemekIslemleri";
            tpYemekIslemleri.SelectedIndex = 0;
            tpYemekIslemleri.Size = new Size(1279, 755);
            tpYemekIslemleri.TabIndex = 31;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(47, 62, 70);
            tabPage1.Controls.Add(btnGeri);
            tabPage1.Controls.Add(grpKategoriler);
            tabPage1.Controls.Add(grpOgunler);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1271, 717);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Öğün İşlemleri";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(47, 62, 70);
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(0, 0);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(57, 41);
            btnGeri.TabIndex = 31;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click_1;
            // 
            // grpKategoriler
            // 
            grpKategoriler.Controls.Add(dgvKategoriler);
            grpKategoriler.Controls.Add(txtKategoriAdi);
            grpKategoriler.Controls.Add(btnKategoriGuncelle);
            grpKategoriler.Controls.Add(btnKategoriSil);
            grpKategoriler.Controls.Add(btnKategoriEkle);
            grpKategoriler.Controls.Add(label2);
            grpKategoriler.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            grpKategoriler.ForeColor = SystemColors.ButtonHighlight;
            grpKategoriler.Location = new Point(0, 355);
            grpKategoriler.Margin = new Padding(4);
            grpKategoriler.Name = "grpKategoriler";
            grpKategoriler.Padding = new Padding(4);
            grpKategoriler.Size = new Size(1271, 362);
            grpKategoriler.TabIndex = 1;
            grpKategoriler.TabStop = false;
            grpKategoriler.Text = "Kategori İşlemleri";
            // 
            // dgvKategoriler
            // 
            dgvKategoriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKategoriler.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriler.Location = new Point(25, 141);
            dgvKategoriler.Name = "dgvKategoriler";
            dgvKategoriler.RowHeadersWidth = 51;
            dgvKategoriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategoriler.Size = new Size(902, 201);
            dgvKategoriler.TabIndex = 4;
            dgvKategoriler.CellClick += dgvKategoriler_CellClick;
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(147, 47);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(223, 31);
            txtKategoriAdi.TabIndex = 3;
            // 
            // btnKategoriGuncelle
            // 
            btnKategoriGuncelle.BackColor = Color.FromArgb(164, 172, 134);
            btnKategoriGuncelle.FlatStyle = FlatStyle.Popup;
            btnKategoriGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            btnKategoriGuncelle.Location = new Point(259, 94);
            btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            btnKategoriGuncelle.Size = new Size(111, 35);
            btnKategoriGuncelle.TabIndex = 1;
            btnKategoriGuncelle.Text = "Güncelle";
            btnKategoriGuncelle.UseVisualStyleBackColor = false;
            btnKategoriGuncelle.Click += btnKategoriGuncelle_Click_1;
            // 
            // btnKategoriSil
            // 
            btnKategoriSil.BackColor = Color.FromArgb(164, 172, 134);
            btnKategoriSil.FlatStyle = FlatStyle.Popup;
            btnKategoriSil.ForeColor = SystemColors.ActiveCaptionText;
            btnKategoriSil.Location = new Point(142, 94);
            btnKategoriSil.Name = "btnKategoriSil";
            btnKategoriSil.Size = new Size(111, 35);
            btnKategoriSil.TabIndex = 1;
            btnKategoriSil.Text = "Sil";
            btnKategoriSil.UseVisualStyleBackColor = false;
            btnKategoriSil.Click += btnKategoriSil_Click_1;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.BackColor = Color.FromArgb(164, 172, 134);
            btnKategoriEkle.FlatStyle = FlatStyle.Popup;
            btnKategoriEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnKategoriEkle.Location = new Point(25, 94);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(111, 35);
            btnKategoriEkle.TabIndex = 1;
            btnKategoriEkle.Text = "Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = false;
            btnKategoriEkle.Click += btnKategoriEkle_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 51);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 0;
            label2.Text = "Kategori Adı";
            // 
            // grpOgunler
            // 
            grpOgunler.Controls.Add(txtOgunAdi);
            grpOgunler.Controls.Add(dgvOgunler);
            grpOgunler.Controls.Add(btnOgunGuncelle);
            grpOgunler.Controls.Add(btnOgunSil);
            grpOgunler.Controls.Add(btnOgunEkle);
            grpOgunler.Controls.Add(label1);
            grpOgunler.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            grpOgunler.ForeColor = SystemColors.ButtonHighlight;
            grpOgunler.Location = new Point(0, 43);
            grpOgunler.Margin = new Padding(4);
            grpOgunler.Name = "grpOgunler";
            grpOgunler.Padding = new Padding(4);
            grpOgunler.Size = new Size(1275, 312);
            grpOgunler.TabIndex = 0;
            grpOgunler.TabStop = false;
            grpOgunler.Text = "Öğün İşlemler";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(47, 62, 70);
            tabPage2.Controls.Add(grpYemekler);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1271, 722);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Yemek İşlemleri";
            // 
            // grpYemekler
            // 
            grpYemekler.Controls.Add(cbKategori);
            grpYemekler.Controls.Add(nudKalori);
            grpYemekler.Controls.Add(label5);
            grpYemekler.Controls.Add(label4);
            grpYemekler.Controls.Add(txtYemekAdi);
            grpYemekler.Controls.Add(dgvYemekler);
            grpYemekler.Controls.Add(btnYemekGuncelle);
            grpYemekler.Controls.Add(btnYemekSil);
            grpYemekler.Controls.Add(btnYemekEkle);
            grpYemekler.Controls.Add(label3);
            grpYemekler.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            grpYemekler.ForeColor = SystemColors.ButtonHighlight;
            grpYemekler.Location = new Point(0, 0);
            grpYemekler.Margin = new Padding(4);
            grpYemekler.Name = "grpYemekler";
            grpYemekler.Padding = new Padding(4);
            grpYemekler.Size = new Size(1275, 721);
            grpYemekler.TabIndex = 1;
            grpYemekler.TabStop = false;
            grpYemekler.Text = "Yemek İşlemleri";
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(152, 115);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(220, 33);
            cbKategori.TabIndex = 6;
            // 
            // nudKalori
            // 
            nudKalori.Location = new Point(152, 152);
            nudKalori.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudKalori.Name = "nudKalori";
            nudKalori.Size = new Size(220, 31);
            nudKalori.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(37, 153);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 4;
            label5.Text = "Kalori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(35, 117);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 4;
            label4.Text = "Kategori ";
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(152, 80);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(220, 31);
            txtYemekAdi.TabIndex = 3;
            // 
            // dgvYemekler
            // 
            dgvYemekler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYemekler.BackgroundColor = Color.FromArgb(202, 210, 197);
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Location = new Point(32, 243);
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.ReadOnly = true;
            dgvYemekler.RowHeadersWidth = 51;
            dgvYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekler.Size = new Size(1216, 466);
            dgvYemekler.TabIndex = 2;
            dgvYemekler.CellClick += dgvYemekler_CellClick_1;
            // 
            // btnYemekGuncelle
            // 
            btnYemekGuncelle.BackColor = Color.FromArgb(164, 172, 134);
            btnYemekGuncelle.FlatStyle = FlatStyle.Popup;
            btnYemekGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            btnYemekGuncelle.Location = new Point(266, 202);
            btnYemekGuncelle.Name = "btnYemekGuncelle";
            btnYemekGuncelle.Size = new Size(111, 35);
            btnYemekGuncelle.TabIndex = 1;
            btnYemekGuncelle.Text = "Güncelle";
            btnYemekGuncelle.UseVisualStyleBackColor = false;
            btnYemekGuncelle.Click += btnYemekGuncelle_Click_1;
            // 
            // btnYemekSil
            // 
            btnYemekSil.BackColor = Color.FromArgb(164, 172, 134);
            btnYemekSil.FlatStyle = FlatStyle.Popup;
            btnYemekSil.ForeColor = SystemColors.ActiveCaptionText;
            btnYemekSil.Location = new Point(149, 202);
            btnYemekSil.Name = "btnYemekSil";
            btnYemekSil.Size = new Size(111, 35);
            btnYemekSil.TabIndex = 1;
            btnYemekSil.Text = "Sil";
            btnYemekSil.UseVisualStyleBackColor = false;
            btnYemekSil.Click += btnYemekSil_Click_1;
            // 
            // btnYemekEkle
            // 
            btnYemekEkle.BackColor = Color.FromArgb(164, 172, 134);
            btnYemekEkle.FlatStyle = FlatStyle.Popup;
            btnYemekEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnYemekEkle.Location = new Point(32, 202);
            btnYemekEkle.Name = "btnYemekEkle";
            btnYemekEkle.Size = new Size(111, 35);
            btnYemekEkle.TabIndex = 1;
            btnYemekEkle.Text = "Ekle";
            btnYemekEkle.UseVisualStyleBackColor = false;
            btnYemekEkle.Click += btnYemekEkle_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(37, 81);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 0;
            label3.Text = "Yemek Adı";
            // 
            // YoneticiOgunKategoriYemekEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1282, 753);
            Controls.Add(tpYemekIslemleri);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "YoneticiOgunKategoriYemekEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiOgunKategoriYemekEkrani";
            Load += YoneticiOgunKategoriYemekEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).EndInit();
            tpYemekIslemleri.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            grpKategoriler.ResumeLayout(false);
            grpKategoriler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).EndInit();
            grpOgunler.ResumeLayout(false);
            grpOgunler.PerformLayout();
            tabPage2.ResumeLayout(false);
            grpYemekler.ResumeLayout(false);
            grpYemekler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKalori).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtOgunAdi;
        private DataGridView dgvOgunler;
        private Button btnOgunGuncelle;
        private Button btnOgunSil;
        private Button btnOgunEkle;
        private Label label1;
        private TabControl tpYemekIslemleri;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox grpOgunler;
        private Button btnGeri;
        private GroupBox grpKategoriler;
        private DataGridView dgvKategoriler;
        private TextBox txtKategoriAdi;
        private Button btnKategoriGuncelle;
        private Button btnKategoriSil;
        private Button btnKategoriEkle;
        private Label label2;
        private GroupBox grpYemekler;
        private ComboBox cbKategori;
        private NumericUpDown nudKalori;
        private Label label5;
        private Label label4;
        private TextBox txtYemekAdi;
        private DataGridView dgvYemekler;
        private Button btnYemekGuncelle;
        private Button btnYemekSil;
        private Button btnYemekEkle;
        private Label label3;
    }
}