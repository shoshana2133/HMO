using AutoMapper;
using AutoMapper.Execution;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.function;
using DAL.Models.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.function
{
    public class VaccinatedMbrBll : IVaccMbrBll
    {
        
        IvaccintedMbrDB vaccMbrDb;
        IMapper m;
        public VaccinatedMbrBll(IvaccintedMbrDB vaccintedMbrDb)
        {

            this.vaccMbrDb = vaccintedMbrDb;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            m = config.CreateMapper();
           
        }
        public int AddVaccintedMbrBll(VaccinatedMbr vacc)
        {
            return vaccMbrDb.AddVaccintedMbrDB(vacc);
        }

        public bool DeleteVaccintedMbrBll(int id)
        {         
            return vaccMbrDb.DeleteVaccintedMbrDB(id);
        }

        public List<VaccinatedMbrDto> GetAllVaccintedMbrBll()
        {
            return m.Map<List<VaccinatedMbr>,List<VaccinatedMbrDto>>( vaccMbrDb.GetAllVaccintedMbrDB());

        }
        public bool UpdateVaccintedMbrBll(VaccinatedMbr vacc)
        {
            return vaccMbrDb.UpdateVaccintedMbrDB(vacc);

        }
        public List<VaccinatedMbrDto> GetAllVaccinatedMbr(int id)
        {
            List<VaccinatedMbrDto> list = new List<VaccinatedMbrDto>();
            foreach (var item in m.Map<List<VaccinatedMbr>, List<VaccinatedMbrDto>>(vaccMbrDb.GetAllVaccintedMbrDB()))
            {
                if (item.MbrCode == id)
                    list.Add(item);
            }
            return list;
        }
    }
}
