using AnnualTaxCalculator.Models;
using System;
using AnnualTaxCalculator.BLL;

namespace AnnualTaxCalculator.Views
{
    public class MainFormViewModel
    {
        readonly Person _person;
        private string _name;
        private decimal _annualTax;

        public MainFormViewModel(Person person)
        {
            _person = person;
        }

        public string Name
        {
            get { return _person.Name; }
            set { _person.Name = value; }
        }
    

        public decimal SalaryPerAnnum
        {
            get {return _person.SalaryPerAnnum;}

            set { _person.SalaryPerAnnum = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _person.DateOfBirth; }
            set { _person.DateOfBirth = value; }
        }

        public decimal AnnualTax
        {
            get { return _annualTax; }
            set { _annualTax = value; }
        }

        public void Calculate()
        {
            var taxReliefCalculator = new TaxReliefCalculator(_person.Age);
            var ageBasedRelief = taxReliefCalculator.Calculate();
            var annualTaxCalculator = new BLL.AnnualTaxCalculator(ageBasedRelief, _person.MonthlySalary);
            AnnualTax = annualTaxCalculator.Calculate();
        }
    }
}
