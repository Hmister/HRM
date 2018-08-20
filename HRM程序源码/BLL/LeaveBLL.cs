using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class LeaveBLL
    {

        //添加数据
        public static bool Leaves1(Entity.Leave leaves1)
        {
            return DAL.LeaveDAL.Leave1(leaves1);
        }

        //查询表
        public static DataTable LeavesAll()
        {
            return DAL.LeaveDAL.LeaveAll();

        }


        //下拉框的显示
        public static DataTable LeaveComBox()
        {

            return DAL.LeaveDAL.LeaveComBox();
        }



        //按员工编号查询查询
        public static DataTable LeavePID(Entity.Leave leave3)
        {

            return DAL.LeaveDAL.LeavePID(leave3);


        }





        //按所属部门查询
        public static DataTable LeaveDep(Entity.Department dp)
        {

            return DAL.LeaveDAL.LeaveDep(dp);
        }





        //按员工姓名查询查询
        public static DataTable LeavePName(Entity.Leave leave4,string name)
        {

            return DAL.LeaveDAL.LeavePName(leave4,name);

        }


        /// <summary>
        /// 按开始时间查询
        /// </summary>
        /// <param name="leave6"></param>
        /// <returns></returns>
        public static DataTable LeaveLstart(Entity.Leave leave6)
        {
            return DAL.LeaveDAL.LeaveLstart(leave6);
        }

        /// <summary>
        /// 查询待审核请假表
        /// </summary>
        /// <returns></returns>
        public static DataTable LeaveYN()
        {

            return DAL.LeaveDAL.LeaveYN();
        }

        /// <summary>
        /// //更新请假详情  LWhy传递状态
        /// </summary>
        /// <param name="le"></param>
        /// <returns></returns>
        public static bool UpLeave(Entity.Leave le)
        {
            if (DAL.LeaveDAL.UpLeave(le) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 更新信息状态
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static void UpState(Entity.Pay p)
        {
            DAL.LeaveDAL.UpPState(p);

        }









    }
}
