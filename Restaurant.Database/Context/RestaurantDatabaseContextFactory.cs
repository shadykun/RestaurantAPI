using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Restaurant.Infrastructure.Config;
using Restaurant.Infrastructure.Config;

namespace Restaurant.Database.Context;

public class RestaurantDatabaseContextFactory : IDesignTimeDbContextFactory<RestaurantDatabaseContext>
{
    public RestaurantDatabaseContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath($"{Directory.GetCurrentDirectory()}")
            .AddJsonFile($"appsettings.Development.json");

        var configuration = builder.Build();
        AppConfig.Init(configuration);

        return new RestaurantDatabaseContext();
    }
}