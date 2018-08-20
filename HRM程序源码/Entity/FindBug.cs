using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 异常反馈表
    /// </summary>
    public class FindBug
    {
        //标题字段
        private string Title;
        public string title
        {
            get
            {
                return this.Title;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("标题不能为空！");
                }
                else
                {
                    this.Title = value;
                }
            }
        }

        //类型字段
        private int Type;
        public int type
        {
            set
            {
                if (value == 0 || value == 1 || value == 2)
                {
                    this.Type = value;
                }
                else
                {
                    throw new HrmException("请选择正确的问题类型！");
                }
            }
            get
            {
                return this.Type;
            }
        }

        //联系方式字段
        private string Call;
        public string call
        {
            set
            {
                if (value == "")
                {
                    throw new HrmException("请输入你的联系方式！");
                }
                else
                {
                    this.Call = value;
                }
            }
            get
            {
                return this.Call;
            }
        }

        //内容字段
        private string Text;
        public string text
        {
            set
            {
                if (value == "")
                {
                    throw new HrmException("请输入问题详情！");
                }
                else
                {
                    this.Text = value;
                }
            }
            get
            {
                return this.Text;
            }
        }

    }
}
