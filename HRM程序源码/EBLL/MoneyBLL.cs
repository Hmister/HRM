using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EBLL
{
    /// <summary>
    /// 奖惩
    /// </summary>
    public class MoneyBLL
    {
        //按工号查询
        public static DataTable unio(Entity.Express a)
        {
            return EDAL.MoneyDAL.unio(a);
        }
        //按奖惩类型查询
        public static DataTable pin(Entity.Express a)
        {
            return EDAL.MoneyDAL.pin(a);
        }
        //按惩罚时间查询
        public static DataTable depa(Entity.Express a)
        {
            return EDAL.MoneyDAL.depa(a);
        }
    }
}
