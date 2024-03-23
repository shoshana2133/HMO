using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Models.Interfaces
{
    public interface Imembers 
    {
        List<MemberHmo> GetAllMemberDB();
        bool DeleteMemberDB(int id_mem);
        int AddMemberDB (MemberHmo member);
        bool UpdateMemberDB (MemberHmo member);
    }
}
