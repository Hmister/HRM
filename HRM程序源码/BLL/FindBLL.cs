using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    /// <summary>
    /// 招聘类
    /// </summary>
    public class FindBLL
    {
        /// <summary>
        /// 传递查询待审核的方法
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable CPL()
        {
            return DAL.FindDAL.CPl();
        }
        /// <summary>
        /// 传递修改应聘
        /// </summary>
        /// <param name="aa"></param>
        /// <returns></returns>
        public static bool xgPP(Entity.Person aa)
        {
            return DAL.FindDAL.XGP(aa);
        }
        /// <summary>
        /// 传递删除修改的方法
        /// </summary>
        /// <param name="dd"></param>
        /// <returns></returns>
        public static bool DDPR(Entity.Person dd)
        {
            return DAL.FindDAL.DDPr(dd);
        }
        /// <summary>
        /// 传递查询试用人员的方法
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable SPL()
        {
            return DAL.FindDAL.SPl();
        }

    }
}
