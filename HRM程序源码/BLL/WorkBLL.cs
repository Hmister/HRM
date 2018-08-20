using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
   public class WorkBLL
   {
        //按时间查询
        public static DataTable Work1(Entity.Work work1)
        {
            return DAL.WorkDAL.Work1(work1);
        }


        //按部门查询
        public static DataTable work2(Entity.Department dp)
        {
            return DAL.WorkDAL.Work2(dp);

        }


        //下拉列表部门的查询
        public static DataTable Work3()
        {
            return DAL.WorkDAL.work3();
        }



        //查询整张表
        public static DataTable Work4()
        {
            return DAL.WorkDAL.work4();
        }


        /// <summary>
        /// 按时间段查询
        /// </summary>
        /// <returns></returns>
        public static DataTable work5(Entity.Work w, DateTime stoptime)
        {
            return DAL.WorkDAL.work5(w, stoptime);

        }


    }
}
