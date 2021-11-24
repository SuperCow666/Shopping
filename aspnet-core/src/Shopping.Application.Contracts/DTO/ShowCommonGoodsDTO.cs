using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DTO
{
  public  class ShowCommonGoodsDTO
    {
        /// <summary>
        ///  序列
        /// </summary>
        public int sequence { get; set; }
        /// <summary>
        /// 上架
        /// </summary>
        public bool putAway { get; set; }
        /// <summary>
        /// 推荐
        /// </summary>
        public bool recommend { get; set; }
        /// <summary>
        /// 热门
        /// </summary>
        public bool hot { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string img { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string goodsName { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public string ordry { get; set; }
        /// <summary>
        /// 佣金
        /// </summary>
        public string brokerage { get; set; }
        /// <summary>
        /// 销售价
        /// </summary>
        public string salesPrice { get; set; }
        /// <summary>
        /// 成本价
        /// </summary>
        public string costPice { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        public string marketPrice { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public int classify { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public int brand { get; set; }

        public DateTime updateCreated { get; set; }

        public string brandName { get; set; }

        public string merchandiseName { get; set; }
    }
}
