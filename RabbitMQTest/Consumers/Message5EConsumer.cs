using AutoMapper;
using MassTransit;
using RabbitMQTest.Models;
using RabbitMQTest.Models.Entities;
using RabbitMQTest.Models.Messages;

namespace RabbitMQTest.Consumers;

public class Message5EConsumer : IConsumer<Message5E>
{
    private readonly IMapper _mapper;

    public Message5EConsumer(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task Consume(ConsumeContext<Message5E> context)
    {
        var m = context.Message.Message;
        var board = _mapper.Map<Board>(context.Message);
        int a = 2;
    }
}