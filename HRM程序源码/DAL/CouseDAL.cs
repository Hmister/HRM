using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public  class CouseDAL
    {
        //添加课程
        public static int Adt(Entity.Train a)
        {
            string s = "insert into lesson values('" + a.leName + "','" + a.leType + "','" + a.leText + "')";
            return DBHelper.GetLine(s);
        }
        //修改课程
        public static int Mod(Entity.Train a)
        {
            string s = string.Format("update lesson set leName='{0}',leType='{1}',leText='{2}' where leId='{3}'", a.leName, a.leType, a.leText, a.leID);
            return DBHelper.GetLine(s);

        }
        //删除课程
        public static DataTable dt()
        {
            string sql = "select leID 课程编号,lename 课程名称,letype 课程类型,letext 课程内容 from lesson";
            return DBHelper.GetDT(sql);
        }
        public static int Del(Entity.Train a)
        {
            string s = string.Format("delete  from lesson where LeID='{0}' ", a.leID);
            return DBHelper.GetLine(s);
        }

    }
}
