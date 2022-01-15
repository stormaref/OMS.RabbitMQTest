using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class Amount
{
    [JsonProperty("IFt")] public string IFt { get; set; }

    [JsonProperty("QMt")] public string QMt { get; set; }
}