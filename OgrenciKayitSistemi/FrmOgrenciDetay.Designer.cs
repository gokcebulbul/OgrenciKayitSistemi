namespace OgrenciKayitSistemi
{
    partial class FrmOgrenciDetay
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblSınav1 = new Label();
            lblSınav2 = new Label();
            lblSınav3 = new Label();
            lblNumara = new Label();
            lblAdSoyad = new Label();
            lblOrtalama = new Label();
            label12 = new Label();
            label13 = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 54);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 1;
            label2.Text = "Numara : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 101);
            label3.Name = "label3";
            label3.Size = new Size(72, 18);
            label3.TabIndex = 2;
            label3.Text = "Sınav 1 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 141);
            label4.Name = "label4";
            label4.Size = new Size(77, 18);
            label4.TabIndex = 3;
            label4.Text = "Sınav 2  : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 178);
            label5.Name = "label5";
            label5.Size = new Size(73, 18);
            label5.TabIndex = 4;
            label5.Text = "Sınav 3 : ";
            // 
            // lblSınav1
            // 
            lblSınav1.AutoSize = true;
            lblSınav1.Location = new Point(100, 101);
            lblSınav1.Name = "lblSınav1";
            lblSınav1.Size = new Size(28, 18);
            lblSınav1.TabIndex = 5;
            lblSınav1.Text = "00";
            // 
            // lblSınav2
            // 
            lblSınav2.AutoSize = true;
            lblSınav2.Location = new Point(100, 141);
            lblSınav2.Name = "lblSınav2";
            lblSınav2.Size = new Size(28, 18);
            lblSınav2.TabIndex = 6;
            lblSınav2.Text = "00";
            // 
            // lblSınav3
            // 
            lblSınav3.AutoSize = true;
            lblSınav3.Location = new Point(100, 178);
            lblSınav3.Name = "lblSınav3";
            lblSınav3.Size = new Size(28, 18);
            lblSınav3.TabIndex = 7;
            lblSınav3.Text = "00";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(100, 54);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(48, 18);
            lblNumara.TabIndex = 8;
            lblNumara.Text = "0000";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(100, 9);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(37, 18);
            lblAdSoyad.TabIndex = 9;
            lblAdSoyad.Text = "Null";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(100, 215);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(28, 18);
            lblOrtalama.TabIndex = 10;
            lblOrtalama.Text = "00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 215);
            label12.Name = "label12";
            label12.Size = new Size(84, 18);
            label12.TabIndex = 11;
            label12.Text = "Ortalama :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 256);
            label13.Name = "label13";
            label13.Size = new Size(71, 18);
            label13.TabIndex = 12;
            label13.Text = "Durum : ";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(100, 256);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(37, 18);
            lblDurum.TabIndex = 13;
            lblDurum.Text = "Null";
            // 
            // FrmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(271, 347);
            Controls.Add(lblDurum);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(lblOrtalama);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblNumara);
            Controls.Add(lblSınav3);
            Controls.Add(lblSınav2);
            Controls.Add(lblSınav1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmOgrenciDetay";
            Text = "Öğrenci Not Kayıt Sistemi";
            Load += FrmOgrenciDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblSınav1;
        private Label lblSınav2;
        private Label lblSınav3;
        private Label lblNumara;
        private Label lblAdSoyad;
        private Label lblOrtalama;
        private Label label12;
        private Label label13;
        private Label lblDurum;
    }
}