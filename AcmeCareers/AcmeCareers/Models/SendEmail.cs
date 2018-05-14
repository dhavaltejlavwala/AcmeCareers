using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace AcmeCareers.Models
{
    public class SendEmail
    {
        public SendEmail(JobApplication Model)
        {
            try
            {
                var toEmail = "tejlavwaladhaval@gmail.com"; //"careers@acme.com.au";
                var EmailSubject = "New Job Application";
                var EMailBody = Model.Name;
 
                WebMail.SmtpServer = "smtp.gmail.com";

                WebMail.SmtpPort = 587;
                WebMail.SmtpUseDefaultCredentials = true;

                WebMail.EnableSsl = true;

                WebMail.UserName = "tejlavwaladhaval@gmail.com";
                WebMail.Password = "intelinsidepentium4";

                WebMail.From = "";

                WebMail.Send(to: toEmail, subject: EmailSubject, body: EMailBody, isBodyHtml: true);
                
            }
            catch (Exception)
            {
               

            }
        }
         
    }
}