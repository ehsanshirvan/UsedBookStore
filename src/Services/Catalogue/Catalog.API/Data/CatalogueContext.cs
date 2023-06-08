using Catalog.API.Entities;
using MongoDB.Driver;
using System.Security.Cryptography.Xml;

namespace Catalog.API.Data
{
    public class CatalogueContext : ICatalogueContext
    {
        public CatalogueContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetValue<string>("DatabaseSettings:ConnectionString"));
            var db = client.GetDatabase(config.GetValue<string>("DatabaseSettings:DatabaseName"));

            Products = db.GetCollection<Product>(config.GetValue<string>("DatabaseSettings:CollectionName"));
            CatalogueContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
