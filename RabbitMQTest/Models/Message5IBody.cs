using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class Message5IBody
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("ZTotTran")] public string ZTotTran { get; set; }

    [JsonProperty("QTotCap")] public Amount QTotCap { get; set; }

    [JsonProperty("QTotTran")] public Amount QTotTran { get; set; }

    [JsonProperty("Filler")] public string Filler { get; set; }
}