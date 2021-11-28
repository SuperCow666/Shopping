using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shopping.Goods
{
  public  class GoodSKUValues : AuditedAggregateRoot<int>
    {
        /// <summary>
        ///  
        /// </summary>
        public int specId { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public string Values { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public string sort { get; set; }
    }
}
