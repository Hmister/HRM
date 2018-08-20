using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace BLL
{
    public class PersonBLL
    {
        //添加人员信息
        public static bool Person(Entity.Person person)
        {
            return DAL.PersonDAL.Person(person);

        }


        //部门表的下拉列表
        public static DataTable PersonDT()
        {
            return DAL.PersonDAL.PersonDT();

        }


        //岗位的下拉表
        public static DataTable PersonDT1(string DepName)
        {

            return DAL.PersonDAL.PersonDT1(DepName);
        }



        //查询员工信息表
        public static DataTable PersonDT2()
        {

            return DAL.PersonDAL.PersonDT2();
        }


        //删除当前行
        public static bool Person1(Entity.Person person1)
        {


            return DAL.PersonDAL.Person2(person1);
        }

        //状态查询
        public static DataTable PersonDT3(Entity.Person person3)
        {

            return DAL.PersonDAL.PersonDT3(person3);
        }

        //入职时间按查询
        public static DataTable PersonDT5(Entity.Person person3)
        {

            return DAL.PersonDAL.PersonDT6(person3);
        }

        //岗位查询
        public static DataTable PersonDT6(Entity.Person person3)
        {

            return DAL.PersonDAL.PersonDT7(person3);
        }

        //编号查询
        public static DataTable PersonDT8(Entity.Person person3)
        {

            return DAL.PersonDAL.PersonDT9(person3);
        }

        //按姓名查询
        public static DataTable FindByName(Entity.Person p)
        {
            return DAL.PersonDAL.FindByName(p);
        }

        //查询单个人信息
        public static DataTable FindOnly(Entity.Person p)
        {

            return DAL.PersonDAL.FindOnly(p);
        }

        /// <summary>
        /// 更新人员照片
        /// </summary>
        /// <param name="p"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool UpLogo(Entity.Person p, string name)
        {
            if (DAL.PersonDAL.UpLogo(p, name) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 更新个人信息
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool UpWho(Entity.Person person)
        {
            return DAL.PersonDAL.Person1(person);
        }

        /// <summary>
        /// 查找人员姓名与邮箱
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataTable FindMail(Entity.Person p)
        {
            return DAL.PersonDAL.FindMail(p);
        }

     


    }
}