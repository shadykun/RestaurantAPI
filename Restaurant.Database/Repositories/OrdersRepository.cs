
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Restaurant.Database.Context;
using Restaurant.Database.Dtos;
using Restaurant.Database.Entities;
using Restaurant.Database.QueryExtensions;
namespace Restaurant.Database.Repositories
{
    public class OrdersRepository : BaseRepository<Order>
    {
        public OrdersRepository(RestaurantDatabaseContext restaurantDatabaseContext) : base(restaurantDatabaseContext)
        {
            this.restaurantDatabaseContext = restaurantDatabaseContext;
            Console.WriteLine("EventsRepository initialized");
        }

        public async Task AddAsync(Order order)
        {
            restaurantDatabaseContext.Orders.Add(order);
            await SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            var results = await restaurantDatabaseContext.Orders
                .Where(e => e.DeletedAt == null)

                .OrderBy(e => e.CustomerID)

                //.AsNoTracking()
                .ToListAsync();

            return results;
        }

        public async Task<List<Order>> GetFilteredAsync(OrdersFilteringDto filters, OrderSortingDto sortingOption)
        {
            var results = await restaurantDatabaseContext.Orders
            .Where(e => e.DeletedAt == null)
            .FilterByOrderStartDate(filters.DateRange)
            .SearchBy(filters.SearchValue)

            .SortBy(sortingOption)

            .Skip(filters.Skip)
            .Take(filters.Take)

            .AsNoTracking()
            .ToListAsync();

            return results;
        }
    }
}
