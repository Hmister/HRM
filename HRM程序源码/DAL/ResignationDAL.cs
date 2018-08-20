using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    /// <summary>
    /// 辞职类
    /// </summary>
    public class ResignationDAL
    {

        /// <summary>
        /// 查询全部辞职信息
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable CR()
        {
            string sql = "select  RID 编号,Person.PID 工号,PName 姓名,JName 所在岗位,Rtext 辞职理由,RTime 申请时间,Rstate 状态 from Resignation,Person,Job where Resignation.PID=Person.PID and Job.JID =Person.JID and Rstate='申请中'";
            return DBHelper.GetDT(sql);

        }
        /// <summary>
        /// 修改状态的方法
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public static bool xR(Entity.Resignation pr)
        {

            string sqlstr = "update Resignation set Rstate='" + pr.rState + "' where RID='" + pr.rID + "'";
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
        /// <summary>
        /// 删除辞职表
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public static bool SR(Entity.Resignation dd)
        {

            string sqlstr = "delete from Resignation where RID='" + dd.rID + "'";
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
