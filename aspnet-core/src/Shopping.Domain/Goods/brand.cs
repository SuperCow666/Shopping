using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shopping.Goods
{
   public class brand: AuditedAggregateRoot<int>
    {
        public int brandId { get; set; }

        public string brandName { get; set; }

        public string brandLogo { get; set; }

        public string brandorderby { get; set; }

        public bool isShow { get; set; }


    }
}
