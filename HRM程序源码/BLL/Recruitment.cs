using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Recruitment
    {
        public static System.Data.DataTable CJobPlan()
        {
            return DAL.JobPlan.CJobPlan();
        }


        public static System.Data.DataTable CJobPlan1(Entity.Job job)
        {
            return DAL.JobPlan.CJobPlan1(job);
        }
    }
}
