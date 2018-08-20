using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EBLL
{
    /// <summary>
    /// 物资类
    /// </summary>
    public class GoodsBLL
    {
        /// <summary>
        /// 提交自评
        /// </summary>
        /// <param name="ap"></param>
        /// <returns></returns>
        public static bool gets(Entity.Appraise ap)
        {
            if (EDAL.GoodsDAL.gets(ap) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 查找物品编码
        /// </summary>
        /// <returns></returns>
        public static bool SearchCode(Entity.GoodsCode gc)
        {
            if (EDAL.GoodsDAL.SearchCode(gc) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        /// <summary>
        /// 加载物资列表
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadGoods()
        {
            return EDAL.GoodsDAL.LoadGoods();
        }


        /// <summary>
        /// 添加申请记录
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static bool AddCode(Entity.GoodsCode gc)
        {
            if (EDAL.GoodsDAL.AddCode(gc) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 查询物品领取码
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static int SearchGC(Entity.GoodsCode gc)
        {
            try
            {
                return EDAL.GoodsDAL.SearchGC(gc);
            }
            catch
            {
                return 0000;
            }
        }

        /// <summary>
        /// 未使用领取码
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static string CodesList(Entity.GoodsCode gc)
        {
            DataTable dt=EDAL.GoodsDAL.CodesList(gc);
            string codes = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                codes += dt.Rows[i][0].ToString()+"\r\n";
            }
            return codes;
        }

        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static int SearchCount(Entity.Goods g)
        {
            return EDAL.GoodsDAL.SearchCount(g);
        }


        }
}
