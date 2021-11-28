using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Shopping.Order
{
    public class OrderInfoListDto :PagedAndSortedResultRequestDto
    {
        public string orderInfoWaybillNum { get; set; } //运单号
        public int orderInfoState { get; set; } = -1; //订单状态


    }
}
