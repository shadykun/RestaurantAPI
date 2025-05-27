using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Services;
using Restaurant.Core.Dtos.Requests.Order;

namespace Restaurant.API.Controllers
{
    [ApiController]
    [Route("orders")]

    public class OrdersController(OrdersWithCustomerNameService ordersWithCustomerNameService, OrdersService ordersService) : Controller
    {
        [HttpGet("get-orders-with-customer-name")]
        public async Task<IActionResult> GetEvents()
        {
            var result = await ordersWithCustomerNameService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost("get-filtered-orders")]
        public async Task<IActionResult> GetFilteredOrders(GetFilteredOrdersRequest payload)
        {
            var results = await ordersService.GetOrdersAsync(payload);
            return Ok(results);
        }

        [HttpPost("add-order")]
        public async Task<IActionResult> AddOrder([FromBody] AddOrderRequest payload)
        {
            await ordersService.AddOrderAsync(payload);
            return Ok("Event added successfully");
        }

        [HttpGet("get-orders")]
        public async Task<IActionResult> GetOrders()
        {
            var result = await ordersService.GetOrdersAsync(null);
            return Ok(result);
        }
    }
}
