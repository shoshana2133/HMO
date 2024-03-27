using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccinatedMbrDto
    {
        public int VmCode { get; set; }

        public int MbrCode { get; set; }

        public string VcManufacturer { get; set; } = null!;

        public int VcCode { get; set; }

        public DateTime VmDate { get; set; }
    }
}
