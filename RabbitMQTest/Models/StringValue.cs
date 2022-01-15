using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class StringValue
{
    [JsonProperty("Value")] public string Value { get; set; }
}