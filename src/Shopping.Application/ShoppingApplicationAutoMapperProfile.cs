using AutoMapper;
using Shopping.DTO;
using Shopping.Goods;
using Shopping.Sku;

namespace Shopping
{
    public class ShoppingApplicationAutoMapperProfile : Profile
    {
        public ShoppingApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<GoodsKind, GoodsTypeDTO>();

            CreateMap<GoodsKind, CreatedGoodsDTO>();
            CreateMap<CreatedGoodsDTO, GoodsKind>();
            CreateMap<GoodsDTO, GoodsKind>();
            CreateMap<brand, ShowBrandDTO>();
            CreateMap<GoodsKind, TodoItemDto>();
            CreateMap<mmall_attribute_value, mmall_attribute_valueDTO>();
            CreateMap<mmall_attribute_valueDTO, mmall_attribute_value>();
            CreateMap<mmall_attribute_valueRequestDTO, mmall_attribute_value>();
            CreateMap<mmall_attribute_value, mmall_attribute_valueRequestDTO>();

        }
    }
}
