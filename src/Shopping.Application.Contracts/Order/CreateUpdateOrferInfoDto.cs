using System;
using System.Collections.Generic;
using System.Text;
using Shopping.Order;

namespace Shopping
{
    public class CreateUpdateOrferInfoDto
    {
        public DateTime orderInfoTime { get; set; } = DateTime.Now; //下订单时间
        public int payWayInfoId { get; set; }   //支付方式
        public int usersId { get; set; }  //用户Id
        public string orderInfoAddre { get; set; } //收货人地址
        public string orderInfoName { get; set; } //收货人姓名
        public string shoppAddreTel { get; set; } //收货人电话
        public decimal orderInfoSalePrice { get; set; } //订单总金额
        public decimal commodCountPrice { get; set; }//商品总金额
        public string orderInfoBarCode { get; set; } //配送方式
        public decimal orderInfoPayPrice { get; set; } //实付金额
        public decimal orderInfoActivePrice { get; set; } //运费
        public List<CreateUpdateOrderAttached> CreateUpdateOrderAttached { get; set; }
    }
}
