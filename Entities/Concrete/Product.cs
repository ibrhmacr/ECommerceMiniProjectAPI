using Core.Entities.Abstract;

namespace Entities.Concrete;

public class Product : IEntity
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int CategoryId { get; set; }

    public string ProductName { get; set; }

    public int UnitsInStock { get; set; }

    public decimal Price { get; set; }

    public string Description { get; set; }
}