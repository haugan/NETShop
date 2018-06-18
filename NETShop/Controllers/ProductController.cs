using Microsoft.AspNetCore.Mvc;
using NETShop.Models.Repositories.Interfaces;

namespace NETShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;

        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult List => View(repository.Products);
    }
}
