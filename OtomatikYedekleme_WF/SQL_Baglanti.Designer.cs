namespace OtomatikYedekleme_WF
{
    partial class SQL_Baglanti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.txbUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaglantitipim = new System.Windows.Forms.ComboBox();
            this.lblBaglantiBilgi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblyanacakUserID = new System.Windows.Forms.Label();
            this.lblYanacakPsssword = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // txbServer
            // 
            this.txbServer.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbServer.Location = new System.Drawing.Point(96, 18);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(240, 23);
            this.txbServer.TabIndex = 6;
            // 
            // txbUserID
            // 
            this.txbUserID.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbUserID.Location = new System.Drawing.Point(96, 125);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.Size = new System.Drawing.Size(169, 23);
            this.txbUserID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "User ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbPassword.Location = new System.Drawing.Point(96, 154);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(169, 23);
            this.txbPassword.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bağlantı Tipi";
            // 
            // cmbBaglantitipim
            // 
            this.cmbBaglantitipim.FormattingEnabled = true;
            this.cmbBaglantitipim.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication (Önerilen)"});
            this.cmbBaglantitipim.Location = new System.Drawing.Point(96, 55);
            this.cmbBaglantitipim.Name = "cmbBaglantitipim";
            this.cmbBaglantitipim.Size = new System.Drawing.Size(240, 21);
            this.cmbBaglantitipim.TabIndex = 12;
            // 
            // lblBaglantiBilgi
            // 
            this.lblBaglantiBilgi.AutoSize = true;
            this.lblBaglantiBilgi.Location = new System.Drawing.Point(-1, 98);
            this.lblBaglantiBilgi.Name = "lblBaglantiBilgi";
            this.lblBaglantiBilgi.Size = new System.Drawing.Size(471, 13);
            this.lblBaglantiBilgi.TabIndex = 13;
            this.lblBaglantiBilgi.Text = "(..SQL Server Authentication ile Baglamak istiyorsanız Aşagıdaki bilgillerin dold" +
    "urulması zorunludur..)";
            this.lblBaglantiBilgi.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // lblyanacakUserID
            // 
            this.lblyanacakUserID.AutoSize = true;
            this.lblyanacakUserID.Location = new System.Drawing.Point(271, 129);
            this.lblyanacakUserID.Name = "lblyanacakUserID";
            this.lblyanacakUserID.Size = new System.Drawing.Size(185, 13);
            this.lblyanacakUserID.TabIndex = 15;
            this.lblyanacakUserID.Text = "=>Bu Alanın Doldurulması zorunludur!!";
            this.lblyanacakUserID.Visible = false;
            // 
            // lblYanacakPsssword
            // 
            this.lblYanacakPsssword.AutoSize = true;
            this.lblYanacakPsssword.Location = new System.Drawing.Point(268, 164);
            this.lblYanacakPsssword.Name = "lblYanacakPsssword";
            this.lblYanacakPsssword.Size = new System.Drawing.Size(188, 13);
            this.lblYanacakPsssword.TabIndex = 16;
            this.lblYanacakPsssword.Text = "=> Bu Alanın Doldurulması zorunludur!!";
            this.lblYanacakPsssword.Visible = false;
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(165, 199);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(86, 33);
            this.btnBaglan.TabIndex = 8;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 270);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(435, 14);
            this.progressBar1.TabIndex = 17;
            // 
            // SQL_Baglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 286);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.lblYanacakPsssword);
            this.Controls.Add(this.lblyanacakUserID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBaglantiBilgi);
            this.Controls.Add(this.cmbBaglantitipim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbUserID);
            this.Controls.Add(this.txbServer);
            this.Controls.Add(this.label1);
            this.Name = "SQL_Baglanti";
            this.Text = "Veri Tabani Baglanti";
            this.Load += new System.EventHandler(this.SQL_Baglanti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.TextBox txbUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBaglantitipim;
        private System.Windows.Forms.Label lblBaglantiBilgi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblyanacakUserID;
        private System.Windows.Forms.Label lblYanacakPsssword;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}