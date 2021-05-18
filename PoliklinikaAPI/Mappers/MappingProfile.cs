﻿using AutoMapper;
using Poliklinika.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoliklinikaAPI.ViewModels;

namespace PoliklinikaAPI.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Odjel, OdjelVM>().ReverseMap();
            CreateMap<Korisnik, KorisnikVM>().ReverseMap();
            CreateMap<Korisnik, SignUpKorisnikVM>().ReverseMap();
            CreateMap<KorisnikVM, SignUpKorisnikVM>().ReverseMap();
            CreateMap<Nalaz, NalazVM>().ReverseMap();

            CreateMap<Doktor, DoktorVM>().ReverseMap();
            CreateMap<Doktor, CreateDoktorVM>().ReverseMap();
            CreateMap<DoktorVM, CreateDoktorVM>().ReverseMap();

            CreateMap<Tehnicar, TehnicarVM>().ReverseMap();
            CreateMap<Tehnicar, CreateTehnicarVM>().ReverseMap();
            CreateMap<TehnicarVM, CreateTehnicarVM>().ReverseMap();

        }
    }
}
