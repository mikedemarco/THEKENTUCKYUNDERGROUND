using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
    //Solid Feature: Open Closed Principle. CharityCalulator is closed for modification and open for an extension.
    //I would not have to change my current classes if I needed to make any changes to the charitable contribuitons.
    //All I would need to do is create a new class with its own calculation logic.
    public class CharityCalculator 
    {                              
        private readonly IEnumerable<BaseCharityCalculator> _charityCalculation;
        public CharityCalculator(IEnumerable<BaseCharityCalculator> charityCalculation)
        {
            _charityCalculation = charityCalculation;
        }
        public double CalculateTotalSalaries()
        {
            double totalDonations = 0D;
            foreach (var chaCalc in _charityCalculation)
            {
                totalDonations += chaCalc.CalculateSalary();
            }
            return totalDonations;
        }
    }
}
