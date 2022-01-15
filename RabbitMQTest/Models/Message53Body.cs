using Newtonsoft.Json;

namespace RabbitMQTest.Models;

public class ASecEco
{
    [JsonProperty("CGdSecEco")] public string CGdSecEco { get; set; }

    [JsonProperty("CSecAtvEco")] public string CSecAtvEco { get; set; }

    [JsonProperty("CSecCompAtv")] public string CSecCompAtv { get; set; }

    [JsonProperty("Filler01")] public string Filler01 { get; set; }
}

public class AClasCo
{
    [JsonProperty("NDivCo")] public string NDivCo { get; set; }

    [JsonProperty("NRubCo")] public string NRubCo { get; set; }

    [JsonProperty("NOrdCo")] public string NOrdCo { get; set; }
}

public class ASbAniVal
{
    [JsonProperty("CResSbAniVal")] public string CResSbAniVal { get; set; }

    [JsonProperty("CSbAniVal")] public string CSbAniVal { get; set; }
}

public class AClsEcoFtseSoc
{
    [JsonProperty("CGdSecEcoFtse")] public string CGdSecEcoFtse { get; set; }

    [JsonProperty("CSecEcoFtse")] public string CSecEcoFtse { get; set; }

    [JsonProperty("CSoSecEcoFtse")] public string CSoSecEcoFtse { get; set; }
}

public class ACarValRLC
{
    [JsonProperty("LVal18")] public string LVal18 { get; set; }

    [JsonProperty("YVal")] public string YVal { get; set; }

    [JsonProperty("SVal")] public string SVal { get; set; }

    [JsonProperty("CPyEmet")] public string CPyEmet { get; set; }

    [JsonProperty("QNmVlo")] public Amount QNmVlo { get; set; }

    [JsonProperty("CDevNm")] public string CDevNm { get; set; }

    [JsonProperty("ZTitAd")] public string ZTitAd { get; set; }

    [JsonProperty("CSocCSAC")] public string CSocCSAC { get; set; }

    [JsonProperty("LSoc30")] public string LSoc30 { get; set; }

    [JsonProperty("ASecEco")] public ASecEco ASecEco { get; set; }

    [JsonProperty("CEtFnc")] public string CEtFnc { get; set; }

    [JsonProperty("IValMry")] public string IValMry { get; set; }

    [JsonProperty("CSegMarEnvLco")] public string CSegMarEnvLco { get; set; }

    [JsonProperty("XIntOblRte")] public Amount XIntOblRte { get; set; }

    [JsonProperty("YTxInt")] public string YTxInt { get; set; }

    [JsonProperty("DEmisObl")] public string DEmisObl { get; set; }

    [JsonProperty("DPrRgLivVal")] public string DPrRgLivVal { get; set; }

    [JsonProperty("DDebAm")] public string DDebAm { get; set; }

    [JsonProperty("DFinAm")] public string DFinAm { get; set; }

    [JsonProperty("DESop")] public string DESop { get; set; }

    [JsonProperty("YOPSJ")] public string YOPSJ { get; set; }

    [JsonProperty("CGdSVal")] public string CGdSVal { get; set; }

    [JsonProperty("CSicoRGAChn")] public string CSicoRGAChn { get; set; }

    [JsonProperty("CQtmJoui")] public string CQtmJoui { get; set; }

    [JsonProperty("CDevPEmis")] public string CDevPEmis { get; set; }

    [JsonProperty("PEmis")] public Amount PEmis { get; set; }

    [JsonProperty("YRbAnt")] public string YRbAnt { get; set; }

    [JsonProperty("YRbPro")] public string YRbPro { get; set; }

    [JsonProperty("IValAdSrd")] public string IValAdSrd { get; set; }

    [JsonProperty("DEchPretEmp")] public string DEchPretEmp { get; set; }

    [JsonProperty("IDtVote")] public string IDtVote { get; set; }

    [JsonProperty("IDemat")] public string IDemat { get; set; }

    [JsonProperty("ITpi")] public string ITpi { get; set; }

    [JsonProperty("ILcoVwap")] public string ILcoVwap { get; set; }

    [JsonProperty("CGrValCot")] public string CGrValCot { get; set; }

    [JsonProperty("Filler001")] public string Filler001 { get; set; }

    [JsonProperty("AClasCo")] public AClasCo AClasCo { get; set; }

    [JsonProperty("IMarche")] public string IMarche { get; set; }

    [JsonProperty("CPyCot")] public string CPyCot { get; set; }

    [JsonProperty("CDevCot")] public string CDevCot { get; set; }

    [JsonProperty("DInMar")] public string DInMar { get; set; }

    [JsonProperty("CCpmLco")] public string CCpmLco { get; set; }

    [JsonProperty("CSocEmetVal")] public string CSocEmetVal { get; set; }

    [JsonProperty("CIdxPasCotVarVal")] public string CIdxPasCotVarVal { get; set; }

    [JsonProperty("YUniExpP")] public string YUniExpP { get; set; }

    [JsonProperty("DDrCV")] public string DDrCV { get; set; }

