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
        public Mapper()
        {
            CreateMap<MemberHmo, MemberDTO>();
            CreateMap<MemberDTO, MemberHmo>();
            CreateMap<VaccinatedMbr, VaccinatedMbrDto>();
              //  .ForMember(x => x.VmMbrCode, src => src.MapFrom(y => y.VmMbrCodeNavigation.MbrCode));

            CreateMap<VaccinatedMbrDto, VaccinatedMbr>();
        }
    }
}
