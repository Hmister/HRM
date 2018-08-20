using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDAL
{
    /// <summary>
    /// 个人信息
    /// </summary>
    public class MyInfoDAL
    {

        /// <summary>
        /// 查询个人全部信息的方法
        /// </summary>
        /// <param name="myp"></param>
        /// <returns></returns>
        public static System.Data.DataTable MInfo(Entity.Person myp)
        {
            string sql = string.Format("select * from Person where PID = '{0}'", myp.pID);
            return DBHelper.GetDT(sql);

        }
        /// <summary>
        /// 查询个人辞职申请
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable CR(Entity.Resignation CR)
        {
            string sql = "select  RID 编号,Person.PID 工号,PName 姓名,JName 所在岗位,Rtext 辞职理由,RTime 申请时间,Rstate 状态 from Resignation,Person,Job where Resignation.PID=Person.PID and Job.JID =Person.JID and Person.PID='" + CR.pID + "'";
            return DBHelper.GetDT(sql);

        }
        /// <summary>
        /// 添加辞职信息
        /// </summary>
        /// <param name="MY"></param>
        /// <returns></returns>
        public static bool TR(Entity.Resignation MY)
        {
            string sql = string.Format("INSERT INTO Resignation  VALUES('{0}','{1}','{2}','申请中')", MY.pID, MY.rText, System.DateTime.Now);
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
        /// 修改个人全部信息的方法
        /// </summary>
        /// <param name="MY"></param>
        /// <returns></returns>
        public static bool XMyInfo(Entity.Person MY)
        {
            string sql = string.Format("update Person set PName='{0}',PSex='{1}',PEthnic='{2}',PAges='{3}',PPhone='{4}',PQQ='{5}',PMail='{6}',PSubject='{7}',PSchool='{8}',PFaction='{9}',PMarry='{10}',PInteresting='{11}',PBirthday='{12}',PCardID='{13}' where PID='{14}'", MY.pName, MY.pSex, MY.pEthnic, MY.pAge, MY.pPhone, MY.pQQ, MY.pMail, MY.pSubject, MY.pSchool, MY.pFaction, MY.pMarry, MY.pInteresting, MY.pBirthday, MY.pCardID, MY.pID);
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
        /// 个人修改密码
        /// </summary>
        /// <param name="MY"></param>
        /// <returns></returns>
        public static bool XMy(Entity.Person MY)
        {
            string sql = string.Format("update Person set PPass='{0}' where PID='{1}'", MY.pPwd, MY.pID);
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
        /// 修改至辞职状态
        /// </summary>
        /// <param name="MY"></param>
        /// <returns></returns>
        public static bool czMy(Entity.Person MY)
        {
            string sql = string.Format("update Person set PState='{0}' where PID='{1}'", MY.pState, MY.pID);
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
