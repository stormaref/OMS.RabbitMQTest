using AutoMapper;
using RabbitMQTest.Mapping;
using RabbitMQTest.Models.Messages;

namespace RabbitMQTest.Models.Entities;

public class Sector : IMapFrom<Message5F>
{
    public string SectorCode { get; set; }
    public string SectorName { get; set; }
    public string SuperSectorCode { get; set; }
    public string ICBSectorCode { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Message5F, Sector>()
            .ForMember(dest =>
                    dest.SectorCode,
                opt => opt.MapFrom(src => src.Message.CSecVal))
            .ForMember(dest =>
                    dest.SectorName,
                opt => opt.MapFrom(src => src.Message.LSecVal))
            .ForMember(dest =>
                    dest.SuperSectorCode,
                opt => opt.MapFrom(src => src.Message.LSecVal))
            .ForMember(dest =>
                    dest.ICBSectorCode,
                opt => opt.MapFrom(src => src.Message.CSecValICB));
    }
}