using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    /// <summary>
    /// 物资类
    /// </summary>
    public class GoodsBLL
    {
        /// <summary>
        /// 物资详情
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable LoadGoods()
        {
            return DAL.GoodsDAL.LoadGoods();
        }

        /// <summary>
        /// 添加物品
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static bool AddGoods(Entity.Goods g)
        {
            if (DAL.GoodsDAL.AddGoods(g) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新物品数量物品数量，价格
        /// </summary>
        /// <returns></returns>
        public static bool UpAdd(Entity.Goods g)
        {
            if (DAL.GoodsDAL.UpAdd(g) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 物品详情
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable LoadGoodOnly(Entity.Goods g)
        {
            return DAL.GoodsDAL.LoadGoodOnly(g);
        }


        /// <summary>
        /// 发放物品
        /// </summary>
        /// <returns></returns>
        public static bool UseCodes(Entity.GoodsCode gc,out string msg)
        {
            if (DAL.GoodsDAL.SearchCode(gc) == false)
            {
                msg = "抱歉,您输入的领取码不存在！";
                return false;
            }
            else if (DAL.GoodsDAL.IfUse(gc) == true)
            {
                System.Data.DataTable dt = DAL.GoodsDAL.CoedInfo(gc);
                msg = "是否确认发放 物品【" + dt.Rows[0][0].ToString() + "】 数量【" + dt.Rows[0][1].ToString() + "】 ？";
                return true;
            }
            else if (DAL.GoodsDAL.IfUse(gc) == false)
            {
                msg = "抱歉,该领取码已被使用！";
                return false;
            }
            else
            {
                msg = "";
                return false;
            }
        }


        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static bool UpCode(Entity.GoodsCode gc)
        {
            if (DAL.GoodsDAL.UpCode(gc) > 0)
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
