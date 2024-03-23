using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Vaccination
{
    public int VcCode { get; set; }

    public string VcManufacturer { get; set; } = null!;

    public virtual ICollection<VaccinatedMbr> VaccinatedMbrs { get; set; } = new List<VaccinatedMbr>();
}
