using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DTO
{
   public class TbSaleNumSDto
    {
        public string OrderInfoId { get; set; }//订单号ID
        public string CommodityId { get; set; }//商品id
        public string Name { get; set; }
        public int Price { get; set; }//价格(购买时)
        public int Num { get; set; }//销售数量
        public string SmallImage { get; set; }//商品图片
    }
}
