using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindPass
{
    /// <summary>
    /// 密码类
    /// </summary>
     public class Pass
    {
        /// <summary>
        /// 检查系统账户ID
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static bool CheckID1(string id)
        {
            string sql = "select count(*) from Users where UName='"+id+"'";
            if ((int)DBHelper.GetScalar(sql) <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 检查邮件是否匹配
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static bool CheckMail1(string id,string mail)
        {
            string sql = "select UMail from Users where UName='"+id+"' ";
            if (DBHelper.GetScalar(sql).ToString().Trim() == mail)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新系统用户密码
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string  UpPass1(string id)
        {
            string p = NewPwd();
            string sql = "update Users set UPwd='"+p+"' where UName='"+id+"'";
            if ((int)DBHelper.GetLine(sql) > 0)
            {
                return p;
            }
            else
            {
                return "修改失败";
            }

        }

        private static string NewPwd()
        {
            Random rd = new Random();
            string pwd = "";
            for (int i = 0; i < 8; i++)
            {
                pwd += rd.Next(0,9);
            }
            return pwd;
        }


        /// <summary>
        /// 检查系统账户ID
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static bool CheckID2(string id)
        {
            string sql = "select count(*) from Person where PID='" + id + "'";
            if ((int)DBHelper.GetScalar(sql) <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 检查邮件是否匹配
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static bool CheckMail2(string id, string mail)
        {
            string sql = "select PMail from Person where PID='" + id + "' ";
            if (DBHelper.GetScalar(sql).ToString().Trim() == mail)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新系统用户密码
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string  UpPass2(string id)
        {
            string p = NewPwd();
            string sql = "update Person set PPass='" + p + "' where PID='" + id + "'";
            if ((int)DBHelper.GetLine(sql) > 0)
            {
                return p;
            }
            else
            {
                return "修改失败";
               
            }

        }



    }
}
