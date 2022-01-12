using Newtonsoft.Json;

namespace RabbitMQTest.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class RLCDiffHeader
    {
        [JsonProperty("Tech_head_Type")]
        public int TechHeadType { get; set; }

        [JsonProperty("ItemCode")]
        public int ItemCode { get; set; }

        [JsonProperty("SessionNumber")]
        public int SessionNumber { get; set; }

        [JsonProperty("ABSMessageNumber")]
        public long ABSMessageNumber { get; set; }

        [JsonProperty("MessageNumberForItemCode")]
        public int MessageNumberForItemCode { get; set; }

        [JsonProperty("BroadCastTimestamp")]
        public long BroadCastTimestamp { get; set; }

        [JsonProperty("TransMitterSignature")]
        public long TransMitterSignature { get; set; }

        [JsonProperty("InstumentCharacteristicHeaderType")]
        public string InstumentCharacteristicHeaderType { get; set; }

        [JsonProperty("MarketFeedCode")]
        public string MarketFeedCode { get; set; }

        [JsonProperty("MarketPlaceCode")]
        public string MarketPlaceCode { get; set; }

        [JsonProperty("FinancialMarketCode")]
        public string FinancialMarketCode { get; set; }

        [JsonProperty("CIDGrc")]
        public string CIDGrc { get; set; }

        [JsonProperty("InstrumentID")]
        public string InstrumentID { get; set; }

        [JsonProperty("CValMNE")]
        public string CValMNE { get; set; }

        [JsonProperty("DEven")]
        public string DEven { get; set; }

        [JsonProperty("HEven")]
        public string HEven { get; set; }

        [JsonProperty("MessageCodeType")]
        public string MessageCodeType { get; set; }

        [JsonProperty("SEQbyINSTandType")]
        public string SEQbyINSTandType { get; set; }
    }

    public class PTran
    {
        [JsonProperty("IFt")]
        public string IFt { get; set; }

        [JsonProperty("QMt")]
        public string QMt { get; set; }
    }

    public class XQVarPJDrPRF
    {
        [JsonProperty("IFt")]
        public string IFt { get; set; }

        [JsonProperty("QMt")]
        public string QMt { get; set; }
    }

    public class Message
    {
        [JsonProperty("$type")]
        public string Type { get; set; }

        [JsonProperty("QTitTran")]
        public string QTitTran { get; set; }

        [JsonProperty("PTran")]
        public PTran PTran { get; set; }

        [JsonProperty("CIdAdhNSCAc")]
        public string CIdAdhNSCAc { get; set; }

        [JsonProperty("CIdAdhNSCVt")]
        public string CIdAdhNSCVt { get; set; }

        [JsonProperty("QTitNgJ")]
        public string QTitNgJ { get; set; }

        [JsonProperty("ISensVarP")]
        public string ISensVarP { get; set; }

        [JsonProperty("Filler1")]
        public string Filler1 { get; set; }

        [JsonProperty("YCpteOmAc")]
        public string YCpteOmAc { get; set; }

        [JsonProperty("YCpteOmVt")]
        public string YCpteOmVt { get; set; }

        [JsonProperty("Filler2")]
        public string Filler2 { get; set; }

        [JsonProperty("ITranYApl")]
        public string ITranYApl { get; set; }

        [JsonProperty("IFinTran")]
        public string IFinTran { get; set; }

        [JsonProperty("YOmAc")]
        public string YOmAc { get; set; }

        [JsonProperty("YOmVt")]
        public string YOmVt { get; set; }

        [JsonProperty("CSensVarPTranPP")]
        public string CSensVarPTranPP { get; set; }

        [JsonProperty("NTran")]
        public string NTran { get; set; }

        [JsonProperty("Filler3")]
        public string Filler3 { get; set; }

        [JsonProperty("YMarNSC")]
        public string YMarNSC { get; set; }

        [JsonProperty("Filler4")]
        public string Filler4 { get; set; }

        [JsonProperty("DHTran")]
        public string DHTran { get; set; }

        [JsonProperty("YOmOrgTran")]
        public string YOmOrgTran { get; set; }

        [JsonProperty("XQVarPJDrPRF")]
        public XQVarPJDrPRF XQVarPJDrPRF { get; set; }
    }

    public class Message01
    {
        [JsonProperty("RLCDiffHeader")]
        public RLCDiffHeader RLCDiffHeader { get; set; }

        [JsonProperty("Message")]
        public Message Message { get; set; }
    }

