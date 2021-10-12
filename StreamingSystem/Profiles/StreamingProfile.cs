using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles
{
    public class StreamingProfile : Profile
    {
        public StreamingProfile()
        {
            CreateMap<CreateStreamingDto, Streaming>();
            CreateMap<Streaming, ReadStreamingDto>();
            CreateMap<UpdateStreamingDto, Streaming>();
        }
    }
}
