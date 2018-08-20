using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BLL
{
    /// <summary>
    /// 员工薪水 业务逻辑层
    /// </summary>
    public class SalaryBLL
    {
        /// <summary>
        /// 保存工资设定
        /// </summary>
        /// <returns></returns>
        public static void SaveSet(Entity.MoneyModel mm)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\Config\Model.XML", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, mm);
            fs.Close();
        }


        /// <summary>
        /// 读取工资设定
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Entity.MoneyModel OpenSet()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\Config\Model.XML", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Entity.MoneyModel mm = (Entity.MoneyModel)bf.Deserialize(fs);
            fs.Close();
            return mm;
        }


        //全勤奖奖金

        private static double allDayAdd;
        private static int goDay;
        /// <summary>
        /// 计算工资
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private static DataTable CountMoney(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double pBase = double.Parse(dt.Rows[i][4].ToString());
                double pAdd = double.Parse(dt.Rows[i][7].ToString());
                double pDel = double.Parse(dt.Rows[i][8].ToString());
                double pShould = 0;
                //应发=基本+奖励
                pShould = pBase + pAdd;
                //实发工资=应发工资-处罚
                dt.Rows[i][9] = pShould - pDel;
                dt.Rows[i][3] = pShould;
     
            }
            return dt;
        }


        /// <summary>
        /// 所有工资记录
        /// </summary>
        /// <returns></returns>
        public static DataTable AllPay()
        {
            Entity.MoneyModel mm = OpenSet();
            allDayAdd = mm.allAdd;
            goDay = mm.goDay;
            DataTable dt = DAL.SalaryDAL.AllSalary();
            SalaryBLL.CountMoney(dt);
            return dt;

        }


        ////按月份执行
        /// <summary>
        /// 按月份部门查询  利用pID传递部门编号
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static DataTable FindByMDep(Entity.Pay p)
        {
            Entity.MoneyModel mm = OpenSet();
            allDayAdd = mm.allAdd;
            goDay = mm.goDay;
            DataTable dt = DAL.SalaryDAL.FindByMDep(p);
            SalaryBLL.CountMoney(dt);
            return dt;
        }

        /// <summary>
        /// 按月份工号查询 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindByMPID(Entity.Pay p)
        {
            Entity.MoneyModel mm = OpenSet();
            allDayAdd = mm.allAdd;
            goDay = mm.goDay;
            DataTable dt = DAL.SalaryDAL.FindByMPID(p);
            SalaryBLL.CountMoney(dt);
            return dt;
        }

        /// <summary>
        /// 按月份实际发放工资段查询  利用payDel传递最小值 payAdd传递最大值
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindByMMoney(Entity.Pay p)
        {
            Entity.MoneyModel mm = OpenSet();
            allDayAdd = mm.allAdd;
            goDay = mm.goDay;
            DataTable dt = DAL.SalaryDAL.FindByMMoney(p);
            SalaryBLL.CountMoney(dt);
            return dt;
        }

        ///不按月份执行
        /// <summary>
        /// 按部门查询  利用pID传递部门编号
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static DataTable FindByDep(Entity.Pay p)
        {

            Entity.MoneyModel mm = OpenSet();
            allDayAdd = mm.allAdd;
            goDay = mm.goDay;
            DataTable dt = DAL.SalaryDAL.FindByDep(p);
            SalaryBLL.CountMoney(dt);
            return dt;
        }

        /// <summary>
        /// 按工号查询 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindByPID(Entity.Pay p)
        {
            Entity.MoneyModel mm = OpenSet();
            allDayAdd = mm.allAdd;
            goDay = mm.goDay;
            DataTable dt = DAL.SalaryDAL.FindByPID(p);
            SalaryBLL.CountMoney(dt);
            return dt;
        }

        /// <summary>
        /// 按实际发放工资段查询  利用payDel传递最小值 payAdd传递最大值
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindByMoney(Entity.Pay p)
        {
            Entity.MoneyModel mm = OpenSet();
            allDayAdd = mm.allAdd;
            goDay = mm.goDay;
            DataTable dt = DAL.SalaryDAL.FindByMoney(p);
            SalaryBLL.CountMoney(dt);
            return dt;
        }

        /// <summary>
        /// 建模
        /// </summary>
        /// <returns></returns>
        public static void MakeMode()
        {
            Entity.MoneyModel mm = OpenSet();
            int day = mm.shouldDay;
            goDay = mm.goDay;
            string time = System.DateTime.Now.Year + "-" + (System.DateTime.Now.Month + 1) + "-" + mm.goDay;
            int pid;
            double b;
            DataTable dt = DAL.SalaryDAL.SearchPID();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pid = int.Parse(dt.Rows[i][0].ToString());
                b = DAL.SalaryDAL.SearchBase(pid);
                DAL.SalaryDAL.NewSalary(b, pid, day, time);
            }

        }

        /// <summary>
        /// 是否存在下月模
        /// </summary>
        /// <returns></returns>
        public static bool IsHave(Entity.Pay p)
        {
            if ((int)DAL.SalaryDAL.IsHave(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 同步设置
        /// </summary>
        /// <returns></returns>
        public static bool UpSave(string path)
        {
            try
            {
                //路径
                string Spath = Directory.GetCurrentDirectory() + @"\Config\Model.XML";
                string Npath = path ;
                if (File.Exists(Npath) == true)
                {
                    File.Delete(Npath);
                }
                File.Copy(Spath, Npath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 同步邮件设置
        /// </summary>
        /// <returns></returns>
        public static bool UpSaveMail(string path)
        {
            try
            {
                //路径
                string Spath = Directory.GetCurrentDirectory() + @"\Config\BackMail.XML";
                string Npath = path;
                if (File.Exists(Npath) == true)
                {
                    File.Delete(Npath);
                }
                File.Copy(Spath, Npath);
                return true;
            }
            catch
            {
                return false;
            }
        }



        /// <summary>
        /// 返回指定人基本工资
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static double PBase(int pid)
        {
            return DAL.SalaryDAL.SearchBase(pid);
        }


        //-------------------------

        /// <summary>
        /// 更新工资记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static bool UpPay(int id, double money)
        {
            if (DAL.SalaryDAL.UpPay(id, money) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 插入全勤奖记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static bool InAdd(int id, double money)
        {
            if (DAL.SalaryDAL.InAdd(id, money) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 查询当月记录
        /// </summary>
        /// <returns></returns>
        public static bool SearchMoon()
        {
            if ((int)DAL.SalaryDAL.SearchMoon() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新工资记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static bool UpPay1(int id, double money)
        {
            if (DAL.SalaryDAL.UpPay1(id, money) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 插入缺勤惩罚记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static bool InDel(int id, double money)
        {
            if (DAL.SalaryDAL.InAdd1(id, money) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 查询基本工资
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static double SearchBase(int pid)
        {
            return DAL.SalaryDAL.SearchBase(pid);
        }


    }
}
