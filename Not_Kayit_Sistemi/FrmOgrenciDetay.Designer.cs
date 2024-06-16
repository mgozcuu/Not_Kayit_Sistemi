namespace Not_Kayit_Sistemi
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
            lblSinav1 = new Label();
            lblSinav2 = new Label();
            lblSinav3 = new Label();
            lblAdSoyad = new Label();
            lblNumara = new Label();
            lblOrtalama = new Label();
            label12 = new Label();
            label13 = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 43);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 79);
            label2.Name = "label2";
            label2.Size = new Size(89, 24);
            label2.TabIndex = 1;
            label2.Text = "Numara:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 147);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 2;
            label3.Text = "Sınav 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 183);
            label4.Name = "label4";
            label4.Size = new Size(81, 24);
            label4.TabIndex = 3;
            label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 223);
            label5.Name = "label5";
            label5.Size = new Size(81, 24);
            label5.TabIndex = 4;
            label5.Text = "Sınav 3:";
            // 
            // lblSinav1
            // 
            lblSinav1.AutoSize = true;
            lblSinav1.Location = new Point(154, 147);
            lblSinav1.Name = "lblSinav1";
            lblSinav1.Size = new Size(34, 24);
            lblSinav1.TabIndex = 5;
            lblSinav1.Text = "00";
            // 
            // lblSinav2
            // 
            lblSinav2.AutoSize = true;
            lblSinav2.Location = new Point(154, 183);
            lblSinav2.Name = "lblSinav2";
            lblSinav2.Size = new Size(34, 24);
            lblSinav2.TabIndex = 6;
            lblSinav2.Text = "00";
            // 
            // lblSinav3
            // 
            lblSinav3.AutoSize = true;
            lblSinav3.Location = new Point(154, 223);
            lblSinav3.Name = "lblSinav3";
            lblSinav3.Size = new Size(34, 24);
            lblSinav3.TabIndex = 7;
            lblSinav3.Text = "00";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(154, 43);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(64, 24);
            lblAdSoyad.TabIndex = 8;
            lblAdSoyad.Text = "NULL";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(154, 79);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(58, 24);
            lblNumara.TabIndex = 9;
            lblNumara.Text = "0000";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(154, 267);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(34, 24);
            lblOrtalama.TabIndex = 10;
            lblOrtalama.Text = "00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 267);
            label12.Name = "label12";
            label12.Size = new Size(100, 24);
            label12.TabIndex = 11;
            label12.Text = "Ortalama:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 312);
            label13.Name = "label13";
            label13.Size = new Size(81, 24);
            label13.TabIndex = 12;
            label13.Text = "Durum:";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(154, 312);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(64, 24);
            lblDurum.TabIndex = 13;
            lblDurum.Text = "NULL";
            // 
            // FrmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(409, 540);
            Controls.Add(lblDurum);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(lblOrtalama);
            Controls.Add(lblNumara);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblSinav3);
            Controls.Add(lblSinav2);
            Controls.Add(lblSinav1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
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
        private Label lblSinav1;
        private Label lblSinav2;
        private Label lblSinav3;
        private Label lblAdSoyad;
        private Label lblNumara;
        private Label lblOrtalama;
        private Label label12;
        private Label label13;
        private Label lblDurum;
    }
}