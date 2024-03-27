using DAL.Interfaces;
using DAL.Models;
using DAL.Models.function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public class VaccintedMbrDB : IvaccintedMbrDB
    {
        HmoDbContext db;
        public VaccintedMbrDB(HmoDbContext _db)
        {
            db = _db;
        }
        public int AddVaccintedMbrDB(VaccinatedMbr vacc)
        {
            db.VaccinatedMbrs.Add(vacc);
            db.SaveChanges();
            return vacc.MbrCode;
        }

        public bool DeleteVaccintedMbrDB(int id)
        {
            VaccinatedMbr vaccToDel = db.VaccinatedMbrs.FirstOrDefault(x => x.VcCode == id);
            if (vaccToDel == null)
            {
                return false;
            }
            db.VaccinatedMbrs.Remove(vaccToDel);
            db.SaveChanges();
            return true;
        }

        public List<VaccinatedMbr> GetAllVaccintedMbrDB()
        {
            return db.VaccinatedMbrs.ToList();
        }

        public bool UpdateVaccintedMbrDB(VaccinatedMbr vacc)
        {
            VaccinatedMbr vaccToDel = db.VaccinatedMbrs.FirstOrDefault(x => x.VcCode == vacc.VcCode);
            if (vaccToDel == null)
            {
                return false;
            }
            vaccToDel.MbrCode = vacc.MbrCode;
            vaccToDel.VmDate = vacc.VmDate;
            vaccToDel.VcCode = vacc.VcCode;
            db.SaveChanges();
            return true;
        }
    }
}





