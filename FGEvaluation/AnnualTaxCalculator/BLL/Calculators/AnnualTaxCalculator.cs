using System.Collections.Generic;
using AnnualTaxCalculator.Models;

namespace AnnualTaxCalculator.BLL
{
    public class AnnualTaxCalculator
        : ICalculator
    {
        private readonly AgeBasedRelief _ageBasedRelief;
        private readonly decimal _monthlySalary;
        public AnnualTaxCalculator(AgeBasedRelief ageBasedRelief, decimal monthlySalary)
        {
            _ageBasedRelief = ageBasedRelief;
            _monthlySalary = monthlySalary;
        }

        public decimal Calculate()
        {
            var deductionRate = GetDeductionRate();
            var taxableDeductionRate = _ageBasedRelief.PercentageOfDeduction * deductionRate;
            return ((_monthlySalary - _ageBasedRelief.MonthlySalaryRelief) * taxableDeductionRate) * 12;
        }

        private decimal GetDeductionRate()
        {
            DeductionRateCondition rateCondition = null;
            for (int i = 0;i<  DeductionRateConditions.Count;i++)
            {
                var con = DeductionRateConditions[i];
                var result = con.Evaluate(_monthlySalary);
                if (result)
                {
                    if (i == DeductionRateConditions.Count - 1)
                        rateCondition = con;
                    else
                        continue;
                }
                rateCondition = con;
                break;
            }
            return rateCondition.DeductionRate ;
        }

        #region Decision Table Conditions

        private List<DeductionRateCondition> DeductionRateConditions => new List<DeductionRateCondition>
        {
            new DeductionRateCondition  { Condition = (salary) => salary > 5000, DeductionRate = 0m },
            new DeductionRateCondition  { Condition = (salary) => salary > 10000, DeductionRate = 0.05m },
            new DeductionRateCondition  { Condition = (salary) => salary > 20000, DeductionRate = 0.075m },
            new DeductionRateCondition  { Condition = (salary) => salary > 35000, DeductionRate = 0.09m },
            new DeductionRateCondition  { Condition = (salary) => salary > 50000, DeductionRate = 0.15m },
            new DeductionRateCondition  { Condition = (salary) => salary > 70000, DeductionRate = 0.25m },
            new DeductionRateCondition  { Condition = (salary) => salary > 70000, DeductionRate = 0.3m },
        };

        #endregion
    }
}
