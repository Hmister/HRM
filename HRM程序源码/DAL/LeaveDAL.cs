using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class LeaveDAL
    {
        //添加请假信息
        public static bool Leave1(Entity.Leave leave)
        {

            string sqlstr = string.Format("insert into Leave values({0},'{1}','{2}','{3}','{4}','{5}')", leave.pID, leave.lWhy, leave.lStart, leave.lStop, leave.lBoss, leave.lState);
            int i = (int)DBHelper.GetLine(sqlstr);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }



        //查询请假表
        public static DataTable LeaveAll()
        {

            string sqlstr = "select LID,Leave.PID,PName,LWhy,LStart,LStop,LBoss,Lstate from Leave,Person where Leave.PID=Person.PID";
            DataTable dt = (DataTable)DBHelper.GetDT(sqlstr);

            return dt;
        }



        //下拉框的显示
        public static DataTable LeaveComBox()
        {
            string sqlstr = "select * from Department";
            DataTable dt = (DataTable)DBHelper.GetDT(sqlstr);

            return dt;

        }



        //按员工编号查询查询
        public static DataTable LeavePID(Entity.Leave leave3)
        {
            string sqlstr = "select LID,Leave.PID,PName,LWhy,LStart,LStop,LBoss,Lstate from Leave,Person where Leave.PID=Person.PID and Person.PID like '%" + leave3.pID + "%'";
            DataTable dt = (DataTable)DBHelper.GetDT(sqlstr);

            return dt;

        }


        //按部门查询
        public static DataTable LeaveDep(Entity.Department dp)
        {
            string sqlstr = "select  LID,Leave.PID,PName,LWhy,LStart,LStop,LBoss,Lstate from Leave,Person,Department,Job where Person.PID=Leave.PID and Person.JID=Job.JID and Job.DepID=Department.DepID and Department.DepID='" + dp.depID + "' ";
            DataTable dt1 = DBHelper.GetDT(sqlstr);
            return dt1;
        }






        //按员工姓名查询查询
        public static DataTable LeavePName(Entity.Leave leave5,string name)
        {
            string sqlstr = "select LID,Leave.PID,PName,LWhy,LStart,LStop,LBoss,Lstate from Leave,Person where Leave.PID=Person.PID and PName like '%" + name + "%'";
            DataTable dt = (DataTable)DBHelper.GetDT(sqlstr);

            return dt;

        }




        /// <summary>
        /// 按开始时间查询
        /// </summary>
        /// <param name="leave6"></param>
        /// <returns></returns>
        public static DataTable LeaveLstart(Entity.Leave leave6)
        {
            string sqlstr = "select LID,Leave.PID,PName,LWhy,LStart,LStop,LBoss,Lstate from Leave,Person where Leave.PID=Person.PID and year(LStart) = " + leave6.lStart.Year + " and month(LStart) = " + leave6.lStart.Month + " and day(LStart) = " + leave6.lStart.Day + "";
            DataTable dt = (DataTable)DBHelper.GetDT(sqlstr);

            return dt;

        }


        /// <summary>
        /// 查询待审核请假表
        /// </summary>
        /// <returns></returns>
        public static DataTable LeaveYN()
        {

            string sqlstr = "select LID,Leave.PID,PName,LWhy,LStart,LStop,LBoss,Lstate from Leave,Person where Leave.PID=Person.PID and LState='待审核'";
            return  DBHelper.GetDT(sqlstr);
        }

        /// <summary>
        /// //更新请假详情  LWhy传递状态
        /// </summary>
        /// <param name="le"></param>
        /// <returns></returns>
        public static int UpLeave(Entity.Leave le)
        {
            string sql = "update Leave set LState='"+le.lWhy+"',LBoss='"+le.lBoss+"' where PID="+le.pID+"";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 更新信息状态
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int UpPState(Entity.Pay p)
        {
            string sql = "update Person set PState='休假' where PID=" + p.pID+"";
            return DBHelper.GetLine(sql);

        }

    }
}
