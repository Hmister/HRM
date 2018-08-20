using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Mail;
using System.Net;

namespace FindPass
{
    /// <summary>
    /// 发送邮件类
    /// </summary>
    public class SendM
    {
        /// <summary>
        /// 读取邮件配置
        /// </summary>
        /// <returns></returns>
        private static Entity.Mail LoadMail()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\Config\BackMail.XML", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Entity.Mail m = (Entity.Mail)bf.Deserialize(fs);
            fs.Close();
            return m;
       }


        /// <summary>
        /// /发送邮件的方法
        /// </summary>
        public static void SendMail( string ToWhere,string pass)
        {
            Entity.Mail mm = LoadMail();
            SmtpClient client = new SmtpClient(mm.url);   //设置邮件协议

            client.UseDefaultCredentials = false;//这一句得写前面

            client.DeliveryMethod = SmtpDeliveryMethod.Network; //通过网络发送到Smtp服务器

            client.Credentials = new NetworkCredential(mm.account, mm.pass); //通过用户名和密码 认证

            MailMessage mmsg = new MailMessage(new MailAddress(mm.account), new MailAddress(ToWhere)); //发件人和收件人的邮箱地址

            mmsg.Subject ="系统密码找回";      //邮件主题

            mmsg.SubjectEncoding = Encoding.UTF8;   //主题编码

            mmsg.Body = "新的登陆密码为："+pass+"请登陆后及时修改！";         //邮件正文

            mmsg.BodyEncoding = Encoding.UTF8;      //正文编码

            mmsg.IsBodyHtml = true;    //设置为HTML格式          

            mmsg.Priority = MailPriority.High;   //优先级
            try

            {
                client.Send(mmsg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }






    }
}
