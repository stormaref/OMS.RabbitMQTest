namespace RabbitMQTest.Models.Entities;

public class BaseEntity
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime ReceiptDateTime { get; set; }
}