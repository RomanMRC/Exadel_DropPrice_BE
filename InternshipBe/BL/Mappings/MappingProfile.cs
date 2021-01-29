﻿using AutoMapper;
using BL.DTO;
using DAL.Entities;

namespace BL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Town, TownDTO>()
                .ForMember(t => t.TownName, source => source.MapFrom(s => s.Name));
            CreateMap<TownDTO, Town>()
                .ForMember(t => t.Name, source => source.MapFrom(s => s.TownName));

            CreateMap<Tag, TagDTO>()
                .ForMember(t => t.TagName, source => source.MapFrom(s => s.Name))
                .ForMember(t => t.TagId, source => source.MapFrom(s => s.Id));
            CreateMap<TagDTO, Tag>()
                .ForMember(t => t.Name, source => source.MapFrom(s => s.TagName))
                .ForMember(t => t.Id, source => source.MapFrom(s => s.TagId)); ;
        }
    }
}
