using Carter;
using NexusCommerce.Application.Products.Handlers;
using NexusCommerce.Shared.Mapping;
using AutoMapper;

namespace NexusCommerce.Api.Modules
{
    public class ProductModule : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products/{id}", async (Guid id, GetProductByIdHandler handler, IMapper mapper) =>
            {
                var product = await handler.Handle(id);
                if (product == null) return Results.NotFound();
                var dto = mapper.Map<ProductDto>(product);
                return Results.Ok(dto);
            });
        }
    }
}
