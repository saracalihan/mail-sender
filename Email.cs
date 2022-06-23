using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace email_sender
{
    internal class Mail
    {
        public String Sender { get; set; }

        public String DisplayName { get; set; }

        public List<String> Receivers { get; }

        public String Subject { get; set; }

        public String Body { get; set; }

        public Boolean IsBodyHtml { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }

        public String Host { get; set; }

        public Int32 Port { get; set; }

        public Boolean EnableSSL { get; set; }

        private readonly SmtpClient client;

        private readonly MailMessage message;

        public Mail()
        {
            this.client = new SmtpClient();
            this.message = new MailMessage();
            this.Receivers = new List<string>();
            this.IsBodyHtml = true;

        }

        public void Init()
        {

            this.message.From = this.DisplayName != null || this.DisplayName != String.Empty ?
                new MailAddress(Sender, DisplayName) : new MailAddress(Sender);
            if (this.Receivers != null && this.Receivers.Count != 0)
            {
                foreach (var receiver in Receivers)
                {
                    this.message.To.Add(receiver);
                }
            }
            this.message.Subject = Subject;
            this.message.Body = Body;
            this.message.IsBodyHtml = IsBodyHtml;


            this.client.Host = Host;
            this.client.Port = Port;
            this.client.EnableSsl = EnableSSL;
            this.client.Credentials = new System.Net.NetworkCredential(Username, Password);
        }

        public Boolean Send()
        {
            this.client.Send(message);
            return true;
        }
    }
}
