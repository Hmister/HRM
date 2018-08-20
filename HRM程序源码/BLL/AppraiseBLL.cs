using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entity;

namespace BLL
{
    public class AppraiseBLL
    {
        //添加评估
        public static bool Appraise1(Entity.Appraise Appraise1)
        {
            return DAL.AppraiseDAL.Appraise(Appraise1);

        }


        //查询评估表
        public static DataTable Appraise2(Entity.Appraise Appraise2)
        {

            return DAL.AppraiseDAL.Appraise2(Appraise2);

        }


        //按评估编号查询
        public static DataTable Appraise3(Entity.Appraise Appraise3)
        {

            return DAL.AppraiseDAL.Appraise3(Appraise3);

        }


        //按员工编号查询
        public static DataTable Appraise4(Entity.Appraise Appraise4)
        {

            return DAL.AppraiseDAL.Appraise4(Appraise4);

        }

        //按评估等级查询
        public static DataTable Appraise5(Entity.Appraise Appraise5)
        {

            return DAL.AppraiseDAL.Appraise5(Appraise5);

        }

        /// <summary>
        /// 加载自评
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadSelf()
        {
            return DAL.AppraiseDAL.LoadSelf();
        }


        /// <summary>
        /// 通过审核
        /// </summary>
        /// <returns></returns>
        public static bool UpSelf(Entity.Appraise a)
        {
            if (DAL.AppraiseDAL.UpSelf(a) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 驳回审核
        /// </summary>
        /// <returns></returns>
        public static bool DelSelf(Entity.Appraise a)
        {
            if (DAL.AppraiseDAL.DelSelf(a) > 0)
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
