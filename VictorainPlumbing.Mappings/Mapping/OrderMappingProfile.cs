using AutoMapper;
using VictorainPlumbing.Domain;
using VictorianPlumbingTest.Dto;

namespace VictorainPlumbing.Mappings
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderDto>()
                .ReverseMap();


            CreateMap<OrderDto, Order>()
                .ForMember(x => x.Products, opt => opt.Ignore())
                .ForMember(x => x.ProductOrders, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}