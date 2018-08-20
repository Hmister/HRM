using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    /// <summary>
    /// 员工薪资逻辑类
    /// </summary>
     public  class MoneyBLL
    {
        //显示所有惩罚信息
        public static DataTable dt()
        {
            return DAL.MoneyDAL.dt();
        }
        //按工号查询
        public static DataTable unio(Entity.Express a)
        {
            return DAL.MoneyDAL.unio(a);
        }
        //按奖惩类型查询
        public static DataTable pin(Entity.Express a)
        {
            return DAL.MoneyDAL.pin(a);
        }
        //按惩罚时间查询
        public static DataTable depa(Entity.Express a)
        {
            return DAL.MoneyDAL.depa(a);
        }
        //按部门查询
        public static DataTable FindByDep(Entity.Express a)
        {
            return DAL.MoneyDAL.FindByDep(a);
        }

        ///------------------------------------------
        /// <summary>
        /// 查找是否存在
        /// </summary>
        /// <returns></returns>
        public static bool FindP(Entity.Express e)
        {
            if ((int)DAL.MoneyDAL.FindP(e) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 奖惩操作
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool ADd(Entity.Express a)
        {
            if (DAL.MoneyDAL.Penlt(a) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 工资处罚操作
        /// </summary>
        /// <returns></returns>
        public static bool MoneyDel(Entity.Express e)
        {
            if (DAL.MoneyDAL.MoneyDel(e) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 工资奖励操作
        /// </summary>
        /// <returns></returns>
        public static bool MoneyAdd(Entity.Express e)
        {
            if (DAL.MoneyDAL.MoneyAdd(e) > 0)
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
