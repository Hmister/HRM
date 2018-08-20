using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 培训相关表字段
    /// </summary>
    public class Train
    {
        //-------培训课程表Lesson字段---------

        //课程编号
        private int LeID;
        public int leID
        {
            get
            {
                return this.LeID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.LeID = value;
                }
                else
                {
                    throw new HrmException("课程编号不再范围内！");
                }
            }
        }

        //课程名称
        private string LeName;
        public string leName
        {
            get
            {
                return this.LeName;
            }
            set
            {
                if (value == "" || value.Length > 50)
                {
                    throw new HrmException("输入的课程名不正确！");
                }
                else
                {
                    this.LeName = value;
                }
            }
        }

        //课程类型
        private string LeType;
        public string leType
        {
            get
            {
                return this.LeType;
            }
            set
            {
                if (value == "全新课程" || value == "补充课程" || value == "强化课程" || value == "其他课程")
                {
                    this.LeType = value;
                }
                else
                {
                    throw new HrmException("您输入的课程类型有误！");
                }
            }
        }

        //课程简介
        private string LeText;
        public string leText
        {
            get
            {
                return this.LeText;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("请输入课程简介！");
                }
                else
                {
                    this.LeText = value;
                }
            }
        }



        //-------培训计划表TrainPlan字段---------
        //培训计划编号
        private int TPID;
        public int tpID
        {
            get
            {
                return this.LeID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.LeID = value;
                }
                else
                {
                    throw new HrmException("课程编号不再范围内！");
                }
            }
        }

        //培训讲师姓名
        private string TPTeacher;
        public string tpTeacher
        {
            get
            {
                return this.TPTeacher;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("请输入讲师姓名！");
                }
                else
                {
                    this.TPTeacher = value;
                }
            }
        }

        //培训地点
        private string TPAdr;
        public string tpAdr
        {
            get
            {
                return this.TPAdr;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("培训地址不能为空！");
                }
                else
                {
                    this.TPAdr = value;
                }
            }
        }

        //培训人数
        private int TPCount;
        public int tpCount
        {
            get
            {
                return this.TPCount;
            }
            set
            {
                if(value>0&&value<10000)
                {
                    this.TPCount = value;
                }
                else
                {
                    throw new HrmException("培训人数填写有误！");
                }
            }
        }

        //培训开始时间
        private DateTime TPStart;
        public DateTime tpStart
        {
            get
            {
                return this.TPStart;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入培训开始时间！");
                }
                else
                {
                    this.TPStart = value;
                }
            }
        }

        //培训结束时间
        private DateTime TPStop;
        public DateTime tpStop
        {
            get
            {
                return this.TPStop;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入培训结束时间！");
                }
                else
                {
                    this.TPStop = value;
                }
            }
        }

        //-------人员培训记录表TPNotes字段---------

        //培训记录编号      
        private int NID;
        public int nID
        {
            get
            {
                return this.NID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.NID = value;
                }
                else
                {
                    throw new HrmException("培训记录编号不再范围内！");
                }
            }
        }

        //培训人员信息编号
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


        //学习效果
        private string NResult;
        public string nResult
        {
            get
            {
                return this.NResult;
            }
            set
            {
                if (value == "优秀" || value == "良好" || value == "一般" || value == "差")
                {
                    this.NResult = value;
                }
                else
                {
                    throw new HrmException("您输入的学习效果类型不存在！");
                }
            }
        }

        //学习结课评价
        private string NTexts;
        public string nTexts
        {
            get
            {
                return this.NTexts;
            }
            set
            {
                if (value != "" && value.Length < 500)
                {
                    this.NTexts = value;
                }
                else
                {
                    throw new HrmException("评价内容不符合要求！");
                }
            }
        }



    }
}
