using AutoMapper;
using Lot.Controllers.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lot
{
    public class LotyProfil : Profile
    {
        public LotyProfil()
        {
            CreateMap<Encje.Lot, LotyDetailsDto>()
                .ForMember(c => c.Kraj, map => map.MapFrom(lot => lot.CelLotu.Kraj))
                .ForMember(c => c.Miasto, map => map.MapFrom(lot => lot.CelLotu.Miasto))
                .ForMember(c => c.Lotnisko, map => map.MapFrom(lot => lot.CelLotu.Lotnisko));
        }
    }
}
