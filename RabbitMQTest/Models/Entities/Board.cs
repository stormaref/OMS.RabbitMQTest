using AutoMapper;
using RabbitMQTest.Mapping;

namespace RabbitMQTest.Models.Entities;

public class Board : IMapFrom<Message5E>
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
                opt => opt.MapFrom(src => byte.Parse(src.Message.LBoard)));
    }
}