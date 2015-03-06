using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace Michaels_Stuff.Utils
{
    public class EmailUtility
    {
            // SenMail
            public static bool SendEmail(MailMessage message)
            {
                try
                {
                    var smtp = new SmtpClient { Host = "smtp.live.com", Port = 587 };
                    message.IsBodyHtml = false;
                    smtp.Send(message);
                    message.Dispose();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        public static bool SendHotmail()
        {

            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("youremail@hotmail.com");
            mail.To.Add("email@gmail.com");
            mail.Subject = "Test Mail - 1";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = "Hello from Kendallsoft Academy";
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("youremail@hotmail.com", "password");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            return true;

        }

        }
    }
