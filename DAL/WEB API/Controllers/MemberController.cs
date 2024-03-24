using BLL.Interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        ImemberBLL member;
        public MemberController(ImemberBLL m)
        {
                member = m;
        }
        [HttpGet]
        [Route("GetAllMembers")]

        public ActionResult<List<MemberDTO>> GetAllMembers()
        {
            return Ok(member.GetAllMemberBll());
        }


        [HttpPost]
        [Route("AddMember")]
        public ActionResult<int> AddMember([FromBody] MemberDTO mem)
        {
            return Ok(member.AddMemberBll(mem));
        }

        [HttpPut]
        [Route("UpdateMember")]
        public ActionResult<bool> UpdateMember([FromBody] MemberDTO mem)
        {
            return Ok(member.UpdateMemberBll(mem));
        }

        [HttpDelete]
        [Route("DeleteMember/{id}")]
        public ActionResult<bool> DeleteMember(int id)
        {
            return Ok(member.DeleteMemberBll(id));
        }
        [HttpGet]
        [Route("GetAllVaccForMem/{id}")]
        public ActionResult<List<VaccinatedMbrDto>> GetAllVaccForMem(int id)
        {
            return Ok(member.GetAllVaccinatedMbr(id));
        }
    }
}
