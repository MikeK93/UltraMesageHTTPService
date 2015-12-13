using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace UltraMessageHTTPSerice.BL
{
    public class EmailProxy
    {
        public bool SendMessage(string email, string subject, string body)
        {
            var toAddress = new MailAddress(email, "To Name");
            var fromAddress = new MailAddress("alexchehotskiy@gmail.com", "From Name");
            const string fromPassword = "25011994";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            try
            {
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}