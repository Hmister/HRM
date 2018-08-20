using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EDAL
{
    /// <summary>
    /// 登陆类
    /// </summary>
    public class LoginDAL
    {
        /// <summary>
        /// 验证密码
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static object ChackPass(Entity.Person p)
        {
            string sql = "select count(*) from Person where PID="+p.pID+" and PPass='"+p.pPwd+"' and PState!='待审核' ";
            return DBHelper.GetScalar(sql);
        }

        /// <summary>
        /// 加载登录信息
        /// </summary>
        public static DataTable LoadInfo(Entity.Person p)
        {
            string sql = "select DepName,JName,PLTime  from Person,Job,Department where Person.JID=Job.JID and Job.DepID=Department.DepID and Person.PID=" + p.pID+"";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 加载人员薪资
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static double LoadMoney(Entity.Person p)
        {
            string sql = "select AgreeMent.AMBase+Pay.PayAdd-Pay.PayDel from Person,Pay,Agreement where Person.PID=Pay.PID and Person.PID=AgreeMent.PID and  Person.PID="+p.pID+" and year(Pay.PayTime)="+ System.DateTime.Now.Year+ " and MONTH(Pay.PayTime)="+System.DateTime.Now.Month+"";
            return double.Parse(DBHelper.GetScalar(sql).ToString());
        }

        /// <summary>
        /// 更新日期
        /// </summary>
        /// <param name="p"></param>
        public static void UpLast(Entity.Person p)
        {
            string sql = "update Person set PLTime='"+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"' where PID="+p.pID+"";
            DBHelper.GetLine(sql);
        }


        /// <summary>
        /// 未读消息总数
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int MsgCount(Entity.Person m)
        {
            string sql = "select count(*) from Message where PID="+m.pID+" and MState='未读'";
            return (int)DBHelper.GetScalar(sql);
        } 

    }
}
