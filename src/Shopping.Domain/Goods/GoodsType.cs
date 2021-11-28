using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Shopping
{
   public class GoodsType: AuditedAggregateRoot<int>
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
        /// 分类名称
        /// </summary>
        public string systematicName { get; set; }
        /// <summary>
        ///  上级分类
        /// </summary>
        public string upSystematic { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int type { get; set; }
    }
}
