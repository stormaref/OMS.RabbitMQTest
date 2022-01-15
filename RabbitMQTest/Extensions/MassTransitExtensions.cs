using MassTransit;
using MassTransit.ExtensionsDependencyInjectionIntegration;

namespace RabbitMQTest.Extensions;

public static class MassTransitExtensions
{
    public static void ConfigureConsumer<TConsumer>(this IServiceCollectionBusConfigurator x,
        string queueName)
        where TConsumer : class, IConsumer
    {
        x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(cfg =>
        {
            cfg.ReceiveEndpoint(queueName, e =>
            {
                e.ClearMessageDeserializers();
                e.UseRawJsonSerializer();
                e.Consumer<TConsumer>(provider);
                e.PrefetchCount = 1;
            });
        }));
    }
}