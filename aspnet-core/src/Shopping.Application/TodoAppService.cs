using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Shopping.DTO;
using Shopping.GoodsApp;
using Volo.Abp.Domain.Repositories;

namespace Shopping
{
    [Authorize]
    public class TodoAppService : Volo.Abp.Application.Services.ApplicationService, ITodoAppService
    {
        private readonly IRepository<GoodsType, int> _todoItemRepository;
        public TodoAppService(IRepository<GoodsType, int> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        /// <summary>
        ///  添加方法
        /// </summary>
        /// <param name="CreatedgoodsDTO"></param>
        /// <returns></returns>
        public async Task<Eume> CreateAsync(GoodsDTO goodsDTO)
        {
            var info = await _todoItemRepository.InsertAsync(ObjectMapper.Map<GoodsDTO, GoodsType>(goodsDTO));
            return Eume.success;

        }
        /// <summary>
        /// 删除方法
        /// </summary>
        /// <param name="DeleteAsync"></param>
        /// <returns></returns>
        public async Task DeleteAsync(int id)
        {
            await _todoItemRepository.DeleteAsync(id);
        }
        /// <summary>
        ///  显示
        /// </summary>
        /// <returns></returns>
       
        public List<GoodsTypeDTO> GetListAsync()
        {
            var lst = _todoItemRepository.ToList();
            return ObjectMapper.Map<List<GoodsType>, List<GoodsTypeDTO>>(lst);
        }

        public async Task<GoodsTypeDTO> GetTaskById(int id)
        {
            var fill = await _todoItemRepository.GetAsync(id);
            return ObjectMapper.Map<GoodsType, GoodsTypeDTO>(fill);



        }

        public async Task<GoodsTypeDTO> UpdategoodsClassDTO(GoodsDTO goodsDTO)
        {
            var info = await _todoItemRepository.UpdateAsync(ObjectMapper.Map<GoodsDTO, GoodsType>(goodsDTO));
            return ObjectMapper.Map<GoodsType, GoodsTypeDTO>(info);
        }
    }
}


