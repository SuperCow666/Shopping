using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shopping.DTO;

namespace Shopping
{
    public interface IShowBrand:Volo.Abp.Application.Services.IApplicationService
    {
        Task<List<ShowBrandDTO>> SelectAnsyn();


       
    }
}
