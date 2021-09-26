namespace OtomatikYedekleme_WF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndatabase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.txbklasor = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAyarMail = new System.Windows.Forms.Button();
            this.dtsaat = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimetarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textAralik = new System.Windows.Forms.TextBox();
            this.radioGun = new System.Windows.Forms.RadioButton();
            this.radioSaat = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radiobtndakika = new System.Windows.Forms.RadioButton();
            this.lblBasladi = new System.Windows.Forms.Label();
            this.lblGöstSayi = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndatabase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDosyaSec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDatabases);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnYedekle);
            this.groupBox1.Controls.Add(this.txbklasor);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yedekleme Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btndatabase
            // 
            this.btndatabase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndatabase.Location = new System.Drawing.Point(255, 44);
            this.btndatabase.Name = "btndatabase";
            this.btndatabase.Size = new System.Drawing.Size(78, 23);
            this.btndatabase.TabIndex = 9;
            this.btndatabase.Text = "Bağlan";
            this.btndatabase.UseVisualStyleBackColor = true;
            this.btndatabase.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yedekle";
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDosyaSec.Location = new System.Drawing.Point(255, 80);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(46, 23);
            this.btnDosyaSec.TabIndex = 7;
            this.btnDosyaSec.Text = "Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hedef Dosya";
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(18, 44);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(227, 21);
            this.cmbDatabases.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "DataBase Seçiniz..";
            // 
            // btnYedekle
            // 
            this.btnYedekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYedekle.BackgroundImage")));
            this.btnYedekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYedekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekle.Enabled = false;
            this.btnYedekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnYedekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYedekle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYedekle.Location = new System.Drawing.Point(378, 29);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(130, 71);
            this.btnYedekle.TabIndex = 3;
            this.btnYedekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnBackupGo_Click);
            // 
            // txbklasor
            // 
            this.txbklasor.Location = new System.Drawing.Point(18, 83);
            this.txbklasor.Name = "txbklasor";
            this.txbklasor.Size = new System.Drawing.Size(227, 21);
            this.txbklasor.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAyarMail
            // 
            this.btnAyarMail.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAyarMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyarMail.Location = new System.Drawing.Point(289, 320);
            this.btnAyarMail.Name = "btnAyarMail";
            this.btnAyarMail.Size = new System.Drawing.Size(248, 49);
            this.btnAyarMail.TabIndex = 43;
            this.btnAyarMail.Text = "Yedeklemeden Önce                       Mail Ayarlarını Düzenle>>";
            this.btnAyarMail.UseVisualStyleBackColor = false;
            this.btnAyarMail.Click += new System.EventHandler(this.btnAyarMail_Click);
            // 
            // dtsaat
            // 
            this.dtsaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtsaat.Location = new System.Drawing.Point(82, 204);
            this.dtsaat.Name = "dtsaat";
            this.dtsaat.ShowUpDown = true;
            this.dtsaat.Size = new System.Drawing.Size(298, 21);
            this.dtsaat.TabIndex = 61;
            this.dtsaat.ValueChanged += new System.EventHandler(this.dtsaat_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 58;
            this.label6.Text = "Saat:";
            // 
            // dateTimetarih
            // 
            this.dateTimetarih.Location = new System.Drawing.Point(82, 177);
            this.dateTimetarih.Name = "dateTimetarih";
            this.dateTimetarih.Size = new System.Drawing.Size(298, 21);
            this.dateTimetarih.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tarih:";
            // 
            // textAralik
            // 
            this.textAralik.Location = new System.Drawing.Point(82, 238);
            this.textAralik.Name = "textAralik";
            this.textAralik.Size = new System.Drawing.Size(292, 21);
            this.textAralik.TabIndex = 65;
            // 
            // radioGun
            // 
            this.radioGun.AutoSize = true;
            this.radioGun.Location = new System.Drawing.Point(289, 277);
            this.radioGun.Name = "radioGun";
            this.radioGun.Size = new System.Drawing.Size(50, 17);
            this.radioGun.TabIndex = 64;
            this.radioGun.TabStop = true;
            this.radioGun.Text = "Gün";
            this.radioGun.UseVisualStyleBackColor = true;
            // 
            // radioSaat
            // 
            this.radioSaat.AutoSize = true;
            this.radioSaat.Location = new System.Drawing.Point(193, 277);
            this.radioSaat.Name = "radioSaat";
            this.radioSaat.Size = new System.Drawing.Size(54, 17);
            this.radioSaat.TabIndex = 63;
            this.radioSaat.TabStop = true;
            this.radioSaat.Text = "Saat";
            this.radioSaat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Aralık:";
            // 
            // radiobtndakika
            // 
            this.radiobtndakika.AutoSize = true;
            this.radiobtndakika.Location = new System.Drawing.Point(88, 277);
            this.radiobtndakika.Name = "radiobtndakika";
            this.radiobtndakika.Size = new System.Drawing.Size(70, 17);
            this.radiobtndakika.TabIndex = 66;
            this.radiobtndakika.TabStop = true;
            this.radiobtndakika.Text = "Dakika";
            this.radiobtndakika.UseVisualStyleBackColor = true;
            // 
            // lblBasladi
            // 
            this.lblBasladi.AutoSize = true;
            this.lblBasladi.Enabled = false;
            this.lblBasladi.Location = new System.Drawing.Point(18, 356);
            this.lblBasladi.Name = "lblBasladi";
            this.lblBasladi.Size = new System.Drawing.Size(218, 13);
            this.lblBasladi.TabIndex = 67;
            this.lblBasladi.Text = "Otomatik yedekleme başlatıldı...";
            // 
            // lblGöstSayi
            // 
            this.lblGöstSayi.AutoSize = true;
            this.lblGöstSayi.Enabled = false;
            this.lblGöstSayi.Location = new System.Drawing.Point(18, 382);
            this.lblGöstSayi.Name = "lblGöstSayi";
            this.lblGöstSayi.Size = new System.Drawing.Size(147, 13);
            this.lblGöstSayi.TabIndex = 68;
            this.lblGöstSayi.Text = "Alınan BackUp Sayısı:";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Enabled = false;
            this.lblSayi.Location = new System.Drawing.Point(172, 382);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(34, 13);
            this.lblSayi.TabIndex = 69;
            this.lblSayi.Text = "sayı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 404);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.lblGöstSayi);
            this.Controls.Add(this.lblBasladi);
            this.Controls.Add(this.radiobtndakika);
            this.Controls.Add(this.textAralik);
            this.Controls.Add(this.radioGun);
            this.Controls.Add(this.radioSaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtsaat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimetarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAyarMail);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "BackUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.TextBox txbklasor;
        private System.Windows.Forms.Button btndatabase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAyarMail;
        private System.Windows.Forms.DateTimePicker dtsaat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimetarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAralik;
        private System.Windows.Forms.RadioButton radioGun;
        private System.Windows.Forms.RadioButton radioSaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radiobtndakika;
        private System.Windows.Forms.Label lblBasladi;
        private System.Windows.Forms.Label lblGöstSayi;
        private System.Windows.Forms.Label lblSayi;
    }
}