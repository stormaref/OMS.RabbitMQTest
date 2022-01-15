using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class Message02Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("QTitTran")] public string QTitTran { get; set; }

    [JsonProperty("PTran")] public Amount PTran { get; set; }

    [JsonProperty("CIdAdhNSCAc")] public string CIdAdhNSCAc { get; set; }

    [JsonProperty("CIdAdhNSCVt")] public string CIdAdhNSCVt { get; set; }

    [JsonProperty("QTitNgJ")] public string QTitNgJ { get; set; }

    [JsonProperty("ISensVarP")] public string ISensVarP { get; set; }

    [JsonProperty("Filler1")] public string Filler1 { get; set; }

    [JsonProperty("YCpteOmAc")] public string YCpteOmAc { get; set; }

    [JsonProperty("YCpteOmVt")] public string YCpteOmVt { get; set; }

    [JsonProperty("PPhSeaCotJ")] public Amount PPhSeaCotJ { get; set; }

    [JsonProperty("PPbSeaCotJ")] public Amount PPbSeaCotJ { get; set; }

    [JsonProperty("IAnuTran")] public string IAnuTran { get; set; }

    [JsonProperty("Filler2")] public string Filler2 { get; set; }

    [JsonProperty("ITranYApl")] public string ITranYApl { get; set; }

    [JsonProperty("IFinTran")] public string IFinTran { get; set; }

    [JsonProperty("YOmOrgTran")] public string YOmOrgTran { get; set; }

    [JsonProperty("YOmAc")] public string YOmAc { get; set; }

    [JsonProperty("YOmVt")] public string YOmVt { get; set; }

    [JsonProperty("CSensVarPTranPP")] public string CSensVarPTranPP { get; set; }

    [JsonProperty("NTran")] public string NTran { get; set; }

    [JsonProperty("Filler3")] public string Filler3 { get; set; }

    [JsonProperty("YMarNSC")] public string YMarNSC { get; set; }

    [JsonProperty("Filler4")] public string Filler4 { get; set; }

    [JsonProperty("DHTran")] public string DHTran { get; set; }

    [JsonProperty("XQVarPJDrPRF")] public Amount XQVarPJDrPRF { get; set; }

    [JsonProperty("Filler5")] public string Filler5 { get; set; }
}