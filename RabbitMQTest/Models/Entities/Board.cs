using AutoMapper;
using RabbitMQTest.Mapping;
using RabbitMQTest.Models.Messages;
using RabbitMQTest.Tools;

namespace RabbitMQTest.Models.Entities;

public class Board : BaseEntity, IMapFrom<Message5E>
{
    public byte Code { get; set; }
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Message5E, Board>()
            .ForMember(dest =>
                    dest.Code,
                opt => opt.MapFrom(src => byte.Parse(src.Message.CComVal)))
            .ForMember(dest =>
                    dest.Name,
                opt => opt.MapFrom(src => byte.Parse(src.Message.LBoard)))
            .ForMember(dest =>
                    dest.ReceiptDateTime,
                opt => opt.MapFrom(src => src.RLCDiffHeader.GetDateTime()));
    }
}