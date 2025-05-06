using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Restaurant.Database.Context;
using Restaurant.Database.Entities;
namespace Restaurant.Database.Repositories
{
    public class CustomersRepository : BaseRepository<Order>
    {
        public CustomersRepository(RestaurantDatabaseContext restaurantDatabaseContext) : base(restaurantDatabaseContext)
        {
            this.restaurantDatabaseContext = restaurantDatabaseContext;
            Console.WriteLine("EventsRepository initialized");
        }

        public async Task AddAsync(Customer entity)
        {
            restaurantDatabaseContext.Customers.Add(entity);
            await SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            var results = await restaurantDatabaseContext.Customers
                .Where(e => e.DeletedAt == null)

                .OrderBy(e => e.Name)

                //.AsNoTracking()
                .ToListAsync();

            return results;
        }
    }
}
