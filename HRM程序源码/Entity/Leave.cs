using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 请假表
    /// </summary>
    public class Leave
    {
        //请假表编号
        private int LID;
        public int lID
        {
            get
            {
                return this.LID;
            }
            set
            {
                if (value > 9999 && value < 1000000)
                {
                    this.LID = value;
                }
                else
                {
                    throw new HrmException("请假单编号超出范围！");
                }
            }
        }

        //请假人员编号
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

        //请假原因
        private string LWhy;
        public string lWhy
        {
            get
            {
                return this.LWhy;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("请假原因不能为空！");
                }
                else
                {
                    this.LWhy = value;
                }
            }
        }

        //假期开始时间
        private DateTime LStart;
        public DateTime lStart
        {
            get
            {
                return this.LStart;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入假期开始时间！");
                }
                else
                {
                    this.LStart = value;
                }
            }
        }

        //假期结束时间
        private DateTime LStop;
        public DateTime lStop
        {
            get
            {
                return this.LStop;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入假期结束时间！");
                }
                else
                {
                    this.LStop = value;
                }
            }
        }


        //准假批准人
        private string LBoss;
        public string lBoss
        {
            get
            {
                return this.LBoss;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("准假人不能为空！");
                }
                else
                {
                    this.LBoss = value;
                }
            }
        }


        //请假状态
        private string LState;
        public string lState
        {
            get
            {
                return this.LState;
            }
            set
            {
                if (value == "待审核" || value == "通过" || value == "驳回"||value== "已销假")
                {
                    this.LState = value;
                }
                else
                {
                    throw new HrmException("请输入正确的状态！");
                }
            }
        }


    }
}
