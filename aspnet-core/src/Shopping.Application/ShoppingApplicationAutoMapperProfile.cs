using AutoMapper;
using Shopping.DTO;

namespace Shopping
{
    public class ShoppingApplicationAutoMapperProfile : Profile
    {
        public ShoppingApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<GoodsType, GoodsTypeDTO>()
               .ForMember(s => s.systematicName, d => d.MapFrom(i => i.systematicName + "是我的名字"))
               .ForMember(s => s.sort, d => d.MapFrom(i => i.sort + 1));
            CreateMap<GoodsDTO, GoodsType>();
        }
    }
}
