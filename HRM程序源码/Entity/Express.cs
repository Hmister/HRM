using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 奖惩表
    /// </summary>
    public class Express
    {

        //奖惩记录编号
        private int EID;
        public int eID
        {
            get
            {
                return this.EID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.EID = value;
                }
                else
                {
                    throw new HrmException("输入的奖惩记录编号有误");
                }
            }
        }

        //处理人员信息编号
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

        //奖惩类型
        private string EType;
        public string eType
        {
            get
            {
                return this.EType;
            }
            set
            {
                if (value == "奖励" || value == "处罚")
                {
                    this.EType = value;
                }
                else
                {
                    throw new HrmException("输入的处理类型不存在！");
                }
            }
        }

        //操作金额
        private double EMoney;
        public double eMoney
        {
            get
            {
                return this.EMoney; 
            }
            set
            {
                if (value > 0 && value < 1000000)
                {
                    this.EMoney = value;
                }
                else
                {
                    throw new HrmException("操作金额不在范围内！");
                }
            }
        }

        //操作原因
        private string EWhy;
        public string eWhy
        {
            get
            {
                return this.EWhy;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("操作原因不能为空！");
                }
                else
                {
                    this.EWhy = value;
                }
            }
        }

        //操作时间
        private DateTime ETime;
        public DateTime eTime
        {
            get
            {
                return this.ETime;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入操作时间！");
                }
                else
                {
                    this.ETime = value;
                }
            }
        }


        //操作人
        private string EBoss;
        public string eBoss
        {
            get
            {
                return this.EBoss;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("操作人不能为空！");
                }
                else
                {
                    this.EBoss = value;
                }
            }
        }



    }
}
