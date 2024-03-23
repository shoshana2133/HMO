using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class VaccinatedMbr
{
    public int VmCode { get; set; }

    public int VmMbrCode { get; set; }

    public int VmVcCode { get; set; }

    public DateTime VmDate { get; set; }

    public virtual MemberHmo VmMbrCodeNavigation { get; set; } = null!;

    public virtual Vaccination VmVcCodeNavigation { get; set; } = null!;
}
