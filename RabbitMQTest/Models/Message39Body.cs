using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class AHPhaGrcSea
{
    [JsonProperty("CPhaCot")] public string CPhaCot { get; set; }

    [JsonProperty("DHDebPhaGrcSea")] public string DHDebPhaGrcSea { get; set; }

    [JsonProperty("CPhaAutoGrcAprOv")] public string CPhaAutoGrcAprOv { get; set; }
}

public class Message39Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("DSeaBsEven")] public string DSeaBsEven { get; set; }

    [JsonProperty("CIdGrc")] public string CIdGrc { get; set; }

    [JsonProperty("AHPhaGrcSea")] public List<AHPhaGrcSea> AHPhaGrcSea { get; set; }
}