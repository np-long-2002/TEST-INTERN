using PosApi.Models;
using PosApi.Repositories;

namespace PosApi.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public List<Product> GetAll()
    {
        return _repository.GetAll();
    }
}
