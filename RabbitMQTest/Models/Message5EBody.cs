using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class Message5EBody
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("CComVal")] public string CComVal { get; set; }

    [JsonProperty("LBoard")] public string LBoard { get; set; }

    [JsonProperty("Filler")] public string Filler { get; set; }
}