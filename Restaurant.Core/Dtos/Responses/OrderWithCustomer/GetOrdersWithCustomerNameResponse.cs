using Restaurant.Core.Dtos.Common.OrderWithCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Dtos.Responses.OrderWithCustomer
{
    public class GetOrdersWithCustomerNameResponse
    {
        public List<OrderWithCustomerNameDto> OrdersWithCustomerName { get; set; } = new List<OrderWithCustomerNameDto>();
    }
}
