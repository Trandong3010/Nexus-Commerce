using NexusCommerce.Domain.Repositories;
using NexusCommerce.Domain.Entities;

namespace NexusCommerce.Application.Products.Handlers
{
    public class GetProductByIdHandler
    {
        private readonly IProductRepository _repository;
        public GetProductByIdHandler(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<Product?> Handle(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
