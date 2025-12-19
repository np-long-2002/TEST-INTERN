using PosApi.Services;
using PosApi.Repositories;
using PosApi.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddSingleton<IOrderService, OrderService>();

builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .SetIsOriginAllowed(_ => true)
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
    });
});

var app = builder.Build();

app.Urls.Add("http://0.0.0.0:5232");

// Enable Swagger
app.UseSwagger();

app.UseSwaggerUI();

app.UseCors("AllowAll");

app.MapControllers();

app.MapHub<OrderHub>("/orderHub");

app.Run();
