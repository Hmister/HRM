using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 岗位表
    /// </summary>
    public class Job
    {
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

        //岗位名称字段
        private string JName;
        public string jName
        {
            get
            {
                return this.JName;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("岗位名称不能为空！");
                }
                else
                {
                    this.JName = value;                }

            }
        }

        //部门编号
        private int DepID;
        public int depID
        {
            get
            {
                return this.DepID;
            }
            set
            {
                if (value > 9999 && value < 100000)
                {
                    this.DepID = value;
                }
                else
                {
                    throw new HrmException("部门编号有误！");
                }
            }
        }

    }
}
