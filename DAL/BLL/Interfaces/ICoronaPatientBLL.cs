using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICoronaPatientBLL
    {
        List<CoronaPatientDTO> GetAllCoronaPatientBll();
        bool DeleteCoronaPatientBll(int id);
        int AddCoronaPatientBll(CoronaPatientDTO cp);
        bool UpdateCoronaPatientBll(CoronaPatientDTO cp);
    }
}
