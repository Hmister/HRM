using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class FindBugBLL
    {
        public static bool SubQuestion(Entity.FindBug fb)
        {
            if (DAL.FinBugDAL.SubQuestion(fb) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
