using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shopping.DTO;

namespace Shopping.GoodsApp
{
   public interface ITodoAppService:Volo.Abp.Application.Services.IApplicationService
    {
        List<GoodsTypeDTO> GetListAsync();
        Task<Eume> CreateAsync(GoodsDTO goodsDTO);

        Task DeleteAsync(int id);

        Task<GoodsTypeDTO> UpdategoodsClassDTO(GoodsDTO goodsDTO);

        Task<GoodsTypeDTO> GetTaskById(int id);
    }
}
