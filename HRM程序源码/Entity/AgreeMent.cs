using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 员工合同表
    /// </summary>
    public class AgreeMent
    {
        //合同记录编号
        private int AMID;
        public int amID
        {
            get
            {
                return this.AMID;
            }
            set
            {
                if (value > 9999 && value < 1000000)
                {
                    this.AMID = value;
                }
                else
                {
                    throw new HrmException("编号不在范围内！");
                }
            }
        }

        //乙方人员编号
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

        //合同生效时间
        private DateTime AMStart;
        public DateTime amStart
        {
            get
            {
                return this.AMStart;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入合同生效时间！");
                }
                else
                {
                    this.AMStart = value;
                }
            }
        }

        public string AMText { set; get; }


        //合同过期时间
        private DateTime AMStop;
        public DateTime amStop
        {
            get
            {
                return this.AMStop;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入合同过期时间！");
                }
                else
                {
                    this.AMStop = value;
                }
            }
        }

        //基本工资
        private double AMBase;
        public double amBase
        {
            get
            {
                return this.AMBase;
            }
            set
            {
                if (value > 0 && value < 999999)
                {
                    this.AMBase = value;
                }
                else
                {
                    throw new HrmException("基本工资金额超出范围！");
                }
            }
        }

        //合同状态
        private string AMState;
        public string amState
        {
            get
            {
                return this.AMState;
            }
            set
            {
                if (value == "未生效" || value == "已生效" || value == "已过期")
                {
                    this.AMState = value;
                }
                else
                {
                    throw new HrmException("不存在该合同状态！");
                }
            }
        }

    }
}
