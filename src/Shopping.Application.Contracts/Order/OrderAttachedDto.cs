using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Order
{
    public class OrderAttachedDto
    {
        public int productId { get; set; } //产品id
        public string productName { get; set; } //产品名称
        public decimal productSPromotion { get; set; } //产品销售价
        public decimal productWeight { get; set; } //产品重量（KG)
        public int productSum { get; set; } //购买数量
        public decimal CountPrice { get; set; } //商品总价
    }
}
