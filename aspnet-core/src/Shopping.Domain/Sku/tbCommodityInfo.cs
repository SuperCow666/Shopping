using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shopping.Sku
{
  public   class tbCommodityInfo:AuditedAggregateRoot<int>
    {
        public string CommodityName { get; set; }//商品名称
        public string CommoditySubtitle { get; set; }//商品副名称
        public bool shelves { get; set; }  //上架
        public bool recommended { get; set; }  //推荐
        public bool hot { get; set; } //热门
        public int Thesorting { get; set; }//排序
        public string Thesaleprice { get; set; }//销售价
        public string Thecostprice { get; set; }//成本价
        public string Themarketprice { get; set; }//市场价
        public int CommodityDisplay { get; set; }//是否显示

        public DateTime CommoditySaleBegin { get; set; }//销售开始时间
        public decimal CommoditySalePrice { get; set; }//销售价格(原价)
        public decimal CommodiSPromotion { get; set; }//促销价格(商城价)
        public string CommodityDetails { get; set; }//商品详情(富文本)
        public int CommodityNum { get; set; }//库存
        public int CommodityWeight { get; set; }//重量(KG)
        public int CommodityFreight { get; set; }//是否包邮
        public string CommodityBarCode { get; set; }//商品条形码
        public string CommodityDescription { get; set; }//商品详情描述
        public int CommodityState { get; set; }//上架状态
        public int CommodityBorwseNum { get; set; }//浏览量
        public int CommoditySaleNum { get; set; }//销售量
        public int CommodityEvaluaNum { get; set; }//评价数
        public string CommodityAttrName { get; set; }//商品属性
        public string CommodSpeciId { get; set; }//商品规格
        public int CommodTypeId { get; set; }//商品一级Id
        public int CommdTypeTwoId { get; set; }//商品二级Id
        public string ImgId { get; set; }//图片
        public int Ordere { get; set; } //品牌
        public int Todolteme { get; set; } //分类
    }
}
