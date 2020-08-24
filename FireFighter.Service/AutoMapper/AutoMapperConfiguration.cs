using AutoMapper;
using FireFighter.Core.Domain;
using FireFighter.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter.Service.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {
        /// <summary>
        /// Create a map profile
        /// </summary>
        /// <returns></returns>
        public static MapperConfiguration Configure()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Award, PlayerAwardNamesDTO>();
                cfg.CreateMap<PlayerAwardNamesDTO, Award>();
                cfg.CreateMap<Animal, AnimalDTO>();
                cfg.CreateMap<AnimalDTO, Animal>();
                cfg.CreateMap<Player, PlayerDTO>();
                cfg.CreateMap<PlayerDTO, Player>();
                cfg.CreateMap<AboutUs, AboutUsDTO>();
                cfg.CreateMap<AboutUsDTO, AboutUs>();
                cfg.CreateMap<AskedQuestion, AskedQuestionDTO>();
                cfg.CreateMap<AskedQuestionDTO, AskedQuestion>();
                cfg.CreateMap<PlayerAwardDTO, PlayerAward>();
                cfg.CreateMap<PlayerAward, PlayerAwardDTO>();
            });
            return mapperConfiguration;
        }
    }
}
