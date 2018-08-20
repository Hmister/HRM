using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    /// <summary>
    /// 辞职类
    /// </summary>
    public class ResignationBLL
    {
        /// <summary>
        /// 传递查询辞职表方法
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public static System.Data.DataTable cr()
        {
            return DAL.ResignationDAL.CR();
        }
        /// <summary>
        /// 传递修改状态的方法
        /// </summary>
        /// <param name="Re"></param>
        /// <returns></returns>
        public static bool XG(Entity.Resignation Re)
        {
            return DAL.ResignationDAL.xR(Re);
        }
        /// <summary>
        /// 传递删除信息的方法
        /// </summary>
        /// <param name="Re"></param>
        /// <returns></returns>
        public static bool SR(Entity.Resignation dd)
        {
            return DAL.ResignationDAL.SR(dd);
        }
    }
}
