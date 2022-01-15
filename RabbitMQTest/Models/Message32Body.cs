using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class Message32Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("PPrCJ")] public Amount PPrCJ { get; set; }

    [JsonProperty("PDrCotJ")] public Amount PDrCotJ { get; set; }

    [JsonProperty("PPhSeaCotJ")] public Amount PPhSeaCotJ { get; set; }

    [JsonProperty("PPbSeaCotJ")] public Amount PPbSeaCotJ { get; set; }

    [JsonProperty("YPOvVal")] public string YPOvVal { get; set; }

    [JsonProperty("QTitNgOvVal")] public string QTitNgOvVal { get; set; }

    [JsonProperty("ISensVarP")] public string ISensVarP { get; set; }

    [JsonProperty("Filler1")] public string Filler1 { get; set; }

    [JsonProperty("CSensVarPTranPP")] public string CSensVarPTranPP { get; set; }

    [JsonProperty("XQVarPJDrPRF")] public Amount XQVarPJDrPRF { get; set; }

    [JsonProperty("Filler2")] public string Filler2 { get; set; }
}