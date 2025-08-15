namespace OnlineStore.Domain.Entities;

public class OrderItem
{
    public Guid Id { get; private set; }
    public Guid ProductId { get; private set; }
    public Product Product { get; private set; }
    public Order Order { get; private set; }
    public Guid OrderId { get; private set; }
    public decimal UnitPrice { get; private set; }
    public int Quantity { get; private set; }

    public OrderItem(Guid orderId, Guid productId, decimal unitPrice, int quantity)
    {
        Id = new Guid();
        OrderId = orderId;
        ProductId = productId;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    public void IncreaseQuantity(int quantity)
    {
        if (quantity <= 0) throw new ArgumentException("Quantity must be positive.");
        Quantity += quantity;
    }

    public decimal TotalPrice() => UnitPrice * Quantity;
}
