namespace OgrenciKayitSistemi
{
    partial class FrmOgretmen_Detay
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            maskNumara = new MaskedTextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtSınav1 = new TextBox();
            button2 = new Button();
            txtSınav3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtSınav2 = new TextBox();
            groupBox3 = new GroupBox();
            lblOrtalama = new Label();
            lblKalanSayisi = new Label();
            lblGecenSayisi = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(maskNumara);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            button1.Location = new Point(99, 178);
            button1.Name = "button1";
            button1.Size = new Size(136, 43);
            button1.TabIndex = 6;
            button1.Text = "Öğrenci Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(99, 133);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(136, 26);
            txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 133);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 4;
            label3.Text = "Soyad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 91);
            label2.Name = "label2";
            label2.Size = new Size(45, 18);
            label2.TabIndex = 3;
            label2.Text = "Ad  : ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(99, 88);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(136, 26);
            txtAd.TabIndex = 2;
            // 
            // maskNumara
            // 
            maskNumara.Location = new Point(99, 46);
            maskNumara.Mask = "0000";
            maskNumara.Name = "maskNumara";
            maskNumara.Size = new Size(136, 26);
            maskNumara.TabIndex = 1;
            maskNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 46);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 0;
            label1.Text = "Numara : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtSınav1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(txtSınav3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSınav2);
            groupBox2.Location = new Point(303, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 238);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notu  Ekle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 46);
            label7.Name = "label7";
            label7.Size = new Size(72, 18);
            label7.TabIndex = 8;
            label7.Text = "Sınav 1 : ";
            // 
            // txtSınav1
            // 
            txtSınav1.Location = new Point(99, 43);
            txtSınav1.Name = "txtSınav1";
            txtSınav1.Size = new Size(136, 26);
            txtSınav1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(99, 178);
            button2.Name = "button2";
            button2.Size = new Size(136, 43);
            button2.TabIndex = 6;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtSınav3
            // 
            txtSınav3.Location = new Point(99, 133);
            txtSınav3.Name = "txtSınav3";
            txtSınav3.Size = new Size(136, 26);
            txtSınav3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 133);
            label4.Name = "label4";
            label4.Size = new Size(77, 18);
            label4.TabIndex = 4;
            label4.Text = "Sınav 3 :  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 91);
            label5.Name = "label5";
            label5.Size = new Size(69, 18);
            label5.TabIndex = 3;
            label5.Text = "Sınav 2 :";
            // 
            // txtSınav2
            // 
            txtSınav2.Location = new Point(99, 88);
            txtSınav2.Name = "txtSınav2";
            txtSınav2.Size = new Size(136, 26);
            txtSınav2.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblOrtalama);
            groupBox3.Controls.Add(lblKalanSayisi);
            groupBox3.Controls.Add(lblGecenSayisi);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(592, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(213, 238);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınıf Durumu";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(126, 49);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(28, 18);
            lblOrtalama.TabIndex = 11;
            lblOrtalama.Text = "00";
            // 
            // lblKalanSayisi
            // 
            lblKalanSayisi.AutoSize = true;
            lblKalanSayisi.Location = new Point(130, 133);
            lblKalanSayisi.Name = "lblKalanSayisi";
            lblKalanSayisi.Size = new Size(28, 18);
            lblKalanSayisi.TabIndex = 10;
            lblKalanSayisi.Text = "00";
            // 
            // lblGecenSayisi
            // 
            lblGecenSayisi.AutoSize = true;
            lblGecenSayisi.Location = new Point(126, 91);
            lblGecenSayisi.Name = "lblGecenSayisi";
            lblGecenSayisi.Size = new Size(28, 18);
            lblGecenSayisi.TabIndex = 9;
            lblGecenSayisi.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 46);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 8;
            label6.Text = "Ortalama : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 133);
            label8.Name = "label8";
            label8.Size = new Size(110, 18);
            label8.TabIndex = 4;
            label8.Text = "Kalan Sayısı :  ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 91);
            label9.Name = "label9";
            label9.Size = new Size(106, 18);
            label9.TabIndex = 3;
            label9.Text = "Geçen Sayısı :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 269);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(793, 259);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(781, 228);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmOgretmen_Detay
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(824, 540);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "FrmOgretmen_Detay";
            Text = "FrmOgretmen_Detay";
            Load += FrmOgretmen_Detay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtSoyad;
        private Label label3;
        private Label label2;
        private TextBox txtAd;
        private MaskedTextBox maskNumara;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtSınav1;
        private Button button2;
        private TextBox txtSınav3;
        private Label label4;
        private Label label5;
        private TextBox txtSınav2;
        private GroupBox groupBox3;
        private Label lblOrtalama;
        private Label lblKalanSayisi;
        private Label lblGecenSayisi;
        private Label label6;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}