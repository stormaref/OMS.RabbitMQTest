using AutoMapper;
using RabbitMQTest.Mapping;
using RabbitMQTest.Models.Messages;
using RabbitMQTest.Tools;

namespace RabbitMQTest.Models.Entities;

public class ClosingPrice : BaseEntity, IMapFrom<Message5J>
{
    /// <summary>
    /// PClosing
    /// </summary>
    public decimal ClosingPriceAmount { get; set; }

    /// <summary>
    /// IClose 
    /// </summary>
    public string ClosingIndicator { get; set; }

    /// <summary>
    /// YClose 
    /// </summary>
    public string ClosingRulesType { get; set; }

    /// <summary>
    /// PClosingNoAdj
    /// </summary>
    public decimal NotAdjustedClosingPrice { get; set; }

    /// <summary>
    /// PVWAP
    /// VWAP or adjusted VWAP computed by RCE
    /// volume-weighted average price
    /// </summary>
    public decimal VWAP { get; set; }

    /// <summary>
    /// PVWAPNoAdj
    /// VWAP not adjusted computed by RCE
    /// volume-weighted average price
    /// </summary>
    public decimal NotAdjustedVWAP { get; set; }

    /// <summary>
    /// PDrCotVal
    /// </summary>
    public decimal LastTradedPrice { get; set; }

    /// <summary>
    /// PDrCotValNoAdj
    /// </summary>
    public decimal NotAdjustedLastTradedPrice { get; set; }

    /// <summary>
    /// ZTotTran
    /// Total number of trades
    /// </summary>
    public long TotalTradesCount { get; set; }

    /// <summary>
    /// QTotTran5J
    /// Total number of shares traded
    /// </summary>
    public long TotalTradesVolume { get; set; }

    /// <summary>
    /// QTotCap
    /// </summary>
    public decimal TotalTradesValue { get; set; }

    // /// <summary>
    // /// XTickPdr
    // /// Percentage threshold normal trade
    // /// </summary>
    // public float TradeThresholdPercent { get; set; }
    //
    // /// <summary>
    // /// XTickPdrApl
    // /// Percentage threshold cross trade 
    // /// </summary>
    // public float CrossTradeThresholdPercent { get; set; }

    // /// <summary>
    // /// ZTitMoyEhgMS
    // /// Daily average shares traded 30 days
    // /// </summary>
    // public decimal LastMonthTradesAverageCount { get; set; }
    //
    // /// <summary>
    // /// XMaxEhgMoy
    // /// Ratio maximum shares traded normal trade
    // /// نسبت حداکثر سهام معامله شده در معاملات عادی
    // /// </summary>
    // public float MaxTradeVolumeRatio { get; set; }
    //
    // /// <summary>
    // /// XMaxEhgMoyApl
    // /// Ratio maximum shares traded cross trade
    // /// </summary>
    // public float MaxCrossTradeVolumeRatio { get; set; }
    //
    // /// <summary>
    // /// XMaxEhgAdm 
    // /// Ratio maximum shares traded normal trade / Outstanding number of shares
    // /// </summary>
    // public float MaxTradeNumberToRemainingSharesNumber { get; set; }
    //
    // /// <summary>
    // /// XMaxEhgAdmApl 
    // /// Ratio maximum shares traded cross trade / Outstanding number of share
    // /// </summary>
    // public float MaxCrossTradeNumberToRemainingSharesNumber { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Message5J, ClosingPrice>()
            .ForMember(dest =>
                    dest.ClosingPriceAmount,
                opt => opt.MapFrom(src => src.Message.PClosing.ConvertToDecimal()))
            .ForMember(dest =>
                    dest.ClosingIndicator,
                opt => opt.MapFrom(src => src.Message.IClose))
            .ForMember(dest =>
                    dest.ClosingRulesType,
                opt => opt.MapFrom(src => src.Message.YClose))
            .ForMember(dest =>
                    dest.ReceiptDateTime,
                opt => opt.MapFrom(src => src.RLCDiffHeader.GetDateTime()))
            .ForMember(dest =>
                    dest.NotAdjustedClosingPrice,
                opt => opt.MapFrom(src =>
                    src.Message.PClosingNoAdj.ConvertToDecimal()))
            .ForMember(dest =>
                    dest.VWAP,
                opt => opt.MapFrom(src =>
                    src.Message.PVWAP.ConvertToDecimal()))
            .ForMember(dest =>
                    dest.NotAdjustedVWAP,
                opt => opt.MapFrom(src =>
                    src.Message.PVWAPNoAdj.ConvertToDecimal()))
            .ForMember(dest =>
                    dest.LastTradedPrice,
                opt => opt.MapFrom(src =>
                    src.Message.PDrCotVal.ConvertToDecimal()))
            .ForMember(dest =>
                    dest.NotAdjustedLastTradedPrice,
                opt => opt.MapFrom(src =>
                    src.Message.PDrCotValNoAdj.ConvertToDecimal()))
            .ForMember(dest =>
                    dest.TotalTradesCount,
                opt => opt.MapFrom(src =>
                    src.Message.ZTotTran.ToLong()))
            .ForMember(dest =>
                    dest.TotalTradesVolume,
                opt => opt.MapFrom(src =>
                    src.Message.QTotTran5J.ToLong()))
            .ForMember(dest =>
                    dest.TotalTradesValue,
                opt => opt.MapFrom(src =>
                    src.Message.QTotCap.ConvertToDecimal()));
    }
}