using System;
using System.Collections.Generic;
using System.Linq;
using AnnualTaxCalculator.Models;

namespace AnnualTaxCalculator.BLL
{
    public class TaxReliefCalculator
        : ICalculator
    {
        private readonly int _age;

        public TaxReliefCalculator(int age)
        {
            if (age == default(int) || age < 18) throw new Exception("Not a valid Age!");
            _age = age;
        }

        public AgeBasedRelief Calculate()
        {
            return AgeBasedReliefs
                .OrderByDescending(p=>p.LowerAgeLimit)
                .FirstOrDefault(p=>p.LowerAgeLimit <= _age);
        }

        #region AgeBasedReliefLookup

        private List<AgeBasedRelief> AgeBasedReliefs => new List<AgeBasedRelief>
        {
            new AgeBasedRelief { LowerAgeLimit = 18,  MonthlySalaryRelief = 2000, PercentageOfDeduction = 1},
            new AgeBasedRelief {LowerAgeLimit = 50,  MonthlySalaryRelief = 5000, PercentageOfDeduction = 0.85m},
        };

        #endregion
    }
}