using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping.DTO;
using Shopping.Eumes;
using Shopping.Goods;
using Shopping.GoodsApp;
using Volo.Abp.Domain.Repositories;

namespace Shopping
{
    [Authorize]
    public class TodoAppService : Volo.Abp.Application.Services.ApplicationService, ITodoAppService
    {
        private readonly IRepository<GoodsKind, int> _todoItemRepository;
        public TodoAppService(IRepository<GoodsKind, int> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        /// <summary>
        ///  添加方法
        /// </summary>
        /// <param name="CreatedgoodsDTO"></param>
        /// <returns></returns>]
        [HttpPost,Route("CreateAsync")]
        public async Task<Eume> CreateAsync(GoodsDTO goodsDTO)
        {
            var info = await _todoItemRepository.InsertAsync(ObjectMapper.Map<GoodsDTO, GoodsKind>(goodsDTO));
            return Eume.success;

        }
        /// <summary>
        /// 删除方法
        /// </summary>
        /// <param name="DeleteAsync"></param>
        /// <returns></returns>
        [HttpDelete, Route("DeleteAsync")]
        public async Task DeleteAsync(int id)
        {
            await _todoItemRepository.DeleteAsync(id);
        }
        /// <summary>
        ///  显示
        /// </summary>
        /// <returns></returns>
       
        public async Task<List<GoodsTypeDTO>> GetListAsync(int uid)
        {
            var lst = await _todoItemRepository.ToListAsync();
             ObjectMapper.Map<List<GoodsKind>, List<GoodsTypeDTO>>(lst);
            return Fonstey(lst, uid);

        }

        public async Task<GoodsTypeDTO> GetTaskById(int id)
        {
            var fill = await _todoItemRepository.GetAsync(id);
            return ObjectMapper.Map<GoodsKind, GoodsTypeDTO>(fill);
          



        }
        private List<GoodsTypeDTO> Fonstey(List<GoodsKind> fill, int uid)
        {
            List<GoodsTypeDTO> values = new List<GoodsTypeDTO>();
            var lig = _todoItemRepository.Where(x => x.parentId == uid);
            foreach(var item in lig)
            {
                values.Add(new GoodsTypeDTO()
                { Id=item.Id,
                    parentId = item.parentId,
                    merchandiseName = item.merchandiseName,
                    isShow = item.isShow,
                    sort = item.sort,
                    picture = item.picture,
                    type = item.type,
                    CreationTime=item.CreationTime,
                    children= Fonstey(fill, item.Id)

                });
               
            } return values;
        }

        public async Task<GoodsTypeDTO> UpdategoodsClassDTO(GoodsDTO goodsDTO)
        {
           
           var info = await _todoItemRepository.UpdateAsync(ObjectMapper.Map<GoodsDTO, GoodsKind>(goodsDTO));
            return ObjectMapper.Map<GoodsKind, GoodsTypeDTO>(info);
        }
        /// <summary>
        /// IsShowDTO
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost,Route("IsShowDTO")]
        public ResStatus IsShowDTO(int id)
        {
            var info =  _todoItemRepository.Where(x => x.Id.Equals(id)).FirstOrDefault();
             info.isShow = !info.isShow;
            return ResStatus.成功;  

        }
    }
}


