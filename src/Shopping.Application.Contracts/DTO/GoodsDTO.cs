using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DTO
{
  public  class GoodsDTO
    {
        public int parentId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string merchandiseName { get; set; }
        /// <summary>
        ///  排序
        /// </summary>
        public int sort { get; set; }
        /// <summary>
        ///  图片
        /// </summary>
        public string picture { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool isShow { get; set; }
       
       
        /// <summary>
        /// 类型
        /// </summary>
        public int type { get; set; }

       
    }
}
