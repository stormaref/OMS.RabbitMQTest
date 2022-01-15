using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class Message37Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("PSGelStaMax")] public Amount PSGelStaMax { get; set; }

    [JsonProperty("PSGelStaMin")] public Amount PSGelStaMin { get; set; }

    [JsonProperty("Filler")] public string Filler { get; set; }
}