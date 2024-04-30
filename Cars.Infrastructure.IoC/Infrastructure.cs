using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Cars.Infrastructure.Data;
using Cars.Application.Outuput.Repositories.CarContext;
using Cars.Infrastructure.Repositories.CarContext;

namespace Cars.Infrastructure.IoC
{
    public static class Infrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("PostgresConnection")); 
            });

            services.AddScoped<ICarRepository, CarRepository>();

            return
                services;
        }
    }
}