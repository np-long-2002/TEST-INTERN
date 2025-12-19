using PosApi.Models;

namespace PosApi.Repositories;

public class OrderRepository : IOrderRepository
{
    private static readonly List<Order> _orders = [];
    private static int _id = 1;

    public Order Create(Order order)
    {
        order.Id = _id++;
        _orders.Add(order);
        return order;
    }

    public List<Order> GetAll() => _orders;
}
