using System.Resources;
using AnnualTaxCalculator.BLL;
using AnnualTaxCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnnualTaxCalculator.Tests
{
    [TestClass]
    public class AnnualTaxCalculatorTests
    {
        //[TestMethod]
        //public void Construct_ShouldNotBeNull()
        //{
        //    //---Setup----------------------------------------------

        //    //---Execute--------------------------------------------
        //    var annualTaxCalculator = new AnnualTaxCalculator();
        //    //---Assert---------------------------------------------
        //    Assert.IsNotNull(annualTaxCalculator);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(NullReferenceException))]
        //public void Construct_NoAnnualSalary_ShouldThrowException()
        //{
        //    //---Setup----------------------------------------------

        //    //---Execute--------------------------------------------
        //    var annualTaxCalculator = new AnnualTaxCalculator(null);
        //    //---Assert---------------------------------------------
        //    Assert.Fail("Exception thrown");
        //}

        //[TestMethod]
        //[ExpectedException(typeof(NullReferenceException))]
        //public void Construct_NoAge_ShouldThrowException()
        //{
        //    //---Setup----------------------------------------------
        //    double annualSalary = 300000;
        //    //---Execute--------------------------------------------
        //    var annualTaxCalculator = new AnnualTaxCalculator(annualSalary,null);
        //    //---Assert---------------------------------------------
        //    Assert.Fail("Exception thrown");
        //}

        [TestMethod]
        public void Calculate_GivenAgeAndAnnualSalary_ShouldReturnAnnualTax()
        {
            //---Setup----------------------------------------------
            double annualSalary = 300000;
            int age = 30;
            var taxReliefCalculator = new TaxReliefCalculator(age);
            var ageBasedRelief = taxReliefCalculator.Calculate();
            var annualTaxCalculator = new AnnualTaxCalculator(ageBasedRelief, annualSalary);
            //---Execute--------------------------------------------
            decimal annualTax = annualTaxCalculator.Calculate();
            //---Assert---------------------------------------------
            Assert.AreEqual(300, annualTax);
        }
    }

    public class AnnualTaxCalculator
    {
        private readonly AgeBasedRelief _ageBasedRelief;
        private double _annualSalary;
        public AnnualTaxCalculator(AgeBasedRelief ageBasedRelief, double annualSalary)
        {
            _ageBasedRelief = ageBasedRelief;
            _annualSalary = annualSalary;
        }

        public decimal Calculate()
        {
            var monthlySalary = GetMonthlySalary();
            return default(decimal);
            //return (monthlySalary - _ageBasedRelief.MonthlySalaryRelief) * _ageBasedRelief.PercentageOfDeduction;
        }

        private double GetMonthlySalary()
        {
            return _annualSalary / 12;
        }
    }
}
