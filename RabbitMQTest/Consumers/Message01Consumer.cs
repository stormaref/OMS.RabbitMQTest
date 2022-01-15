using MassTransit;
using RabbitMQTest.Models;
using RabbitMQTest.Tools;

namespace RabbitMQTest.Consumers;

public class Message01Consumer : IConsumer<Message01>
{
    public Task Consume(ConsumeContext<Message01> context)
    {
        var message = context.Message;
        var d = message.Message.PTran.ConvertToDouble();
        var a = message.RLCDiffHeader.GetDateTime();
        // var d = StaticTools.ConvertToDouble(message.Message.PTran);
        return Task.CompletedTask;
    }
}