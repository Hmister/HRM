using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EBLL
{
    /// <summary>
    /// 登陆类
    /// </summary>
    public class LoginBLL
    {
        /// <summary>
        /// 验证密码
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool ChackPass(Entity.Person p)
        {
            if ((int)EDAL.LoginDAL.ChackPass(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 加载登录信息
        /// </summary>
        public static DataTable LoadInfo(Entity.Person p)
        {
            return EDAL.LoginDAL.LoadInfo(p);
        }

        /// <summary>
        /// 加载人员薪资
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string LoadMoney(Entity.Person p)
        {
            try
            {
                return EDAL.LoginDAL.LoadMoney(p).ToString()+" 元";
            }
            catch(Exception)
            {
                return "未找到数据";
            }
        }

        /// <summary>
        /// 更新日期
        /// </summary>
        /// <param name="p"></param>
        public static void UpLast(Entity.Person p)
        {
            EDAL.LoginDAL.UpLast(p);
        }

        /// <summary>
        /// 未读消息总数
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int MsgCount(Entity.Person m)
        {
            return EDAL.LoginDAL.MsgCount(m);
        }


        }
}
