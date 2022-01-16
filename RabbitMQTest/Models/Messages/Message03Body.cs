using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class Message03Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("PObjMsgP")] public Amount PObjMsgP { get; set; }

    [JsonProperty("PPhSeaCotJ")] public Amount PPhSeaCotJ { get; set; }

    [JsonProperty("PPbSeaCotJ")] public Amount PPbSeaCotJ { get; set; }

    [JsonProperty("YPMsgP")] public string YPMsgP { get; set; }

    [JsonProperty("ISensVarP")] public string ISensVarP { get; set; }

    [JsonProperty("Filler1")] public string Filler1 { get; set; }

    [JsonProperty("CSensVarPValPP")] public string CSensVarPValPP { get; set; }

    [JsonProperty("XQVarPJDrPRF")] public Amount XQVarPJDrPRF { get; set; }

    [JsonProperty("Filler2")] public string Filler2 { get; set; }
}