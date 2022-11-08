using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
    public class HabitatForHumanity : BaseCharityCalculator
    {
        public HabitatForHumanity(CharityReport charityReport)
            : base(charityReport)
        {
        }
        public override double CalculateSalary() => CharityReport.Rate * CharityReport.Tickets;
    }
}