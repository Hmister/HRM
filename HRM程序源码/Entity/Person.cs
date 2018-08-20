using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 人员信息表
    /// </summary>
     public class Person
    {
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


        //员工密码
        private string PPwd;
        public string pPwd
        {
            set
            {
                if (value == "")
                {
                    throw new HrmException("输入密码不能为空！");
                }
                else
                {
                    this.PPwd = value;
                }
            }
            get
            {
                return this.PPwd;
            }
        }

        //人员状态
        private string PState;
        public string pState
        {
            get
            {
                return this.PState;
            }
            set
            {
                if (value!="")
                {
                    this.PState = value;
                }
                else
                {
                    throw new HrmException("选择的账号状态有误！");
                }
            }
        }

        //人源姓名字段
        private string PName;
        public string pName
        {
            get
            {
                return this.PName;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("人员姓名不能为空！");
                }
                else
                {
                    this.PName = value;
                }
            }
        }

        //性别字段
        private char PSex;
        public char pSex
        {
            get
            {
                return this.PSex;
            }
            set
            {
                if (value == '男' || value == '女')
                {
                    this.PSex = value;
                }
                else
                {
                    throw new  HrmException("请输入正确的性别");
                }
            }
        }

        //人员民族字段
        private string PEthnic;
        public string pEthnic
        {
            get
            {
                return this.PEthnic;
            }
            set
            {
                if (value == "")
                {
                    throw new HrmException("请输入民族！");
                }
                else if (value.Length > 20)
                {
                    throw new HrmException("字数超出限制！");
                }
                else
                {
                    this.PEthnic = value;
                }
                    
            }
        }

        //人员年龄
        private int PAge;
        public int pAge
        {
            get
            {
                return this.PAge;
            }
            set
            {
                if (value > 0 && value < 200)
                {
                    this.PAge = value;
                }
                else
                {
                    throw new HrmException("请输入正确的年龄！");
                }
            }
        }

        //人员照片名称
        public string pPic { get; set; }

        //用户联系方式
        private string PPhone;
        public string pPhone
        {
            get
            {
                return this.PPhone;
            }
            set
            {
                if (value != "")
                {
                    this.PPhone = value;
                }
                else
                {
                    throw new HrmException("请输入您的联系方式！");
                }
            }
        }

        //用户QQ
        private string PQQ;
        public string pQQ
        {
            get
            {
                return this.PQQ;
            }
            set
            {
                if (value != "")
                {
                    this.PQQ = value;
                }
                else
                {
                    throw new HrmException("请输入您的QQ号码！");
                }
            }
        }

        //用户邮箱
        private string PMail;
        public string pMail
        {
            get
            {
                return this.PMail;
            }
            set
            {
                if (value != "")
                {
                    this.PMail = value;
                }
                else
                {
                    throw new HrmException("请输入您的电子邮箱！");
                }
            }
        }


        //入职日期
        private DateTime PInTime;
        public DateTime pInTime
        {
            get
            {
                return this.PInTime;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("请输入你的入职时间！");

                }
                else
                {
                    this.PInTime = value;
                }
            } 
        }

        //所学专业
        private string PSubject = "未填写";
        public string pSubject
        {
            get
           {
                return this.PSubject;
            }
            set
            {
                this.PSubject = value;
            }
        }

        //毕业院校
        private string PSchool = "学校名称未知";
        public string pSchool
        {
            get
            {
                return this.PSchool;
            }
            set
            {
                this.PSchool = value;
            }
        }

        //政治面貌
        private string PFaction = "群众";
        public string pFaction
        {
            get
            {
                return this.PFaction;
            }
            set
            {
                if (value == "群众" || value == "团员" || value == "党员" || value == "其它")
                {
                    this.PFaction = value;
                }
                else
                {
                    throw new HrmException("不存在此种类型的政治面貌！");
                }
            }
        }

        //婚姻状况
        private string PMarry = "未婚";
        public string pMarry
        {
            get
            {
                return this.PMarry;
            }
            set
            {
                if (value == "未婚" || value == "已婚" || value == "离婚" || value == "保密")
                {
                    this.PMarry = value;
                }
                else
                {
                    throw new HrmException("请选择正确的婚姻状况！");
                }
            }
        }

        //兴趣爱好
        private string PInteresting;
        public string pInteresting
        {
            set
            {
                if (value == "")
                {
                    throw new HrmException("请输入您的兴趣爱好！");
                }
                else
                {
                    this.PInteresting = value;
                }
            }
            get
            {
                return this.PInteresting;
            }
        }

        //出生日期
        private DateTime PBirthday;
        public DateTime pBirthday
        {
            set
            {
                if (value == null)
                {
                    throw new HrmException("请填写您的出生日期！");
                }
                else
                {
                    this.PBirthday = value;
                }
            }
            get
            {
                return this.PBirthday;
            }
        }

        //身份证号码
        private string PCardID;
        public string pCardID
        {
            set
            {
                if (value == null)
                {
                    throw new HrmException("请填写身份证号码！");
                }
                else
                {
                    this.PCardID= value;
                }
            }
            get
            {
                return this.PCardID;
            }
        }

        //岗位编号
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

        //最后登录时间
        private DateTime PLTime;
        public DateTime pLTime
        {
            get
            {
                return this.PLTime;
            }
            set
            {
                if (value == null)
                {
                    throw new HrmException("登录时间不能为空！");
                }
                else
                {
                    this.PLTime = value;
                }
            }
        }




    }
}
