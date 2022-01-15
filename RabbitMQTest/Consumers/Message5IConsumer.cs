using AutoMapper;
using MassTransit;
using RabbitMQTest.Models;
using RabbitMQTest.Models.Entities;

namespace RabbitMQTest.Consumers;

public class Message5IConsumer : IConsumer<Message5I>
{
    private readonly IMapper _mapper;

    public Message5IConsumer(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task Consume(ConsumeContext<Message5I> context)
    {
        var marketActivity = _mapper.Map<MarketActivity>(context.Message);
        int a = 2;
    }
}