using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class Message16Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("CIdGrc")] public string CIdGrc { get; set; }

    [JsonProperty("CEtaGrc")] public string CEtaGrc { get; set; }

    [JsonProperty("ZPcsNSCEmetMsgRLCGrc")] public string ZPcsNSCEmetMsgRLCGrc { get; set; }

    [JsonProperty("Filler")] public string Filler { get; set; }
}