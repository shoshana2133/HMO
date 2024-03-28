using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IVaccinationBll
    {
        //There is no possibility of adding/deleting/updating a vaccine
        //because it is a closed database of the Ministry of Health
        List<VaccinationDTO> GetAllVaccintion();

    }
}
