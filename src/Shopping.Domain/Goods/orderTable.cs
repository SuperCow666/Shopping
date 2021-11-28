using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shopping.Goods
{
    public class orderTable : AuditedAggregateRoot<int>
    {
        public string orderInfoId { get; set; } //雪花Id
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
        public int orderInfoState { get; set; } = 0; //订单状态（已下单（未支付）0 ，待发货（已支付）10，已发货（待收货）20，已完成（已确认）30，订单取消（订单关闭）40）
        public string orderInfoWaybillNum { get; set; } //运单号
    }
}
