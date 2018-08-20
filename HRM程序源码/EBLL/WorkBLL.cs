using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Entity;
using System.Data;

namespace EBLL
{
    /// <summary>
    /// 签到  请假 业务逻辑类
    /// </summary>
    public class WorkBLL
    {
        /// <summary>
        /// 每日签到方法
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool DayWork(out string msg,Person p)
        {
            
            //加载
            MoneyModel mm = OpenSet();
            
            //判断时间
            int uid = p.pID;
            DateTime time = System.DateTime.Now;
            DateTime now = DateTime.Parse(time.ToString("HH:mm"));

            if (now >=DateTime.Parse("6:00") && now <= DateTime.Parse("8:00"))
            {
                if (EDAL.WorkDAL.IsHere(uid) == 1)
                {
                    msg = "您已签到，请勿重复签到！";
                    return false;
                }
                else
                {
                    //更新考勤
                    p.pState = "成功";
                    EDAL.WorkDAL.AddWork(p);
                    //更新出勤天数
                    EDAL.WorkDAL.UpPayDay(p);
                    msg = "恭喜您，签到成功";
                    return true;
                }

            }
            else if (now > DateTime.Parse("8:00") & now < DateTime.Parse("12:00"))
            {

                if (EDAL.WorkDAL.IsHere(uid) == 1)
                {
                    msg = "您已签到，请勿重复签到！";
                    return false;
                }
                else
                {
                    //早上迟到
                    //更新考勤
                    p.pState = "迟到";
                    EDAL.WorkDAL.AddWork(p);
                    //更新出勤天数 惩罚工资
                    EDAL.WorkDAL.UpPayDay(p);
                    double paydel = Math.Round((now - DateTime.Parse("8:00")).TotalHours,2) * mm.hourDel;
                    EDAL.WorkDAL.UpPayDel(uid, paydel);
                    //添加惩罚记录
                    EDAL.WorkDAL.AddLate(uid, paydel);
                    msg = "签到成功，因迟到被处罚" + paydel + "元";
                    return true;
                }

            }
            else if (now >= DateTime.Parse("12:00") && now < DateTime.Parse("18:00"))
            {
                //查询今日出勤记录 有早退  无 缺勤
                if (EDAL.WorkDAL.IsHere(uid) == 0)
                {
                    //迟到
                    if (EDAL.WorkDAL.IsHere(uid) == 1)
                    {
                        msg = "您已签到，请勿重复签到！";
                        return false;
                    }
                    else
                    {
                        //无  早上迟到
                        //更新考勤
                        p.pState = "迟到";
                        EDAL.WorkDAL.AddWork(p);
                        //更新 惩罚工资1天工资 惩罚时工资*12
                        double paydel = mm.hourDel * Math.Round((now - DateTime.Parse("8:00")).TotalHours, 2);
                        EDAL.WorkDAL.UpPayDay(p);
                        EDAL.WorkDAL.UpPayDel(uid, paydel);
                        //添加惩罚记录
                        EDAL.WorkDAL.AddLate(uid, paydel);
                        msg = "签到成功，因迟到被处罚" + paydel + "元";
                        return true;
                    }

                }
                else
                {
                    if (EDAL.WorkDAL.IsHere(uid) == 2)
                    {
                        msg = "您已签到，请勿重复签到！";
                        return false;
                    }
                    else
                    {
                        //下午早退
                        //更新考勤
                        p.pState = "早退";
                        EDAL.WorkDAL.AddWork(p);
                        //更新 惩罚工资
                        double paydel = mm.hourDel * Math.Round((DateTime.Parse("18:00")-now).TotalHours, 2);
                        EDAL.WorkDAL.UpPayDel(uid, paydel);
                        //添加惩罚记录
                        EDAL.WorkDAL.AddEarly(uid, paydel);
                        msg = "签到成功，因早退被处罚" + paydel + "元";
                        return true;
                    }
                }
            }
            else if (now >= DateTime.Parse("18:00") && now <= DateTime.Parse("19:00"))
            {
                if (EDAL.WorkDAL.IsHere(uid) == 0)
                {
                    msg = "今日您不可签到，做缺勤处理！";
                    return false;
                }
                else if (EDAL.WorkDAL.IsHere(uid) == 2)
                {
                    msg = "您已签到，请勿重复签到！";
                    return false;
                }
                else
                {
                    //下班打卡成功
                    //更新考勤
                    p.pState = "成功";
                    EDAL.WorkDAL.AddWork(p);
                    msg = "恭喜您，下班签到成功！";
                    return true;
                }
            }
            else if (now > DateTime.Parse("19:00") && now <= DateTime.Parse("23:59"))
            {
                if (EDAL.WorkDAL.IsHere(uid) == 0)
                {
                    msg = "今日您不可签到，做缺勤处理！";
                    return false;
                }
                else if (EDAL.WorkDAL.IsHere(uid) == 2)
                {
                    msg = "您已签到，请勿重复签到！";
                    return false;
                }
                else
                {
                    //晚上加班
                    //更新考勤
                    p.pState = "成功";
                    EDAL.WorkDAL.AddWork(p);
                    //更新 奖励工资
                    double payadd = mm.houeAdd * Math.Round((DateTime.Parse("24:00")-now).TotalHours, 2);
                    EDAL.WorkDAL.UpPayAdd(uid, payadd);
                    //添加奖励记录
                    EDAL.WorkDAL.AddGood(uid, payadd);
                    msg = "签到成功，因加班工资增加" + payadd + "元";
                    return true;
                }

            }
            else if (now > DateTime.Parse("23:59") && now < DateTime.Parse("5:59"))
            {
                msg = "不在打卡时间！";
                return false;
            }
            else
            {
                msg = "不在打卡时间！";
                return false;
            }
          

        }


        /// <summary>
        /// 读取工资设定
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static MoneyModel OpenSet()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\Config\Model.XML", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            MoneyModel mm = (MoneyModel)bf.Deserialize(fs);
            fs.Close();
            return mm;
        }

        /// <summary>
        /// 加载请假记录
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable LoadLeave(Entity.Person p)
        {
            return EDAL.WorkDAL.LoadLeave(p);
        }

        /// <summary>
        /// 提交请假申请
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool SubLeave(Entity.Leave l,out string msg)
        {

            TimeSpan ts1 = l.lStart.AddMinutes(5) - System.DateTime.Now;
            double i1 = ts1.Seconds;
            TimeSpan ts2 = l.lStop.AddMinutes(5) - l.lStart;
            double i2 = ts2.Seconds;

            if (i1 <= 0)
            {
                msg="假期开始时间不可早于当前时间！";
                return false;
            }

            else if (i2 <= 0)
            {
                msg="假期结束时间不可早于开始时间！";
                return false;
            }

            else if (EDAL.WorkDAL.SubLeave(l) > 0)
            {
                msg = "您的请假申请已提交，请耐心等待答复！";
                return true;
            }
            else
            {
                msg = "抱歉,申请提交失败！";
                return false;
            }
        }


        /// 报到
        /// </summary>
        /// <returns></returns>
        public static bool UpLState(Entity.Leave l)
        {
            if (EDAL.WorkDAL.UpLState(l) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 更新信息状态
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static void UpState(Entity.Leave l)
        {
            EDAL.WorkDAL.UpPState(l);

        }


    }
}
