using PosApi.Models;

namespace PosApi.Services;

public interface IProductService
{
    List<Product> GetAll();
}
