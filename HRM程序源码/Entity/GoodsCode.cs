using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 物资领取记录
    /// </summary>
     public class GoodsCode
    {
        //记录编号
        private int GCID;
        public int gcID
        {
            get
            {
                return this.GCID;
            }
            set
            {
                if (value > 9999 && value < 1000000)
                {
                    this.GCID = value;
                }
                else
                {
                    throw new HrmException("记录编号有误！");
                }
            }
        }

        //人员信息编号
        private int PID;
        public int pID
        {
            get
            {
                return this.PID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.PID = value;
                }
                else
                {
                    throw new HrmException("输入的人员编号有误");
                }
            }
        }

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

        //领取数量
        private int GCCount;
        public int gcCount
        {
            get
            {
                return this.GCCount;
            }
            set
            {
                if (value > 0)
                {
                    this.GCCount = value;
                }
                else
                {
                    throw new HrmException("请填写正确的领取数量！");
                }
            }
        }

        //领取时间
        public DateTime gcTime { get; set; }

        //记录状态
        private string GCState;
        public string gcState
        {
            get
            {
                return this.GCState;
            }
            set
            {
                if (value == "未领取" || value == "已使用")
                {
                    this.GCState = value;
                }
                else
                {
                    throw new HrmException("记录状态录入有误！");
                }
            }
        }

    }
}
