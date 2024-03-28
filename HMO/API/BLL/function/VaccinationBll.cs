using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.function
{
    public class VaccinationBll : IVaccinationBll
    {
        IVaccinationDB vaccDb;
        IMapper m;
        public VaccinationBll(IVaccinationDB vaccDb)
        {

            this.vaccDb = vaccDb;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            m = config.CreateMapper();

        }
        public List<VaccinationDTO> GetAllVaccintion()
        {
            return m.Map<List<Vaccination>, List<VaccinationDTO>>(vaccDb.GetAllVaccintion());

        }
    }
}
