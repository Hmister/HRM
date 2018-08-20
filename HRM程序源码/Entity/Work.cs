using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 考勤表
    /// </summary>
    public class Work
    {
        //考勤表编号
        private int WID;
        public int wID
        {
            get
            {
                return this.WID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.WID = value;
                }
                else
                {
                    throw new HrmException("您输入的考勤表编号有误！");
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

        private DateTime WTime;
        public DateTime wTime
        {
            get
            {
                return this.WTime;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("考勤时间不能为空！");
                }
                else
                {
                    this.WTime = value;
                }
            } 
        }

        //考勤状态
        private string WState;
        public string wState
        {
            get
            {
                return this.WState;
            }
            set
            {
                if (value == "成功" || value == "迟到" || value == "早退")
                {
                    this.WState = value;
                }
                else
                {
                    throw new HrmException("此考勤状态不存在！");
                }
            }
        }










    }
}
