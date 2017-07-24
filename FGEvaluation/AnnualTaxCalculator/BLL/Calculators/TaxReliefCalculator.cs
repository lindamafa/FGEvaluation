using System;
using System.Collections.Generic;
using AnnualTaxCalculator.Models;

namespace AnnualTaxCalculator.BLL
{
    public class TaxReliefCalculator
        : ICalculator
    {
        private readonly int _age;

        public TaxReliefCalculator(int age)
        {
            if (age == default(int) || age < 18) throw new Exception("Not a valid age!");
            _age = age;
        }

        public AgeBasedRelief Calculate()
        {
            AgeBasedReliefCondition trueCondition = null;
            foreach (var condition in AgeBasedReliefConditions)
            {
                var result = condition.Evaluate(_age);
                if (result)
                {
                    trueCondition = condition;
                    continue;
                }
                else
                    break;
            }
            return trueCondition?.AgeBasedRelief;
        }

        #region AgeBasedReliefLookup

        private List<AgeBasedReliefCondition> AgeBasedReliefConditions => new List<AgeBasedReliefCondition>
        {
            new AgeBasedReliefCondition
            {
                Condition = (age) => age > 18,
                AgeBasedRelief = new AgeBasedRelief {MonthlySalaryRelief= 2000, PercentageOfDeduction = 1 },
            },
            new AgeBasedReliefCondition
            {
                Condition = (age) => age > 50,
                AgeBasedRelief = new AgeBasedRelief { MonthlySalaryRelief = 5000, PercentageOfDeduction = 0.85m },
            }
        };

        #endregion
    }
}