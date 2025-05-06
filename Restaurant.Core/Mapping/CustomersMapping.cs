using Restaurant.Core.Dtos.Requests.Customer;
using Restaurant.Database.Entities;

namespace Restaurant.Core.Mapping
{
    public static class CustomersMapping
    {
        public static Customer ToEntity(this AddCustomerRequest payload)
        {
            var customerEntity = new Customer();

            customerEntity.Name = payload.Name;
            customerEntity.Address = payload.Address;

            return customerEntity;
        }
    }
}
