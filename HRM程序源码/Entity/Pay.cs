using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 工资表
    /// </summary>
    public class Pay
    {
        //工资信息编号
        private int PayID;
        public int payID
        {
            get
            {
                return this.PayID;
            }
            set
            {
                if (value > 9999 && value < 100000000)
                {
                    this.PayID = value;
                }
                else
                {
                    throw new HrmException("工资单编号超出范围！");
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

        //应发工资
        private double PayAll;
        public double payAll
        {
            get
            {
                return this.PayAll;
            }
            set
            {
                if (value > 0)
                {
                    this.PayAll = value;
                }
                else
                {
                    throw new HrmException("您输入的应发工资金额有误！");
                }
            }
        }

        //基本工资
        private double PayBase;
        public double payBase
        {
            get
            {
                return this.PayBase;
            }
            set
            {
                if (value > 0)
                {
                    this.PayBase = value;
                }
                else
                {
                    throw new HrmException("您输入的基本工资金额有误！");
                }
            }
        }

        //补贴工资
        private double PayAdd;
        public double payAdd
        {
            get
            {
                return this.PayAdd;
            }
            set
            {
                if (value >= 0)
                {
                    this.PayAdd = value;
                }
                else
                {
                    throw new HrmException("您输入的补贴工资金额有误！");
                }
            }
        }

        //扣除工资
        private double PayDel;
        public double payDel
        {
            get
            {
                return this.PayDel;
            }
            set
            {
                if (value >= 0)
                {
                    this.PayDel = value;
                }
                else
                {
                    throw new HrmException("您输入的扣除工资金额有误！");
                }
            }
        }

        //应出勤天数
        private int PayAllDay;
        public int payAllDay
        {
            get
            {
                return this.PayAllDay;
            }
            set
            {
                if (value > 0 && value < 32)
                {
                    this.PayAllDay = value;
                }
                else
                {
                    throw new HrmException("应出勤天数超出范围！");
                }
            }

        }

        //实际勤天数
        private int PayDay;
        public int payDay
        {
            get
            {
                return this.PayDay;
            }
            set
            {
                if (value > 0 && value < 32)
                {
                    this.PayDay = value;
                }
                else
                {
                    throw new HrmException("实际出勤天数超出范围！");
                }
            }

        }

        //实发工资
        private double PayIn;
        public double payIn
        {
            get
            {
                return this.PayIn;
            }
            set
            {
                if (value > 0)
                {
                    this.PayIn = value;
                }
                else
                {
                    throw new HrmException("您输入的实发工资金额有误！");
                }
            }
        }

        //工资发放时间
        private DateTime PayTime;
        public DateTime payTime
        {
            get
            {
                return this.PayTime;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入工资发放时间！");
                }
                else
                {
                    this.PayTime = value;
                }
            }
        }


    }
}
