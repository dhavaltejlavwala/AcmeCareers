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
                //Configuring webMail class to send emails  
                //gmail smtp server  
                WebMail.SmtpServer = "smtp.gmail.com";
                //gmail port to send emails  
                WebMail.SmtpPort = 587;
                WebMail.SmtpUseDefaultCredentials = true;
                //sending emails with secure protocol  
                WebMail.EnableSsl = true;
                //EmailId used to send emails from application  
                WebMail.UserName = "tejlavwaladhaval@gmail.com";
                WebMail.Password = "intelinsidepentium4";

                //Sender email address.  
                WebMail.From = "";

                //Send email  
                WebMail.Send(to: toEmail, subject: EmailSubject, body: EMailBody, isBodyHtml: true);
                
            }
            catch (Exception)
            {
               

            }
        }
         
    }
}