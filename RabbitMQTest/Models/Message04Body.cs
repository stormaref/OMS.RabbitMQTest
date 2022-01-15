using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class AMeLim
{
    [JsonProperty("QTitMeDem")] public string QTitMeDem { get; set; }

    [JsonProperty("ZOrdMeDem")] public string ZOrdMeDem { get; set; }

    [JsonProperty("PMeDem")] public Amount PMeDem { get; set; }

    [JsonProperty("PMeOf")] public Amount PMeOf { get; set; }

    [JsonProperty("ZOrdMeOf")] public string ZOrdMeOf { get; set; }

    [JsonProperty("QTitMeOf")] public string QTitMeOf { get; set; }

    [JsonProperty("Filler001")] public string Filler001 { get; set; }
}

public class Message04Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("YOmOrgTran")] public string YOmOrgTran { get; set; }

    [JsonProperty("Filler")] public string Filler { get; set; }

    [JsonProperty("ITabModMeLim")] public List<StringValue> ITabModMeLim { get; set; }

    [JsonProperty("AMeLim")] public List<AMeLim> AMeLim { get; set; }
}