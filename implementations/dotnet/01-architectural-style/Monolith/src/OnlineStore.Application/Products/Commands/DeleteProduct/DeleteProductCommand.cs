using MediatR;
namespace OnlineStore.Application.Products.Commands;

public class DeleteProductCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
}
