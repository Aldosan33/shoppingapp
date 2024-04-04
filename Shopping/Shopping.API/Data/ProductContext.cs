using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Shopping.API.Models;

namespace Shopping.Client.Data
{
    public class ProductContext
    {
        public IMongoCollection<Product>  Products { get; }

        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);

            Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
            SeedData();
        }

        private void SeedData()
        {
            var existProduct = Products.Find(p => true).Any();
            if (!existProduct) {
                Products.InsertManyAsync(new List<Product>
                {
                    new()
                    {
                        Name = "IPhone X",
                        Description = "This phone is the 10th edition of iphone models",
                        ImageFile = "product-1.png",
                        Price = 950.00M,
                        Category  = "IPhone"
                    },
                    new()
                    {
                        Name = "Samsung 10",
                        Description = "This phone is the 10th edition of samsung models",
                        ImageFile = "product-2.png",
                        Price = 840.00M,
                        Category  = "Smart Phone"
                    }
                });
            }
        }
    }
}
