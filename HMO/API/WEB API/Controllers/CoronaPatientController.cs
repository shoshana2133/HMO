using AutoMapper.Execution;
using BLL.Interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaPatientController : ControllerBase
    {
        ICoronaPatientBLL cp;

        public CoronaPatientController(ICoronaPatientBLL cp)
        {
            this.cp = cp;

        }
        [HttpGet]
        [Route("GetAllCoronaPatient")]
        public ActionResult<List<CoronaPatientDTO>> GetAllCoronaPatient()
        {
            return Ok(cp.GetAllCoronaPatientBll());
        }


        [HttpPost]
        [Route("AddCoronaPatient")]
        public ActionResult<int> AddCoronaPatient([FromBody] CoronaPatientDTO cop)
        {
            return Ok(cp.AddCoronaPatientBll(cop));
        }

        [HttpPut]
        [Route("UpdateCoronaPatient")]
        public ActionResult<bool> UpdateCoronaPatient([FromBody] CoronaPatientDTO cop)
        {
            return Ok(cp.UpdateCoronaPatientBll(cop));
        }

        [HttpDelete]
        [Route("DeleteCoronaPatient/{id}")]
        public ActionResult<bool> DeleteCoronaPatient(int id)
        {
            return Ok(cp.DeleteCoronaPatientBll(id));
        }

    }
}
