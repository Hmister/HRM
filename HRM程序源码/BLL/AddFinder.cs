using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
     public class AddFinder
    {
        public static System.Data.DataTable CJobPla()
        {
            return DAL.JobPlan.CJobPlan8();
        }

        public static System.Data.DataTable aaa()
        {
            return DAL.JobPlan.aaa();
        }
        public static System.Data.DataTable bbb(string b)
        {

            return DAL.JobPlan.bbb(b);
        }
        //传递修改方法
        public static bool JPL(Entity.JobPlan JPlan)
        {
            return DAL.JobPlan.JPlan(JPlan);
        }
        //传递删除方法
        public static bool DJP(Entity.JobPlan DJP)
        {
            return DAL.JobPlan.DJPlan(DJP);
        }
        //传递增加方法
        public static bool AJP(Entity.JobPlan AJP)
        {
            return DAL.JobPlan.AJPlan(AJP);
        }
        //传递查询管理员表
        public static System.Data.DataTable ccc()
        {
            return DAL.JobPlan.ccc();
        }
    }
}
