using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Database.Context;
using Restaurant.Database.Repositories;

namespace Restaurant.Database;

public static class DIConfig
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddDbContext<RestaurantDatabaseContext>();
        services.AddScoped<DbContext, RestaurantDatabaseContext>();
        services.AddScoped<OrdersRepository>();
        services.AddScoped<CustomersRepository>();

        return services;
    }
}