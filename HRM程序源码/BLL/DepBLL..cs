using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
     public class DepBLL
    {
        /// <summary>
        /// 传递查询部门的方法
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable CDp()
        {
            return DAL.DepDAL.CDp();
        }/// <summary>
         /// 传递修改部门的方法
         /// </summary>
         /// <param name="CDP"></param>
         /// <returns></returns>
        public static bool CDL(Entity.Department CDP)
        {
            return DAL.DepDAL.DPL(CDP);
        }
        /// <summary>
        /// 传递新增的方法
        /// </summary>
        /// <param name="CDP"></param>
        /// <returns></returns>
        public static bool ADL(Entity.Department ADP)
        {
            return DAL.DepDAL.ADPL(ADP);
        }
        /// <summary>
        /// 传递删除的方法
        /// </summary>
        /// <param name="DDDP"></param>
        /// <returns></returns>
        public static bool DDL(Entity.Department DDDP)
        {
            return DAL.DepDAL.DDPL(DDDP);
        }

    }
}
