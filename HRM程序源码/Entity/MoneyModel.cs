using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 可被序列化的  工资模类
    /// </summary>
    [Serializable]
    public class MoneyModel
    {
        //每小时迟到罚钱
        private double HourDel;
        public double hourDel
        {
            get
            {
                return this.HourDel;
            }
            set
            {
                if (value > 0)
                {
                    this.HourDel = value;
                }
                else
                {
                    throw new HrmException("金额不可为负数！");
                }
            }
        }

        //每小时加班费用
        private double HourAdd;
        public double houeAdd
        {
            get
            {
                return this.HourAdd;
            }
            set
            {
                if (value > 0)
                {
                    this.HourAdd = value;
                }
                else
                {
                    throw new HrmException("金额不可为负数！");
                }
            }
        }

        //全勤奖金
        private double AllAdd;
        public double allAdd
        {
            get
            {
                return this.AllAdd;
            }
            set
            {
                if (value > 0)
                {
                    this.AllAdd = value;
                }
                else
                {
                    throw new HrmException("金额不可为负数！");
                }
            }
        }

       

        //下月应出勤天数
        private int ShouldDay;
        public int shouldDay
        {
            get
            {
                return this.ShouldDay;
            }
            set
            {
                if (value > 0 && value < 31)
                {
                    this.ShouldDay = value;
                }
                else
                {
                    throw new HrmException("天数超出范围！");
                }
            }
        }

        //每月工资发放日
        private int GoDay;
        public int goDay
        {
            get
            {
                return this.GoDay;
            }
            set
            {
                if (value > 0 && value < 31)
                {
                    this.GoDay = value;
                }
                else
                {
                    throw new HrmException("天数超出范围！");
                }
            }
        }

        //是否为第一次登陆
        private bool IsNew;
        public bool isNew
        {
            get
            {
                return this.IsNew;
            }
            set
            {
                this.IsNew = value;
            }
        }
    }
}
