using Restaurant.Core.Dtos.Responses.OrderWithCustomer;
using Restaurant.Database.Context;
using Restaurant.Database.Repositories;
using Restaurant.Core.Dtos.Common.OrderWithCustomer;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Core.Services
{
    public class OrdersWithCustomerNameService
    {
        private readonly CustomersRepository customersRepository;
        private readonly OrdersRepository ordersRepository;

        public OrdersWithCustomerNameService(OrdersRepository ordersRepository, CustomersRepository customersRepository)
        {
            this.customersRepository = customersRepository;
            this.ordersRepository = ordersRepository;

            Console.WriteLine("OrdersWithCustomerNameService initialized");
        }

        public async Task<GetOrdersWithCustomerNameResponse> GetAllAsync()
        {
            var context = new RestaurantDatabaseContext();

            var results = new GetOrdersWithCustomerNameResponse
            { 
                OrdersWithCustomerName = await context.Orders
                    .Include(o => o.Customer)
                    .Select(o => new OrderWithCustomerNameDto
                    {
                        OrderID = o.Id,
                        OrderDate = o.OrderDate,
                        CustomerName = o.Customer.Name,
                    })
                    //.AsNoTracking()
                    .ToListAsync()
            };

            return results;
        }
    }
}
