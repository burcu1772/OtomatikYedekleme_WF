using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OtomatikYedekleme_WF
{
    
  
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            
        private void btnMailBİlgileriKaydet_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txbAdres1.Text)|| string.IsNullOrEmpty(txbMailicerik.Text) || string.IsNullOrEmpty(txbKonu.Text) || string.IsNullOrEmpty(txbSifre.Text) || string.IsNullOrEmpty(cmbgonderen.Text))
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!");

            if (Directory.Exists(@"C:\BackupDB-Settings"))
            {
            }
            else
            {
                Directory.CreateDirectory(@"C:\BackupDB-Settings");
            }

            if (txbGonderen.Text.Contains("@") && txbAdres1.Text.Contains("@"))
            {
                
                    XmlTextWriter yaz = new XmlTextWriter(SQL_Baglanti.XmlDosyaPath, System.Text.UTF8Encoding.UTF8);
                    yaz.Formatting = Formatting.Indented;
                    try
                    {
                    Encoding iso = Encoding.GetEncoding("ISO-8859-1");
                    Encoding utf8 = Encoding.UTF8;
                    string sifre = iso.GetString(utf8.GetBytes(txbSifre.Text));
                 
                        yaz.WriteStartDocument();
                        yaz.WriteStartElement("BackupAyarları");
                        yaz.WriteStartElement("Ayarlar");
                        yaz.WriteAttributeString("BackUp", "burcu.acar1772@gmail.com");
                        yaz.WriteElementString("GonderenMail", txbGonderen.Text);
                        yaz.WriteElementString("GonderenMailEkBilgi", cmbgonderen.Text);
                        yaz.WriteElementString("GonderenSifre",sifre);
                        yaz.WriteElementString("GidenMail", txbAdres1.Text);
                        //yaz.WriteElementString("GidenİkinciMail", txbGidenikinciMail.Text);
                        yaz.WriteElementString("MailKonu", txbKonu.Text);
                        yaz.WriteElementString("MailIcerik", txbMailicerik.Text);



                    if (checkBoxYedeklemeDosyasiEkle.Checked == true)
                            yaz.WriteElementString("YedeklemeDosyasiEkteGelsin", "Evet");
                        else
                            yaz.WriteElementString("YedeklemeDosyasiEkteGelsin", "Hayır");
                        if (checkBoxYedeklemeBilgisiGonder.Checked == true)
                            yaz.WriteElementString("HerYedeklemedeBildirim", "Evet");
                        else
                            yaz.WriteElementString("HerYedeklemedeBildirim", "Hayır");
                       

                        yaz.WriteEndElement();
                        yaz.WriteEndElement();
                        yaz.Close();
                    prgsbarMail.Maximum = 3000000;

                    prgsbarMail.Minimum = 100;

                    for (int i = 100; i < 3000000; i += 10)

                    {

                        prgsbarMail.Value = i;

                    }
                   
                    }
                    catch (Exception ex)
                    {
                        Logger log = new Logger();
                        log.Logla("Xml YAZDIRMA HATASI!!"+ex.ToString(), true);
                    MessageBox.Show("Loglama Yapıldı!! Lütfen Olay Görüntüleyicisine Gidiniz!! ");
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
                                    case "GonderenMailEkBilgi":
                                        SQL_Baglanti.GonderenMailEkBilgi = oku.ReadString();
                                        break;

                                case "GonderenSifre":
                                    SQL_Baglanti.GonderenMailSifre = oku.ReadString();
                                    break;
                                case "GidenMail":
                                        SQL_Baglanti.GidenMail = oku.ReadString();
                                        break;
                                    //case "GidenİkinciMail":
                                    //SQL_Baglanti.GidenİkinciMAil = oku.ReadString();
                                    //    break;
                                    case "MailKonu":
                                        SQL_Baglanti.MailKonu = oku.ReadString();
                                        break;
                                    case "MailIcerik":
                                        SQL_Baglanti.MailIcerik = oku.ReadString();
                                        break;
                                    case "MailGondermeSaati":
                                        SQL_Baglanti.Mailsaat = oku.ReadString();
                                        break;
                                    case "MAilGOndermeTarihi":
                                        SQL_Baglanti.Mailtarih = oku.ReadString();
                                        break;
                                    case "MailGondermeAraligi":
                                        SQL_Baglanti.MailGOndermearalık = oku.ReadString();
                                        break;

                                    case "YedeklemeDosyasiEkteGelsin":
                                        SQL_Baglanti.MailDosyaEkteGelsinMi = oku.ReadString();
                                        break;
                                    case "HerYedeklemedeBildirim":
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
                    
                        Form1 gecis = new Form1();
                    this.Hide();
                        gecis.ShowDialog();
                   
                    }
                    catch (Exception ex)
                    {
                        string hata = ex.ToString();
                        Logger log = new Logger();
                        log.Logla("Xml OKUMA HATASI: " + hata + "", true);
                    MessageBox.Show("Loglama Yapıldı!! Lütfen Olay Görüntüleyicisine Gidiniz!!");

                }


                }
            }
        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Mail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}