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
        public int TypeId { get; set; }//Key值表外键
        public string attribute_name { get; set; }//属性value表名
    }
}
