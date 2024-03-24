using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MemberDTO
    {

        public int MbrCode { get; set; }

        public string MbrTz { get; set; } = null!;

        public string MbrFirstName { get; set; } = null!;

        public string MbrLastName { get; set; } = null!;

        public string MbrCity { get; set; } = null!;

        public string MbrStreet { get; set; } = null!;

        public int? MbrNumStreet { get; set; }

        public DateTime MbrBirthDate { get; set; }

        public string? MbrTel { get; set; }

        public string? MbrPhon { get; set; }

        public bool MbrVaccinted { get; set; }

        public bool MbrPatient { get; set; }

    }
}
