namespace Catalog.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; } = default!;
    public string? Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }

    private Product() { } // for EF
    public Product(string name, decimal price, int stock, string? description = null)
    {
        Update(name, price, stock, description);
    }

    public void Update(string name, decimal price, int stock, string? description = null)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name is required");
        if (price < 0) throw new ArgumentException("Price cannot be negative");
        if (stock < 0) throw new ArgumentException("Stock cannot be negative");

        Name = name.Trim();
        Price = price;
        Stock = stock;
        Description = description?.Trim();
    }

    public void IncreaseStock(int amount) => Stock += amount;
    public void DecreaseStock(int amount)
    {
        if (amount < 0) throw new ArgumentException("amount must be positive");
        if (Stock - amount < 0) throw new InvalidOperationException("Insufficient stock");
        Stock -= amount;
    }
}
