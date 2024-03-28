using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ImemberBLL
    {
        List<MemberDTO> GetAllMemberBll();
        bool DeleteMemberBll(int id_mem);
        int AddMemberBll(MemberDTO member);
        bool UpdateMemberBll(MemberDTO member);

    }
}
