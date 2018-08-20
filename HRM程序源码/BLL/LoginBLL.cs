using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class LoginBLL
    {

        public static bool TestLogin(Entity.Users users)
        {
            return DAL.LoginDAL.TestLogin(users);
        }


        /// <summary>
        /// 获取用户信息
        /// </summary>
        public static int UserInfo(Entity.Users users, out string msg)
        {
            //成功登录帐号
            System.Data.DataTable dt = DAL.LoginDAL.UserInfo(users);
            users.uID = int.Parse(dt.Rows[0][0].ToString());
            users.sex = char.Parse(dt.Rows[0][4].ToString());
            users.age = int.Parse(dt.Rows[0][5].ToString());
            users.logo = dt.Rows[0][6].ToString();
            users.state = dt.Rows[0][7].ToString();
            users.lastTime = DateTime.Parse(dt.Rows[0][8].ToString());
            users.uMail= dt.Rows[0][2].ToString();

            msg = "";
            int i = -1;
            if (users.state == "待审核")
            {
                msg = "您的账号还未启用！";
                i=0;
            }
            else if (users.state == "禁用")
            {
                msg = "抱歉，您的账号已被禁用！";
                i=0;
            }
            else if(users.state == "启用")
            {
                i=1;
            }
            return i;
        }


        public static void UpLastTime(Entity.Users user)
        {
            if (DAL.LoginDAL.UpLastTime(user) > 0)
            {
               // throw new Exception("时间更新成功！");
            }
            else
            {
               // throw new Exception("时间更新失败！");
            }
        }


        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool PassChange(Entity.Users users)
        {
            if (DAL.Users.PassChange(users) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 注册账户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool RegUsers(Entity.Users users)
        {
            if (DAL.LoginDAL.RegUser(users) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsHave(Entity.Users users)
        {
            return DAL.Users.IsHave(users);
        }

    }
}
