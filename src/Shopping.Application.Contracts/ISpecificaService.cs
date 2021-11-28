using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shopping.DTO;

namespace Shopping
{
   public interface ISpecificaService
    {
        Task<List<TodoItemDto>> GetttbCommodityTypeDtos(string id); //显示商品类别
        Task<List<TodoItemDto>> GetType(int id);//通过类别Id来查询到该类别名称
        int AddCommodityKey(mmall_attribute_keySDTO dto);//添加Key
        List<CreateUpdateKeyDisplay> ShowKeyInfo();//显示Key  
        Task<int> AddCommdityValue(mmall_attribute_valueRequestDTO dto);//添加Value
        Task<List<CreateKeyValueDTO>> ShowKey(string id);

        Task<List<CreateUpdateProductDto>> getshow();

        Task<List<mmall_attribute_valueDTO>> getvalue();

        List<CreateUpdateKeyDisplay> ShowKeyinfo();
    }
}
