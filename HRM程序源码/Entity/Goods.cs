using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 物资表
    /// </summary>
    public class Goods
    {
        //物资编号
        private int GID;
        public int gID
        {
            get
            {
                return this.GID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.GID = value;
                }
                else
                {
                    throw new HrmException("物资编号有误！");
                }
            }
        }

        //物资名称
        private string GName;
        public string gName
        {
            get
            {
                return this.GName;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("物资名称不能为空！");
                }
                else
                {
                    this.GName = value;
                }
            }
        }

        //物资数量
        private int GCount;
        public int gCount
        {
            get
            {
                return this.GCount;
            }
            set
            {
                if (value >= 0)
                {
                    this.GCount = value;
                }
                else
                {
                    throw new HrmException("物资数量有误！");
                }
            }

        }

        //物资单价
        private double GPrice;
        public double gPrice
        {
            get
            {
                return this.GPrice;
            }
            set
            {
                if (value >= 0)
                {
                    this.GPrice = value;
                }
                else
                {
                    throw new HrmException("物品单价有误！");
                }
            }
        }



    }
}
