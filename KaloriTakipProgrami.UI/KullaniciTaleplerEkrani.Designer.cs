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
            label1 = new Label();
            txtKonu = new TextBox();
            txtMesaj = new TextBox();
            label2 = new Label();
            btnGönder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(59, 146);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 0;
            label1.Text = "Mesaj :";
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(121, 89);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(247, 27);
            txtKonu.TabIndex = 1;
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(126, 145);
            txtMesaj.Multiline = true;
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(242, 201);
            txtMesaj.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(59, 89);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 0;
            label2.Text = "Konu :";
            // 
            // btnGönder
            // 
            btnGönder.Location = new Point(274, 371);
            btnGönder.Name = "btnGönder";
            btnGönder.Size = new Size(94, 29);
            btnGönder.TabIndex = 3;
            btnGönder.Text = "Gönder";
            btnGönder.UseVisualStyleBackColor = true;
            btnGönder.Click += btnGönder_Click;
            // 
            // KullaniciTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 429);
            Controls.Add(btnGönder);
            Controls.Add(txtMesaj);
            Controls.Add(txtKonu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KullaniciTaleplerEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciTaleplerEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKonu;
        private TextBox txtMesaj;
        private Label label2;
        private Button btnGönder;
    }
}