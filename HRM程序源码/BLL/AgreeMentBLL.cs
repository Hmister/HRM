using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entity;


namespace BLL
{
    public class AgreeMentBLL
    {

        //添加合同信息
        public static bool AgreeMent1(Entity.AgreeMent AgreeMent1)
        {


            return DAL.AgreeMentDAL.AgreeMent(AgreeMent1);
        }



        //查询表
        public static DataTable AgreeMent2(Entity.AgreeMent AgreeMent2)
        {

            return DAL.AgreeMentDAL.AgreeMent2(AgreeMent2);

        }


        //查询合同表名
        public static DataTable AgreeMent3(Entity.AgreeMent AgreeMent3)
        {

            return DAL.AgreeMentDAL.AgreeMent3(AgreeMent3);

        }


        //查询乙方
        public static DataTable AgreeMent4(Entity.AgreeMent AgreeMent4)
        {

            return DAL.AgreeMentDAL.AgreeMent4(AgreeMent4);

        }


        //查询合同状态
        public static DataTable AgreeMent5(Entity.AgreeMent AgreeMent5)
        {

            return DAL.AgreeMentDAL.AgreeMent5(AgreeMent5);

        }


        //修改
        public static bool AgreeMent6(Entity.AgreeMent AgreeMent6)
        {

            return DAL.AgreeMentDAL.AgreeMent6(AgreeMent6);

        }





    }
}
