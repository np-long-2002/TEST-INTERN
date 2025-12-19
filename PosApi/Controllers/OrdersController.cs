using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PosApi.Hubs;
using PosApi.Models;
using PosApi.Services;

namespace PosApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;
    private readonly IHubContext<OrderHub> _hub;

    public OrdersController(
        IOrderService orderService,
        IHubContext<OrderHub> hub)
    {
        _orderService = orderService;
        _hub = hub;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] Order order)
    {
        var result = await _orderService.CreateAsync(order);
        return Ok(result);
    }


    [HttpGet]
    public IActionResult GetAllOrders()
    {
        return Ok(_orderService.GetAll());
    }
}
