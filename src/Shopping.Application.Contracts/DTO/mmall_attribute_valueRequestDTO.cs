using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DTO
{
   public  class mmall_attribute_valueRequestDTO
    {
         public int attributr_id { get; set; }//Key值表外键
        public string attribute_Value { get; set; }//属性value表名字
        public string[] ItemValue { get; set; }
    }
}
