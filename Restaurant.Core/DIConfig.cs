using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core
{
    public static class DIConfig
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<CustomersService>();
            services.AddScoped<OrdersService>();
            services.AddScoped<OrdersWithCustomerNameService>();
            services.AddSingleton<SingletonService>();

            return services;
        }
    }
}