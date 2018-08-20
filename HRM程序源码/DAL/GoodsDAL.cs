using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    /// <summary>
    /// 物资类
    /// </summary>
    public class GoodsDAL
    {

        /// <summary>
        /// 物资详情
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable LoadGoods()
        {
            string sql = "select GID 物品编号,GName 物品名称,GCount 物品数量,GPrice 物品单价 from Goods";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 物品详情
        /// </summary>
        /// <returns></returns>
        public static System.Data.DataTable LoadGoodOnly(Entity.Goods g)
        {
            string sql = "select GName ,GCount ,GPrice  from Goods where GID="+g.gID+"";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 添加物品
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static int AddGoods(Entity.Goods g)
        {
            string sql = "insert into Goods values('"+g.gName+"','"+g.gCount+"','"+g.gPrice+"')";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 更新物品数量物品数量，价格
        /// </summary>
        /// <returns></returns>
        public static int UpAdd(Entity.Goods g)
        {
            string sql = "update Goods set GCount='"+g.gCount+"',GPrice='"+g.gPrice+"' where GID="+g.gID+"";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 检测号码是否存在
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static bool SearchCode(Entity.GoodsCode gc)
        {
            string sql = "select COUNT(*) from GoodsCode where GCID="+gc.gcID+"";
            if ((int)DBHelper.GetScalar(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否使用
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static bool IfUse(Entity.GoodsCode gc)
        {
            string sql = "select GCState from GoodsCode Where GCID=" + gc.gcID + "";
            if (DBHelper.GetScalar(sql).ToString() == "未领取")
            {
                return true;
            }
            else
            {

                return false;
            }
        }


        /// <summary>
        /// 查询发放信息
        /// </summary>
        /// <param name="gc"></param>
        public static System.Data.DataTable CoedInfo(Entity.GoodsCode gc)
        {
            string sql = "select GName,GCCount from Goods,GoodsCode where Goods.GID=GoodsCode.GID and GcID="+gc.gcID+"";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static int UpCode(Entity.GoodsCode gc)
        {
            string sql = "update GoodsCode set GCState='已使用' where GCID=" + gc.gcID + "";
            return (int)DBHelper.GetLine(sql);
        }

    }
}
