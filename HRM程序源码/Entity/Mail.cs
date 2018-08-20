using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 可被序列化的邮件配置字段类
    /// </summary>
    [Serializable]
    public class Mail
    {
        //SMTP地址
        private string Url;
        public string url
        {
            get
            {
                return this.Url;
            }
            set
            {
                if (value.Contains("smtp") == true)
                {
                    this.Url = value;
                }
                else
                {
                    throw new HrmException("请输入正确的SMTP服务器地址！");
                }
            }
        }

        //SMTP端口
        private int Port;
        public int port
        {
            get
            {
                return Port;
            }
            set
            {
                if (value > 0 && value < 65535)
                {
                    this.Port = value;
                }
                else
                {
                    throw new HrmException("端口超出范围！");
                }
            }
        }
        
        //发件账号
        public string account { get; set; }
        
        //账号密码
        public string pass { get; set; }

        //邮件标题
        private string Title;
        public string title
        {
            get
            {
                return this.Title;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("邮件标题不能为空");
                }
                else
                {
                    this.Title = value;
                }
            }
        }

        //邮件正文
        private string Text;
        public string text
        {
            get
            {
                return this.Text;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("邮件正文不能为空");
                }
                else
                {
                    this.Text= value;
                }
            }
        }


    }
}
