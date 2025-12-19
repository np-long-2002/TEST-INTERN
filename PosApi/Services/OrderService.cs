using PosApi.Models;
using PosApi.Repositories;
using Microsoft.AspNetCore.SignalR;
using PosApi.Hubs;

namespace PosApi.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _repository;
    private readonly IHubContext<OrderHub> _hub;

    public OrderService(IOrderRepository repository, IHubContext<OrderHub> hub)
    {
        _repository = repository;
        _hub = hub;
    }

    public async Task<Order> CreateAsync(Order order)
    {
        var created = _repository.Create(order);

        await _hub.Clients.All.SendAsync("OrderCreated", created);

        return created;
    }


    public List<Order> GetAll()
    {
        return _repository.GetAll();
    }
}
