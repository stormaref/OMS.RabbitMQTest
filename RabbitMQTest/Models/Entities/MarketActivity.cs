using AutoMapper;
using RabbitMQTest.Mapping;
using RabbitMQTest.Models.Messages;
using RabbitMQTest.Tools;

namespace RabbitMQTest.Models.Entities;

public class MarketActivity : BaseEntity, IMapFrom<Message5I>
{
    public long TotalTradesCount { get; set; }
    public double TotalTradesValue { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Message5I, MarketActivity>()
            .ForMember(dest =>
                    dest.TotalTradesCount,
                opt => opt.MapFrom(src => src.Message.QTotTran.ToLong()))
            .ForMember(dest =>
                    dest.TotalTradesValue,
                opt => opt.MapFrom(src => src.Message.QTotCap.ConvertToDouble()))
            .ForMember(dest =>
                    dest.ReceiptDateTime,
                opt => opt.MapFrom(src => src.RLCDiffHeader.GetDateTime()));
    }
}