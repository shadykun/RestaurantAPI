using Microsoft.Extensions.Configuration;
using Restaurant.Infrastructure.Config.Models;

namespace Restaurant.Infrastructure.Config
{
    public class AppConfig
    {
        public static bool ConsoleLogQueries = true;
        public static ConnectionStringsSettings? ConnectionStrings { get; set; }

        public static void Init(IConfiguration configuration)
        {
            Configure(configuration);
        }

        private static void Configure(IConfiguration configuration)
        {
            ConnectionStrings = configuration.GetSection("ConnectionStrings").Get<ConnectionStringsSettings>();
        }
    }
}
