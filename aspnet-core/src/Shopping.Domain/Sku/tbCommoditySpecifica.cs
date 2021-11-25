using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shopping.Sku
{
    public class tbCommoditySpecifica : AuditedAggregateRoot<int>
    {
        public string CommodSpeciName { get; set; }//规格名称
        public string CommodSpecTypeName { get; set; }//循环名称
        public int CommodSpeciOrder { get; set; }//排序
        public int CommProductId { get; set; }//商品外键
        public bool CommodSpeciDisplay { get; set; }//是否显示
    }
}
