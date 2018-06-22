using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClientManager.Web.Controllers
{
    public class ContactsController:Controller
    {

        public ContactsController()
        {
            
        }
       
        public void SendMessage(string to, string subject, string body)
        {


            var message= ComposeMessage(to ,subject, body);
            SendEmail(message);          
        }

        private MailMessage ComposeMessage(string to, string subject, string body)
        {
            MailAddress From = new MailAddress("salpucandrei@gmail.com");

            MailAddress To = new MailAddress(to);

            MailMessage message = new MailMessage(From, To);
            message.Body = body;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = subject;
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            return message;
        }

        private void SendEmail(MailMessage message)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials= new NetworkCredential("salpucandrei@gmail.com","cristinaa321");
            client.EnableSsl = true;
            try
            {
                client.Send(message);
            }
            catch (Exception e)
            {

            }
        }

    }
}
