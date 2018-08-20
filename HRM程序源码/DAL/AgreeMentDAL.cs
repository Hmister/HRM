using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entity;

namespace DAL
{
    public class AgreeMentDAL
    {
        //添加合同
        public static bool AgreeMent(Entity.AgreeMent AgreeMent1)
        {
            string sqlstr = "insert into AgreeMent values('" + AgreeMent1.pID + "','" + AgreeMent1.amStart + "','" + AgreeMent1.amStop + "','" + AgreeMent1.AMText + "',"+AgreeMent1.amBase+",'" + AgreeMent1.amState + "')";

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

        //查询
        public static DataTable AgreeMent2(Entity.AgreeMent AgreeMent2)
        {

            string sqlstr = "select * from AgreeMent";
            DataTable dt = DBHelper.GetDT(sqlstr);

            return dt;
        }



        //查询合同编号
        public static DataTable AgreeMent3(Entity.AgreeMent AgreeMent3)
        {

            string sqlstr = "select * from AgreeMent where AMID like '%" + AgreeMent3.amID + "%'";
            DataTable dt = DBHelper.GetDT(sqlstr);

            return dt;
        }




        //查询乙方
        public static DataTable AgreeMent4(Entity.AgreeMent AgreeMent4)
        {

            string sqlstr = "select * from AgreeMent where PID like '%" + AgreeMent4.pID + "%'";
            DataTable dt = DBHelper.GetDT(sqlstr);

            return dt;
        }




        //查询状态
        public static DataTable AgreeMent5(Entity.AgreeMent AgreeMent5)
        {

            string sqlstr = "select * from AgreeMent where AMState='" + AgreeMent5.amState + "'";
            DataTable dt = DBHelper.GetDT(sqlstr);

            return dt;
        }



        //修改合同
        public static bool AgreeMent6(Entity.AgreeMent AgreeMent6)
        {
            string sqlstr = "update AgreeMent set PID='" + AgreeMent6.pID + "', AMStop='" + AgreeMent6.amStop + "', AMBase="+AgreeMent6.amBase+",AMState='" + AgreeMent6.amState + "' where AMID='" + AgreeMent6.amID + "'";
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
