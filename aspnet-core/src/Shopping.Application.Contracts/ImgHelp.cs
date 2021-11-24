using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Shopping
{
  public  interface ImgHelp
    {
        /// <returns></returns>
        string ImgHelper(IFormFile file);

       
    }
}
