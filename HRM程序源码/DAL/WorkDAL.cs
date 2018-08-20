using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class WorkDAL
    {



        //按时间查询
        public static DataTable Work1(Entity.Work work1)
        {
            string sqlstr = "select WID,PName,Work.PID,Wtime,WState from Work,Person where Person.PID=Work.PID and Wtime='" + work1.wTime + "' ";
            DataTable dt1 = DBHelper.GetDT(sqlstr);

            return dt1;
        }



        //按部门查询
        public static DataTable Work2(Entity.Department dp)
        {
            string sqlstr = "select WID,PName,Work.PID,Wtime,WState,DepName from Work,Person,Department,Job where Person.PID=Work.PID and Person.JID=Job.JID and Job.DepID=Department.DepID and Department.DepID='" + dp.depID + "' ";
            DataTable dt1 = DBHelper.GetDT(sqlstr);
            return dt1;
        }


        //下拉列表部门的查询
        public static DataTable work3()
        {
            string sqlstr = "select * from Department";
            DataTable dt = DBHelper.GetDT(sqlstr);
            return dt;
        }




        //查询整张表
        public static DataTable work4()
        {
            DataTable dt = DBHelper.GetDT("select WID,PName,Work.PID,Wtime,WState,DepName from Work,Person,Department,Job where Person.PID=Work.PID and Person.JID=Job.JID and Job.DepID=Department.DepID");
            return dt;
        }

        /// <summary>
        /// 按时间段查询
        /// </summary>
        /// <returns></returns>
        public static DataTable work5(Entity.Work w, DateTime stopTime)
        {
            DataTable dt = DBHelper.GetDT("select WID,PName,Work.PID,Wtime,WState,DepName from Work,Person,Department,Job where Person.PID=Work.PID and Person.JID=Job.JID and Job.DepID=Department.DepID  and Wtime between '" + w.wTime + "' and '" + stopTime + "'");
            return dt;
        }

    }
}
