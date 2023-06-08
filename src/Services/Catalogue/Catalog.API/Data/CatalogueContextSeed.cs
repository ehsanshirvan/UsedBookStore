using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogueContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection) { 
            bool existProduct = productCollection.Find(x=>true).Any();
            if (existProduct)
            {
                productCollection.InsertManyAsync(GetProducts());
            }
        }

      

        private static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Shahname",
                    Summary = "Shahnameh is an epic poem written by Ferdowsi, recounting the mythical and historical past of Iran, including stories of legendary heroes like Rostam, spanning from the creation of the world to the Arab conquest.",
                    Description = "\r\nShahnameh is a Persian epic poem by Ferdowsi, chronicling the ancient history and heroic tales of Iran, including the legendary exploits of heroes like Rostam, across the mythical and historical eras.",
                    ImageFile = "Shahname.png",
                    Price = 200.5M,
                    Category = "Epic Literature"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Golestan",
                    Summary = "\"Golestan\" is a collection of moral stories, anecdotes, and poems that offer wisdom and ethical guidance.",
                    Description = "\"Golestan\" is a collection of poetry and prose written by Saadi,",
                    ImageFile = "Golestan.png",
                    Price = 840.00M,
                    Category = "Poetry, Prose"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Huawei Plus",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "product-3.png",
                    Price = 350.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Khosrow and Shirin",
                    Summary = "\"Khosrow and Shirin\" is an epic poem by Nezami,",
                    Description = "\"Khosrow and Shirin\" narrates the tragic love story of Khosrow, the Persian king, and Shirin, a princess, with themes of love, loyalty, and fate.",
                    ImageFile = "Khosrow and Shirinpng",
                    Price = 400.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "HTC U11+ Plus",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "product-5.png",
                    Price = 180.00M,
                    Category = "Poetry, Prose"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "Divan-e Hafez",
                    Summary = "\"Divan-e Hafez\" is a collection of poems by Hafez,",
                    Description = "\"Divan-e Hafez\" showcases the mystical and romantic poetry of Hafez, exploring themes of love, spirituality, and the pursuit of divine union.",
                    ImageFile = "Divan-e Hafez.png",
                    Price = 220.00M,
                    Category = "Poetry"
                }
            };
        }
    }
}
