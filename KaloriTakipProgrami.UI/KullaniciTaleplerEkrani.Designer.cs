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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(121, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 145);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 201);
            textBox2.TabIndex = 2;
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
            // 
            // KullaniciTaleplerEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 429);
            Controls.Add(btnGönder);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button btnGönder;
    }
}