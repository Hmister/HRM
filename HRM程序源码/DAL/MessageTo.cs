using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    /// <summary>
   /// 消息发送
    /// </summary>
    public class MessageTo
    {
        /// <summary>
        /// 消息历史
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadMsg()
        {
            string sql = "select MID 消息编号 ,MSend 发送人员 ,MText 消息内容, MTime 发送时间  from Message where PID=10000 ";
            return DBHelper.GetDT(sql);
        }


        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="m"></param>
        public static int AddMsg(Entity.Message m)
        {
            string sql = "insert into Message values('"+m.uID+"','"+m.mText+"','"+m.mTIme.ToString("yyyy-MM-dd HH:mm:ss")+"','未读',"+m.pID+")";
            return DBHelper.GetLine(sql);
        }


        /// <summary>
        /// 查询所有员工的PID
        /// </summary>
        /// <returns></returns>
        public static DataTable SearchPID()
        {
            string sql = "select PID from Person where PState!='待审核'";
            return DBHelper.GetDT(sql);
        }


    }
}
