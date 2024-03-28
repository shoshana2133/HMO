using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CoronaPatientDTO
    {
        public int CpCode { get; set; }

        public int MbrCode { get; set; }

        public DateTime CpDatePositive { get; set; }

        public DateTime? CpDateRecovery { get; set; }

    }
}
