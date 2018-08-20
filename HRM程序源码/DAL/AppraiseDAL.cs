using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entity;

namespace DAL
{
    public class AppraiseDAL
    {
        //添加评估
        public static bool Appraise(Entity.Appraise Appraise1)
        {
            string sqlstr = "insert into Appraise values('" + Appraise1.pID + "','" + Appraise1.aTIme + "','" + Appraise1.ABoss + "','" + Appraise1.aText + "','"+Appraise1.aType+"','" + Appraise1.aRate + "')";

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



        //查看评估
        public static DataTable Appraise2(Entity.Appraise Appraise2)
        {
            string sqlstr = "select * from Appraise where AType!='待审核'";

            DataTable dt1 = DBHelper.GetDT(sqlstr);
            return dt1;
        }


        //按评估编号查询
        public static DataTable Appraise3(Entity.Appraise Appraise3)
        {
            string sqlstr = "select * from Appraise where AID like '%" + Appraise3.aID + "%' and AType!='待审核'";
            DataTable dt = DBHelper.GetDT(sqlstr);

            return dt;

        }



        //按员工编号查询
        public static DataTable Appraise4(Entity.Appraise Appraise4)
        {
            string sqlstr = "select * from Appraise where PID like '%" + Appraise4.pID + "%' and AType!='待审核'";
            DataTable dt = DBHelper.GetDT(sqlstr);

            return dt;

        }



        //按评估等级查询
        public static DataTable Appraise5(Entity.Appraise Appraise5)
        {
            string sqlstr = "select * from Appraise where ARate='" + Appraise5.aRate + "' and AType!='待审核'";
            DataTable dt = DBHelper.GetDT(sqlstr);

            return dt;

        }


        /// <summary>
        /// 加载自评
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadSelf()
        {
            string sql = "select AID 评价编号, Person.PID 员工编号,PName 员工姓名, AText 自评内容,ARate 自评等级 ,ATime 自评时间 from Person,Appraise where Appraise.ABoss='待审核' and Atype='员工自评' and Person.PID=Appraise.PID ";
            return DBHelper.GetDT(sql);
        }


        /// <summary>
        /// 通过审核
        /// </summary>
        /// <returns></returns>
        public static int UpSelf(Entity.Appraise a)
        {
            string sql = "update Appraise set AType='员工自评',ABoss='"+a.ABoss+"' where  AID="+a.aID+"";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 驳回审核
        /// </summary>
        /// <returns></returns>
        public static int DelSelf(Entity.Appraise a)
        {
            string sql = "delete from Appraise where AID="+a.aID+"";
            return DBHelper.GetLine(sql);
        }



    }
}
