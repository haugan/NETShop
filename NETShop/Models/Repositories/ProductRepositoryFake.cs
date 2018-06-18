using NETShop.Models.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NETShop.Models.Repositories
{
    public class ProductRepositoryFake : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Product 1", Price = 150 },
            new Product { Name = "Product 2", Price = 90 },
            new Product { Name = "Product 3", Price = 320 }

        }.AsQueryable();
    }
}
