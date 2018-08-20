using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    /// <summary>
    /// 自定义异常类
    /// </summary>
    public class HrmException:ApplicationException
    {
        public HrmException(string message) : base(message)
        { }
    }
}
