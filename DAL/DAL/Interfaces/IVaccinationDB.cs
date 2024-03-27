using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IVaccinationDB
    {
        //There is no possibility of adding/deleting/updating a vaccine
        //because it is a closed database of the Ministry of Health
        List<Vaccination> GetAllVaccintion();

    }
}
