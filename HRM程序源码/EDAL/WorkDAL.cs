using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EDAL
{
    /// <summary>
    /// 签到 请假  数据访问
    /// </summary>
     public class WorkDAL
    {
        /// <summary>
        /// 添加考勤信息  利用PState传递考勤状态
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public static int AddWork(Entity.Person p)
        {
        string sql = "insert into Work values("+p.pID+",'" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+ "','"+p.pState+"')";
        return  (int)DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 更新出勤天数
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int UpPayDay(Entity.Person p)
        {
            DateTime time = System.DateTime.Now;
            string sql = "update Pay set PayDay+=1 where PID=" +p.pID+ " and year(PayTime)=" + time.Year + " and Month(PayTime)=" + time.Month + "";
            return  (int)DBHelper.GetLine(sql);
        }


        /// <summary>
        /// 更新奖励工资
        /// </summary>
        /// <returns></returns>
        public static int UpPayAdd(int id,double money)
        {
            DateTime time = System.DateTime.Now;
            string sql = "update Pay set PayAdd+="+money+" where PID=" + id + " and year(PayTime)=" + time.Year + " and Month(PayTime)=" + time.Month + "";
            return (int)DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 更新处罚工资
        /// </summary>
        /// <returns></returns>
        public static int UpPayDel(int id, double money)
        {
            DateTime time = System.DateTime.Now;
            string sql = "update Pay set PayDel+=" + money + " where PID=" + id + " and year(PayTime)=" + time.Year + " and Month(PayTime)=" + time.Month + "";
            return (int)DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 查询今日签到记录
        /// </summary>
        /// <returns></returns>
        public static int IsHere(int id)
        {
            DateTime time = System.DateTime.Now;
            string sql = "select count(*) from Work where PID=" + id + " and year(WTime)=" + time.Year + " and MONTH(WTime)=" + time.Month + " and day(WTime)=" + time.Day + "";
            int i = (int)DBHelper.GetScalar(sql);
            return i;
        }

        /// <summary>
        /// 添加迟到处罚记录
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static int AddLate(int uid,double money)
        {
            string sql = "insert into Express values(" + uid + ",'处罚'," + money + ",'上班迟到处罚','" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','终端自动处罚')";
            return (int)DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 添加早退处罚记录
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static int AddEarly(int uid, double money)
        {
            string sql = "insert into Express values(" + uid + ",'处罚'," + money + ",'下班早退处罚','" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','终端自动处罚')";
            return (int)DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 添加加班奖励记录
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static int AddGood(int uid, double money)
        {
            string sql = "insert into Express values(" + uid + ",'奖励'," + money + ",'加班奖金','" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','终端自动奖励')";
            return (int)DBHelper.GetLine(sql);
        }


        /// <summary>
        /// 加载请假记录
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable LoadLeave(Entity.Person p)
        {
            string sql = "select LID 记录编号 ,LWhy 请假原因, LStart 开始时间, LStop 结束时间 ,LBoss 批准领导, LState 申请状态   from Leave where PID="+p.pID+"";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 提交请假申请
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public static int SubLeave(Entity.Leave l)
        {
            string sql = string.Format("insert into Leave values({0},'{1}','{2}','{3}','终端提交','待审核')", l.pID, l.lWhy, l.lStart.ToString("yyyy-MM-dd HH:mm:ss"),l.lStop.ToString("yyyy-MM-dd HH:mm:ss"));
            return (int)DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 报到
        /// </summary>
        /// <returns></returns>
        public static int UpLState(Entity.Leave l)
        {
            string sql = "update Leave set LState = '已销假' where LID = "+l.lID+"";
            return (int)DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 更新信息状态
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int UpPState(Entity.Leave l)
        {
            string sql = "update Person set PState='正式' where PID=" + l.pID + "";
            return DBHelper.GetLine(sql);

        }
    }
}
