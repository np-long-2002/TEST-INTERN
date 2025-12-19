using PosApi.Models;

namespace PosApi.Services;

public interface IOrderService
{
    Task<Order> CreateAsync(Order order);
    List<Order> GetAll();
}
