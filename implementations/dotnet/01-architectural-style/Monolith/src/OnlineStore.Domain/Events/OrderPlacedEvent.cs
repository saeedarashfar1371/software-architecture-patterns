using OnlineStore.Domain.Entities;

namespace OnlineStore.Domain.Events;

public class OrderPlacedEvent
{
    public Guid OrderId { get; }
    public Guid CustomerId { get; }
    public DateTime OccurredOn { get; }

    public OrderPlacedEvent(Order order)
    {
        OrderId = order.Id;
        CustomerId = order.CustomerId;
        OccurredOn = DateTime.UtcNow;
    }
}
