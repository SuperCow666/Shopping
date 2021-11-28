using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DTO
{
   public class SpecificaSDTO
    {
        public string CommodSpeciName { get; set; }//规格名称
        public string CommodSpecTypeName { get; set; }//循环名称
        public int CommodSpeciOrder { get; set; }//排序
        public string CommProductId { get; set; }//商品外键
        public int CommodSpeciDisplay { get; set; }//是否显示
    }
}
