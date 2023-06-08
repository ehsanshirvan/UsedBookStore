using Catalog.API.Data;
using Catalog.API.Entities;
using MongoDB.Driver;
using System.Xml.Linq;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogueContext _context;

        public ProductRepository(ICatalogueContext context)
        {
            _context = context;
        }
        public async Task CreateProduct(Product product)
        {
            if(product == null) { throw new Exception("Null value cannot be inserted"); }
            await _context.Products.InsertOneAsync(product);
        }

        public async Task<bool> DeleteProductAsync(string productId)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(x => x.Id, productId);
            var res = await _context.Products.DeleteOneAsync(filter);
            return res.IsAcknowledged && res.DeletedCount > 0;
        }

        public async Task<Product> GetProductByIdAsync(string id)
        {
            var res =  await _context.Products.FindAsync(x=>x.Id == id);
            return  res.FirstOrDefault();
        }

        public async Task<IEnumerable<Product>> GetProductByNameAsync(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.ElemMatch(x => x.Name, name);
            var res = await _context.Products.FindAsync(filter);
            return res.ToList();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.FindAsync(x => true).Result.ToListAsync();

        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryName(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.ElemMatch(x => x.Category, name);            
            var res = await _context.Products.FindAsync(filter);
            return res.ToList();

        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            var tmp = await _context.Products.ReplaceOneAsync(filter:x=>x.Id == product.Id,replacement:product);
            return tmp.IsAcknowledged && tmp.ModifiedCount > 0;
        }
    }
}
