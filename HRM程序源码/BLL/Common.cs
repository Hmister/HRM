using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;


namespace BLL
{
    /// <summary>
    /// 公共业务逻辑类
    /// </summary>
    public class Common
    {
        /// <summary>
        /// 测试网络连接的方法
        /// </summary>
        /// <returns></returns>
        public static bool ToInternet()
        {
            Ping p = new Ping();
            //淘宝网IP
            PingReply pip = p.Send("140.205.172.5");
            if (pip.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 测试服务器主机连接的方法
        /// </summary>
        /// <returns></returns>
        public static bool ToVPS()
        {
            Ping p = new Ping();
            //Jiuone网站服务器IP
            PingReply pip = p.Send("139.199.99.160");
            if (pip.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 最新软件版本号
        /// </summary>
        /// <returns></returns>
        public static int CheckUp()
        {
            WebClient MyWebClient = new WebClient();


            MyWebClient.Credentials = CredentialCache.DefaultCredentials;

            Byte[] pageData = MyWebClient.DownloadData("http://www.jiuone.cn/Items/HRM_Version.html"); 

            string page = Encoding.Default.GetString(pageData);
            return int.Parse(page);
        }

    }
}
