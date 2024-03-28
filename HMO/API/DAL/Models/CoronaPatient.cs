using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CoronaPatient
{
    public int CpCode { get; set; }

    public int MbrCode { get; set; }

    public DateTime CpDatePositive { get; set; }

    public DateTime? CpDateRecovery { get; set; }

    public virtual MemberHmo MbrCodeNavigation { get; set; } = null!;
}
