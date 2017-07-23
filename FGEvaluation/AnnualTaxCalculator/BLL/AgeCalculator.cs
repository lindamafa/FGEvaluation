using System;

namespace AnnualTaxCalculator.BLL
{
    public class AgeCalculator
        : ICalculator
    {
        private readonly DateTime _dateOfBirth;
        public AgeCalculator(DateTime dateofBirth)
        {
            _dateOfBirth = dateofBirth;
        }

        public int Calculate()
        {
            int result = (int)DateTime.Today.Subtract((_dateOfBirth)).Days / 365;
            return result;
        }
    }
}
