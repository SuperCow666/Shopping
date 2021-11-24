using AutoMapper;
using Shopping.DTO;
using Shopping.Goods;

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
        }
    }
}
