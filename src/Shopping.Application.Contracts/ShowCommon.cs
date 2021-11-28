using System;
using System.Collections.Generic;
using System.Text;
using Shopping.DTO;

namespace Shopping
{
  public  interface ShowCommon
    {
        List<ShowCommonGoodsDTO> ShowAsys();

        List<ShowCommonGoodsDTO> UpAsys();

        List<ShowCommonGoodsDTO> DownAsys();
    }
}
