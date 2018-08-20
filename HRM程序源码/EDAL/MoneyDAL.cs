using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EDAL
{
    /// <summary>
    /// 奖惩类
    /// </summary>
    public class MoneyDAL
    {
        //按编号查询
        public static DataTable unio(Entity.Express a)
        {
            string s = "select person.pid 人员工号,pname 人员姓名,etype 奖惩类型,emoney 发生金额,ewhy 处理原因,etime 处理时间,EBoss 处理人员  from person inner join express on person.PID=express.PID where person.PID= " + a.pID + "";
            return DBHelper.GetDT(s);
        }
        //按奖惩类型查询
        public static DataTable pin(Entity.Express a)
        {
            string s = "select a.pid 人员工号,pname 人员姓名,etype 奖惩类型,emoney 发生金额,ewhy 处理原因,etime 处理时间,EBoss 处理人员 from  person a inner join express p on p.pid=a.pid where p.etype='" + a.eType + "'and p.PID= " + a.pID + "";

            return DBHelper.GetDT(s);
        }
        //按处理时间查询

        public static DataTable depa(Entity.Express a)
        {
            string s = "select person.pid 人员工号,pname 人员姓名,etype 奖惩类型,emoney 发生金额,ewhy 处理原因,etime 处理时间,EBoss 处理人员  from person inner join express on person.PID=express.PID where year(ETime)=" + a.eTime.Year + " and month(ETime)=" + a.eTime.Month + " and day(ETime)=" + a.eTime.Day + " and person.PID= " + a.pID + "";
            return DBHelper.GetDT(s);
        }

    }
}
