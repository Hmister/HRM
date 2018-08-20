using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EDAL
{
    /// <summary>
    /// 物资类
    /// </summary>
    public class GoodsDAL
    {
        /// <summary>
        /// 提交自评
        /// </summary>
        /// <param name="ap"></param>
        /// <returns></returns>
        public static int gets(Entity.Appraise ap)
        {
            string sqlstr = "insert into Appraise values('" + ap.pID + "','" + ap.aTIme + "','待审核','" + ap.aText + "','员工自评','" + ap.aRate + "')";
            int i = DBHelper.GetLine(sqlstr);
            return i;
        }


        /// <summary>
        /// 查找物品编码
        /// </summary>
        /// <returns></returns>
        public static int SearchCode(Entity.GoodsCode gc)
        {
            string sql = "select COUNT(*) from Goods where GID=" + gc.gID + "";
            return (int)DBHelper.GetScalar(sql);
        }

        /// <summary>
        /// 加载物资列表
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadGoods()
        {
            string sql = "select * from Goods";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 添加申请记录
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static int AddCode(Entity.GoodsCode gc)
        {
            string sql = "insert into GoodsCode values(" + gc.pID + "," + gc.gID + "," + gc.gcCount + ",'" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','未领取')";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 查询物品领取码
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static int SearchGC(Entity.GoodsCode gc)
        {
            string sql = "select top 1 GCID from GoodsCode where PID=" + gc.pID + " order by GCTime DESC";
            return (int)DBHelper.GetScalar(sql);
        }


        /// <summary>
        /// 未使用领取码
        /// </summary>
        /// <param name="gc"></param>
        /// <returns></returns>
        public static DataTable CodesList(Entity.GoodsCode gc)
        {
            string sql = "select GCID from GoodsCode where PID=" + gc.pID + " and GCState='未领取'";
            return DBHelper.GetDT(sql);
        }

        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public static int SearchCount(Entity.Goods g)
        {
            string sql = "select GCount from Goods where GID="+g.gID+"";
            return (int)DBHelper.GetScalar(sql);
        }
    }
}
