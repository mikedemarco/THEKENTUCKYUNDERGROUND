using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
    public class CharityReport
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Level { get; set; }
        public int Tickets { get; set; }
        public double Rate { get; set; }
    }
}
