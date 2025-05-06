using Restaurant.Core.Services;
using Restaurant.Core.Dtos.Common.Customer;
using Restaurant.Core.Dtos.Requests.Customer;
using Restaurant.Core.Dtos.Responses.Customer;
using Restaurant.Core.Mapping;
using Restaurant.Database.Repositories;

namespace Restaurant.Core.Services
{
    public class CustomersService
    {
        private readonly CustomersRepository customersRepository;

        public CustomersService(CustomersRepository customersRepository)
        {
            this.customersRepository = customersRepository;

            Console.WriteLine("EventsService initialized");
        }

        public async Task AddCustomerAsync(AddCustomerRequest payload)
        {
            var newEvent = payload.ToEntity();
            newEvent.CreatedAt = DateTime.UtcNow;

            await customersRepository.AddAsync(newEvent);
        }

        public async Task<GetCustomersResponse> GetEventsAsync()
        {
            var events = await customersRepository.GetAllAsync();

            var result = new GetCustomersResponse
            {
                Customers = events.Select(e => new CustomerDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    StartDate = e.CreatedAt,
                    EndDate = e.ModifiedAt,
                }).ToList()
            };

            return result;
        }
    }
}
