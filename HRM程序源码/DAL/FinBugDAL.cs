using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class FinBugDAL
    {
        /// <summary>
        /// 提交使用反馈
        /// </summary>
        /// <param name="fb"></param>
        /// <returns></returns>
        public static int SubQuestion(Entity.FindBug fb)
        {
            string sql = string.Format("insert into FindBug values('{0}',{1},'{2}','{3}')",fb.title,fb.type,fb.call,fb.text);
            return DBHelper.GetLine(sql);
        }
    }
}
