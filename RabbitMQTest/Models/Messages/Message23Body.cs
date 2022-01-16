using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class Message23Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("CIdGrc")] public string CIdGrc { get; set; }

    [JsonProperty("IUrg")] public string IUrg { get; set; }

    [JsonProperty("YCrl")] public string YCrl { get; set; }

    [JsonProperty("YDest")] public string YDest { get; set; }

    [JsonProperty("CIdMsg")] public string CIdMsg { get; set; }

    [JsonProperty("ZTotSeg")] public string ZTotSeg { get; set; }

    [JsonProperty("NSeqSeg")] public string NSeqSeg { get; set; }

    [JsonProperty("LTit")] public string LTit { get; set; }

    [JsonProperty("LMsg")] public string LMsg { get; set; }
}