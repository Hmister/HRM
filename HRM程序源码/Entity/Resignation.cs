using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 辞职申请记录表
    /// </summary>
    public class Resignation
    {
        //记录编号
        private int RID;
        public int rID
        {
            get
            {
                return this.RID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.RID = value;
                }
                else
                {
                    throw new HrmException("输入的记录编号有误！");
                }
            }
        }

        //员工编号
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

        //辞职原因
        private string RText;
        public string rText
        {
            get
            {
                return this.RText;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("辞职原因不能为空！");
                }
                else
                {
                    this.RText = value;
                }
            }
        }

        //提交时间
        private DateTime RTime;
        public DateTime rTime
        {
            get
            {
                return this.RTime;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("提交时间不能为空！");
                }
                else
                {
                    this.RTime = value;
                }
            }
        }


        //申请状态
        private string RState;
        public string rState
        {
            get
            {
                return this.RState;
            }
            set
            {
                if (value == "申请中" || value == "驳回" || value == "同意")
                {
                    this.RState = value;
                }
                else
                {
                    throw new HrmException("你输入的状态有误！");
                }
            }
        }


    }
}
