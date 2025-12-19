using PosApi.Models;

namespace PosApi.Repositories;

public class ProductRepository : IProductRepository
{
    private static readonly List<Product> _products =
    [
        new() { Id = 1, Name = "Áo thun", Price = 100000 },
        new() { Id = 2, Name = "Quần jean", Price = 200000 },
        new() { Id = 3, Name = "Giày", Price = 500000 }
    ];

    public List<Product> GetAll() => _products;
}
