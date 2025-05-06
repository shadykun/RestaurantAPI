using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Restaurant.Database.Entities;

public class Order : BaseEntity
{
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public string Meal { get; set; }

    // Foreign key
    public int CustomerID { get; set; }

    // Navigare inversă
    public Customer Customer { get; set; }
}
