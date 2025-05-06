using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Restaurant.Infrastructure.Config;
using System.Net.Sockets;
using Restaurant.Database.Entities;
using Restaurant.Infrastructure.Config;

namespace Restaurant.Database.Context;

public class RestaurantDatabaseContext : DbContext
{
    public RestaurantDatabaseContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(AppConfig.ConnectionStrings?.RestaurantDatabase);//.LogTo(Console.WriteLine);

    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}