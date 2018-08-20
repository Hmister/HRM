using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class JobPlan
    {
        /// 查询全部招聘信息
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable CJobPlan()
        {
            string sql = "select  JPID 编号,JName 需求岗位,JPCount 需求人数,JPNeed 岗位要求,JPStart 发布时间,JPStop 结束时间,JPCall 联系人,JPPhone 联系人电话 from JobPlan,job where JobPlan.JID=job.JID";
            return DBHelper.GetDT(sql);

        }
        /// <summary>
        /// 按部门查询招聘计划
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public static System.Data.DataTable CJobPlan1(Entity.Job job)
        {
            string sql = "select  JPID 编号,JName 需求岗位,JPCount 需求人数,JPNeed 岗位要求,JPStart 发布时间,JPStop 结束时间,JPCall 联系人,JPPhone 联系人电话 from JobPlan,job where JName like '%" + job.jName + "%' and JobPlan.JID=job.JID";
            return DBHelper.GetDT(sql);

        }

        /// <summary>
        /// 查询全部招聘信息
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable CJobPlan8()
        {
            string sql = "select  JPID 编号,DepName 需求部门,JName 需求岗位,JPCount 需求人数,JPNeed 岗位要求,JPStart 发布时间,JPStop 截止时间,JPCall 联系人,JPPhone 联系人电话 from JobPlan,job,Department where Job.DepID=Department.DepID and  JobPlan.JID=job.JID ";
            return DBHelper.GetDT(sql);
        }


        /// <summary>
        /// 测试用查询部门表的方法
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable aaa()
        {
            string sql = "select  * from Department";
            return DBHelper.GetDT(sql);

        }
        /// <summary>
        /// 修改招聘表方法
        /// </summary>
        /// <param name="JPlan"></param>
        /// <returns></returns>
        public static bool JPlan(Entity.JobPlan JPlan)
        {
            string sql = string.Format("update JobPlan set JID='{0}',JPCount='{1}',JPNeed='{2}',JPStop='{3}',JPCall='{4}',JPPhone='{5}' where JPID='{6}'", JPlan.jID, JPlan.jpCount, JPlan.jpNeed, JPlan.jpStop, JPlan.jpCall, JPlan.jpPhone, JPlan.jpID);
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
        /// 删除招聘计划的方法
        /// </summary>
        /// <param name="JPlan"></param>
        /// <returns></returns>
        public static bool DJPlan(Entity.JobPlan DJP)
        {
            string sql = string.Format("delete from JobPlan where JPID='{0}'", DJP.jpID);
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
        /// 增加招聘计划
        /// </summary>
        /// <param name="AJP"></param>
        /// <returns></returns>
        public static bool AJPlan(Entity.JobPlan AJP)
        {
            string sql = string.Format("insert into JobPlan values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", AJP.jID, AJP.jpCount, AJP.jpNeed, System.DateTime.Now, AJP.jpStop.ToString("yyyy-MM-dd HH:mm:ss"), AJP.jpCall, AJP.jpPhone);
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
        /// 测试用查询岗位表的方法
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public static System.Data.DataTable bbb(string job)
        {
            string sql = "select JName,JID from job,Department where job.DepID=Department.DepID and DepName='" + job + "'";
            return DBHelper.GetDT(sql);

        }
        /// <summary>
        /// 测试查管理员表方法
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public static System.Data.DataTable ccc()
        {
            string sql = "select * from  Users";
            return DBHelper.GetDT(sql);

        }


        /// <summary>
        /// 加载部门下的岗位
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable LoadJobs(Entity.Job job)
        {
            string sql = "select * from Job where DepID="+job.depID+"";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 添加岗位到部门
        /// </summary>
        /// <returns></returns>
        public static int AddJob(Entity.Job job)
        {
            string sql = "insert into Job values('"+job.jName+"',"+job.depID+")";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 删除部门下的岗位
        /// </summary>
        /// <returns></returns>
        public static int DelJob(Entity.Job job)
        {
            string sql = "delete from Job where JID="+job.jID+"";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 更新岗位名称
        /// </summary>
        /// <returns></returns>
        public static int UpJob(Entity.Job job)
        {
            string sql = "update Job set JName='"+job.jName+"' where JID="+job.jID+"";
            return DBHelper.GetLine(sql);
        }
    }
}
