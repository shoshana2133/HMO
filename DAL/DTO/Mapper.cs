using AutoMapper;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Mapper:Profile
    {
        //public Mapper()
        //{
        //    CreateMap<MemberHmo, MemberDTO>();
        //    CreateMap<MemberDTO, MemberHmo>();
        //    CreateMap<VaccinatedMbr, VaccinatedMbrDto>()
        //       .ForMember(x => x.VcManufacturer, src => src.MapFrom(y => y.VcCodeNavigation.VcManufacturer));
        //    CreateMap<VaccinatedMbrDto, VaccinatedMbr>();
        //}
        public Mapper()
        {
            CreateMap<MemberHmo, MemberDTO>();
            CreateMap<MemberDTO, MemberHmo>();
            CreateMap<VaccinatedMbr, VaccinatedMbrDto>()
                .ForMember(dest => dest.VcManufacturer, opt => opt.MapFrom(src => src.VcCodeNavigation.VcManufacturer));
            CreateMap<VaccinatedMbrDto, VaccinatedMbr>();
            CreateMap<Vaccination, VaccinationDTO>();
            CreateMap<VaccinationDTO, Vaccination>();
        }
    }
}
