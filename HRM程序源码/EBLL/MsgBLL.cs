using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EBLL
{
    /// <summary>
    /// 消息
    /// </summary>
    public class MsgBLL
    {
        /// <summary>
        /// 加载未读消息
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadMsg(Entity.Message m)
        {
            return EDAL.MsgDAL.LoadMsg(m);
        }


        /// <summary>
        /// 加载已读消息
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadMsgYse(Entity.Message m)
        {
            return EDAL.MsgDAL.LoadMsgYse(m);
        }

        /// <summary>
        /// 查询发信人
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static int SendID(Entity.Message msg)
        {
            return EDAL.MsgDAL.SendID(msg);
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <returns></returns>
        public static void UpState(Entity.Message msg)
        {
            EDAL.MsgDAL.UpState(msg);
        }


        }
}
