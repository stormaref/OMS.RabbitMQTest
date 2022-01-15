using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class Message5FBody
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("CSecVal")] public string CSecVal { get; set; }

    [JsonProperty("LSecVal")] public string LSecVal { get; set; }

    [JsonProperty("CSuperSecVal")] public string CSuperSecVal { get; set; }

    [JsonProperty("CSecValICB")] public string CSecValICB { get; set; }

    [JsonProperty("Filler")] public string Filler { get; set; }
}