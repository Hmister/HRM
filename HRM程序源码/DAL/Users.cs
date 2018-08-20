using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Users
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static System.Data.DataTable ADm()
        {
            string sql = "select UserID 工号,UName 名称,UPwd 密码,Ustate 状态,Usex 性别,Uage 年龄,ULTime 上次登陆 from Users";
            return DBHelper.GetDT(sql);

        }

        /// <summary>
        /// 修改管理员表的方法
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool APlus(Entity.Users users)
        {
            string sql = string.Format("update Users set UName='{0}',UPwd='{1}',Usex='{2}',Uage='{3}',Ustate='{4}',UMail='{6}' where UserID='{5}'", users.uName, users.uPwd, users.sex, users.age, users.state, users.uID,users.uMail);
            int i = (int)DBHelper.GetLine(sql);
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
        /// 删除管理员的方法
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool ADelete(Entity.Users users)
        {
            string sql = string.Format("delete from Users where UserID='{0}'", users.uID);
            int i = (int)DBHelper.GetLine(sql);
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
        /// 修改密码
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static int PassChange(Entity.Users users)
        {
            string sql = "update Users set UPwd='" + users.uPwd + "' where UserID="+users.uID+"";
            return DBHelper.GetLine(sql);
        }


        /// <summary>
        /// 测试账号是否存在
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool IsHave(Entity.Users users)
        {

            string sql = string.Format("select count(*) from Users where UName='{0}'", users.uName);
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
        /// 增加管理员的方法
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool ADAdd(Entity.Users users)
        {
            string sql = string.Format("insert into Users values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", users.uName,users.uMail, users.uPwd, users.sex, users.age, 1, users.state, System.DateTime.Now);
            int i = (int)DBHelper.GetLine(sql);
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
        /// 更新用户头像
        /// </summary>
        /// <returns></returns>
        public static int UpLogo(Entity.Users u)
        {
            string sql = "update Users set ULogo='"+u.logo+"' where UserID="+u.uID+"";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 验证账户名称
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static int CheckName(Entity.Users u)
        {
            string sql = " select count(*) from Users where UName='"+u.uName+"'";
            return (int)DBHelper.GetScalar(sql);
        }


    }
}
