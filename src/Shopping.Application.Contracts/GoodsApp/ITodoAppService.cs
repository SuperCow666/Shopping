using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shopping.DTO;
using Shopping.Eumes;

namespace Shopping.GoodsApp
{
   public interface ITodoAppService: Volo.Abp.Application.Services.IApplicationService
    {
       Task<List<GoodsTypeDTO>> GetListAsync(int uid);
        Task<Eume> CreateAsync(GoodsDTO goodsDTO);

        Task DeleteAsync(int id);

        Task<GoodsTypeDTO> UpdategoodsClassDTO(GoodsDTO goodsDTO);

        Task<GoodsTypeDTO> GetTaskById(int id);
        ResStatus IsShowDTO(int id);

    }

}
