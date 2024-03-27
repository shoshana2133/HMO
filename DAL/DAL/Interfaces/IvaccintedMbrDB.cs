using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IvaccintedMbrDB
    {
        List<VaccinatedMbr> GetAllVaccintedMbrDB();
        bool DeleteVaccintedMbrDB(int id);
        int AddVaccintedMbrDB(VaccinatedMbr vacc);
        bool UpdateVaccintedMbrDB(VaccinatedMbr vacc);
    }
}
