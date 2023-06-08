using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(string id);
        Task<IEnumerable<Product>> GetProductByNameAsync(string name);
        Task<IEnumerable<Product>> GetProductsByCategoryName(string name);

        Task CreateProduct(Product product);
        Task<bool> DeleteProductAsync(string productId);
        Task<bool> UpdateProductAsync(Product product);
    }
}
