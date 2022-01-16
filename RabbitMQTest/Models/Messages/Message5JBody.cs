using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class Message5JBody
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("PClosing")] public Amount PClosing { get; set; }

    [JsonProperty("IClose")] public string IClose { get; set; }

    [JsonProperty("YClose")] public string YClose { get; set; }

    [JsonProperty("PClosingNoAdj")] public Amount PClosingNoAdj { get; set; }

    [JsonProperty("PVWAP")] public Amount PVWAP { get; set; }

    [JsonProperty("PVWAPNoAdj")] public Amount PVWAPNoAdj { get; set; }

    [JsonProperty("PDrCotVal")] public Amount PDrCotVal { get; set; }

    [JsonProperty("PDrCotValNoAdj")] public Amount PDrCotValNoAdj { get; set; }

    [JsonProperty("ZTotTran")] public string ZTotTran { get; set; }

    [JsonProperty("QTotTran5J")] public string QTotTran5J { get; set; }

    [JsonProperty("QTotCap")] public Amount QTotCap { get; set; }

    [JsonProperty("Filler")] public string Filler { get; set; }
}