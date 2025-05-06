using Restaurant.Core.Dtos.Common.Customer;

namespace Restaurant.Core.Dtos.Responses.Customer
{
    public class GetCustomersResponse
    {
        public List<CustomerDto> Customers { get; set; } = new List<CustomerDto>();
    }
}
