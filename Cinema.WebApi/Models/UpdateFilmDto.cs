﻿using AutoMapper;
using Cinema.Application.Cinema.Commands.UpdateFilm;
using Cinema.Application.Common.Mappings;

namespace Cinema.WebApi.Models
{
    public class UpdateFilmDto : IMapWith<UpdateFilmCommand>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int YearPublished { set; get; }
        public string Genres { get; set; }
        public string Duration { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateFilmDto, UpdateFilmCommand>()
                .ForMember(filmCommand => filmCommand.Name,
                opt => opt.MapFrom(filmDto => filmDto.Name))
                .ForMember(filmCommand => filmCommand.Country,
                opt => opt.MapFrom(filmDto => filmDto.Country))
                .ForMember(filmCommand => filmCommand.YearPublished,
                opt => opt.MapFrom(filmDto => filmDto.YearPublished))
                .ForMember(filmCommand => filmCommand.Genres,
                opt => opt.MapFrom(filmDto => filmDto.Genres))
                .ForMember(filmCommand => filmCommand.Duration,
                opt => opt.MapFrom(filmDto => filmDto.Duration))
                .ForMember(filmCommand => filmCommand.Id,
                opt => opt.MapFrom(filmDto => filmDto.Id));
        }
    }
}
