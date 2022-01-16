using AutoMapper;
using MassTransit;
using RabbitMQTest.Models.Entities;
using RabbitMQTest.Models.Messages;

namespace RabbitMQTest.Consumers;

public class Message5JConsumer : IConsumer<Message5J>
{
    private readonly IMapper _mapper;

    public Message5JConsumer(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task Consume(ConsumeContext<Message5J> context)
    {
        var closingPrice = _mapper.Map<ClosingPrice>(context.Message);
    }
}