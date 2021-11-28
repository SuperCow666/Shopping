using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Shopping.Order
{
    public class OrderInfoDto : AuditedEntityDto<int>
    {
        //public OrderInfoDto() {
        //    GetOrderAttachedDto = new List<OrderAttachedDto>();
        //}

        public DateTime orderInfoTime { get; set; } //下订单时间
        public int payWayInfoId { get; set; }   //支付方式
        public string orderInfoAddre { get; set; } //收货人地址
        public string orderInfoName { get; set; } //收货人姓名
        public string shoppAddreTel { get; set; } //收货人电话
        public decimal orderInfoSalePrice { get; set; } //订单总金额
        public string orderInfoBarCode { get; set; } //配送方式
        public decimal orderInfoPayPrice { get; set; } //实付金额
        public int orderInfoState { get; set; }  //订单状态（已下单（未支付）0 ，待发货（已支付）10，已发货（待收货）20，已完成（已确认）30，订单取消（订单关闭）40）                                                                                                                                                                                                                                                                                                                                                             
        public string orderInfoWaybillNum { get; set; } //运单号
        public List<OrderAttachedDto> GetOrderAttachedDto { get; set; }
    }
}
