using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.DataAccess.Repositories;

namespace SistemasVentas.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<ICustomerService, CustomerService>();

        return services;
    }
}