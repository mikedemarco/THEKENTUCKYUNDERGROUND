using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
    public abstract class BaseCharityCalculator
    {
        protected CharityReport CharityReport { get; private set; }

        public BaseCharityCalculator(CharityReport charityReport)
        {
            CharityReport = charityReport;
        }

        public abstract double CalculateSalary();
    }
}
