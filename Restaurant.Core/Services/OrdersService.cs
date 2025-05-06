using Restaurant.Database.Repositories;
using Restaurant.Core.Dtos.Requests.Order;
using Restaurant.Core.Mapping;
using Restaurant.Core.Dtos.Common.Order;
using Restaurant.Core.Dtos.Responses.Order;

namespace Restaurant.Core.Services
{
    public class OrdersService
    {
        private readonly OrdersRepository ordersRepository;

        public OrdersService(OrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;

            Console.WriteLine("OrdersService initialized");
        }

        public async Task AddOrderAsync(AddOrderRequest payload)
        {
            var newOrder = payload.ToEntity();
            newOrder.CreatedAt = DateTime.UtcNow;
            newOrder.OrderDate = DateTime.UtcNow;

            await ordersRepository.AddAsync(newOrder);
        }

        public async Task<GetOrdersResponse> GetOrdersAsync()
        {
            var events = await ordersRepository.GetAllAsync();

            var result = new GetOrdersResponse
            {
                Orders = events.Select(e => new OrderDto
                {
                    Id = e.Id,
                    OrderDate = e.OrderDate,
                    Meal = e.Meal
                }).ToList()
            };

            return result;
        }
    }
}
