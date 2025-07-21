using NexusCommerce.Domain.Entities;
using NexusCommerce.Domain.Repositories;

namespace NexusCommerce.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new(); // Dummy in-memory
        public Task<Product?> GetByIdAsync(Guid id) => Task.FromResult(_products.FirstOrDefault(p => p.Id == id));
        public Task<IEnumerable<Product>> GetAllAsync() => Task.FromResult<IEnumerable<Product>>(_products);
        public Task AddAsync(Product product) { _products.Add(product); return Task.CompletedTask; }
        public Task UpdateAsync(Product product) { /* update logic */ return Task.CompletedTask; }
        public Task DeleteAsync(Guid id) { _products.RemoveAll(p => p.Id == id); return Task.CompletedTask; }
    }
}
