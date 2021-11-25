using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shopping.Sku
{
    public class TbSaleNum : AuditedAggregateRoot<int>
    {
        /// <summary>
        /// 订单号ID
        /// </summary>
        public int OrderInfoId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 商品名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 价格(购买时)
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int Num { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string SmallImage { get; set; }
    }
}
