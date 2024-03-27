using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IVaccMbrBll
    {
        List<VaccinatedMbrDto> GetAllVaccintedMbrBll();
        bool DeleteVaccintedMbrBll(int id);
        int AddVaccintedMbrBll(VaccinatedMbr vacc);
        bool UpdateVaccintedMbrBll(VaccinatedMbr vacc);
        public List<VaccinatedMbrDto> GetAllVaccinatedMbr(int id);
    }
}
