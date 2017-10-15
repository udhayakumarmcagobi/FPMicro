using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBMicor.Web.Application.Core
{
    public class EmailService
    {
        public bool SendEmail(string subject, string emailBody, string toAddresses, string fromAddress)
        {
            var mailMessage = new MailMessage(); //Email Message            
            var SMTPClient = new SmtpClient(); //Email client
            string sSMTPServer = WebConfigurationManager.AppSettings["SMTP"];
            mailMessage.To.Add(new MailAddress(toAddresses)); //To Address
            mailMessage.From = new MailAddress(fromAddress); //From address
            mailMessage.Subject = subject;
            //Message type is HTML
            mailMessage.IsBodyHtml = true;
            
            //Assign body content
            mailMessage.Body = emailBody;

            SMTPClient = new SmtpClient(sSMTPServer);
            SMTPClient.Send(mailMessage);
            return true;
        }
    }
}