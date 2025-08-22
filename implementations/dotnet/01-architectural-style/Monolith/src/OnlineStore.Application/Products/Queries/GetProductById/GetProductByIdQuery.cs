using MediatR;
using OnlineStore.Domain.Entities;
namespace OnlineStore.Application.Products.Queries;

public class GetProductByIdQuery : IRequest<Product>
{
    public Guid Id { get; set; }
}

