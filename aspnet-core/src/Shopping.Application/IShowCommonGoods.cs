using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping.DTO;
using Shopping.Goods;
using Volo.Abp.Domain.Repositories;

namespace Shopping
{
    public class IShowCommonGoods : Volo.Abp.Application.Services.ApplicationService, ShowCommon
    {
        private readonly IRepository<commonGoods, int> _comm;
        private readonly IRepository<brand, int> _brand;
        private readonly IRepository<GoodsKind, int> _Kind;

        public IShowCommonGoods(IRepository<brand, int> brand,   IRepository<commonGoods, int> comm,IRepository<GoodsKind, int> Kind)
        {
            _comm = comm;
            _brand = brand;
            _Kind = Kind;
        }
        [HttpGet,Route("ShowAsys")]
        public List<ShowCommonGoodsDTO> ShowAsys()
        {
            var info = (from a in _comm
                        join b in _brand
                        on a.brand equals b.Id
                        join c in _Kind 
                        on a.classify equals c.Id
                        select new ShowCommonGoodsDTO
                        {
                            sequence = a.sequence,
                            brandName = b.brandName,
                            brand = b.Id,
                            classify = c.Id,
                            goodsName = a.goodsName,
                            costPice = a.costPice,
                            hot = a.hot,
                            img = a.img,
                            ordry = a.ordry,
                            marketPrice = a.marketPrice,
                            putAway = a.putAway,
                            salesPrice = a.salesPrice,
                            updateCreated = a.updateCreated,
                            brokerage = a.brokerage,
                            merchandiseName = c.merchandiseName,
                            recommend = a.recommend




                        }).ToList();
            return info;
        }
    }
}
