using Tickify.Database.Dtos;

namespace Restaurant.Database.Dtos
{
    public class OrdersFilteringDto
    {
        public string SearchValue { get; set; }
        public DateRangeDto DateRange { get; set; }
        public int Skip { get; set; } = 0;
        public int Take { get; set; } = 15;
    }
}
