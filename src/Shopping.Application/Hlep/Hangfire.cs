using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Extensions.Hosting;
using Shopping.Goods;
using Shopping.Sku;
using Volo.Abp.Domain.Repositories;

namespace Shopping
{
  public  class Hangfire:BackgroundService
    {
        private readonly IRepository<orderTable, int> _orderTables;
        private readonly IRepository<OrderAttached, int> OrderAttacheds;
        private readonly IRepository<tbCommodityInfo, int> _tbCommodityInfo;
        public Hangfire(IRepository<orderTable, int> orderTables, IRepository<OrderAttached, int> _OrderAttacheds)
        {
            _orderTables = orderTables;
            OrderAttacheds = _OrderAttacheds;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            RecurringJob.AddOrUpdate(() => Hangfirejob(),Cron.Hourly());
            return Task.CompletedTask;
        }
        public async Task Hangfirejob()
        { var lists = _orderTables.Where(x => x.orderInfoTime.AddHours(24) > DateTime.Now);
            var list = await _orderTables.GetListAsync();
            var comm = await OrderAttacheds.GetListAsync();
          

         
            foreach (var item in comm)
            {
                var commodity = _tbCommodityInfo.Where(s => s.Id.ToString().Equals(item.orderInfoId)).FirstOrDefault();//通过订单表中的商品Id查询出该商品的信息
                commodity.CommodityNum = commodity.CommodityNum + item.productSum;//将数量加上购买数量
                await _tbCommodityInfo.UpdateAsync(commodity);//保存数据库
            
            };
           
        }

    }
}
