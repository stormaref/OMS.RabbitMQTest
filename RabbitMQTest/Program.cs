using System.Reflection;
using MassTransit;
using RabbitMQTest.Consumers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddMassTransit(x =>
{
    // x.AddConsumer<Message01Consumer>();
    // x.AddConsumer<Message5EConsumer>();
    x.AddConsumer<Message5IConsumer>();

    x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(cfg =>
    {
        cfg.Host("192.168.72.210", 5672, "/", hostConfigurator =>
        {
            hostConfigurator.Username("admin");
            hostConfigurator.Password("z");
        });

        // cfg.ReceiveEndpoint("arcRLC0001", e =>
        // {
        //     e.ClearMessageDeserializers();
        //     e.UseRawJsonSerializer();
        //     e.Consumer<Message01Consumer>();
        //     e.PrefetchCount = 1;
        // });

        // cfg.ReceiveEndpoint("arcRLC005E", e =>
        // {
        //     e.ClearMessageDeserializers();
        //     e.UseRawJsonSerializer();
        //     e.Consumer<Message5EConsumer>(provider);
        //     e.PrefetchCount = 1;
        // });

        cfg.ReceiveEndpoint("arcRLC005I", e =>
        {
            e.ClearMessageDeserializers();
            e.UseRawJsonSerializer();
            e.Consumer<Message5IConsumer>(provider);
            e.PrefetchCount = 1;
        });
    }));
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