using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shopping.Order
{
  public  class CreateUpdateOrderAttached
    {
        public string productId { get; set; } //产品主键
        public int productSum { get; set; } //购买数量
        [Required]
        [Range(typeof(decimal), "0.00", "9999999.99")]
        public decimal countPrice { get; set; } //商品总价
    }
}
