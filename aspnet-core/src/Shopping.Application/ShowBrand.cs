using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping.DTO;
using Shopping.Goods;
using Shopping.GoodsApp;
using Volo.Abp.Domain.Repositories;

namespace Shopping
{
    public class ShowBrand : Volo.Abp.Application.Services.ApplicationService, IShowBrand
    {
        private readonly IRepository<brand, int> _todoItemRepository;

        public  ShowBrand(IRepository<brand, int> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }
        [HttpGet,Route("SelectAnsyn")]
        public async Task<List<ShowBrandDTO>> SelectAnsyn()
        {
            var lst = await _todoItemRepository.ToListAsync();
          return  ObjectMapper.Map<List<brand>, List<ShowBrandDTO>>(lst);
        }
    }
}
