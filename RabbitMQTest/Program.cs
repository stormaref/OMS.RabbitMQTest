using System.Reflection;
using MassTransit;
using OMS.RabbitMQInfrastructure.Extensions;
using OMS.RabbitMQInfrastructure.Settings;
using RabbitMQTest.Consumers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var assembly = Assembly.GetExecutingAssembly();

builder.Services.AddAutoMapper(assembly);

builder.Services.ConfigureMassTransit(x =>
{
    x.AddConsumers(assembly);

    x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(cfg =>
    {
        cfg.Login(builder.Configuration.GetSetting<RabbitMQSettings>());

        // cfg.ConfigureConsumer<Message5IConsumer>(provider, "arcRLC005I", 1);
        // cfg.ConfigureConsumer<Message5EConsumer>(provider, "arcRLC005E", 1);
        cfg.ConfigureConsumer<Message5JConsumer>(provider, "arcRLC005J", 1);
        // cfg.ConfigureConsumer<Message01Consumer>(provider, "arcRLC0001", 1);
    }));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();