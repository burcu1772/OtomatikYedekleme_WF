
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;


namespace OtomatikYedekleme_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string server = SQL_Baglanti.server;
        string database = SQL_Baglanti.database;
        string userID = SQL_Baglanti.userID;
        string password = SQL_Baglanti.password;
        string klasor = SQL_Baglanti.klasor;
        string GonderenMail = SQL_Baglanti.GonderenMail;
        string GonderenMailEkBilgi = SQL_Baglanti.GonderenMailEkBilgi;
        string GidenMail = SQL_Baglanti.GidenMail;
        //string GidenikinciMail = SQL_Baglanti.GidenİkinciMAil;
        string GonderenMailSifre = SQL_Baglanti.GonderenMailSifre;
        string MailIcerik = SQL_Baglanti.MailIcerik;
        string MailBaslik = SQL_Baglanti.MailBaslik;
        string MailKonu = SQL_Baglanti.MailKonu;
        string MailDosyaEkteGelsinMi = SQL_Baglanti.MailDosyaEkteGelsinMi;
        string HerYedeklemedeBildirim = SQL_Baglanti.HerBackuptaBildirim;
        string XmlPath = SQL_Baglanti.XmlDosyaPath;

        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          
            btnYedekle.Enabled = true;
            string connectionString = "Data Source=" + server + "; Initial Catalog =master;Trusted_Connection=true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("SELECT name FROM sys.databases", conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbDatabases.Items.Add(reader["name"].ToString());
            }
            conn.Close();
            conn.Dispose();
            MessageBox.Show("Database Baglantısı gerçekleşti!!", "BİLGİ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textAralik.Text = Convert.ToString(0);
        }
        string dosyayolu;
        public void Backup()
        {
            if (string.IsNullOrEmpty(txbklasor.Text))
            {
                dosyayolu = @"C:\BackUP";
                Directory.CreateDirectory(@"C:\BackUP");
                txbklasor.Text = @"C:\BackUP";
            }
            if (string.IsNullOrEmpty(cmbDatabases.Text))
                MessageBox.Show("Lütfen Baglanıp Bir Veri Tabanı Seçiniz", "Uyarı:Eksik Ya Da Hatalı Bilgi!!");
            else
            {
                dosyayolu = txbklasor.Text;
                database = cmbDatabases.Text;


                timer1.Enabled = true;

                SqlConnection conn = new SqlConnection("Server=" + server + ";Database=" + database + ";user id=" + userID + ";Password=" + password);
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    var sqlKomut = "backup database " + database + " to disk='" + klasor + "\\" + database + ".bak'";
                    SqlCommand cmd = new SqlCommand(sqlKomut, conn);
                    var read = cmd.ExecuteReader();
                    
                }
                catch (Exception ex)
                {

                    Logger loglama = new Logger();
                    loglama.Loglayalim(ex);
                    MessageBox.Show("Loglama Yapıldı! Lütfen Olay Görüntüleyicisine Gidiniz!!");

                }
                conn.Close();
                    conn.Dispose();
                    MailMessage ePosta = new MailMessage();
                    ePosta.From = new MailAddress("" + GonderenMail + "" + GonderenMailEkBilgi + "");
                    ePosta.To.Add(GidenMail);
                    //ePosta.To.Add(GidenikinciMail);
                    ePosta.Subject = MailKonu;
                    ePosta.Body = MailIcerik;
                    if (MailDosyaEkteGelsinMi == "Evet")
                    {
                        ePosta.Attachments.Add(new Attachment(XmlPath));
                    }


                    if (HerYedeklemedeBildirim == "Evet")
                    {
                        SmtpClient smtp = new SmtpClient();
                        smtp.Credentials = new System.Net.NetworkCredential("" + GonderenMail + GonderenMailEkBilgi + "", "" + GonderenMailSifre + "");

                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        if (GonderenMailEkBilgi.Contains("gmail.com"))
                        {
                            smtp.Host = "smtp." + GonderenMailEkBilgi + "";
                        }
                        else if (GonderenMailEkBilgi.Contains("hotmail.com"))
                        {
                            smtp.Host = "smtp.live.com";
                        }
                    try
                    {
                        smtp.Send(ePosta);
                        sayac += 1;
                        lblSayi.Text = Convert.ToString(sayac);
                    }

                    catch (Exception ex)
                    {

                        Logger loglar = new Logger();

                        loglar.loglat(ex);
                        MessageBox.Show("Loglama yapıldı! Olay görüntleyicisine gidiniz...");
                    }
                        
                        ePosta.Dispose();






                    }
               

            }
        }
        string suankiZaman;
        public void timer1_Tick(object sender, EventArgs e)
        {
            suankiZaman = DateTime.Now.ToLongTimeString();
            if (suankiZaman == dtsaat.Text)
            {
                if (radioSaat.Checked == true)
                {
                    dtsaat.Text = DateTime.Now.AddHours(Convert.ToDouble(textAralik.Text)).ToString();
                    dateTimetarih.Text = DateTime.Now.AddHours(Convert.ToDouble(textAralik.Text)).ToString();
                }

                if (radiobtndakika.Checked == true)
                {
                    dtsaat.Text = DateTime.Now.AddMinutes(Convert.ToDouble(textAralik.Text)).ToString();
                    dateTimetarih.Text = DateTime.Now.AddMinutes(Convert.ToDouble(textAralik.Text)).ToString();
                }
                if (radioGun.Checked == true)
                {
                    dateTimetarih.Text = DateTime.Now.AddDays(Convert.ToDouble(textAralik.Text)).ToString();
                }

                Backup();
            }
        }
                private void btnDosyaSec_Click(object sender, EventArgs e)
        {

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txbklasor.Text = folderBrowserDialog1.SelectedPath;

            }
        }
        
        private void btnBackupGo_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
            btndatabase.Enabled = false;
            btnDosyaSec.Enabled = false;
            dateTimetarih.Enabled = false;
            radiobtndakika.Enabled = false;
            dtsaat.Enabled = false;
            radioGun.Enabled = false;
            radioSaat.Enabled = false;
            btnYedekle.Enabled = false;
            cmbDatabases.Enabled = false;
            txbklasor.Enabled = false;
            textAralik.Enabled = false;
            lblBasladi.Enabled = true;
            lblGöstSayi.Enabled = true;
            lblSayi.Enabled = true;
           
         
        }

        private void btnAyarMail_Click(object sender, EventArgs e)
        {

            Mail ucuncusf = new Mail();
            this.Hide();
            ucuncusf.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dtsaat_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
      

     

      
    
