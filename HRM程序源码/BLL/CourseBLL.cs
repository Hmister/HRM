using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class CourseBLL
    {
        public static bool adt(Entity.Train a)
        {
            if (DAL.CouseDAL.Adt(a) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool mod(Entity.Train a)
        {
            if (DAL.CouseDAL.Mod(a) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool del(Entity.Train a)
        {
            if (DAL.CouseDAL.Del(a) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static DataTable dt()
        {
            return DAL.CouseDAL.dt();
        }

    }
}
