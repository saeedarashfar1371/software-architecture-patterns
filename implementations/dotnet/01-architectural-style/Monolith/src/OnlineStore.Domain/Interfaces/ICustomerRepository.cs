using OnlineStore.Domain.Entities;

namespace OnlineStore.Domain.Interfaces;

public interface ICustomerRepository
{
    Task<Customer> GetByIdAsync(Guid id);
    Task<List<Customer>> GetAllAsync();
    Task AddAsync(Customer customer);
    Task UpdateAsync(Customer customer);
    Task DeleteAsync(Customer customer);
    IUnitOfWork UnitOfWork { get; }
}