    [JsonProperty("PDrAjSajCotV")] public Amount PDrAjSajCotV { get; set; }

    [JsonProperty("Filler002")] public string Filler002 { get; set; }

    [JsonProperty("PDrAjCotV")] public Amount PDrAjCotV { get; set; }

    [JsonProperty("QPasCotFxeVal")] public Amount QPasCotFxeVal { get; set; }

    [JsonProperty("LVal18AFC")] public string LVal18AFC { get; set; }

    [JsonProperty("YTitVal")] public string YTitVal { get; set; }

    [JsonProperty("YAdTitNg")] public string YAdTitNg { get; set; }

    [JsonProperty("OCertifVAL")] public string OCertifVAL { get; set; }

    [JsonProperty("Filler003")] public string Filler003 { get; set; }

    [JsonProperty("QNmVal")] public Amount QNmVal { get; set; }

    [JsonProperty("CAFCValObjMsg")] public string CAFCValObjMsg { get; set; }

    [JsonProperty("CAFCValSjaWar")] public string CAFCValSjaWar { get; set; }

    [JsonProperty("IYMdvVal")] public string IYMdvVal { get; set; }

    [JsonProperty("Filler004")] public string Filler004 { get; set; }

    [JsonProperty("IApaValRlISB")] public string IApaValRlISB { get; set; }

    [JsonProperty("IApaValRlSbi")] public string IApaValRlSbi { get; set; }

    [JsonProperty("IApaValRlGrgr")] public string IApaValRlGrgr { get; set; }

    [JsonProperty("IApaValRlDn")] public string IApaValRlDn { get; set; }

    [JsonProperty("IApaValRlGar")] public string IApaValRlGar { get; set; }

    [JsonProperty("QNorCpxBlcFmp")] public Amount QNorCpxBlcFmp { get; set; }

    [JsonProperty("Filler005")] public string Filler005 { get; set; }

    [JsonProperty("SRbEmp")] public string SRbEmp { get; set; }

    [JsonProperty("QQtTranMarVal")] public string QQtTranMarVal { get; set; }

    [JsonProperty("Filler006")] public string Filler006 { get; set; }

    [JsonProperty("DPrEch")] public string DPrEch { get; set; }

    [JsonProperty("Filler007")] public string Filler007 { get; set; }

    [JsonProperty("ASbAniVal")] public ASbAniVal ASbAniVal { get; set; }

    [JsonProperty("Filler008")] public string Filler008 { get; set; }

    [JsonProperty("YApaValIdxRLC")] public string YApaValIdxRLC { get; set; }

    [JsonProperty("Filler009")] public string Filler009 { get; set; }

    [JsonProperty("CIsin")] public string CIsin { get; set; }

    [JsonProperty("CValIsinChn")] public string CValIsinChn { get; set; }

    [JsonProperty("Filler0010")] public string Filler0010 { get; set; }

    [JsonProperty("TDeDn")] public string TDeDn { get; set; }

    [JsonProperty("YTrtTitSico")] public string YTrtTitSico { get; set; }

    [JsonProperty("DAdValDep")] public string DAdValDep { get; set; }

    [JsonProperty("DRadValDep")] public string DRadValDep { get; set; }

    [JsonProperty("CFfoDepVal")] public string CFfoDepVal { get; set; }

    [JsonProperty("AClsEcoFtseSoc")] public AClsEcoFtseSoc AClsEcoFtseSoc { get; set; }

    [JsonProperty("Filler0011")] public string Filler0011 { get; set; }

    [JsonProperty("ZNorTitBlcNg")] public string ZNorTitBlcNg { get; set; }

    [JsonProperty("Filler0012")] public string Filler0012 { get; set; }

    [JsonProperty("CFlmVal")] public string CFlmVal { get; set; }

    [JsonProperty("QNmMarValVlo")] public Amount QNmMarValVlo { get; set; }

    [JsonProperty("CDevNmMarValIso3A")] public string CDevNmMarValIso3A { get; set; }

    [JsonProperty("ZTitCirObl")] public string ZTitCirObl { get; set; }

    [JsonProperty("Filler0013")] public string Filler0013 { get; set; }
}

public class CProdCpsProdYCbn
{
    [JsonProperty("Value")] public string Value { get; set; }
}

public class AKProdCpsProdYCbn
{
    [JsonProperty("CSignKMuProdCps")] public string CSignKMuProdCps { get; set; }

    [JsonProperty("KMuProdCpsProdCbn")] public string KMuProdCpsProdCbn { get; set; }
}

public class StSplitAgg
{
    [JsonProperty("QCurStSplit")] public string QCurStSplit { get; set; }

    [JsonProperty("QNewStSplit")] public string QNewStSplit { get; set; }
}

public class StDivAgg
{
    [JsonProperty("QCurStDiv")] public string QCurStDiv { get; set; }

    [JsonProperty("QAddStDiv")] public string QAddStDiv { get; set; }
}

public class Message53Body
{
    [JsonProperty("$type")] public string Type { get; set; }

    [JsonProperty("ACarValRLC")] public ACarValRLC ACarValRLC { get; set; }

