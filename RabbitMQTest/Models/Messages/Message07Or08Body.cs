using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class Message07Or08Body
{
    [JsonProperty("$type")] public string Type { get; set; }
}