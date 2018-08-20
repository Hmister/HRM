using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entity;

namespace BLL
{
    public class JobChangeBLL
    {
        //显示员工姓名
        public static string JobPName(Entity.Person pr)
        {
            return DAL.JobChangeDAL.JobPName(pr);

        }


        //显示部门名称
        public static string JobDepName(Entity.Person pr)
        {
            return DAL.JobChangeDAL.JobDepName(pr);

        }



        //显示岗位名称
        public static string JobJName(Entity.Person pr)
        {
            return DAL.JobChangeDAL.JobJName(pr);

        }





        //修改信息
        public static bool JobUPDATE(Entity.Person pr)
        {
            return DAL.JobChangeDAL.JobUPDATE(pr);

        }


        //////岗位管理

        /// <summary>
        /// 加载部门下的岗位
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable LoadJobs(Entity.Job job)
        {
            return DAL.JobPlan.LoadJobs(job);
        }

        /// <summary>
        /// 添加岗位到部门
        /// </summary>
        /// <returns></returns>
        public static bool AddJob(Entity.Job job)
        {
            if (DAL.JobPlan.AddJob(job) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除部门下的岗位
        /// </summary>
        /// <returns></returns>
        public static bool DelJob(Entity.Job job)
        {
            if (DAL.JobPlan.DelJob(job) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新岗位名称
        /// </summary>
        /// <returns></returns>
        public static bool UpJob(Entity.Job job)
        {
            if (DAL.JobPlan.UpJob(job) > 0)
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