    [JsonProperty("DHDebCotProdMdv")] public string DHDebCotProdMdv { get; set; }

    [JsonProperty("DHFinCotProdMdv")] public string DHFinCotProdMdv { get; set; }

    [JsonProperty("IValiOmIns")] public string IValiOmIns { get; set; }

    [JsonProperty("CProdCpsProdYCbn")] public List<CProdCpsProdYCbn> CProdCpsProdYCbn { get; set; }

    [JsonProperty("AKProdCpsProdYCbn")] public List<AKProdCpsProdYCbn> AKProdCpsProdYCbn { get; set; }

    [JsonProperty("YExpPValMdvAdf")] public string YExpPValMdvAdf { get; set; }

    [JsonProperty("YExpVarPValDrPRf")] public string YExpVarPValDrPRf { get; set; }

    [JsonProperty("QTickValMdv")] public Amount QTickValMdv { get; set; }

    [JsonProperty("PExoProdMdv")] public Amount PExoProdMdv { get; set; }

    [JsonProperty("CDevPExoProdMdv")] public string CDevPExoProdMdv { get; set; }

    [JsonProperty("QTitMinSaiOmProd")] public string QTitMinSaiOmProd { get; set; }

    [JsonProperty("QTitMaxSaiOmProd")] public string QTitMaxSaiOmProd { get; set; }

    [JsonProperty("ICaVarPJDrPRf")] public string ICaVarPJDrPRf { get; set; }

    [JsonProperty("DSeaPCompValMdv")] public string DSeaPCompValMdv { get; set; }

    [JsonProperty("YPCompValMdv")] public string YPCompValMdv { get; set; }

    [JsonProperty("PCompValMdv")] public Amount PCompValMdv { get; set; }

    [JsonProperty("PSaiSMaxOkValMdv")] public Amount PSaiSMaxOkValMdv { get; set; }

    [JsonProperty("PSaiSMinOkValMdv")] public Amount PSaiSMinOkValMdv { get; set; }

    [JsonProperty("ZMaxLimDifVal")] public string ZMaxLimDifVal { get; set; }

    [JsonProperty("YAppaValMdv")] public string YAppaValMdv { get; set; }

    [JsonProperty("YQStg")] public string YQStg { get; set; }

    [JsonProperty("PCpsDrvObl")] public Amount PCpsDrvObl { get; set; }

    [JsonProperty("XDtaStg")] public Amount XDtaStg { get; set; }

    [JsonProperty("YStg")] public string YStg { get; set; }

    [JsonProperty("YCreValMdv")] public string YCreValMdv { get; set; }

    [JsonProperty("CIdAdfCreValMdv")] public string CIdAdfCreValMdv { get; set; }

    [JsonProperty("CIdNgCreValMdv")] public string CIdNgCreValMdv { get; set; }

    [JsonProperty("CIsinProdSja")] public string CIsinProdSja { get; set; }

    [JsonProperty("YMarNSC")] public string YMarNSC { get; set; }

    [JsonProperty("YExoFamProdYOpt")] public string YExoFamProdYOpt { get; set; }

    [JsonProperty("ISupOmCrn")] public string ISupOmCrn { get; set; }

    [JsonProperty("IEtaPcsOl")] public string IEtaPcsOl { get; set; }

    [JsonProperty("CComVal")] public string CComVal { get; set; }

    [JsonProperty("CSecVal")] public string CSecVal { get; set; }

    [JsonProperty("CSoSecVal")] public string CSoSecVal { get; set; }

    [JsonProperty("YDeComp")] public string YDeComp { get; set; }

    [JsonProperty("IProdIsl")] public string IProdIsl { get; set; }

    [JsonProperty("Filler1")] public string Filler1 { get; set; }

    [JsonProperty("IVtDec")] public string IVtDec { get; set; }

    [JsonProperty("LPra")] public string LPra { get; set; }

    [JsonProperty("Filler2")] public string Filler2 { get; set; }

    [JsonProperty("Filler3")] public string Filler3 { get; set; }

    [JsonProperty("CIsinForeign")] public string CIsinForeign { get; set; }

    [JsonProperty("LocForeignIndicator")] public string LocForeignIndicator { get; set; }

    [JsonProperty("CIndustryValICB")] public string CIndustryValICB { get; set; }

    [JsonProperty("CSuperSecValICB")] public string CSuperSecValICB { get; set; }

    [JsonProperty("CSecValICB")] public string CSecValICB { get; set; }

    [JsonProperty("Filler4")] public string Filler4 { get; set; }

    [JsonProperty("StSplitAgg")] public StSplitAgg StSplitAgg { get; set; }

    [JsonProperty("StDivAgg")] public StDivAgg StDivAgg { get; set; }

    [JsonProperty("QTitMaxSaiOmBuy")] public string QTitMaxSaiOmBuy { get; set; }

    [JsonProperty("QTitMaxSaiOmSell")] public string QTitMaxSaiOmSell { get; set; }

    [JsonProperty("Filler5")] public string Filler5 { get; set; }
}