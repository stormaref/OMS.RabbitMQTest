using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class Message05Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("IEtaCotVal")] public string IEtaCotVal { get; set; }

    [JsonProperty("IOrgResVal")] public string IOrgResVal { get; set; }

    [JsonProperty("DDebSuVal")] public string DDebSuVal { get; set; }

    [JsonProperty("HDebSuVal")] public string HDebSuVal { get; set; }

    [JsonProperty("CEtaVal")] public string CEtaVal { get; set; }

    [JsonProperty("CActModEtaVal")] public string CActModEtaVal { get; set; }

    [JsonProperty("HOvPgmVal")] public string HOvPgmVal { get; set; }

    [JsonProperty("CEtaValSysTCS")] public string CEtaValSysTCS { get; set; }

    [JsonProperty("Filler")] public string Filler { get; set; }
}