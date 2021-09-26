namespace OtomatikYedekleme_WF
{
    partial class Mail
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
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbAdres1 = new System.Windows.Forms.TextBox();
            this.txbKonu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbGonderen = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbSifre = new System.Windows.Forms.TextBox();
            this.cmbgonderen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMailBİlgileriKaydet = new System.Windows.Forms.Button();
            this.checkBoxYedeklemeBilgisiGonder = new System.Windows.Forms.CheckBox();
            this.checkBoxYedeklemeDosyasiEkle = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMailicerik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prgsbarMail = new System.Windows.Forms.ProgressBar();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Alıcı Mail Adres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(52, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mail Konu:";
            // 
            // txbAdres1
            // 
            this.txbAdres1.Location = new System.Drawing.Point(133, 27);
            this.txbAdres1.Name = "txbAdres1";
            this.txbAdres1.Size = new System.Drawing.Size(215, 21);
            this.txbAdres1.TabIndex = 13;
            // 
            // txbKonu
            // 
            this.txbKonu.Location = new System.Drawing.Point(133, 78);
            this.txbKonu.Name = "txbKonu";
            this.txbKonu.Size = new System.Drawing.Size(215, 21);
            this.txbKonu.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(52, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Gönderen:";
            // 
            // txbGonderen
            // 
            this.txbGonderen.Location = new System.Drawing.Point(133, 131);
            this.txbGonderen.Name = "txbGonderen";
            this.txbGonderen.Size = new System.Drawing.Size(215, 21);
            this.txbGonderen.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(50, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "mail-Şifre:";
            // 
            // txbSifre
            // 
            this.txbSifre.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbSifre.Location = new System.Drawing.Point(133, 176);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.PasswordChar = '.';
            this.txbSifre.Size = new System.Drawing.Size(215, 23);
            this.txbSifre.TabIndex = 19;
            // 
            // cmbgonderen
            // 
            this.cmbgonderen.FormattingEnabled = true;
            this.cmbgonderen.Items.AddRange(new object[] {
            "hotmail.com"});
            this.cmbgonderen.Location = new System.Drawing.Point(358, 129);
            this.cmbgonderen.Name = "cmbgonderen";
            this.cmbgonderen.Size = new System.Drawing.Size(121, 23);
            this.cmbgonderen.TabIndex = 20;
            this.cmbgonderen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(380, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 11);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hesap Tipi Seciniz";
            // 
            // btnMailBİlgileriKaydet
            // 
            this.btnMailBİlgileriKaydet.Location = new System.Drawing.Point(314, 311);
            this.btnMailBİlgileriKaydet.Name = "btnMailBİlgileriKaydet";
            this.btnMailBİlgileriKaydet.Size = new System.Drawing.Size(117, 74);
            this.btnMailBİlgileriKaydet.TabIndex = 12;
            this.btnMailBİlgileriKaydet.Text = "Kaydet";
            this.btnMailBİlgileriKaydet.UseVisualStyleBackColor = true;
            this.btnMailBİlgileriKaydet.Click += new System.EventHandler(this.btnMailBİlgileriKaydet_Click);
            // 
            // checkBoxYedeklemeBilgisiGonder
            // 
            this.checkBoxYedeklemeBilgisiGonder.AutoSize = true;
            this.checkBoxYedeklemeBilgisiGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxYedeklemeBilgisiGonder.Location = new System.Drawing.Point(13, 335);
            this.checkBoxYedeklemeBilgisiGonder.Name = "checkBoxYedeklemeBilgisiGonder";
            this.checkBoxYedeklemeBilgisiGonder.Size = new System.Drawing.Size(234, 17);
            this.checkBoxYedeklemeBilgisiGonder.TabIndex = 31;
            this.checkBoxYedeklemeBilgisiGonder.Text = "Yedekleme Yapıldı Bilgisini Adresime Gönder";
            this.checkBoxYedeklemeBilgisiGonder.UseVisualStyleBackColor = true;
            // 
            // checkBoxYedeklemeDosyasiEkle
            // 
            this.checkBoxYedeklemeDosyasiEkle.AutoSize = true;
            this.checkBoxYedeklemeDosyasiEkle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxYedeklemeDosyasiEkle.Location = new System.Drawing.Point(13, 358);
            this.checkBoxYedeklemeDosyasiEkle.Name = "checkBoxYedeklemeDosyasiEkle";
            this.checkBoxYedeklemeDosyasiEkle.Size = new System.Drawing.Size(242, 18);
            this.checkBoxYedeklemeDosyasiEkle.TabIndex = 32;
            this.checkBoxYedeklemeDosyasiEkle.Text = "Yedekleme Dosyasını Maile Eklemek İstiyorum";
            this.checkBoxYedeklemeDosyasiEkle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "(gönderen@)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mail İçerik";
            // 
            // txbMailicerik
            // 
            this.txbMailicerik.Location = new System.Drawing.Point(133, 229);
            this.txbMailicerik.Multiline = true;
            this.txbMailicerik.Name = "txbMailicerik";
            this.txbMailicerik.Size = new System.Drawing.Size(215, 37);
            this.txbMailicerik.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prgsbarMail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbMailicerik);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBoxYedeklemeDosyasiEkle);
            this.groupBox2.Controls.Add(this.checkBoxYedeklemeBilgisiGonder);
            this.groupBox2.Controls.Add(this.btnMailBİlgileriKaydet);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbgonderen);
            this.groupBox2.Controls.Add(this.txbSifre);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txbGonderen);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txbKonu);
            this.groupBox2.Controls.Add(this.txbAdres1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 466);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "e-Mail Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // prgsbarMail
            // 
            this.prgsbarMail.Location = new System.Drawing.Point(2, 419);
            this.prgsbarMail.Name = "prgsbarMail";
            this.prgsbarMail.Size = new System.Drawing.Size(477, 17);
            this.prgsbarMail.TabIndex = 38;
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(509, 465);
            this.Controls.Add(this.groupBox2);
            this.Name = "Mail";
            this.Text = "Mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mail_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMailicerik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxYedeklemeDosyasiEkle;
        private System.Windows.Forms.CheckBox checkBoxYedeklemeBilgisiGonder;
        private System.Windows.Forms.Button btnMailBİlgileriKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbgonderen;
        private System.Windows.Forms.TextBox txbSifre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbGonderen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbKonu;
        private System.Windows.Forms.TextBox txbAdres1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar prgsbarMail;
    }
}