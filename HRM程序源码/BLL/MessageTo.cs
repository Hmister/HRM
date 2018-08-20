using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    /// <summary>
    /// 系统消息
    /// </summary>
    public class MessageTo
    {

        /// <summary>
        /// 消息历史
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable LoadMsg()
        {
            return DAL.MessageTo.LoadMsg();
        }


        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="m"></param>
        public static bool AddMsg(Entity.Message m)
        {
            System.Data.DataTable dt = DAL.MessageTo.SearchPID();
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    m.pID = int.Parse(dt.Rows[i][0].ToString());
                    DAL.MessageTo.AddMsg(m);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }



    }
}
