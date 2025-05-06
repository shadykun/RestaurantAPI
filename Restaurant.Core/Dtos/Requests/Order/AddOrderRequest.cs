using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Dtos.Requests.Order
{
    public class AddOrderRequest
    {
        public string Meal { get; set; }

        public int CustomerID { get; set; }
    }
}
