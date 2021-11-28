using City_Mall.DTO;
using Shopping.Entities;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;
using Microsoft.AspNetCore.Http;
using Shopping.Sku;
using Shopping.Goods;
using Shopping.DTO;
using Shopping;
using Microsoft.EntityFrameworkCore;

namespace City_Mall.SpecificaServices
{
    public class SpecificaService : ApplicationService, ISpecificaService
    {
        private readonly IRepository<tbCommodityInfo, int> _infos;  //商品表
        private readonly IRepository<GoodsKind, int> _Todoltem;//商品父级传级
        private readonly IRepository<tbCommoditySpecifica, int> _specificas; //规格表
        private readonly IRepository<mmall_attribute_key, int> _tbCommodityKeys; //规格Key值
        private readonly IRepository<mmall_attribute_value, int> _tbCommodityValues;//规格value值

        public SpecificaService(IRepository<GoodsKind, int> Todoltems,
            IRepository<mmall_attribute_key, int> tbCommodityKeys,
            IRepository<mmall_attribute_value, int> tbCommodityValues,
            IRepository<tbCommodityInfo, int> infos,
            IRepository<tbCommoditySpecifica, int> specificas)
        {
            _tbCommodityValues = tbCommodityValues;
            _tbCommodityKeys = tbCommodityKeys;
            _Todoltem = Todoltems;
            _infos = infos;
            _specificas = specificas;
        }
        [HttpPost, Route("AddCommdityValue")]
        public async Task<int> AddCommdityValue(mmall_attribute_valueRequestDTO dto)
        {
            string en = "";//定义一个数组
            foreach (var item in dto.ItemValue) //循环
            {
                en += item.ToString() + ',';//将字符串赋值并截取(循环) 分割
                dto.attribute_Value = item;

            }
            var lst = await _tbCommodityValues.InsertAsync(ObjectMapper.Map<mmall_attribute_valueRequestDTO, mmall_attribute_value>(dto));
            return 1;
        }


        [HttpPost]  //循环添加
        public int AddCommodityKey(mmall_attribute_keySDTO dto)
        {
            List<mmall_attribute_key> list = new List<mmall_attribute_key>();
            foreach (var item in dto.ItemKey)
            {
                list.Add(new mmall_attribute_key { TypeId = dto.TypeId, attribute_name = item });
            }
            _tbCommodityKeys.InsertManyAsync(list);
            return 1;
        }



        [HttpGet]   //显示
        public async Task<List<TodoItemDto>> GetType(int id)
        {
            var list = await _Todoltem.Where(x => x.Id.ToString().Equals(id)).ToListAsync();
            return ObjectMapper.Map<List<GoodsKind>, List<TodoItemDto>>(list);
        }
        [HttpGet, Route("ShowKey")]
        public async Task<List<CreateKeyValueDTO>> ShowKey(string id)
        {
            var lst = _infos.Where(s => s.Id.Equals(id)).FirstOrDefault();
            var shows = await (from keys in _tbCommodityKeys
                               join values in _tbCommodityValues
                               on keys.Id equals values.attributr_id
                               where keys.TypeId == lst.CommdTypeTwoId
                               select new CreateKeyValueDTO
                               {
                                   attribute_name = keys.attribute_name,
                                   attribute_Value = values.attribute_Value,
                                   attributr_id = values.attributr_id,
                                   TypeId = keys.TypeId,
                                   KId = keys.Id.ToString(),
                                   VId = values.Id.ToString()
                               }).ToListAsync();
            return shows;
        }
        [HttpGet]
        public List<CreateUpdateKeyDisplay> ShowKeyInfo()
        {
            var list = (from type in _Todoltem
                        join key in _tbCommodityKeys
                        on type.Id equals key.TypeId
                        select new CreateUpdateKeyDisplay()
                        {
                            Id = key.Id.ToString(),
                            TypeId = key.TypeId,
                            CommodTypeName = type.merchandiseName,
                            attribute_name = key.attribute_name,
                            CommodTypeParentId = type.parentId.ToString(),
                        }).ToList();
            return list;
        }
        [HttpGet]
        public async Task<List<TodoItemDto>> GetttbCommodityTypeDtos(string id)
        {
            List<GoodsKind> types = await _Todoltem.ToListAsync();
            List<TodoItemDto> dtos = ObjectMapper.Map<List<GoodsKind>, List<TodoItemDto>>(types);
            dtos = dtos.Where(s => s.parentId.Equals(id)).ToList();
            return dtos;
        }

        public async Task<List<CreateUpdateProductDto>> getshow()
        {
            var info = await _infos.GetListAsync();
            return ObjectMapper.Map<List<tbCommodityInfo>, List<CreateUpdateProductDto>>(info);
        }

        [HttpGet,Route("ShowKeyinfo")]
        public List<CreateUpdateKeyDisplay> ShowKeyinfo()
        {
            var list = (from type in _Todoltem
                        join Key in _tbCommodityKeys
                        on type.type equals Key.Id
                        select new CreateUpdateKeyDisplay()
                        {
                            Id = Key.Id.ToString(),
                            TypeId = Key.TypeId,
                            CommodTypeName = type.merchandiseName,
                            attribute_name = Key.attribute_name,
                            CommodTypeParentId = type.parentId.ToString()

                        }

                      ).ToList();
            return list;
        }

        public async Task<List<mmall_attribute_valueDTO>> getvalue()
        {
            var info = await _tbCommodityValues.GetListAsync();
            return ObjectMapper.Map<List<mmall_attribute_value>, List<mmall_attribute_valueDTO>>(info);
        }
    }
}
