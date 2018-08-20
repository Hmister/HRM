using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace BLL
{
    /// <summary>
    /// 邮件发送 逻辑类
    /// </summary>
    public class MailToBLL
    {

        //邮件配置字段
        //账号
        private static string Account;
        //密码
        private static string Pass;
        //服务器
        private static string SMTP;

        /// <summary>
        /// 加载发送邮件服务器配置信息
        /// </summary>
        private static void LoadSendMailSet()
        {
            Entity.Mail m = BLL.FileUse.OpenMailSet("MailSet");
            Account = m.account.Trim(); ;
            Pass = m.pass.Trim();
            SMTP = m.url.Trim();
        }


        /// <summary>
        /// /发送邮件的方法
        /// </summary>
        private static void SendMail(Entity.Mail mail, string ToWhere)
        {

            SmtpClient client = new SmtpClient(SMTP);   //设置邮件协议

            client.UseDefaultCredentials = false;//这一句得写前面

            client.DeliveryMethod = SmtpDeliveryMethod.Network; //通过网络发送到Smtp服务器

            client.Credentials = new NetworkCredential(Account, Pass); //通过用户名和密码 认证

            MailMessage mmsg = new MailMessage(new MailAddress(Account), new MailAddress(ToWhere.Trim())); //发件人和收件人的邮箱地址

            mmsg.Subject = mail.title;      //邮件主题

            mmsg.SubjectEncoding = Encoding.UTF8;   //主题编码

            mmsg.Body = mail.text;         //邮件正文

            mmsg.BodyEncoding = Encoding.UTF8;      //正文编码

            mmsg.IsBodyHtml = true;    //设置为HTML格式          

            mmsg.Priority = MailPriority.High;   //优先级
            try

            {
                client.Send(mmsg);
            }
            catch (Exception ex)
            {
                throw new Entity.HrmException(ex.Message);
            }
        }


        /// <summary>
        /// 批量发送邮件方法
        /// </summary>
        public static void SendToPer(Entity.Mail mail, System.Collections.ArrayList urls)
        {
            //加载邮件配置
            LoadSendMailSet();

            for (int i = 0; i < urls.Count; i++)
            {
                //发送邮件
                SendMail(mail, urls[i].ToString().Trim());
            }
        }


    }
}
