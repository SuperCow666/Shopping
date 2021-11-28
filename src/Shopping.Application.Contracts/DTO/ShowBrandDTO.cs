using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;

namespace Shopping.DTO
{
  public  class ShowBrandDTO :AuditedEntityDto<int>
    {
        public int brandId { get; set; }

        public string brandName { get; set; }

        public string brandLogo { get; set; }

        public string brandorderby { get; set; }

        public bool isShow { get; set; }
    }
}
