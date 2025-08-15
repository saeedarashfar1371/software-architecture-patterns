using OnlineStore.Domain.Entities;

namespace OnlineStore.Domain.Interfaces;

public interface IOrderRepository
{
    Task<Order> GetByIdAsync(Guid id);
    Task<List<Order>> GetByCustomerIdAsync(Guid customerId);
    Task AddAsync(Order order);
    Task UpdateAsync(Order order);
    Task DeleteAsync(Order order);
    IUnitOfWork UnitOfWork { get; }
}
