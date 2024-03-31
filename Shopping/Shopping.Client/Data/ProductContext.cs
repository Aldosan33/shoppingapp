using System.Collections.Generic;
using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
                Name = "IPhone X",
                Description = "This phone is the 10th edition of iphone models",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category  = "IPhone"
            },
            new Product()
            {
                Name = "Samsung 10",
                Description = "This phone is the 10th edition of samsung models",
                ImageFile = "product-2.png",
                Price = 840.00M,
                Category  = "Smart Phone"
            },
        };
    }
}
