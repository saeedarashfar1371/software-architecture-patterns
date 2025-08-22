using MediatR;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Application.Products.Queries;

public class GetAllProductsQuery : IRequest<IList<Product>>
{
}
