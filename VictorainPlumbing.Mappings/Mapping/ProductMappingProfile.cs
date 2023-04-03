using AutoMapper;
using VictorainPlumbing.Domain;
using VictorianPlumbingTest.Dto;

namespace VictorainPlumbing.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ReverseMap();

            CreateMap<ProductDto, Product>()
                .ForMember(x => x.Orders, opt => opt.Ignore())
                .ForMember(x => x.ProductOrders, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}