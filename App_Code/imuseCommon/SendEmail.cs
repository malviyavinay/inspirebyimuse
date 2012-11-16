using System;
using System.Configuration;
//using OpenSmtp.Mail;
using System.Text;
using System.IO;
using System.Net;
//using System.Net.Mail;
using System.Web.Mail;

namespace imuse.Common
{
    public class SendEmail
    {
        /// <summary>
        /// To Send Mail
        /// </summary>
        /// <param name="ToAddress"></param>
        /// <param name="FromAddress"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <returns></returns>
        public Boolean SendMails(string ToAddress, string FromAddress, string Subject, string Body)
        {
            try
            {
                //if (BaseClass.IsTestMode())
                //    ToAddress = "prashant.gupta@cebsworldwide.com";
                //String MailSmtpServer = ConfigurationManager.AppSettings["SMTPServer"];
                //String MailSmtpPort = ConfigurationManager.AppSettings["SMTPPort"];
                //String MailSmtpServerUserName = ConfigurationManager.AppSettings["SMTPUser"];
                //String MailSmtpServerPassword = ConfigurationManager.AppSettings["SMTPPassword"];
                //EmailAddress FromName = new EmailAddress(FromAddress, ConfigurationManager.AppSettings["AdminEmailName"]);
                //EmailAddress MailTo = new EmailAddress(ToAddress);
                //MailMessage objMessage = new MailMessage(FromName, MailTo) { Subject = Subject, HtmlBody = Body };
                //Smtp smtp = new Smtp();
                //smtp.Host = MailSmtpServer;
                //smtp.Port = Convert.ToInt32(MailSmtpPort);
                //if (MailSmtpServerUserName.Length > 0 && MailSmtpServerPassword.Length > 0)
                //{
                //    smtp.Username = MailSmtpServerUserName;
                //    smtp.Password = MailSmtpServerPassword;
                //}
                //smtp.SendMail(objMessage);
                //return true;                

                //MailMessage objMessage = new MailMessage();
                //objMessage.From = new MailAddress(FromAddress);
                //objMessage.To.Add(ToAddress);
                //objMessage.IsBodyHtml = true;
                //objMessage.Body = Body;
                //objMessage.BodyEncoding = Encoding.UTF8;
                //objMessage.Subject = Subject;
                //objMessage.SubjectEncoding = Encoding.UTF8;

                //SmtpClient smtp = new SmtpClient();
                //smtp.EnableSsl = true;
                //smtp.Host = MailSmtpServer;
                //smtp.Port = Convert.ToInt32(MailSmtpPort);
                //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //smtp.UseDefaultCredentials = false;
                ////smtp.Timeout = 600;                
                //smtp.Credentials = new System.Net.NetworkCredential(MailSmtpServerUserName, MailSmtpServerPassword);
                //smtp.Send(objMessage);
                //return true;

                String MailSmtpServer = ConfigurationManager.AppSettings["SMTPServer"];
                String MailSmtpPort = ConfigurationManager.AppSettings["SMTPPort"];
                String MailSmtpServerUserName = ConfigurationManager.AppSettings["SMTPUser"];
                String MailSmtpServerPassword = ConfigurationManager.AppSettings["SMTPPassword"];
                MailMessage msg = new MailMessage();
                msg.From = FromAddress;
                msg.To = ToAddress;
                msg.Bcc = MailSmtpServerUserName;
                msg.Subject = Subject;
                msg.BodyFormat = MailFormat.Html;
                msg.Body = Body;
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", MailSmtpServerUserName);
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", MailSmtpServerPassword);
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", MailSmtpPort);
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
                SmtpMail.SmtpServer = MailSmtpServer;
                msg.Priority = MailPriority.High;
                SmtpMail.Send(msg);
                return true;
            }
            catch (Exception ex)
            {
               // new ErrorLogManager().SaveErrorLog(ex, "SendEmail.cs", "SendMails");                
                return false;
            }
        }


        /// <summary>
        /// To Send Mail with attachements
        /// </summary>
        /// <param name="ToAddress"></param>
        /// <param name="FromAddress"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <param name="objAttachments"></param>
        /// <returns></returns>
        /// 


