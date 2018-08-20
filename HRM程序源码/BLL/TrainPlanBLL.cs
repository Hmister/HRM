using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    /// <summary>
    /// 添加培训计划
    /// </summary>
    public class TrainPlanBLL
    {
        public static bool sss(Entity.Train z)
        {
            if (DAL.TrainPlanDAL.pxjh(z) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static System.Data.DataTable bb()
        {
            return DAL.TrainPlanDAL.dd();

        }


        /// <summary>
        /// 小窗口显示的培训计划
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable SmallTP()
        {
            return DAL.TrainPlanDAL.SmallTP();
        }

        //添加信息
        public static bool adjId(Entity.Train a)
        {
            if (DAL.TrainPlanDAL.STCOM(a) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
       

        //模糊查询
        public static System.Data.DataTable TPNotes(Entity.Train d)
        {


            return DAL.TrainPlanDAL.ddd(d);
        }

        /// <summary>
        /// 查询人员是否存在
        /// </summary>
        /// <returns></returns>
        public static int IsHave(Entity.Train train)
        {
            return DAL.TrainPlanDAL.IsHave(train);
        }



        //按课程
        public static DataTable cou(Entity.Train a)
        {
            return DAL.TrainPlanDAL.cou(a);
        }
        //按讲师
        public static DataTable lect(Entity.Train a)
        {
            return DAL.TrainPlanDAL.lect(a);
        }
        //按地点
        public static DataTable place(Entity.Train a)
        {
            return DAL.TrainPlanDAL.place(a);
        }
        //导入课程
        public static DataTable cous()
        {
            return DAL.TrainPlanDAL.cous();
        }
        //查看培训记录
        public static DataTable dt()
        {
            return DAL.TrainPlanDAL.dt();
        }


    }
}
