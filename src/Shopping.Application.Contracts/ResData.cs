using System;
using System.Collections.Generic;
using System.Text;

using Shopping.Eumes;

namespace Shopping
{
 public   class ResData<T>
    {
        public ResStatus Status { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T Info { get; set; }

        public static ResData<T> Error(T t,Exception ex,ResStatus resStatus = ResStatus.修改失败)
        {
            return new ResData<T>() { Info = t, Msg = ex.Message, Status = resStatus };
        }

    }
}
