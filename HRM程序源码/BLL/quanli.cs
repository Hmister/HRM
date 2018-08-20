using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class quanli
    {
        public static System.Data.DataTable ADm()
        {
            return DAL.Users.ADm();
        }
        public static bool Testusers(Entity.Users users)
        {
            return DAL.Users.APlus(users);
        }
        public static bool TeDelete(Entity.Users users)
        {
            return DAL.Users.ADelete(users);
        }

        public static bool TeAdd(Entity.Users users)
        {
            return DAL.Users.ADAdd(users);
        }

        /// <summary>
        /// 更新用户头像
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool UpLogo(Entity.Users u)
        {
            if (DAL.Users.UpLogo(u) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 验证账户名称
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public static bool CheckName(Entity.Users u)
        {
            if (DAL.Users.CheckName(u) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        }
}
