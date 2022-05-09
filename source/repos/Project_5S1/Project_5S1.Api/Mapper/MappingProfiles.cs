using AutoMapper;
 
using Project_5S.Domain.DTOs;
using Project_5S.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_5S.Api.Mapper
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
             
            //CreateMap<SaisieFilialeDTO, Filiale>();

             
             
                CreateMap<Filiale, SaisieFilialeDTO>()
                .ForMember(d => d.polename, a=>a.MapFrom(src => src.pole.PoleName))
                

                 .ReverseMap();
            CreateMap<criteres, CriteresDTO>()
               .ForMember(d => d.normename, z=> z.MapFrom(src => src.Normes.designation))


                .ReverseMap();



            CreateMap<Pole, PoleDTO>()

                .ReverseMap();
            CreateMap<notation, notationDTO>()

                .ReverseMap();
            CreateMap<Normes, NormesDTO>()

                .ReverseMap();
            CreateMap<Users, UsersDTO>()

                .ReverseMap();
            CreateMap<plan_action, plan_actionDTO>()

                .ReverseMap();
            CreateMap<FilLocal, FilLocalDTO>()
                .ForMember(d => d.fliname, n => n.MapFrom(src => src.Filiale.filialName))

                .ReverseMap();
            CreateMap<Pole, PoleDTO>()

             .ReverseMap();
        }


    }
    }

