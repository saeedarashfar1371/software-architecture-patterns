using MediatR;
namespace OnlineStore.Application.Products.Commands.CreateProduct;

public class UpdateProductCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
