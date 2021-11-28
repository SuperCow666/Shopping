using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DTO

{
  public  class mmall_attribute_keySDTO
    {
        public int TypeId { get; set; }//商品类别外键
        public string attribute_name { get; set; }//规格Key值名字
        public string[] ItemKey { get; set; }
    }
}
