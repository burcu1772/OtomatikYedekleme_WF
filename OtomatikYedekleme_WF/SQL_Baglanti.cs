using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OtomatikYedekleme_WF
{
    public partial class SQL_Baglanti : Form
    {
        public SQL_Baglanti()
        {
            InitializeComponent();
        }
        public static string server = null;
        public static string database = "master;";
        public static string userID = null;
        public static string password = null;
        public static string baglantip = null;
        public static string klasor = null;
        public static string pcAdi = System.Environment.MachineName;
        public static string XmlDosyaPath = "C:\\BackupDB-Settings\\Yedek.xml";
        public static string HerBackuptaBildirim = "Hayır";
        public static string VarsayilanYedeklemeKlasoru = null;
        public static string GonderenMail = null;
        public static string GonderenMailEkBilgi = null;
        public static string GonderenMailSifre = null;
        public static string GidenMail = null;
        //public static string GidenİkinciMAil = null;
        public static string MailBaslik = null;
        public static string MailKonu = null;
        public static string MailIcerik = null;
        public static string MailDosyaEkteGelsinMi = "Evet";
        public static string Mailsaat = null;
        public static string Mailtarih = null;
        public static string MailGOndermearalık = null;
        private void SQL_Baglanti_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\BackupDB"))
            { }

            else
            {
                Directory.CreateDirectory(@"C:\BackupDB");
            }

            if (Directory.Exists(@"C:\BackupDB-Settings"))
            { }
            else
            {
                Directory.CreateDirectory(@"C:\BackupDB-Settings");
            }
            XmlTextReader oku = new XmlTextReader(SQL_Baglanti.XmlDosyaPath);
            try
            {
                while (oku.Read()) 
                {
                    if (oku.NodeType == XmlNodeType.Element)
                    {
                        switch (oku.Name)
                        {
                            case "GonderenMail":
                                SQL_Baglanti.GonderenMail = oku.ReadString();
                                break;
                            case "GonderenSifre":
                                SQL_Baglanti.GonderenMailSifre = oku.ReadString();
                                break;
                            case "GidenMail":
                                SQL_Baglanti.GidenMail = oku.ReadString();
                                break;

                            case "MailBaslik":
                                SQL_Baglanti.MailBaslik = oku.ReadString();
                                break;
                            case "MailIcerik":
                                SQL_Baglanti.MailIcerik = oku.ReadString();
                                break;
                            case "BackupDosyasiEkteGelsin":
                                SQL_Baglanti.MailDosyaEkteGelsinMi = oku.ReadString();
                                break;
                            case "HerBackuptaBildirim":
                                SQL_Baglanti.HerBackuptaBildirim = oku.ReadString();
                                break;
                            case "VarsayilanYedeklemeKlasoru":
                                SQL_Baglanti.VarsayilanYedeklemeKlasoru = oku.ReadString();
                                break;
                        }
                    }
                }
                oku.Close();
                oku.Dispose();
            }
            catch (Exception ex)
            {
                string hata = ex.ToString();
                Logger log = new Logger();
                log.Logla("Xml Okuma HATASI: " + hata + "", true);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            server = txbServer.Text;
            userID = txbUserID.Text;
            password = txbPassword.Text;
            baglantip = cmbBaglantitipim.Text;
           
            if (string.IsNullOrEmpty(server)&&string.IsNullOrEmpty(baglantip))
                MessageBox.Show("Lütfen eksiksiz bilgi giriniz");
            else
            {
                if (cmbBaglantitipim.Text.Contains("Windows Authentication"))
                {
                    string connectionString = "Data Source=" + server + "; Initial Catalog=master;Trusted_connection=true";
                    SqlConnection con = new SqlConnection(connectionString);
                    try
                    {
                        con.Open();
                       
                        progressBar1.Maximum = 3000000;

                        progressBar1.Minimum = 100;

                        for (int i = 100; i < 3000000; i+=10)

                        {

                            progressBar1.Value = i;

                        }
                       
                        Form1 ikinciform = new Form1();
                        this.Hide();
                        ikinciform.ShowDialog();
                       

                    }
                    catch (Exception ex)
                    {
                        Logger log = new Logger();
                        log.Loglayalim(ex);
                        MessageBox.Show("Loglama Yapıldı,Olay Görüntüleyicisine Gidiniz!!");

                    }
                }
                else if (cmbBaglantitipim.Text.Contains("SQL Server Authentication"))
                {

                    if (string.IsNullOrEmpty(userID))
                    {
                        lblyanacakUserID.Visible = true;
                        lblBaglantiBilgi.Visible = true;

                    }
                    if (string.IsNullOrEmpty(password))
                    {
                        lblYanacakPsssword.Visible = true;
                        lblBaglantiBilgi.Visible = true;
                    }
                    SqlConnection conn = new SqlConnection("Server=" + server + ";Database=master;user id=" + userID + ";Password=" + password);
                    try
                    {
                        conn.Open();

                      

                        conn.Close();
                        conn.Dispose();

                        progressBar1.Maximum = 3000000;

                        progressBar1.Minimum = 100;

                        for (int i = 100; i < 3000000; i+=10)

                        {

                            progressBar1.Value = i;

                        }
                      
                      
                        Form1 ikinciform = new Form1();
                        this.Hide();
                        ikinciform.ShowDialog();
                        
                    }
                    catch (Exception ex)
                    {

                        Logger log = new Logger();
                        log.Loglayalim(ex);
                        MessageBox.Show("Loglama Yapıldı");

                    }
                    

                }
            }
            
        }
        
           
    }
}
