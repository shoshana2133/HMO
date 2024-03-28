using AutoMapper;
using AutoMapper.Execution;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.function;
using DAL.Models.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.function
{
    public class CoronaPatientBll : ICoronaPatientBLL
    {
        ICoronaPatientDB cpDB;

        IMapper m;
        public CoronaPatientBll(ICoronaPatientDB cpDB)
        {

            this.cpDB = cpDB;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            m = config.CreateMapper();

        }
        public int AddCoronaPatientBll(CoronaPatientDTO cp)
        {
            return cpDB.AddCoronaPatientDB(m.Map<CoronaPatientDTO, CoronaPatient>(cp));
        }

        public bool DeleteCoronaPatientBll(int id)
        {
            return cpDB.DeleteCoronaPatientDB(id);

        }

        public List<CoronaPatientDTO> GetAllCoronaPatientBll()
        {
            return m.Map<List<CoronaPatient>, List<CoronaPatientDTO>>(cpDB.GetAllCoronaPatientDB());
           
        }

        public bool UpdateCoronaPatientBll(CoronaPatientDTO cp)
        {
            return cpDB.UpdateCoronaPatientDB(m.Map<CoronaPatientDTO, CoronaPatient>(cp));

        }
    }
}
