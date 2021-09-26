using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OtomatikYedekleme_WF
{
    class Logger
    {
        public void Logla(string LogMesaji, bool HataMi)
        {
            if (!EventLog.SourceExists("Otomatik Yedek"))
            {
                EventLog.CreateEventSource("Otomatik Yedek", "Otomatik Yedek");
            }

            EventLog log = new EventLog();
            log.Source = "Otomatik Yedek";
            log.EnableRaisingEvents = true;
            if (HataMi)
            {

                log.WriteEntry(LogMesaji, EventLogEntryType.Error);

            }
            else
            {
                log.WriteEntry(LogMesaji, EventLogEntryType.Information);

            }

        }



        public void Loglayalim(Exception hata)
        {

            SqlException hatam = hata as SqlException;
            if (hatam == null)
            {
                Logla(hatam.Message, false);
            }
            else//Sql hatası gelmiş demektir
            {
                SqlHatalarim(hata.Message, hatam.Errors);
            }

        }

     
        private void SqlHatalarim(string LogMesaji, SqlErrorCollection SqlHatalari)
        {
            StringBuilder sb = new StringBuilder();//Hatanın Yapısını Olusturuyoruz

            foreach (SqlError item in SqlHatalari)
            {
                sb.AppendLine("Hata Tarihi");
                sb.Append(DateTime.Now);
                sb.Append(Environment.NewLine);
                sb.AppendLine("Satır Numarası");
                sb.Append(item.LineNumber);
                sb.Append(Environment.NewLine);
                sb.AppendLine("Mesaj:");
                sb.Append(item.Message);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                sb.Append(LogMesaji);
                Logla(sb.ToString(), true);
            }
        }


         public void emailHatalarim(string LogMesaji, string mailHatalari)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in mailHatalari)
            {

                sb.AppendLine("Hata Tarihi");
                sb.Append(DateTime.Now);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                sb.AppendLine("Mesaj:");
                sb.Append(item.ToString());


                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
                sb.Append(LogMesaji);
                Logla(sb.ToString(), true);
            }

        }
        public void loglat(Exception hata)
        {
            var hatam = hata as SmtpException;
                 if(hatam!=null)
                {
                Logla(hata.Message,true);

                }
            else
            {
                Logla(hata.Message, false);
            }
        }
       
    }
}
