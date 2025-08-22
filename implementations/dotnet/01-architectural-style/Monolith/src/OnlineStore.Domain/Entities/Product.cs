namespace OnlineStore.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }

    public Product(string name, string description, decimal price, int stock)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
    }

    public void UpdateStock(int quantity)
    {
        if (quantity < 0 && Stock + quantity < 0)
            throw new InvalidOperationException("Insufficient stock.");
        Stock += quantity;
    }

    public void UpdatePrice(decimal newPrice)
    {
        if (newPrice < 0) throw new ArgumentException("Price cannot be negative.");
        Price = newPrice;
    }

    public void UpdateName(string name)
    {
        if (name is null || name.Trim().Length == 0)
            throw new InvalidOperationException("Name cannot be empty.");
        Name = name;
    }

    public void UpdateDescription(string description)
    {
        Description = description ?? string.Empty;
    }
}
