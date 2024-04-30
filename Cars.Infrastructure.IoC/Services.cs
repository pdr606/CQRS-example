using Cars.Infrastructure.Data;
using cqrs.example.application.Input.Commands.CarContext;
using cqrs.example.application.Input.Handlers.CarContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cars.Infrastructure.IoC
{
    public static class Services
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<InsertCarHandler>();
            services.AddTransient<InsertCarCommand>();

            return 
                services;
        }
    }
}
