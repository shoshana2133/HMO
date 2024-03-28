using BLL.Interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccmemController : ControllerBase
    {
        IVaccMbrBll vcb;
  
        public VaccmemController(IVaccMbrBll v)
        {
            vcb= v;
         
        }
        [HttpGet]
        [Route("GetAllVaccForMem/{id}")]
        public ActionResult<List<VaccinatedMbrDto>> GetAllVaccForMem(int id)
        {
            return Ok(vcb.GetAllVaccinatedMbr(id));
        }
        [HttpGet]
        [Route("GetAllVaccMem")]

        public ActionResult<List<VaccinatedMbrDto>> GetAllVaccMem()
        {
            return Ok(vcb.GetAllVaccintedMbrBll());
        }
        [HttpPost]
        [Route("AddVaccMem")]
        public ActionResult<int> AddVaccMem([FromBody] VaccinatedMbrDto vm)
        {
            return Ok(vcb.AddVaccintedMbrBll(vm));
        }

    }
}
