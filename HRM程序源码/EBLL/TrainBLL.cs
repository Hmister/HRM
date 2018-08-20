using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBLL
{
    /// <summary>
    /// 培训
    /// </summary>
    public class TrainBLL
    {
        public static System.Data.DataTable TPNotes(Entity.Train d)
        {


            return EDAL.TrainDAL.ddd(d);
        }
        public static System.Data.DataTable DT(Entity.Train d)
        {


            return EDAL.TrainDAL.dt(d);
        }
        public static System.Data.DataTable DTT(Entity.Train d)
        {


            return EDAL.TrainDAL.dte(d);
        }

    }
}
