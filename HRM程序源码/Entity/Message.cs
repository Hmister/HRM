using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 消息类
    /// </summary>
    public class Message
    {
        //消息编号
        private int MID;
        public int mID
        {
            get
            {
                return this.MID;
            }
            set
            {
                if (value > 9999 && value < 10000000)
                {
                    this.MID = value;
                }
                else
                {
                    throw new HrmException("消息编号有误！");
                }
            }
        }

        //发信人账户编号
        private int UID;
        public int uID
        {
            set
            {
                if (uID < 0)
                {
                    throw new HrmException("输入的账户编号有误！");
                }
                else
                {
                    this.UID = value;
                }
            }
            get
            {
                return this.UID;
            }
        }

        //邮件正文
        private string MText;
        public string mText
        {
            get
            {
                return this.MText;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("消息内容不能为空");
                }
                else
                {
                    this.MText = value;
                }
            }
        }

        //发信时间
        private DateTime MTime;
        public DateTime mTIme
        {
            get
            {
                return this.MTime;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("发信时间不能为空！");
                }
                else
                {
                    this.MTime = value;
                }
            }
        }

        //发信状态
        private string MState;
        public string mState
        {
            get
            {
                return this.MState;
            }
            set
            {
                if (value == "未读" || value == "已读")
                {
                    this.MState = value;
                }
                else
                {
                    throw new HrmException("消息状态有误！");
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


    }
}
