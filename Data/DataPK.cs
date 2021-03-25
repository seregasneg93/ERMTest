using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERMTest.Data
{
    public class DataPK
    {
        public int Id { get; set; }
        public decimal FreeOfMemory { get; set; }
        public decimal TotalMemory { get; set; }
        public decimal UsageCPU { get; set; }
        public decimal FreeDisks { get; set; }
        public decimal TotalDisks { get; set; }
    }
}
