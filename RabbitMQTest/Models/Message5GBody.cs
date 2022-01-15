using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class Message5GBody
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("CSecVal")] public string CSecVal { get; set; }

    [JsonProperty("CSoSecVal")] public string CSoSecVal { get; set; }

    [JsonProperty("LSoSecVal")] public string LSoSecVal { get; set; }

    [JsonProperty("CSecValICB")] public string CSecValICB { get; set; }

    [JsonProperty("Filler")] public string Filler { get; set; }
}