        public Boolean SendInvitationMails(string ToAddress, string FromAddress, string Subject, string Body, string[] bccval)
        {
            try
            {
                String MailSmtpServer = ConfigurationManager.AppSettings["SMTPServer"];
                String MailSmtpPort = ConfigurationManager.AppSettings["SMTPPort"];
                String MailSmtpServerUserName = ConfigurationManager.AppSettings["SMTPUser"];
                String MailSmtpServerPassword = ConfigurationManager.AppSettings["SMTPPassword"];
                MailMessage msg = new MailMessage();
                msg.From = FromAddress;
                
                //msg.Bcc = MailSmtpServerUserName;
                string strBcc="";
                for (int i = 0; i < bccval.Length; i++)
                {
                    if(strBcc=="")
                        strBcc += bccval[i].ToString();
                    else
                        strBcc = strBcc + ";" + bccval[i].ToString();
                }

                msg.To = strBcc;
               // msg.Cc = strBcc;

                msg.Subject = Subject;
                msg.BodyFormat = MailFormat.Html;
                msg.Body = Body;
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", MailSmtpServerUserName);
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", MailSmtpServerPassword);
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", MailSmtpPort);
                msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
                
                SmtpMail.SmtpServer = MailSmtpServer;
                msg.Priority = MailPriority.High;
                SmtpMail.Send(msg);
                return true;
            }
            catch (Exception ex)
            {
               // new ErrorLogManager().SaveErrorLog(ex, "SendEmail.cs", "SendMails");                
                return false;
            }
        }


        public Boolean SendMailsWithAttachment(string ToAddress, string FromAddress, string Subject, string Body, String objAttachments)
        {
            try
            {
                String MailSmtpServer = ConfigurationManager.AppSettings["SMTPServer"];
                String MailSmtpPort = ConfigurationManager.AppSettings["SMTPPort"];
                String MailSmtpServerUserName = ConfigurationManager.AppSettings["SMTPUser"];
                String MailSmtpServerPassword = ConfigurationManager.AppSettings["SMTPPassword"];
                //EmailAddress FromName = new EmailAddress(FromAddress, ConfigurationManager.AppSettings["AdminEmailName"]);
                //EmailAddress MailTo = new EmailAddress(ToAddress);
                //MailMessage objMessage = new MailMessage(FromName, MailTo) { Subject = Subject, HtmlBody = Body };
                //string[] Attachements = objAttachments.Split(',');
                ////For Send Details
                //for (int i = 0; i < Attachements.Length - 1; i++)
                //{
                //    objMessage.AddAttachment(Path.GetFullPath(Attachements[i]));
                //}
                ////For Invoice
                //if (Attachements.Length == 1 && objAttachments.Trim() != "")
                //{
                //    objMessage.AddAttachment(Path.GetFullPath(objAttachments));
                //}
                //Smtp smtp = new Smtp();
                //smtp.Host = MailSmtpServer;
                //if (MailSmtpServerUserName.Length > 0 && MailSmtpServerPassword.Length > 0)
                //{
                //    smtp.Username = MailSmtpServerUserName;
                //    smtp.Password = MailSmtpServerPassword;
                //}
                //smtp.SendMail(objMessage);




                //MailMessage objMessage = new MailMessage();
                //objMessage.From = new MailAddress(FromAddress);
                //objMessage.To.Add(ToAddress);
                //objMessage.IsBodyHtml = true;
                //objMessage.Body = Body;
                //objMessage.Subject = Subject;
                ////objMessage.Attachments.Add(Path.GetFullPath(Attachements[i]));

                //SmtpClient smtp = new SmtpClient();
                //smtp.Host = MailSmtpServer;
                //smtp.Port = Convert.ToInt32(MailSmtpPort);
                //smtp.Credentials = new System.Net.NetworkCredential(MailSmtpServerUserName, MailSmtpServerPassword);
                //smtp.Send(objMessage);
                return true;                
            }
            catch (Exception ex)
            {
             //   new ErrorLogManager().SaveErrorLog(ex, "SendEmail.cs", "SendMails");
                return false;                
            }
        }       
    }
}
