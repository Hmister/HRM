using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 培训计划添加
    /// </summary>
    public class TrainPlanDAL
    {
        public static int ass(Entity.Train d)
        {
            string s = "insert into lesson values('" + d.leName + "','" + d.leType + "','" + d.leText + "')";
            return DBHelper.GetLine(s);

        }
        public static int pxjh(Entity.Train z)
        {
            string s = "insert into trainplan values('" + z.leID+ "','" + z.tpTeacher + "','" + z.tpAdr + "','" + z.tpCount + "','" + z.tpStart + "','" + z.tpStop + "')";
            return DBHelper.GetLine(s);
        }

        public static System.Data.DataTable dd()
        {

            string sqlstr = "select * from lesson ";


            return DBHelper.GetDT(sqlstr);
        }


        /// <summary>
        /// 小窗口显示的培训计划
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable SmallTP()
        {
            string sql = "select LeName 培训课程 ,TPTeacher 课程讲师,TPAdr 培训地点,TPCount 参训人数,TPStart 开始时间,TPStop 结束时间,LeText 课程内容 from TrainPlan,Lesson where TrainPlan.LeID=Lesson.LeID";
            return DBHelper.GetDT(sql);
        }

        //添加人员信息
        public static int STCOM(Entity.Train a)
        {
            string sql = "insert into Tpnotes values('" + a.pID + "','" + a.tpID + "','" + a.nResult + "','" + a.nTexts + "')";
            return DBHelper.GetLine(sql);
        }

        public static System.Data.DataTable ddd(Entity.Train d)
        {
            string sql = "select NID 记录编号,PName 人员姓名,LeName 培训课程,NResult 培训效果,NTexts 教员评价 from Tpnotes,Lesson,Person,TrainPlan where Person.PID=Tpnotes.PID and Tpnotes.TPID=TrainPlan.TPID and Lesson.LeID=TrainPlan.LeID and TrainPlan.TPID="+d.tpID+"";
             return DBHelper.GetDT(sql);
            
        }

        //查询人员是否存在
        public static int IsHave(Entity.Train train)
        {
            string s = "select count(*) from Person where PID=" + train.pID + " ";
            return (int)DBHelper.GetScalar(s);

        }

        //查看培训计划
        public static DataTable dt()
        {
            string s = "select tpid 培训计划编号,lename 培训课程,letype 课程类型,TPTeacher 讲师,tpadr 培训地点,Tpcount 培训人数,tpstart 开始时间,tpstop 结束时间 from lesson,trainplan where trainplan.leid=lesson.leid";
            return DBHelper.GetDT(s);
        }
        //按课程查看
        public static DataTable cou(Entity.Train a)
        {
            string s = "select lename 培训课程,TPTeacher 讲师,tpadr 培训地点,Tpcount 培训人数,tpstart 开始时间,tpstop 结束时间 from lesson,trainplan where trainplan.leid=lesson.leid  and trainplan.leid='" + a.leID + "'";
            return DBHelper.GetDT(s);
        }
        //按讲师查看
        public static DataTable lect(Entity.Train a)
        {
            string s = "select lename 培训课程,TPTeacher 讲师,tpadr 培训地点,Tpcount 培训人数,tpstart 开始时间,tpstop 结束时间 from lesson,trainplan where trainplan.leid=lesson.leid  and TPTeacher like '%" + a.tpTeacher + "%'";
            return DBHelper.GetDT(s);
        }
        //按培训地点查看
        public static DataTable place(Entity.Train a)
        {
            string s = "select lename 培训课程,TPTeacher 讲师,tpadr 培训地点,Tpcount 培训人数,tpstart 开始时间,tpstop 结束时间 from lesson,trainplan where trainplan.leid=lesson.leid  and  TPAdr like '%" + a.tpAdr + "%'";
            return DBHelper.GetDT(s);
        }
        //绑定课程值
        public static DataTable cous()
        {
            string s = "select * from lesson";
            return DBHelper.GetDT(s);
        }


    }
}
