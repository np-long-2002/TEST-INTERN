using PosApi.Models;

namespace PosApi.Repositories;

public interface IOrderRepository
{
    Order Create(Order order);
    List<Order> GetAll();
}
