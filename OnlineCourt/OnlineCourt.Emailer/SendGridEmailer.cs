using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourt.Emailer
{
    public static class SendGridEmailer
    {
        static string _apikey = "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";
        static string _fromaddress = "noreply@pepperminttechnology.co.uk";

        public static void SendEmail(string[] recipients, string subject, string body, Tuple<string, byte[]>[] attachments = null)
        {
            if (recipients == null || recipients.Length == 0 || recipients.All(x => string.IsNullOrWhiteSpace(x)))
            {
                throw new Exception("Unable to send email using SendGrid as no recipients have been provided");
            }

            var client = new SendGridClient(WebRequest.DefaultWebProxy, _apikey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(_fromaddress),
                Subject = subject,
                PlainTextContent = body
            };

            foreach (var recipient in recipients)
            {
                if (!string.IsNullOrWhiteSpace(recipient))
                {
                    msg.AddTo(new EmailAddress(recipient));
                }
            }

            if (attachments != null)
            {
                foreach (var attachment in attachments)
                {
                    msg.AddAttachment(attachment.Item1, Convert.ToBase64String(attachment.Item2));
                }
            }

            client.SendEmailAsync(msg);
        }
    }
}
