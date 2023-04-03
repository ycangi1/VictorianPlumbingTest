using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using VictorainPlumbing.Mappings;

namespace VictorianPlumbingTest.Mappings
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMapping(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new OrderMappingProfile());
                m.AddProfile(new ProductMappingProfile());
                m.AddProfile(new ProductOrderMappingProfile());
            });
            return services;
        }
    }
}