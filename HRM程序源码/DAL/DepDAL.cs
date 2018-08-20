using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DepDAL
    {
        /// <summary>
        /// 查部门的方法
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable CDp()
        {
            string sql = "select * from Department";
            return DBHelper.GetDT(sql);

        }
        /// <summary>
        /// 修改部门的方法
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool DPL(Entity.Department DPL)
        {
            string sql = string.Format("update Department set DepName='{0}'where DepID='{1}'", DPL.depName, DPL.depID);
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
        /// 添加部门的方法
        /// </summary>
        /// <param name="DPL"></param>
        /// <returns></returns>
        public static bool ADPL(Entity.Department DPL)
        {
            string sql = string.Format("insert into Department values('{0}')", DPL.depName);
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
        /// 删除部门的方法
        /// </summary>
        /// <param name="DDPL"></param>
        /// <returns></returns>
        public static bool DDPL(Entity.Department DDPL)
        {
            string sql = string.Format("delete from Department where DepID='{0}'", DDPL.depID);
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

       


    }
}
