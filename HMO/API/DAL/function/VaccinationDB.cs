using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public class VaccinationDB : IVaccinationDB
    {
        HmoDbContext db;
        public VaccinationDB(HmoDbContext _db)
        {
            db = _db;
        }
        List<Vaccination> IVaccinationDB.GetAllVaccintion()
        {
            return db.Vaccinations.ToList();
        }
    }
}
