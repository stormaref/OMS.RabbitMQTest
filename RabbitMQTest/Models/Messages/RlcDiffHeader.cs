using Newtonsoft.Json;

namespace RabbitMQTest.Models.Messages;

public class RlcDiffHeader
{
    [JsonProperty("Tech_head_Type")] public int TechHeadType { get; set; }

    [JsonProperty("ItemCode")] public int ItemCode { get; set; }

    [JsonProperty("SessionNumber")] public int SessionNumber { get; set; }

    [JsonProperty("ABSMessageNumber")] public long ABSMessageNumber { get; set; }

    [JsonProperty("MessageNumberForItemCode")]
    public long MessageNumberForItemCode { get; set; }

    [JsonProperty("BroadCastTimestamp")] public long BroadCastTimestamp { get; set; }

    [JsonProperty("TransMitterSignature")] public long TransMitterSignature { get; set; }

    [JsonProperty("InstumentCharacteristicHeaderType")]
    public string InstumentCharacteristicHeaderType { get; set; }

    [JsonProperty("MarketFeedCode")] public string MarketFeedCode { get; set; }

    [JsonProperty("MarketPlaceCode")] public string MarketPlaceCode { get; set; }

    [JsonProperty("FinancialMarketCode")] public string FinancialMarketCode { get; set; }

    [JsonProperty("CIDGrc")] public string CIDGrc { get; set; }

    [JsonProperty("InstrumentID")] public string InstrumentID { get; set; }

    [JsonProperty("CValMNE")] public string CValMNE { get; set; }

    [JsonProperty("DEven")] public string DEven { get; set; }

    [JsonProperty("HEven")] public string HEven { get; set; }

    [JsonProperty("MessageCodeType")] public string MessageCodeType { get; set; }

    [JsonProperty("SEQbyINSTandType")] public string SEQbyINSTandType { get; set; }
}