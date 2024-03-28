using BLL.Interfaces;
using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccController : ControllerBase
    {

        IVaccinationBll vaccination;

        public VaccController(IVaccinationBll vc)
        {
            vaccination = vc;
        }

        [HttpGet]
        [Route("GetAllVacc")]
        public ActionResult<List<VaccinationDTO>> GetAllVacc()
        {
            return Ok(vaccination.GetAllVaccintion());

        }
      
    }
}
