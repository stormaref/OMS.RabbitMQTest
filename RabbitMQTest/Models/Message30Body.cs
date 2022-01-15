using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class Message30Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("PTeoOvJ")] public Amount PTeoOvJ { get; set; }

    [JsonProperty("QXtePTeoOvj")] public string QXtePTeoOvj { get; set; }

    [JsonProperty("ISensVarP")] public string ISensVarP { get; set; }

    [JsonProperty("Filler1")] public string Filler1 { get; set; }

    [JsonProperty("CSensQNrepOv")] public string CSensQNrepOv { get; set; }

    [JsonProperty("QNrepOv")] public string QNrepOv { get; set; }

    [JsonProperty("QTitMeLimSimAc")] public string QTitMeLimSimAc { get; set; }

    [JsonProperty("PMeLimSimAcVal")] public Amount PMeLimSimAcVal { get; set; }

    [JsonProperty("PMeLimSimVtVal")] public Amount PMeLimSimVtVal { get; set; }

    [JsonProperty("QTitMeLimSimVt")] public string QTitMeLimSimVt { get; set; }

    [JsonProperty("XQVarPJDrPRF")] public Amount XQVarPJDrPRF { get; set; }

    [JsonProperty("Filler2")] public string Filler2 { get; set; }
}