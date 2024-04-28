using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Data;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductsController
    {
        private readonly ProductContext _context;

        public ProductsController(ProductContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.Find(p => true).ToListAsync();
        }
    }
}