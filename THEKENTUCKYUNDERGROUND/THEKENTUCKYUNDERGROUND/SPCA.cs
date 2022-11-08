using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
    public class SPCA : BaseCharityCalculator
    {
        public SPCA(CharityReport report)
            : base(report)
        {
        }
        public override double CalculateSalary() => CharityReport.Rate * CharityReport.Tickets;
    }
}