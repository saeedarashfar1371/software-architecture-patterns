using OnlineStore.Domain.Events;
using System.Collections.Generic;
using System.Linq;

namespace OnlineStore.Domain.Entities;

public class Order
{
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public Customer Customer { get; private set; }
    public DateTime OrderDate { get; private set; }
    private readonly List<OrderItem> _items = new();
    public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();

    private readonly List<object> _domainEvents = new();
    public IReadOnlyCollection<object> DomainEvents => _domainEvents.AsReadOnly();


    public Order(Guid customerId)
    {
        Id = Guid.NewGuid();
        CustomerId = customerId;
        OrderDate = DateTime.UtcNow;
    }

    public void AddItem(Product product, int quantity)
    {
        if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");

        var existingItem = _items.FirstOrDefault(i => i.ProductId == product.Id);
        if (existingItem != null)
        {
            existingItem.IncreaseQuantity(quantity);
        }
        else
        {
            _items.Add(new OrderItem(Id, product.Id, product.Price, quantity));
        }
        _domainEvents.Add(new OrderPlacedEvent(this));
    }

    public decimal TotalAmount() => _items.Sum(i => i.TotalPrice());
}
