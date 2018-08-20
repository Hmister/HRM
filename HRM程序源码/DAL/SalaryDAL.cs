using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 工资计算  数据访问层
    /// </summary>
     public class SalaryDAL
    {
        /// <summary>
        /// 查询全部工资详情
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static DataTable AllSalary()
        {
            string sql = "select PayID,PName,Pay.PID,PayAll,PayBase,PayAllDay,PayDay,PayAdd,PayDel,PayIn,PayTime from Pay,Person where Pay.PID=Person.PID and Person.PState='正式' ";
            return DBHelper.GetDT(sql);
        }


        ////按月份执行
        /// <summary>
        /// 按月份部门查询  利用pID传递部门编号
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static DataTable FindByMDep(Entity.Pay p)
        {
            string sql = "select PayID,PName,Pay.PID,PayAll,PayBase,PayAllDay,PayDay,PayAdd,PayDel,PayIn,PayTime from Pay,Person,Job where Pay.PID=Person.PID and Person.JID=Job.JID and Job.DepID="+p.pID+ " and  year(PayTime)=" + p.payTime.ToString("yyyy") + "and month(PayTime)=" + p.payTime.ToString("MM")+ " and Person.PState='正式'";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 按月份工号查询 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindByMPID(Entity.Pay p)
        {
            string sql = "select PayID,PName,Pay.PID,PayAll,PayBase,PayAllDay,PayDay,PayAdd,PayDel,PayIn,PayTime from Pay,Person where Pay.PID=Person.PID and year(PayTime)="+p.payTime.ToString("yyyy") + "and month(PayTime)=" + p.payTime.ToString("MM") + " and Pay.PID=" + p.pID+ "  and Person.PState='正式'";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 按月份实际发放工资段查询  利用payDel传递最小值 payAdd传递最大值
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindByMMoney(Entity.Pay p)
        {
            string sql = "select PayID,PName,Pay.PID,PayAll,PayBase,PayAllDay,PayDay,PayAdd,PayDel,PayIn,PayTime from Pay,Person where Pay.PID=Person.PID and year(PayTime)=" + p.payTime.ToString("yyyy") + "and month(PayTime)=" + p.payTime.ToString("MM") + " and ( PayIn between " +p.payDel+" and "+p.payAdd+ " )  and Person.PState='正式'";
            return DBHelper.GetDT(sql);
        }

        ///不按月份执行
        /// <summary>
        /// 按部门查询  利用pID传递部门编号
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static DataTable FindByDep(Entity.Pay p)
        {
            string sql = "select PayID,PName,Pay.PID,PayAll,PayBase,PayAllDay,PayDay,PayAdd,PayDel,PayIn,PayTime from Pay,Person,Job where Pay.PID=Person.PID and Person.JID=Job.JID and Job.DepID=" + p.pID + "  and Person.PState='正式'";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 按工号查询 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindByPID(Entity.Pay p)
        {
            string sql = "select PayID,PName,Pay.PID,PayAll,PayBase,PayAllDay,PayDay,PayAdd,PayDel,PayIn,PayTime from Pay,Person where Pay.PID=Person.PID   and Pay.PID=" + p.pID + "  and Person.PState='正式' ";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 按实际发放工资段查询  利用payDel传递最小值 payAdd传递最大值
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindByMoney(Entity.Pay p)
        {
            string sql = "select PayID,PName,Pay.PID,PayAll,PayBase,PayAllDay,PayDay,PayAdd,PayDel,PayIn,PayTime from Pay,Person where Pay.PID=Person.PID  and ( PayIn between " + p.payDel + " and " + p.payAdd + " )  and Person.PState='正式'";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 更新工资记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static int UpPay(int id,double money)
        {
            string sql = "update Pay set PayAdd+="+money+" where PID="+id+" and YEAR(PayTime)="+System.DateTime.Now.Year+" and MONTH(PayTime)="+System.DateTime.Now.Month+"";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 插入全勤奖记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static int InAdd(int id, double money)
        {
            string sql = "insert into Express values("+id+",'奖励',"+money+",'全勤奖奖励','"+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"','系统计算奖励')";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 查询当月记录
        /// </summary>
        /// <returns></returns>
        public static object SearchMoon()
        {
            string sql = "select count(*) from Express where EBoss like '系统计算%'and YEAR(ETime)=" + System.DateTime.Now.Year+" and MONTH(ETime)="+ System.DateTime.Now.Month+ "";
            return DBHelper.GetScalar(sql);
        }

        /// <summary>
        /// 更新工资记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static int UpPay1(int id, double money)
        {
            string sql = "update Pay set PayDel+=" + money + " where PID=" + id + " and YEAR(PayTime)=" + System.DateTime.Now.Year + " and MONTH(PayTime)=" + System.DateTime.Now.Month + "";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 插入缺勤惩罚记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static int InAdd1(int id, double money)
        {
            string sql = "insert into Express values(" + id + ",'惩罚'," + money + ",'缺勤惩罚','" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','系统计算惩罚')";
            return DBHelper.GetLine(sql);
        }



        //-----------------------------------------

        /// <summary>
        /// 查询所有员工的PID
        /// </summary>
        /// <returns></returns>
        public static DataTable SearchPID()
        {
            string sql = "select PID from Person where PState='正式' or PState='休假'";
            return DBHelper.GetDT(sql);
        }


        /// <summary>
        /// 查询员工基本工资
        /// </summary>
        /// <returns></returns>
        public static double SearchBase(int pid)
        {
            string sql = "select AMBase from AgreeMent where PID = " + pid + "";
            string sql1 = "select COUNT(*) from AgreeMent where PID = " + pid + "";
            if ((int)DBHelper.GetScalar(sql1) == 0)
            {
                return 0;
            }
            else
            {
                return double.Parse(DBHelper.GetScalar(sql).ToString());
            }
        }

        /// <summary>
        /// 插入工资记录
        /// </summary>
        public static void NewSalary(double b,int pid,int day,string time)
       {
            string sql = "insert into Pay values("+pid+",0,"+b+","+day+",0,0,0,0,'"+time+"')";
            DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 是否存在下月模
        /// </summary>
        /// <returns></returns>
        public static object IsHave(Entity.Pay p)
        {
            string sql = "select count(*) from Pay where year(PayTime)="+p.payTime.Year+" and MONTH(PayTime)="+(p.payTime.Month+1)+"";
            return DBHelper.GetScalar(sql);
        }

    }
}
