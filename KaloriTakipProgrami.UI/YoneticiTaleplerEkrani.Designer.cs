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
            btnReddet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).BeginInit();
            SuspendLayout();
            // 
            // dgvTalepler
            // 
            dgvTalepler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalepler.Location = new Point(77, 96);
            dgvTalepler.Name = "dgvTalepler";
            dgvTalepler.RowHeadersWidth = 51;
            dgvTalepler.Size = new Size(617, 188);
            dgvTalepler.TabIndex = 0;
            dgvTalepler.CellClick += dgvTalepler_CellClick;
            // 
            // btnOnayla
            // 
            btnOnayla.Location = new Point(230, 318);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(94, 29);
            btnOnayla.TabIndex = 1;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnReddet
            // 
            btnReddet.Location = new Point(401, 318);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(94, 29);
            btnReddet.TabIndex = 2;
            btnReddet.Text = "Reddet ";
            btnReddet.UseVisualStyleBackColor = true;
            btnReddet.Click += btnReddet_Click;
            // 
            // YoneticiTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReddet);
            Controls.Add(btnOnayla);
            Controls.Add(dgvTalepler);
            Name = "YoneticiTaleplerEkrani";
            Text = "YoneticiTaleplerEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTalepler;
        private Button btnOnayla;
        private Button btnReddet;
    }
}