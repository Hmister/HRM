using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace DAL
{
    public class LoginDAL
    {
        /// <summary>
        /// 登陆方法
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool TestLogin(Entity.Users users)
        {
            string sql = string.Format("select count(*) from Users where UName='{0}' and UPwd='{1}'", users.uName, users.uPwd);
            int i = (int)DBHelper.GetScalar(sql);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// 获取用户详细信息
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static System.Data.DataTable UserInfo(Entity.Users users)
        {
            string sql = "select * from Users where UName='"+users.uName+"' and UPwd='"+users.uPwd+"' ";
            return DBHelper.GetDT(sql);
        }


        /// <summary>
        /// 更新登陆时间
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static int UpLastTime(Entity.Users users)
        {
            DateTime time = DateTime.Parse(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            string sql = "update Users set ULTime='"+time+"' where UserID="+users.uID+"";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <returns></returns>
        public static int RegUser(Entity.Users users)
        {
            string sql = string.Format("insert into Users values('{0}','{5}', '{1}', '{2}', {3}, '2', '待审核', '{4}')",users.uName,users.uPwd,users.sex,users.age,users.lastTime,users.uMail);
            return DBHelper.GetLine(sql);
        }

      
    }
}
