using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class Amount
{
    [JsonProperty("IFt")] public string IFt { get; set; }

    [JsonProperty("QMt")] public string QMt { get; set; }
}