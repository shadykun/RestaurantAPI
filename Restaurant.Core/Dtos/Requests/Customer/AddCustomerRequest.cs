using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Dtos.Requests.Customer
{
    public class AddCustomerRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
