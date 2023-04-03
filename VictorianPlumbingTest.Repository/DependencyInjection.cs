using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VictorianPlumbingTest.Repository.Context;

namespace VictorianPlumbingTest.Repository
{

    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<VictorianPlumbingContext>(opt => opt
                .UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB; Database=VictorianPlumbing;Trusted_Connection=True;"));
            return services;
        }
    }
}