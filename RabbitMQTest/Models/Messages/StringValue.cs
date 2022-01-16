using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class StringValue
{
    [JsonProperty("Value")] public string Value { get; set; }
}