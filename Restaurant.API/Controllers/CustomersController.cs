using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Dtos.Requests.Customer;
using Restaurant.Core.Services;

namespace Restaurant.Api.Controllers
{
    [ApiController]
    [Route("customers")]

    public class CustomesrsController(CustomersService customerService) : ControllerBase
    {
        [HttpPost("add-customer")]
        public async Task<IActionResult> AddCustomer([FromBody] AddCustomerRequest payload)
        {
            await customerService.AddCustomerAsync(payload);
            return Ok("Event added successfully");
        }

        [HttpGet("get-customers")]
        public async Task<IActionResult> GetEvents()
        {
            var result = await customerService.GetEventsAsync();
            return Ok(result);
        }
    }
}
