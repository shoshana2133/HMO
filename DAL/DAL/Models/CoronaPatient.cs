using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CoronaPatient
{
    public int CpCode { get; set; }

    public int CpMbrCode { get; set; }

    public DateTime CpDatePositive { get; set; }

    public DateTime? CpDateRecovery { get; set; }

    public virtual MemberHmo CpMbrCodeNavigation { get; set; } = null!;
}
