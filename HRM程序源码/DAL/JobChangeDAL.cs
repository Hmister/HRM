using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entity;

namespace DAL
{
    public class JobChangeDAL
    {
        //显示员工姓名
        public static string JobPName(Entity.Person pr)
        {

            string sqlstr = "select PName from Job,Department,Person where Job.DepID=Department.DepID and Person.JID=Job.JID and PID='" + pr.pID + "'";
            string name = DBHelper.GetScalar(sqlstr).ToString();

            return name;
        }


        //显示部门名称
        public static string JobDepName(Entity.Person pr)
        {

            string sqlstr = "select DepName from Job,Department,Person where Job.DepID=Department.DepID and Person.JID=Job.JID and PID='" + pr.pID + "'";
            string name = DBHelper.GetScalar(sqlstr).ToString();
            return name;
        }


        //显示岗位名称
        public static string JobJName(Entity.Person pr)
        {

            string sqlstr = "select JName from Job,Department,Person where Job.DepID=Department.DepID and Person.JID=Job.JID and PID='" + pr.pID + "'";
            string name = DBHelper.GetScalar(sqlstr).ToString();
            return name;
        }




        //修改信息
        public static bool JobUPDATE(Entity.Person pr)
        {

            string sqlstr = "update Person set JID='" + pr.jID + "' where PID='" + pr.pID + "'";
            int i = DBHelper.GetLine(sqlstr);
            if (i > 0)
            {

                return true;
            }
            else
            {

                return false;
            }



        }


    }
}
