using System.Linq;

namespace NETShop.Models.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
