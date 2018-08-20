using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
     public class PersonDAL
    {
        //添加人员信息
        public static bool Person(Entity.Person person)
        {

            string sqlstr = "insert into Person values('" + person.pPwd + "','" + person.pState + "','" + person.pName + "','" + person.pSex + "','" + person.pEthnic + "','" + person.pAge + "','" + person.pPic + "','" + person.pPhone + "','" + person.pQQ + "','" + person.pMail + "','" + person.pInTime + "','" + person.pSubject + "','" + person.pSchool + "','" + person.pFaction + "','" + person.pMarry + "','" + person.pInteresting + "','" + person.pBirthday + "','" + person.pCardID + "','" + person.jID + "','"+System.DateTime.Now.ToString("yyyy-MM-dd")+"')";
            int i = DBHelper.GetLine(sqlstr);
            if (i > 0)
            {
                return true;
            }
            else
            {

                return false;
            }

        }



        //部门的下拉列表
        public static DataTable PersonDT()
        {
            string sqlstr1 = "select * from Department";
            DataTable dt1 = DBHelper.GetDT(sqlstr1);

            return dt1;
        }

        //删除用户
        public static bool Person2(Entity.Person person1)
        {
            string sqlstr = "update Person set PState='已辞退' where PID='" + person1.pID + "'";
            int i = DBHelper.GetLine(sqlstr);

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }


        //岗位的下拉表
        public static DataTable PersonDT1(string DepName)
        {
            string sqlstr1 = "select JName,JID from Job,Department where Job.DepID=Department.DepID and DepName='" + DepName + "'";
            DataTable dt2 = DBHelper.GetDT(sqlstr1);

            return dt2;
        }




        //查询整张表
        public static DataTable PersonDT2()
        {
            string sqlstr2 = "select PID,PName,PSex,PEthnic,PAges,PPhone,PQQ,PMail,PInTime,PSubject,PSchool,PFaction,PMarry,PInteresting,PBirthday,PCardID,JName from Person,Job where Job.JID=Person.JID and PState!='待审核' and PState!='已辞退'";

            DataTable dt3 = DBHelper.GetDT(sqlstr2);
            return dt3;
        }


        //查询单个人信息
        public static DataTable FindOnly(Entity.Person p)
        {
            string sql = "select * from Person,Job,Department where Job.JID=Person.JID and Department.DepID=Job.DepID and PID=" + p.pID + " and PState!='待审核' and PState!='已辞退'";

            DataTable dt = DBHelper.GetDT(sql);
            return dt;
        }


        //按员工状态查询
        public static DataTable PersonDT3(Entity.Person person3)
        {
            string sqlstr3 = "select PID,PName,PSex,PEthnic,PAges,PPhone,PQQ,PMail,PInTime,PSubject,PSchool,PFaction,PMarry,PInteresting,PBirthday,PCardID,JName from Person,Job where Job.JID=Person.JID and Person.PState='" + person3.pState + "' and  Person.PState !='待审核' and PState!='已辞退'";

            DataTable dt3 = DBHelper.GetDT(sqlstr3);
            return dt3;
        }

       

        //按入职时间查询
        public static DataTable PersonDT6(Entity.Person person3)
        {
            string sqlstr3 = "select PID,PName,PSex,PEthnic,PAges,PPhone,PQQ,PMail,PInTime,PSubject,PSchool,PFaction,PMarry,PInteresting,PBirthday,PCardID,JName from Person,Job where Job.JID=Person.JID and  Person.PInTime = '" + person3.pInTime + "' and  Person.PState !='待审核' and PState!='已辞退'";

            DataTable dt3 = DBHelper.GetDT(sqlstr3);
            return dt3;
        }


        //按所在岗位查询
        public static DataTable PersonDT7(Entity.Person person3)
        {
            string sqlstr3 = "select PID,PName,PSex,PEthnic,PAges,PPhone,PQQ,PMail,PInTime,PSubject,PSchool,PFaction,PMarry,PInteresting,PBirthday,PCardID,JName from Person,Job where Job.JID=Person.JID and   Person.JID='" + person3.jID + "' and  Person.PState !='待审核' and PState!='已辞退'";

            DataTable dt3 = DBHelper.GetDT(sqlstr3);
            return dt3;
        }



        //按员工姓名查询
        public static DataTable FindByName(Entity.Person p)
        {
            string sql = "select PID,PName,PSex,PEthnic,PAges,PPhone,PQQ,PMail,PInTime,PSubject,PSchool,PFaction,PMarry,PInteresting,PBirthday,PCardID,JName from Person,Job where Job.JID=Person.JID and  Person.PName Like '%" + p.pName+ "%' and  Person.PState !='待审核' and PState!='已辞退'";
            DataTable dt = DBHelper.GetDT(sql);
            return dt;
            
        }


        //按员工编号查询
        public static DataTable PersonDT9(Entity.Person person3)
        {
            string sqlstr3 = "select PID,PName,PSex,PEthnic,PAges,PPhone,PQQ,PMail,PInTime,PSubject,PSchool,PFaction,PMarry,PInteresting,PBirthday,PCardID,JName from Person,Job where Job.JID=Person.JID and  Person.PID like '%" + person3.pID + "%' and  Person.PState !='待审核' and PState!='已辞退'";

            DataTable dt3 = DBHelper.GetDT(sqlstr3);
            return dt3;
        }


        /// <summary>
        /// 更新个人信息
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool Person1(Entity.Person person)
        {

            string sqlstr = "update Person set  PState='" + person.pState + "',PName='" + person.pName + "',PSex='" + person.pSex + "',PEthnic='" + person.pEthnic + "',PAges=" + person.pAge + ",PPic='" + person.pPic + "',PPhone='" + person.pPhone + "',PQQ='" + person.pQQ + "',PMail='" + person.pMail + "',PInTime='" + person.pInTime + "',PSubject='" + person.pSubject + "',PSchool='" + person.pSchool + "',PFaction='" + person.pFaction + "',PMarry='" + person.pMarry + "',PInteresting='" + person.pInteresting + "',PBirthday='" + person.pBirthday + "',PCardID='" + person.pCardID + "' where PID="+person.pID+"";
            int i = DBHelper.GetLine(sqlstr);
            if (i > 0)
            {
                return true;
            }
            else
            {

                return false;
            }

        }
        
        /// <summary>
        /// 更新人员照片
        /// </summary>
        /// <param name="p"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int UpLogo(Entity.Person p ,string name)
        {
            string sql = "update Person set PPic='" +name+ "' where PID="+p.pID+"";
            return DBHelper.GetLine(sql);
        }

        /// <summary>
        /// 查找人员姓名与邮箱
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindMail(Entity.Person p)
        {
            string sql = "select PName, PMail from Person where JID = " + p.jID + "";
            return DBHelper.GetDT(sql);
        }



    }
}
