using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class VaccinatedMbr
{
    public int VmCode { get; set; }

    public int MbrCode { get; set; }

    public int VcCode { get; set; }

    public DateTime VmDate { get; set; }

    public virtual MemberHmo MbrCodeNavigation { get; set; } = null!;

    public virtual Vaccination VcCodeNavigation { get; set; } = null!;
}
