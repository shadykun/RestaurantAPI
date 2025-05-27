using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Database.Enums;

namespace Restaurant.Database.Dtos
{
    public class OrderSortingDto
    {
        public SortingOrder Order { get; set; }
        public OrdersSortingCriteria Criterion { get; set; }
    }
}
