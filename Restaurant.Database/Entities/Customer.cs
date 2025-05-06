namespace Restaurant.Database.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; }

    public string Address { get; set; }

    // Relația one-to-many: un client are mai multe comenzi
    public ICollection<Order> Orders { get; set; }
}
