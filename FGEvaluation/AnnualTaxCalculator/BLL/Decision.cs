using System;
using AnnualTaxCalculator.Models;

namespace AnnualTaxCalculator.BLL
{
    public abstract class Decision<T>
    {
        public abstract bool Evaluate(T obj);
    }

    public class DeductionRateCondition
        : Decision<decimal>
    {
        public Func<decimal, bool> Condition { get; set; }
        public decimal DeductionRate { get; set; }

        public override bool Evaluate(decimal salary)
        {
            return Condition(salary);
        }
    }
    public class AgeBasedReliefCondition
        : Decision<int>
    {
        public Func<int, bool> Condition { get; set; }
        public AgeBasedRelief AgeBasedRelief { get; set; }

        public override bool Evaluate(int age)
        {
            return Condition(age);
        }
    }
}
