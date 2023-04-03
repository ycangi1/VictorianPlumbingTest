using AutoMapper;
using VictorainPlumbing.Domain;
using VictorianPlumbingTest.Dto;

namespace VictorainPlumbing.Mappings
{
    public class ProductOrderMappingProfile : Profile
    {
        public ProductOrderMappingProfile()
        {
            CreateMap<ProductOrder, ProductOrderDto>()
                .ReverseMap();
        }
    }
}