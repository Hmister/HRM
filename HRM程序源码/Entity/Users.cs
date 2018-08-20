using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Users
    {
        //账户编号
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

        //账户名称
        private string UName;
        public string uName
        {
            set
            {
                if (value == "")
                {
                    throw new HrmException("账户名称不能为空！");
                }
                else
                {
                    this.UName = value;
                }
            }
            get
            {
                return this.UName;
            }
        }

        //账户密码
        private string UPwd;
        public string uPwd
        {
            set
            {
                if (value == "")
                {
                    throw new HrmException("输入密码不能为空！");
                }
                else
                {
                    this.UPwd = value;
                }
            }
            get
            {
                return this.UPwd;
            }
        }

        //账户邮箱
        private string UMail;
        public string uMail
        {
            get
            {
                return this.UMail;
            }
            set
            {
                if (value != "")
                {
                    this.UMail = value;
                }
                else
                {
                    throw new HrmException("请输入您的电子邮箱！");
                }
            }
        }


        //账户状态
        private string State;
        public string state
        {
            get
            {
                return this.State;
            }
            set
            {
                if (value!="")
                {
                    this.State = value;
                }
                else
                {
                    throw new HrmException("请输入正确的账户状态！");
                }
            }
        }

        //头像名称
        public string logo { get; set; }

        //用户性别
        private char Sex;
        public char sex
        {
            get
            {
                return this.Sex;
            }
            set
            {
                if (value == '男' || value == '女')
                {
                    this.Sex = value;
                }
                else
                {
                    throw new HrmException("请输入正确的性别");
                }
            }
        }

        //用户年龄
        private int Age;
        public int age
        {
            get
            {
                return this.Age;
            }
            set
            {
                if (value>0 &&value <200)
                {
                    this.Age= value;
                }
                else
                {
                    throw new HrmException("请输入正确的年龄！");
                }
            }
        }

        //用户联系方式
        private string Phone;
        public string phone
        {
            get
            {
                return this.Phone;
            }
            set
            {
                if (value != "")
                {
                    this.Phone = value;
                }
                else
                {
                    throw new HrmException("请输入您的联系方式！");
                }
            }
        }

        //最后登录时间
        public DateTime lastTime { get; set; }


    }
}
