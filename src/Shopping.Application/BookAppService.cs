using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Volo.Abp.Application.Dtos;

using Volo.Abp.Uow;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;


using Shopping.Goods;
using Shopping;
using Ecommerce.Application.Caching;

using Volo.Abp.Domain.Repositories;
using Shopping.DTO;
using Volo.Abp.Application.Services;

namespace Shopping
{
    public class BookAppService : CrudAppService<GoodsKind, GoodsTypeDTO, int>, IBookAppService
    {
        public IDistributedCache Cache { get; set; }
        private readonly IRepository<GoodsKind, int> _repository;
        public BookAppService(IRepository<GoodsKind, int> repository) : base(repository)
        {
            _repository = repository;
        }

        [HttpGet("GetBookListByRedis")]
        public async Task<IEnumerable<GoodsKind>> GetBookListByRedis(int Type)
        {
            return await Cache.GetOrAddAsync("BookListByType" + Type,
                async () =>
                {
                    //TODO:后续需要加缓存降级处理
                    var query = await _repository.GetListAsync();                       
                    return query;
                },
            60
            );
        }
        [HttpGet("GetBookByRedis")]
        public async Task<GoodsTypeDTO> GetBookByRedis(int id)
        {
            return await Cache.GetOrAddAsync("tbGoods" + id, async () =>
            {
                try
                {
                    var goods = await _repository.GetAsync(id);
                    return ObjectMapper.Map<GoodsKind, GoodsTypeDTO>(goods);
                }
                catch (Exception e)
                {
                    //TODO:后续需要加缓存穿透处理
                    return new GoodsTypeDTO();
                }
            },
            24 * 60
            );

        }
    }
}