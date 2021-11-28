using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DTO
{
  public  class CreateKeyValueDTO
    {
        public string KId { get; set; }
        public string VId { get; set; }
        public int TypeId { get; set; }//商品类别外键
        public string attribute_name { get; set; }//规格Key值名字
        public int attributr_id { get; set; }//Key值表外键
        public string attribute_Value { get; set; }//属性value表名字
    }
}
