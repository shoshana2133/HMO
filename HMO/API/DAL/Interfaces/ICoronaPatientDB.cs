using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICoronaPatientDB
    {
        List<CoronaPatient> GetAllCoronaPatientDB();
        bool DeleteCoronaPatientDB(int id);
        int AddCoronaPatientDB(CoronaPatient cp);
        bool UpdateCoronaPatientDB(CoronaPatient cp);
    }
}
