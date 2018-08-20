using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 部门表
    /// </summary>
    public class Department
    {
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

        //部门名称
        private string DepName;
        public string depName
        {
            get
            {
                return this.DepName;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("部门名称不能为空！");
                }
                else
                {
                    this.DepName = value;
                }
            }
        }
    }
}
