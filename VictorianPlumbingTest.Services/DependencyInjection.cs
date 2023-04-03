using Microsoft.Extensions.DependencyInjection;
using VictorianPlumbingTest.Services.Interfaces;

namespace VictorianPlumbingTest.Services
{

    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();

            return services;
        }
    }
}