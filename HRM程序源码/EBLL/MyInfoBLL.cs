using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBLL
{
    /// <summary>
    /// 个人信息类
    /// </summary>
    public class MyInfoBLL
    {
        /// <summary>
        /// 传递查询个人信息方法
        /// </summary>
        /// <param name="myp"></param>
        /// <returns></returns>
        public static System.Data.DataTable MInfo(Entity.Person myp)
        {
            return EDAL.MyInfoDAL.MInfo(myp);
        }
        /// <summary>
        /// 传递查询个人申请的方法
        /// </summary>
        /// <param name="Cr"></param>
        /// <returns></returns>
        public static System.Data.DataTable CR(Entity.Resignation Cr)
        {
            return EDAL.MyInfoDAL.CR(Cr);

        }
        /// <summary>
        /// 传递添加个人辞职申请的方法
        /// </summary>
        /// <param name="Tr"></param>
        /// <returns></returns>
        public static bool TR(Entity.Resignation Tr)
        {
            return EDAL.MyInfoDAL.TR(Tr);

        }
        /// <summary>
        /// 传递修改个人信息方法
        /// </summary>
        /// <param name="XMYINFO"></param>
        /// <returns></returns>
        public static bool XMY(Entity.Person XMYINFO)
        {
            return EDAL.MyInfoDAL.XMyInfo(XMYINFO);

        }

        /// <summary>
        /// 修改个人密码
        /// </summary>
        /// <param name="XMYINFO"></param>
        /// <returns></returns>
        public static bool XMy(Entity.Person XMYINFO)
        {
            return EDAL.MyInfoDAL.XMy(XMYINFO);

        }
        /// <summary>
        /// 修改个人辞职状态
        /// </summary>
        /// <param name="XMYINFO"></param>
        /// <returns></returns>
        public static bool czMy(Entity.Person XMYINFO)
        {
            return EDAL.MyInfoDAL.czMy(XMYINFO);

        }
    }
}
