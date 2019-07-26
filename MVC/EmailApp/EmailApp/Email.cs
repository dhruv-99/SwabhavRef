using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace EmailApp
{
    class Email
    {
        public string senderEmail = ConfigurationManager.AppSettings["SenderEmail"];
        public string senderPassword = ConfigurationManager.AppSettings["Password"];
        string serverName = "smtp.gmail.com";
        int portNumber = 587;

        public void SendMail(string receiverEmail)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(receiverEmail);
                mail.Subject = "Hello from dhruv";
                mail.IsBodyHtml = true;
                mail.Body = "This message is from c# console app";
                using (SmtpClient client = new SmtpClient(serverName, portNumber))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(senderEmail,senderPassword);
                    client.Send(mail);
                }
            }
        }
    }
}
