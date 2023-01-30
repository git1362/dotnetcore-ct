
namespace Domain
{
    public class Product: BaseEntity<Guid>
    {
        string Name { get; set; } = default(string)!;
        decimal Price { get; set; } = default(decimal)!;
    }
}
