using Restaurant.Core.Dtos.Common.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Dtos.Responses.Order
{
    public class GetOrdersResponse
    {
        public List<OrderDto> Orders {  get; set; } = new List<OrderDto>();
    }
}
