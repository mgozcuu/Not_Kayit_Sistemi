namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            b = new Button();
            txtSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            mskNumara = new MaskedTextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtSinav1 = new TextBox();
            btnGüncelle = new Button();
            txtSinav3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtSinav2 = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblKalanSayisi = new Label();
            lblGecenSayisi = new Label();
            lblOrtalama = new Label();
            label7 = new Label();
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
            groupBox1.Controls.Add(b);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(mskNumara);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 286);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // b
            // 
            b.Location = new Point(101, 177);
            b.Name = "b";
            b.Size = new Size(164, 36);
            b.TabIndex = 6;
            b.Text = "Öğrenci Kaydet";
            b.UseVisualStyleBackColor = true;
            b.Click += button1_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(101, 133);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(164, 30);
            txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 133);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 4;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 94);
            label2.Name = "label2";
            label2.Size = new Size(40, 24);
            label2.TabIndex = 3;
            label2.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(101, 88);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(164, 30);
            txtAd.TabIndex = 2;
            // 
            // mskNumara
            // 
            mskNumara.Location = new Point(101, 52);
            mskNumara.Mask = "0000";
            mskNumara.Name = "mskNumara";
            mskNumara.Size = new Size(164, 30);
            mskNumara.TabIndex = 1;
            mskNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 52);
            label1.Name = "label1";
            label1.Size = new Size(89, 24);
            label1.TabIndex = 0;
            label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSinav1);
            groupBox2.Controls.Add(btnGüncelle);
            groupBox2.Controls.Add(txtSinav3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSinav2);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(307, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 286);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notları";
            // 
            // txtSinav1
            // 
            txtSinav1.Location = new Point(101, 46);
            txtSinav1.Name = "txtSinav1";
            txtSinav1.Size = new Size(164, 30);
            txtSinav1.TabIndex = 7;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(101, 177);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(164, 36);
            btnGüncelle.TabIndex = 6;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // txtSinav3
            // 
            txtSinav3.Location = new Point(101, 133);
            txtSinav3.Name = "txtSinav3";
            txtSinav3.Size = new Size(164, 30);
            txtSinav3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 139);
            label4.Name = "label4";
            label4.Size = new Size(81, 24);
            label4.TabIndex = 4;
            label4.Text = "Sınav 3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 94);
            label5.Name = "label5";
            label5.Size = new Size(81, 24);
            label5.TabIndex = 3;
            label5.Text = "Sınav 2:";
            // 
            // txtSinav2
            // 
            txtSinav2.Location = new Point(101, 88);
            txtSinav2.Name = "txtSinav2";
            txtSinav2.Size = new Size(164, 30);
            txtSinav2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 52);
            label6.Name = "label6";
            label6.Size = new Size(79, 24);
            label6.TabIndex = 0;
            label6.Text = "Sınav 1:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblKalanSayisi);
            groupBox3.Controls.Add(lblGecenSayisi);
            groupBox3.Controls.Add(lblOrtalama);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(624, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(280, 286);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınav Notları";
            // 
            // lblKalanSayisi
            // 
            lblKalanSayisi.AutoSize = true;
            lblKalanSayisi.Location = new Point(144, 139);
            lblKalanSayisi.Name = "lblKalanSayisi";
            lblKalanSayisi.Size = new Size(34, 24);
            lblKalanSayisi.TabIndex = 7;
            lblKalanSayisi.Text = "00";
            // 
            // lblGecenSayisi
            // 
            lblGecenSayisi.AutoSize = true;
            lblGecenSayisi.Location = new Point(144, 94);
            lblGecenSayisi.Name = "lblGecenSayisi";
            lblGecenSayisi.Size = new Size(34, 24);
            lblGecenSayisi.TabIndex = 6;
            lblGecenSayisi.Text = "00";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(144, 52);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(34, 24);
            lblOrtalama.TabIndex = 5;
            lblOrtalama.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 139);
            label7.Name = "label7";
            label7.Size = new Size(125, 24);
            label7.TabIndex = 4;
            label7.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 94);
            label8.Name = "label8";
            label8.Size = new Size(129, 24);
            label8.TabIndex = 3;
            label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 52);
            label9.Name = "label9";
            label9.Size = new Size(100, 24);
            label9.TabIndex = 0;
            label9.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(6, 313);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(898, 191);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(892, 162);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(1019, 540);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmOgretmenDetay";
            Text = "FrmOgretmenDetay";
            Load += FrmOgretmenDetay_Load;
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
        private Button b;
        private TextBox txtSoyad;
        private Label label3;
        private Label label2;
        private TextBox txtAd;
        private MaskedTextBox mskNumara;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtSinav1;
        private Button btnGüncelle;
        private TextBox txtSinav3;
        private Label label4;
        private Label label5;
        private TextBox txtSinav2;
        private Label label6;
        private GroupBox groupBox3;
        private Label lblKalanSayisi;
        private Label lblGecenSayisi;
        private Label lblOrtalama;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}