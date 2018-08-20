using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    /// <summary>
    /// 招聘计划数据访问类
    /// </summary>
     public class FindDAL
    {
        /// <summary>
        /// 查询待审核人员的方法
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable CPl()
        {
            string sql = "select PID,PName,PSex,PEthnic,PAges,PPhone,PQQ,PMail,PSubject,PSchool,PFaction,PMarry,PInteresting,PBirthday,PCardID,JName,PState from Person,Job where Person.JID=Job.JID and PState='待审核'";
            return DBHelper.GetDT(sql);

        }
        /// <summary>
        /// 查询试用人员的方法
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable SPl()
        {
            string sql = "select PID,PName,PSex,PEthnic,PAges,PPhone,PQQ,PMail,PSubject,PSchool,PFaction,PMarry,PInteresting,PBirthday,PCardID,JName,PState from Person,Job where Person.JID=Job.JID and PState='实习'";
            return DBHelper.GetDT(sql);

        }

        /// <summary>
        /// 修改应聘方式
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static bool XGP(Entity.Person sss)
        {
            string sql = string.Format("update Person set PState='{0}' where PID='{1}'", sss.pState, sss.pID);
            int i = (int)DBHelper.GetLine(sql);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除人员的方法
        /// </summary>
        /// <param name="dd"></param>
        /// <returns></returns>
        public static bool DDPr(Entity.Person dd)
        {
            string sql = string.Format("delete from Person where PID='{0}'", dd.pID);
            int i = (int)DBHelper.GetLine(sql);
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
