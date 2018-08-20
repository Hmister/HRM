using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EDAL
{
    /// <summary>
    /// 消息类
    /// </summary>
    public class MsgDAL
    {
        /// <summary>
        /// 加载未读消息
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadMsg(Entity.Message m)
        {
            string sql = "select MID,MText,MTime from Message where MState='未读' and PID="+m.pID+"";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 加载已读消息
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadMsgYse(Entity.Message m)
        {
            string sql = "select MID,MText,MTime from Message where MState='已读' and PID=" + m.pID + "";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 查询发信人
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static int SendID(Entity.Message msg)
        {
            string sql = "select MSend from Message where MID="+msg.mID+"";
            return (int)DBHelper.GetScalar(sql);
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <returns></returns>
        public static int UpState(Entity.Message msg)
        {
            string sql = "update Message set MState='已读' where MID="+msg.mID+"";
            return (int)DBHelper.GetLine(sql);
        }
        

    }
}
