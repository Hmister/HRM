using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 员工评价记录表
    /// </summary>
    public class Appraise
    {
        //评价记录编号
        private int AID;
        public int aID
        {
            get
            {
                return this.AID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.AID = value;
                }
                else
                {
                    throw new HrmException("输入的评价记录编号有误");
                }
            }


        }//人员信息编号
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

        //评估时间
        private DateTime ATime;
        public DateTime aTIme
        {
            get
            {
                return this.ATime;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("评价时间不能为空！");
                }
                else
                {
                    this.ATime = value;
                }
            }
        }


        //评估内容
        private string AText;
        public string aText
        {
            get
            {
                return this.AText;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("请填写评价内容！");
                }
                else
                {
                    this.AText = value;
                }
            }
        }

        //评定等级
        private string ARate;
        public string aRate
        {
            get
            {
                return this.ARate;
            }
            set
            {
                if (value == "优秀" || value == "一般" || value == "良好" || value == "差")
                {
                    this.ARate = value;
                }
                else
                {
                    throw new HrmException("您输入的等级不存在！");
                }
            }
        }

        //评价类型
        private string AType;
        public string aType
        {
            get
            {
                return this.AType;
            }
            set
            {
                if (value == "直属领导" || value == "高层直评" || value == "员工自评")
                {
                    this.AType = value;
                }
                else
                {
                    throw new HrmException("请输入正确的评价类型！");
                }
            }
        }


        //评估人员
        public string ABoss { set; get; }












    }
}
