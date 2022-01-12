using MassTransit;
using RabbitMQTest.Consumers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<Message01Consumer>();

    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("192.168.72.210", 5672, "/", hostConfigurator =>
        {
            hostConfigurator.Username("admin");
            hostConfigurator.Password("z");
        });

        cfg.ReceiveEndpoint("arcRLC0001", e =>
        {
            e.ClearMessageDeserializers();
            e.UseRawJsonSerializer();
            e.Consumer<Message01Consumer>();
            e.PrefetchCount = 1;
        });
    });
});

builder.Services.AddMassTransitHostedService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();