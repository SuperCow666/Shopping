using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shopping.Goods
{
   public class OrderAttached : AuditedAggregateRoot<int>
    {
        public string orderInfoId { get; set; } //订单雪花Id
        public int productId { get; set; } //产品名称
        public int productSum { get; set; } //购买数量
        public decimal CountPrice { get; set; } //商品总价
    }
}
