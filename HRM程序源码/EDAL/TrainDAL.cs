using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDAL
{
    /// <summary>
    /// 培训
    /// </summary>
    public class TrainDAL
    {
        public static System.Data.DataTable ddd(Entity.Train d)
        {
            string sql = "select NID 记录编号,PName 人员姓名,LeName 培训课程,NResult 培训效果,NTexts 教员评价,tpstart 开始时间 from Tpnotes,Lesson,Person,TrainPlan where Person.PID=Tpnotes.PID and Tpnotes.TPID=TrainPlan.TPID and Lesson.LeID=TrainPlan.LeID and Person.PID='" + d.pID + "'";
            return DBHelper.GetDT(sql);

        }
        public static System.Data.DataTable dt(Entity.Train d)
        {
            string sql = "select NID 记录编号,PName 人员姓名,LeName 培训课程,NResult 培训效果,NTexts 教员评价,tpstart 开始时间 from Tpnotes,Lesson,Person,TrainPlan where Person.PID=Tpnotes.PID and Tpnotes.TPID=TrainPlan.TPID and Lesson.LeID=TrainPlan.LeID and Person.PID='" + d.pID + "'and  Tpnotes.NResult='" + d.nResult + "'";
            return DBHelper.GetDT(sql);

        }
        //按开始时间查看
        public static System.Data.DataTable dte(Entity.Train d)
        {
            string sql = "select NID 记录编号,PName 人员姓名,LeName 培训课程,NResult 培训效果,NTexts 教员评价,tpstart 开始时间 from Tpnotes,Lesson,Person,TrainPlan where Person.PID=Tpnotes.PID and Tpnotes.TPID=TrainPlan.TPID and Lesson.LeID=TrainPlan.LeID and Person.PID='" + d.pID + "'and  year(TrainPlan.TPStart)=" + d.tpStart.Year + "and  month(TrainPlan.TPStart)=" + d.tpStart.Month + "and  day(TrainPlan.TPStart)=" + d.tpStart.Day + "";
            return DBHelper.GetDT(sql);

        }

    }
}
