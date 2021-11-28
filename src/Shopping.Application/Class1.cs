using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.Goods;
using Shopping.Order;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Shopping
{
  public  class SeckillAppServer:ApplicationService, ISeckillAppServer
    {
        private readonly IRepository<taseKill, Guid>taseKills1;

        public SeckillAppServer(IRepository<taseKill, Guid> taseKills)
        {
            taseKills1 = taseKills;
        }

        public async Task<int> SeckillCreate(CreateSkillDTO SeckillDto)
        {
            var Seckills = new taseKill
            {
                seckillName = SeckillDto.seckillName,
                productId = SeckillDto.productId,
                seckillSatae = SeckillDto.seckillSatae,
                seckillPrice = SeckillDto.seckillPrice,
                seckillSum = SeckillDto.seckillSum,
                seckillastrict = SeckillDto.seckillastrict,
                seckillBegin = SeckillDto.seckillBegin,
                seckillEnd = SeckillDto.seckillEnd,
                seckillWeight = SeckillDto.seckillWeight
            };
            taseKill i = await taseKills1.InsertAsync(Seckills);

            return i == null ? (int)CommunalEnum.returnstate.defeated : (int)CommunalEnum.returnstate.succeed;
        }
    }
}
