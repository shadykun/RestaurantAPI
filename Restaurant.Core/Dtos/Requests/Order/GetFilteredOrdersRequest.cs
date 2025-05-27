using Restaurant.Database.Dtos;
using Restaurant.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Dtos.Requests.Order
{
    public class GetFilteredOrdersRequest
    {
        public OrdersFilteringDto Filters { get; set; }
        public OrderSortingDto SortingOptions { get; set; }
    }
}
