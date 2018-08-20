using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;



namespace DAL
{
    /// <summary>
    /// 薪资数据访问层
    /// </summary>
     public class MoneyDAL
    {
        public static DataTable dt()
        {
            string s = "select a.pid 人员工号,pname 人员姓名,etype 奖惩类型,emoney 发生金额,ewhy 处理原因,etime 处理时间,EBoss 处理人员  from person a inner join express p on p.pid=a.pid";
            return DBHelper.GetDT(s);
        }

        //按编号查询
        public static DataTable unio(Entity.Express a)
        {
            string s = "select person.pid 人员工号,pname 人员姓名,etype 奖惩类型,emoney 发生金额,ewhy 处理原因,etime 处理时间,EBoss 处理人员  from person inner join express on person.PID=express.PID where person.PID like '%" + a.pID + "%'";
            return DBHelper.GetDT(s);
        }
        //按奖惩类型查询
        public static DataTable pin(Entity.Express a)
        {
            string s = "select a.pid 人员工号,pname 人员姓名,etype 奖惩类型,emoney 发生金额,ewhy 处理原因,etime 处理时间,EBoss 处理人员 from  person a inner join express p on p.pid=a.pid where p.etype='" + a.eType + "'";

            return DBHelper.GetDT(s);
        }
        //按处理时间查询

        public static DataTable depa(Entity.Express a)
        {
            string s = "select person.pid 人员工号,pname 人员姓名,etype 奖惩类型,emoney 发生金额,ewhy 处理原因,etime 处理时间,EBoss 处理人员  from person inner join express on person.PID=express.PID where year(ETime)=" + a.eTime.Year + " and  month(ETime)=" + a.eTime.Month + " and  day(ETime)=" + a.eTime.Day + "";
            return DBHelper.GetDT(s);
        }
        //按部门查询
        public static DataTable FindByDep(Entity.Express a)
        {
            string s = "select person.pid 人员工号,pname 人员姓名,etype 奖惩类型,emoney 发生金额,ewhy 处理原因,etime 处理时间,EBoss 处理人员 from person,express,Job where person.PID=express.PID and Person.JID=Job.JID and Job.DepID=" + a.eID + "";
            return DBHelper.GetDT(s);
        }

        //-------------------------------------------
        /// <summary>
        /// 查找是否存在
        /// </summary>
        /// <returns></returns>
        public static object FindP(Entity.Express e)
        {
            string sql = "select count(*) from Person where PID="+e.pID+"";
            return DBHelper.GetScalar(sql);
        }

        /// <summary>
        /// 奖惩记录操作
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Penlt(Entity.Express a)
        {
            string s = "insert into express values('" + a.pID + "','" + a.eType + "','" + a.eMoney + "','" + a.eWhy + "','" + a.eTime + "','" + a.eBoss + "')";
            return DBHelper.GetLine(s);
        }

        /// <summary>
        /// 工资惩罚操作
        /// </summary>
        /// <returns></returns>
        public static int MoneyDel(Entity.Express e)
        {
            string sql = "update Pay set PayDel=PayDel+"+e.eMoney+" where PID="+e.pID+"";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 工资奖励操作
        /// </summary>
        /// <returns></returns>
        public static int MoneyAdd(Entity.Express e)
        {
            string sql = "update Pay set PayAdd=PayAdd+" + e.eMoney + " where PID=" + e.pID + "";
            return DBHelper.GetLine(sql);
        }


    }
}
