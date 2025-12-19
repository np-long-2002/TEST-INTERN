using PosApi.Models;

namespace PosApi.Repositories;

public interface IProductRepository
{
    List<Product> GetAll();
}
