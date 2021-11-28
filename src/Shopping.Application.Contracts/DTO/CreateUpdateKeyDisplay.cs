using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DTO
{
  public  class CreateUpdateKeyDisplay
    {
        public string Id { get; set; }
        public int TypeId { get; set; }//商品类别外键
        public string attribute_name { get; set; }//规格Key值名字
        public string attributr_id { get; set; }//外键链接Key表
        public string attribute_Value { get; set; }//属性value表名字
        public string CommodTypeParentId { get; set; }//父级编号
        public string CommodTypeAlias { get; set; }//别名
        public string CommodTypeName { get; set; }//商品分类名称
        public int CommodTypeOrder { get; set; }//排序
        public bool CommodTypeDisplay { get; set; }//是否显示
        public string CommodSpeciName { get; set; }//规格名称
        public string CommodSpecTypeName { get; set; }//循环名称
        public int CommodSpeciOrder { get; set; }//排序
        public int CommProductId { get; set; }//商品外键
        public int CommodSpeciDisplay { get; set; }//是否显示
    }
}
