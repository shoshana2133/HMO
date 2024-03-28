using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public class CoronaPatientDB : ICoronaPatientDB
    {
        HmoDbContext db;
        public CoronaPatientDB(HmoDbContext _db)
        {
            db = _db;
        }
        public int AddCoronaPatientDB(CoronaPatient cp)
        {
            db.CoronaPatients.Add(cp);
            db.SaveChanges();
            return cp.CpCode;
        }

        public bool DeleteCoronaPatientDB(int id)
        {
            CoronaPatient cp = db.CoronaPatients.FirstOrDefault(x => x.CpCode == id);
            if (cp == null)
            {
                return false;
            }
            db.CoronaPatients.Remove(cp);
            db.SaveChanges();
            return true;
        }

        public List<CoronaPatient> GetAllCoronaPatientDB()
        {
            return db.CoronaPatients.ToList();
        }

        public bool UpdateCoronaPatientDB(CoronaPatient cp)
        {
            CoronaPatient cpToUpdate = db.CoronaPatients.FirstOrDefault(x => x.CpCode == cp.CpCode);
            if (cpToUpdate == null)
            {
                return false;
            }
            cpToUpdate.CpDatePositive = cp.CpDatePositive;
            cpToUpdate.CpDateRecovery=cp.CpDateRecovery;
            db.SaveChanges();
            return true;
        }
    }
}
