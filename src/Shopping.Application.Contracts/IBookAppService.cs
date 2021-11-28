using System;
using System.Collections.Generic;
using System.Text;

using Shopping.DTO;
using Volo.Abp.Application.Services;

namespace Shopping
{
   public interface IBookAppService:ICrudAppService<GoodsTypeDTO, int>
    {

    }
}
