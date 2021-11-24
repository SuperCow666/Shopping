using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DTO
{
  public  class ShowBrandDTO
    {
        public int brandId { get; set; }

        public string brandName { get; set; }

        public string brandLogo { get; set; }

        public string brandorderby { get; set; }

        public bool isShow { get; set; }
    }
}
