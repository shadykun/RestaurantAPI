using Restaurant.Database.Entities;
using Restaurant.Core.Dtos.Requests.Order;

namespace Restaurant.Core.Mapping
{
    public static class OrdersMapping
    {
        public static Order ToEntity(this AddOrderRequest payload)
        {
            var orderEntity = new Order();

            orderEntity.Meal = payload.Meal;
            orderEntity.CustomerID = payload.CustomerID;

            return orderEntity;
        }
    }
}
