using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shopping.Sku
{
   public class mmall_attribute_key: AuditedAggregateRoot<int>
    {
        public int attributr_id { get; set; }//Key值表外键
        public string attribute_Value { get; set; }//属性value表名
    }
}
