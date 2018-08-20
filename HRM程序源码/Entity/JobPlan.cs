using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 招聘计划表
    /// </summary>
    public class JobPlan
    {
        //招聘计划编号
        private int JPID;
        public int jpID
        {
            get
            {
                return this.JPID;
            }
            set
            {
                if (value > 999 && value < 10000)
                {
                    this.JPID = value;
                }
                else
                {
                    throw new HrmException("您输入的计划编号有误！");
                }
            }
        }

        // 岗位编号
        //岗位编号字段
        private int JID;
        public int jID
        {
            get
            {
                return this.JID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.JID = value;
                }
                else
                {
                    throw new HrmException("输入的岗位编号有误！");
                }
            }

        }

        //招聘人数
        private int JPCount;
        public int jpCount
        {
            get
            {
                return this.JPCount;
            }
            set
            {
                if (value > 0 && value < 100000)
                {
                    this.JPCount = value;
                }
                else
                {
                    throw new HrmException("招聘人数超出范围！");
                }
            }
        }

        //招聘要求
        private string JPNeed;
        public string jpNeed
        {
            get
            {
                return this.JPNeed;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("请输入招聘计划的具体要求！");
                }
                else
                {
                    this.JPNeed = value;
                }
            }
        }

        //招聘开始时间
        private DateTime JPStart;
        public DateTime jpStart
        {
            get
            {
                return this.JPStart;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入开始时间！");
                }
                else
                {
                    this.JPStart = value;
                }
            }
        }

        //招聘结束时间
        private DateTime JPStop;
        public DateTime jpStop
        {
            get
            {
                return this.JPStop;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入结束时间！");
                }
                else
                {
                    this.JPStop = value;
                }
            }
        }

        //招聘方联系人
        private string JPCall;
        public string jpCall
        {
            get
            {
                return this.JPCall;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("招聘联系人不能为空！");
                }
                else
                {
                    this.JPCall = value;
                }
            }
        }

        //联系人电话
        private string JPPhone;
        public string jpPhone
        {
            get
            {
                return this.JPPhone;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("请输入招聘联系人的联系方式！");
                }
                else
                {
                    this.JPPhone = value;
                }
            }
        }


    }
}
